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
    public partial class ManHinhChao : ContentPage
    {
        public ManHinhChao()
        {
            InitializeComponent();
        }
        private void Chao(object sender, EventArgs e)
        {
            String HoTen = txtHoTen.Text;
            DisplayAlert("Chao", "Chào Bạn :" + HoTen, "Thoát");
        }
    }
}