using BaiTapDanhGia.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BaiTapDanhGia
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            Detail = new NavigationPage(new OverviewPage());
            IsPresented = false;
            InitializeComponent();
        }
    }
}
