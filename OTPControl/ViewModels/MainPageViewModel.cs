using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OTPControl.ViewModels
{
    public class MainPageViewModel :BaseViewModel
    {
        private string _selectedOTP;
        public string SelectedOTP
        {
            get => _selectedOTP;
            set => SetProperty(ref _selectedOTP, value);

        }

        public MainPageViewModel()
        {

        }


        public ICommand GetOtpCommand => new Command<string>((param) =>
         {
             SelectedOTP = param;
         });
    }
}
