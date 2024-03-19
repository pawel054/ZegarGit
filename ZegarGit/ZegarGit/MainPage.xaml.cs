using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ZegarGit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
                });
                return true;
            });

        }

        private void SaveButtonClicked(object sender, EventArgs e)
        {
            FileClass.WriteToFile(labelTime.Text);
        }

        private void ShowButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SavedTimes());
        }
    }
}
