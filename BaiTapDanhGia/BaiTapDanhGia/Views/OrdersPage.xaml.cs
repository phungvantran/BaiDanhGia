using BaiTapDanhGia.Models;
using BaiTapDanhGia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTapDanhGia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetCommandPage : ContentPage
    {
        public SetCommandPage()
        {
            InitializeComponent();
            ViewModel = new OrdersPageViewModel();
        }
        
        public OrdersPageViewModel ViewModel
        {
            get { return BindingContext as OrdersPageViewModel; }
            set { BindingContext = value; }
        }

        private void OnSelectTradingCode(object sender, SelectedItemChangedEventArgs e)
        {
            var t = e.SelectedItem as TradingCode;
            ViewModel.SelectTradingCode(t);
        }

        private void OnDropdownSelected(object sender, ItemSelectedEventArgs e)
        {
            ViewModel.SelectDropdown(e.SelectedIndex);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var x = sender as StackLayout;
            ViewModel.Tapped(x);
        }

        private void CustomEntry_Unfocused(object sender, FocusEventArgs e)
        {
            ViewModel.CheckConditions();
        }

       
    }
}