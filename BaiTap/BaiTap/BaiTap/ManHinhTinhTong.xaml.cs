using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTap
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManHinhTinhTong : ContentPage
    {
        public ManHinhTinhTong()
        {
            InitializeComponent();
        }
        private void TinhTong(object sender, EventArgs e)
        {
            double so1, so2, tong;
            so1 = double.Parse(soA.Text);
            so2 = double.Parse(soB.Text);

            tong = so1 + so2;
            txttong.Text = tong.ToString();
        }

        private void VeTrangChu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}