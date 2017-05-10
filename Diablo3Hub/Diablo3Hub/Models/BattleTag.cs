using SQLite;
using Template10.Mvvm;

namespace Diablo3Hub.Models
{
    /// <summary>
    /// 배틀 테그 정보
    /// </summary>
    public class BattleTag : BindableBase
    {
        private string _bestHeroId;
        private string _description;
        private string _locale;
        private string _server;
        private string _tag;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        /// <summary>
        ///     게임 서버 미국, 유럽, 아시아, 중국 (배틀넷앱 기준)
        /// </summary>
        public string Server
        {
            get => _server;
            set => Set(ref _server, value);
        }

        /// <summary>
        ///     한글, 영어, ..나중에는 어디까지 지원할지 모르지머
        /// </summary>
        public string Locale
        {
            get => _locale;
            set => Set(ref _locale, value);
        }

        /// <summary>
        ///     BattleTag 클래스명과 겹쳐서 그냥 Tag로
        /// </summary>
        public string Tag
        {
            get => _tag;
            set => Set(ref _tag, value);
        }

        /// <summary>
        ///     설명
        /// </summary>
        public string Description
        {
            get => _description;
            set => Set(ref _description, value);
        }

        /// <summary>
        ///     대표 히어로 아이디
        /// </summary>
        public string BestHeroId
        {
            get => _bestHeroId;
            set => Set(ref _bestHeroId, value);
        }
        //마지막 시즌 히어로 수 등

        //혹은 총 히어로 수
    }
}