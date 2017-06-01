using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Diablo3Hub.Models;
using Diablo3Hub.Services;
using Diablo3Hub.Views;
using Newtonsoft.Json;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    /// <summary>
    ///     배틀 테그 상세 페이지 뷰모델
    /// </summary>
    public class BattleTagDetailPageViewModel : ViewModelBase
    {
        private CareerProfile _currentBattleTag;

        /// <summary>
        ///     기본 생성자
        /// </summary>
        public BattleTagDetailPageViewModel()
        {
            if (DesignMode.DesignModeEnabled)
                CurrentBattleTag = new CareerProfile
                {
                    BattleTag = "SuperOwl#1417",
                    LastUpdated = 1495638790,
                    LastHeroPlayed = 62681397,
                    ParagonLevel = 264,
                    Heroes = new[]
                    {
                        new Hero
                        {
                            Id = 62202694,
                            Name = "KakiBaba",
                            Class = "barbarian",
                            Gender = 0,
                            Level = 60,
                            Kills = new Kills {Elites = 9449},
                            ParagonLevel = 264,
                            Hardcore = false,
                            Seasonal = false,
                            Dead = false,
                            Lastupdated = 1490517844,
                        },
                        new Hero
                        {
                            Id = 62681397,
                            Name = "카키디",
                            Class = "demon-hunter",
                            Gender = 0,
                            Level = 70,
                            Kills = new Kills {Elites = 8051},
                            ParagonLevel = 826,
                            Hardcore = false,
                            Seasonal = true,
                            Dead = false,
                            Lastupdated = 1495638790
                        }
                    },
                    Kills = new Kills
                    {
                        Elites = 53537,
                        Monsters = 1251703
                    },
                    GuildName = "UWP",
                    TimePlayed = new Timeplayed
                    {
                        Barbarian = 0.813f,
                        Crusader = 0.778f,
                        Demonhunter = 1.0f,
                        Monk = 0.081f,
                        Witchdoctor = 0.111f,
                        Wizard = 0.65f
                    },
                    Progression = new Progression
                    {
                        Act1 = true,
                        Act2 = true,
                        Act3 = true,
                        Act4 = true,
                        Act5 = false
                    },
                    Blacksmith = new StoreInfo
                    {
                        Slug = "blacksmith",
                        Level = 12,
                        StepCurrent = 0,
                        StepMax = 1
                    },
                    Jeweler = new StoreInfo
                    {
                        Slug = "jeweler",
                        Level = 12,
                        StepCurrent = 0,
                        StepMax = 1
                    },
                    BlacksmithHardcore = new StoreInfo
                    {
                        Slug = "blacksmith",
                        Level = 0,
                        StepCurrent = 0,
                        StepMax = 1
                    },
                    ParagonLevelSeason = 721,
                    ParagonLevelHardcore = 0,
                    ParagonLevelSeasonHardcore = 0,
                };
            else
                Init();

        }

        private void Init()
        {
            ItemClickCommand = new DelegateCommand<object>(obj =>
            {
                var args = obj as ItemClickEventArgs;
                var item = args?.ClickedItem as Hero;
                if (item == null) return;

                //네비게이션 파라메터로 사용할 녀석 생성
                var para = new KeyValuePair<string, string>(CurrentBattleTag.BattleTag, item.Id.ToString());

                var serialPara = JsonConvert.SerializeObject(para);
                NavigationService.Navigate(typeof(HeroPage), serialPara);
            });
        }

        /// <summary>
        ///     현재 배틀테그
        /// </summary>
        public CareerProfile CurrentBattleTag
        {
            get => _currentBattleTag;
            set => Set(ref _currentBattleTag, value);
        }
        /// <summary>
        /// 히어로 클릭 커맨드
        /// </summary>
        public ICommand ItemClickCommand { get; set; }

        /// <summary>
        /// 네비게이션
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="mode"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode,
            IDictionary<string, object> state)
        {
            if (parameter is string == false) return;
            //파라메터로 넘어온 배틀테그 만들고
            var battleTag = JsonConvert.DeserializeObject<BattleTag>(parameter.ToString());
            if (mode == NavigationMode.Back)
            {
                //네비게이션 백
            }
            else
            {
                Busy.SetBusy(true, "Please wait...");
                //평범한 네비게이션
                var result = await ApiHelper.Instance.GetCareerProfileAsync(battleTag.Tag);
                if (result == null) goto ExitRtn;
                if (string.IsNullOrEmpty(result.BattleTag))
                {
                    //배틀테그를 찾을 수 없었을 때
                    //배틀테그를 찾을 수 없다는 메시지 출력하고 CurrentBattleTag = null로 입력
                }
                else
                {
                    //제대로된 배틀테그라면..
                    CurrentBattleTag = result;
                }


            ExitRtn:
                Busy.SetBusy(false);
            }
        }
    }
}