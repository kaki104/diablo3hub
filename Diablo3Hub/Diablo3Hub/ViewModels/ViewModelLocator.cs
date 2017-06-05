using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo3Hub.ViewModels
{
    public class ViewModelLocator
    {

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<BattleTagPageViewModel>();
            SimpleIoc.Default.Register<BattleTagItemDelConfirmDialogViewModel>();
        }

        // <summary>
        // Gets the  BattleTagPageViewModel view model.
        // </summary>
        // <value>
        // The BattleTagPageViewModel.
        // </value>
        public BattleTagPageViewModel BattleTagPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<BattleTagPageViewModel>();
            }
        }

        // <summary>
        // Gets the  BattleTagItemDelConfirmDialogViewModel view model.
        // </summary>
        // <value>
        // The BattleTagItemDelConfirmDialogViewModel.
        // </value>
        public BattleTagItemDelConfirmDialogViewModel BattleTagItemDelConfirmDialogViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<BattleTagItemDelConfirmDialogViewModel>();
            }
        }

        // <summary>
        // The cleanup.
        // </summary>
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
