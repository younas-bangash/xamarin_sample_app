using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace SampleApp.Core.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {

        string userPassword;

        public string UserPassword {
            get { return userPassword; }
            private set {
                userPassword = value;
                RaisePropertyChanged(() => userPassword);
            }
        }

        string userName;

        public string UserName {
            get { return userName; }
            private set {
                userName = value;
                RaisePropertyChanged(() => UserName);
            }
        }

        /**
         * asynchronous operation. Thread(s) are used to complete that operation by breaking the 
         * work up into chunks and assigning to separate threads.
         * */
        public override Task Initialize()
        {
            //TODO: Add starting logic here

            return base.Initialize();
        }

       

    }
}
