using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.Storage;
using Diablo3Hub.Commons;
using Diablo3Hub.Models;
using Newtonsoft.Json;
using System.IO;

namespace Diablo3Hub.Services
{
    public class ApiHelper
    {
        private static ApiHelper _instance;

        private IList<KeyValuePair<string, string>> _apiKeys
            = new List<KeyValuePair<string, string>>();

        /// <summary>
        ///     인스턴스
        /// </summary>
        public static ApiHelper Instance
        {
            get { return _instance = _instance ?? new ApiHelper(); }
        }

        /// <summary>
        ///     배틀넷 API Key https://dev.battle.net/io-docs
        /// </summary>
        public string ApiKey
        {
            get { return !_apiKeys.Any() ? null : _apiKeys.FirstOrDefault(p => p.Key == "Key").Value; }
        }

        public string ApiSecret
        {
            get { return !_apiKeys.Any() ? null : _apiKeys.FirstOrDefault(p => p.Key == "Secret").Value; }
        }
        /// <summary>
        /// us, eu, tw, kr
        /// </summary>
        public string SelectedGameServer { get; set; }
        /// <summary>
        /// Locale ko_KR
        /// </summary>
        public string SelectedLocale { get; set; }

        /// <summary>
        ///     초기화, 반드시 사용전 호출해서 API Key를 설정하고 사용한다.
        /// </summary>
        /// <returns></returns>
        public async Task InitAsync()
        {
            var uri = new Uri("ms-appx:///ApiKeys.publishsettings");
            try
            {
                var apiFile = await StorageFile.GetFileFromApplicationUriAsync(uri);
                var content = await FileIO.ReadTextAsync(apiFile);
                string[] stringSeparators = { "\r\n" };
                var lines = content.Split(stringSeparators, StringSplitOptions.None);
                _apiKeys = (from kkk in lines
                            where kkk.Length > 0  //Apikey 파일 편집시 new line이 들어가는 경우, outofbound Exception이 발생하여 이 부분을 처리하였습니다.
                            let key = kkk.Split('=')
                            select new KeyValuePair<string, string>(key[0], key[1])).ToList();
            }
            catch (FileNotFoundException)
            {
                await new Windows.UI.Popups.MessageDialog("ApiKeys 파일을 찾지 못햇습니다. \n다시 확인해 주세요.").ShowAsync();
                return;
            }
            catch (Exception)
            {
                await new Windows.UI.Popups.MessageDialog("ApiKeys 파일을 읽는 중에 문제가 발생하였습니다. \n 다시 확인해 주세요.").ShowAsync();
                return;
            }
            
            SelectedGameServer = GameConfigs.ServerKR;
            SelectedLocale = GameConfigs.LocaleKR;
        }
        /// <summary>
        /// Get CareerProfile 
        /// </summary>
        /// <param name="battleTag"></param>
        /// <returns></returns>
        public async Task<CareerProfile> GetCareerProfileAsync(string battleTag)
        {
            using (var hc = new HttpClient())
            {
                var url = $"https://{SelectedGameServer}.api.battle.net/d3/profile/{battleTag}/?locale={SelectedLocale}&apikey={ApiKey}";
                var content = await hc.GetStringAsync(url);
                var jsonResult = JsonConvert.DeserializeObject<CareerProfile>(content);
                return jsonResult;
            }
        }

        public async Task<HeroProfile> GetHeroProfileAsync(string battleTag, string heroId)
        {
            using (var hc = new HttpClient())
            {
                var url = $"https://{SelectedGameServer}.api.battle.net/d3/profile/{battleTag}/hero/{heroId}?locale={SelectedLocale}&apikey={ApiKey}";
                var content = await hc.GetStringAsync(url);
                var jsonResult = JsonConvert.DeserializeObject<HeroProfile>(content);
                return jsonResult;
            }
        }
    }
}