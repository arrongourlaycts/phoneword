using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Phoneword
{
    public partial class CallHistoryPage : ContentPage
    {
        public CallHistoryPage()
        {
            InitializeComponent();
        }

        async void OnCall(object sender, EventArgs e)
        {
            var dialer = DependencyService.Get<IDialer>();
                dialer.Dial("555555555");

        }
    }
}
