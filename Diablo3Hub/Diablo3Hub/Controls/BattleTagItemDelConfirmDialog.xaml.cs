using Diablo3Hub.Models;
using Diablo3Hub.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Diablo3Hub.Controls
{
    public sealed partial class BattleTagItemDelConfirmDialog : ContentDialog
    {
        public BattleTagItemDelConfirmDialog()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 추가 생성자
        /// </summary>
        /// <param name="selectedBattleTag"></param>
        public BattleTagItemDelConfirmDialog(IList<BattleTag> selectedBattleTag) : this()
        {
            ViewModel.SelectedBattleTags = selectedBattleTag;
        }

        public BattleTagItemDelConfirmDialogViewModel ViewModel
        {
            get => DataContext as BattleTagItemDelConfirmDialogViewModel;
            set => DataContext = value;
        }
    }
}
