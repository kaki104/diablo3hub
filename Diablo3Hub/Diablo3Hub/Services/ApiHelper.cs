using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using Diablo3Hub.Commons;
using Diablo3Hub.Models;
using Newtonsoft.Json;
using Template10.Services.NetworkAvailableService;

namespace Diablo3Hub.Services
{
    public class ApiHelper
    {
        private static ApiHelper _instance;

        private IList<KeyValuePair<string, string>> _apiKeys
            = new List<KeyValuePair<string, string>>();

        private INetworkAvailableService _network;

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
        ///     us, eu, tw, kr
        /// </summary>
        public string SelectedGameServer { get; set; }

        /// <summary>
        ///     Locale ko_KR
        /// </summary>
        public string SelectedLocale { get; set; }

        /// <summary>
        ///     초기화, 반드시 사용전 호출해서 API Key를 설정하고 사용한다.
        /// </summary>
        /// <returns></returns>
        public async Task InitAsync()
        {
            _network = new NetworkAvailableService();

            var uri = new Uri("ms-appx:///ApiKeys.publishsettings");
            try
            {
                var apiFile = await StorageFile.GetFileFromApplicationUriAsync(uri);
                var content = await FileIO.ReadTextAsync(apiFile);
                string[] stringSeparators = {"\r\n"};
                var lines = content.Split(stringSeparators, StringSplitOptions.None);
                _apiKeys = (from kkk in lines
                    where kkk.Length > 0 //Apikey 파일 편집시 new line이 들어가는 경우, outofbound Exception이 발생하여 이 부분을 처리하였습니다.
                    let key = kkk.Split('=')
                    select new KeyValuePair<string, string>(key[0], key[1])).ToList();
            }
            catch (FileNotFoundException)
            {
                await new MessageDialog("ApiKeys 파일을 찾지 못햇습니다. \n다시 확인해 주세요.").ShowAsync();
                return;
            }
            catch (Exception)
            {
                await new MessageDialog("ApiKeys 파일을 읽는 중에 문제가 발생하였습니다. \n 다시 확인해 주세요.").ShowAsync();
                return;
            }

            SelectedGameServer = GameConfigs.ServerKR;
            SelectedLocale = GameConfigs.LocaleKR;
        }

        /// <summary>
        ///     GetApiCacheData
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static async Task<ApiCacheData> GetApiCacheDataAsync(string url)
        {
            var cache = await DBHelper.Instance.ApiCacheTable()
                .Where(p => p.Url == url)
                .FirstOrDefaultAsync();
            var returnItem = cache?.CreateDT > DateTime.Now.AddMinutes(-5) ? cache : null;
            if (returnItem == null && cache != null)
                await DBHelper.Instance.DeleteAsync(cache);
            return returnItem;
        }

        /// <summary>
        ///     Get CareerProfile
        /// </summary>
        /// <param name="battleTag"></param>
        /// <returns></returns>
        public async Task<CareerProfile> GetCareerProfileAsync(string battleTag)
        {
            if (await CheckInternetAvailableAsync() == false) return null;

            var url =
                $"https://{SelectedGameServer}.api.battle.net/d3/profile/{battleTag.Replace("#", "-")}/?locale={SelectedLocale}&apikey={ApiKey}";

            var cache = await GetApiCacheDataAsync(url);
            if (cache != null)
            {
                var result = JsonConvert.DeserializeObject<CareerProfile>(cache.Content);
                return result;
            }

            using (var hc = new HttpClient())
            {
                var content = await hc.GetStringAsync(url);
                var jsonResult = JsonConvert.DeserializeObject<CareerProfile>(content);

                await ApiDataInsertAsync(url, content);
                return jsonResult;
            }
        }

        /// <summary>
        ///     ApiData 추가
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        private static async Task ApiDataInsertAsync(string url, string content)
        {
            await DBHelper.Instance.InsertAsync(new ApiCacheData
            {
                Url = url,
                Content = content,
                CreateDT = DateTime.Now
            });
        }

        /// <summary>
        ///     인터넷 연결 상태 확인
        /// </summary>
        /// <returns></returns>
        private async Task<bool> CheckInternetAvailableAsync()
        {
            if (await _network.IsInternetAvailable()) return true;
            await CommonStaticHelper.ShowMessageBoxAsync("인터넷 연결이 필요합니다. 잠시후 다시 시도해 주시기 바랍니다.");
            return false;
        }

        /// <summary>
        ///     히어로 프로파일
        /// </summary>
        /// <param name="battleTag"></param>
        /// <param name="heroId"></param>
        /// <returns></returns>
        public async Task<HeroProfile> GetHeroProfileAsync(string battleTag, string heroId)
        {
            if (await CheckInternetAvailableAsync() == false) return null;

            var url =
                $"https://{SelectedGameServer}.api.battle.net/d3/profile/{battleTag.Replace("#", "-")}/hero/{heroId}?locale={SelectedLocale}&apikey={ApiKey}";

            var cache = await GetApiCacheDataAsync(url);
            if (cache != null)
            {
                var result = JsonConvert.DeserializeObject<HeroProfile>(cache.Content);
                return result;
            }

            using (var hc = new HttpClient())
            {
                var content = await hc.GetStringAsync(url);
                var jsonResult = JsonConvert.DeserializeObject<HeroProfile>(content);

                await ApiDataInsertAsync(url, content);
                return jsonResult;
            }
        }

        /// <summary>
        ///     아이템 정보 조회
        /// </summary>
        /// <param name="itemCode"></param>
        /// <returns></returns>
        public async Task<ItemDetail> GetItemDetailAsync(string itemCode)
        {
            if (await CheckInternetAvailableAsync() == false) return null;

            var parts = itemCode.Split('/');
            if (parts.Length != 2 || parts.First() != "item") return null;
            var url =
                $"https://{SelectedGameServer}.api.battle.net/d3/data/item/{parts.Last()}?locale={SelectedLocale}&apikey={ApiKey}";

            var cache = await GetApiCacheDataAsync(url);
            if (cache != null)
            {
                var result = JsonConvert.DeserializeObject<ItemDetail>(cache.Content);
                return result;
            }

            using (var hc = new HttpClient())
            {
                var content = await hc.GetStringAsync(url);
                var jsonResult = JsonConvert.DeserializeObject<ItemDetail>(content);

                await ApiDataInsertAsync(url, content);
                return jsonResult;
            }
        }
    }
}