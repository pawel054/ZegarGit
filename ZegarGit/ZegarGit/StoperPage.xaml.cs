using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZegarGit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StoperPage : ContentPage
    {
        private bool firstClick = true;
        DateTime dateTime = new DateTime();
        public StoperPage()
        {
            InitializeComponent();
        }

        private void StoperButton(object sender, EventArgs e)
        {
            startButton.Text = "Stop";
            startButton.Opacity = 0.6;
            if (firstClick)
            {
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        dateTime = dateTime.AddSeconds(1);
                        labelTime.Text = dateTime.ToString("mm:ss");
                    });
                    return true;
                });
                firstClick = false;
            }
            else
            {
                startButton.Text = "Start";

                firstClick = true;
            }
        }
    }
}