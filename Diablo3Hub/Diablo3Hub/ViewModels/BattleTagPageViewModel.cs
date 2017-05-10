using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diablo3Hub.Models;
using Template10.Mvvm;

namespace Diablo3Hub.ViewModels
{
    public class BattleTagPageViewModel : ViewModelBase
    {
        private IList<BattleTag> _battleTags;
        /// <summary>
        /// 배틀 테그 목록
        /// </summary>
        public IList<BattleTag> BattleTags
        {
            get { return _battleTags; }
            set { Set(ref _battleTags ,value); }
        }
    }
}
