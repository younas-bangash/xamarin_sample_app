using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Navigation;
using SampleApp.Core.ViewModels;

/**
 *  This class is responsibile to present the first viewModel or viewModels 
 * */
namespace SampleApp.Core
{
    class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        private readonly IMvxNavigationService _mvxNavigationService;

        public AppStart(IMvxNavigationService mvxNavigationService)
        {
            _mvxNavigationService = mvxNavigationService;
        }

        public void Start(object hint = null)
        {
            _mvxNavigationService.Navigate<LoginViewModel>();
        }
    }
}
