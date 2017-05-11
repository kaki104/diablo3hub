using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Template10.Mvvm;

namespace Diablo3Hub.Models
{
    public class FavoriteHero : BindableBase
    {
        private string _description;
        /// <summary>
        /// 히어로 아이디
        /// </summary>
        [PrimaryKey]
        public int HeroId { get; set; }
        /// <summary>
        /// 배틀테그 아이디
        /// </summary>
        [Indexed]
        public int BattleTagId { get; set; }
        /// <summary>
        /// 히어로 이름
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 클래스명
        /// </summary>
        public string Class { get; set; }
        /// <summary>
        /// 하드코어 여부
        /// </summary>
        public bool Hardcore { get; set; }
        /// <summary>
        /// 시즌 케릭 여부
        /// </summary>
        public bool Seasonal { get; set; }

        /// <summary>
        ///     설명
        /// </summary>
        public string Description
        {
            get => _description;
            set => Set(ref _description, value);
        }
    }
}
