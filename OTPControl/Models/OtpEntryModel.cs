using OTPControl.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OTPControl.Models
{
    public class OtpEntryModel : BaseViewModel
    {
        public string Text { get; set; }
        public Color Color { get; set; }
    }
}
