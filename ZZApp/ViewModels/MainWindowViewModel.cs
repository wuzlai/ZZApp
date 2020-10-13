using System;
using System.Collections.Generic;
using System.Text;
using ZZApp.Views;

namespace ZZApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";


        public void btnClick()
        {
            UserAgreementView view = new UserAgreementView();
            view.Show();
        }
    }
}
