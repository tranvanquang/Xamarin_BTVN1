using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BaiTap
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ManHinhChao(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManHinhChao());

        }


        private void ManHinhTinhTong(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManHinhTinhTong());
        }


        private void AbsoluteLayout(object sender, EventArgs e)
        {

        }
        private void StackLayout(object sender, EventArgs e)
        {

        }
        private void Login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

        private void GrildLayout(object sender, EventArgs e)
        {

        }
    }
}
