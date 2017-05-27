using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Hub.ViewModels
{
    public class ViewModelLocator
    {
        private BattleTagPageViewModel _battleTagPageViewModel;
        private BattleTagItemDelConfirmDialogViewModel _battleTagItemDelConfirmDialogViewModel;

        public BattleTagPageViewModel BattleTagPageViewModel =>

                _battleTagPageViewModel ?? (_battleTagPageViewModel = new BattleTagPageViewModel());

        public BattleTagItemDelConfirmDialogViewModel BattleTagItemDelConfirmDialogViewModel =>

                _battleTagItemDelConfirmDialogViewModel ?? (_battleTagItemDelConfirmDialogViewModel = new BattleTagItemDelConfirmDialogViewModel());
    }
}
