using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using BaiTapDanhGia.Models;
using BaiTapDanhGia.Services;
using System.Threading.Tasks;

namespace BaiTapDanhGia.ViewModels
{
    public class OrdersPageViewModel : BaseViewModel
    {
        private TradingCodeService _service = new TradingCodeService();
        private TradingCode _selectedItem;
        private TradingCode _tradingCodeDisplay;

        private float _percent1;
        private float _percent2;
        private string _imgbtnSourceExpand;
        private string _imgbtnSourceShowPass;
        private string _lblColorMua;
        private string _bgColorMua;
        private string _lblColorBan;
        private string _bgColorBan;
        private string _bgColorEntryGia;
        private string _bgColorEntryKhoiLuong;
        private string _bgButtonConfirm;

        private bool _isVisibleBoxViewBuy;
        private bool _isVisibleBoxViewSell;
        private bool _isVisibleListTradingCode;
        private bool _isVisibleFrameCover;
        private bool _isVisibleGridExpand;
        private bool _isVisibleConditionUP;
        private bool _isVisibleConditionDOWN;
        private bool _isVisibleConditionUPDOWN;
        private bool _isVisibleConditionOCO;
        private bool _isVisibleConditionBB;
        public bool _isPassword;
        public float _quantity;
        private float _price;
        private float _triggerPrice;
        private float _spread;
        private float _adjustedPrice;
        private float _takeprofitPrice;
        private float _profitStep;
        private float _lossStep;
        private float _triggerPriceGray;
        private string _tradingPassword;

        public ObservableCollection<TradingCode> ListCode { get; private set; } = new ObservableCollection<TradingCode>();
        public List<string> ListOrder { get; private set; } = new List<string>();
        public TradingCode SelectedItem
        {
            get { return _selectedItem; }
            set { SetValue(ref _selectedItem, value); }
        }
        public TradingCode TradingCodeDisplay
        {
            get { return _tradingCodeDisplay; }
            set { SetValue(ref _tradingCodeDisplay, value); }
        }
        public float Percent1
        {
            get { return _percent1; }
            set { SetValue(ref _percent1, value); }
        }
        public float Percent2
        {
            get { return _percent2; }
            set { SetValue(ref _percent2, value); }
        }
        public bool IsVisibleBoxViewBuy
        {
            get { return _isVisibleBoxViewBuy; }
            set { SetValue(ref _isVisibleBoxViewBuy, value); }
        }
        public bool IsVisibleBoxViewSell
        {
            get { return _isVisibleBoxViewSell; }
            set { SetValue(ref _isVisibleBoxViewSell, value); }
        }
        public bool IsVisibleListTradingCode
        {
            get { return _isVisibleListTradingCode; }
            set { SetValue(ref _isVisibleListTradingCode, value); }
        }
        public bool IsVisibleFrameCover
        {
            get { return _isVisibleFrameCover; }
            set { SetValue(ref _isVisibleFrameCover, value); }
        }
        public bool IsVisibleGridExpand
        {
            get { return _isVisibleGridExpand; }
            set { SetValue(ref _isVisibleGridExpand, value); }
        }
        public bool IsVisibleConditionUP
        {
            get { return _isVisibleConditionUP; }
            set { SetValue(ref _isVisibleConditionUP, value); }
        }
        public bool IsVisiblleConditionDOWN
        {
            get { return _isVisibleConditionDOWN; }
            set { SetValue(ref _isVisibleConditionDOWN, value); }
        }
        public bool IsVisibleConditionUPDOWN
        {
            get { return _isVisibleConditionUPDOWN; }
            set { SetValue(ref _isVisibleConditionUPDOWN, value); }
        }
        public bool IsVisibleConditionOCO
        {
            get { return _isVisibleConditionOCO; }
            set { SetValue(ref _isVisibleConditionOCO, value); }
        }
        public bool IsVisibleConditionBB
        {
            get { return _isVisibleConditionBB; }
            set { SetValue(ref _isVisibleConditionBB, value); }
        }
        public string ImgbtnSourceExpand
        {
            get { return _imgbtnSourceExpand; }
            set { SetValue(ref _imgbtnSourceExpand, value); }
        }
        public string ImgbtnSourceShowPass
        {
            get { return _imgbtnSourceShowPass; }
            set { SetValue(ref _imgbtnSourceShowPass, value); }
        }
        public string LblColorMua
        {
            get { return _lblColorMua; }
            set { SetValue(ref _lblColorMua, value); }
        }
        public string BgColorMua
        {
            get { return _bgColorMua; }
            set { SetValue(ref _bgColorMua, value); }
        }
        public string LblColorBan
        {
            get { return _lblColorBan; }
            set { SetValue(ref _lblColorBan, value); }
        }
        public string BgColorBan
        {
            get { return _bgColorBan; }
            set { SetValue(ref _bgColorBan, value); }
        }
        public string BgColorEntryGia
        {
            get { return _bgColorEntryGia; }
            set { SetValue(ref _bgColorEntryGia, value); }
        }
        public string BgColorEntryKhoiLuong
        {
            get { return _bgColorEntryKhoiLuong; }
            set { SetValue(ref _bgColorEntryKhoiLuong, value); }
        }
        public string BgButtonConfirm
        {
            get { return _bgButtonConfirm; }
            set { SetValue(ref _bgButtonConfirm, value); }
        }
        public bool IsPassword
        {
            get { return _isPassword; }
            set { SetValue(ref _isPassword, value); }
        }
        public float Quantity
        {
            get { return _quantity; }
            set { SetValue(ref _quantity, value); }
        }
        public float Price
        {
            get { return _price; }
            set { SetValue(ref _price, value); }
        }
        public float TriggerPrice
        {
            get { return _triggerPrice; }
            set { SetValue(ref _triggerPrice, value); }
        }
        public float Spread
        {
            get { return _spread; }
            set { SetValue(ref _spread, value); }
        }
        public float AdjustedPrice
        {
            get { return _adjustedPrice; }
            set { SetValue(ref _adjustedPrice, value); }
        }
        public float TakeprofitPrice
        {
            get { return _takeprofitPrice; }
            set { SetValue(ref _takeprofitPrice, value); }
        }
        public float ProfitStep
        {
            get { return _profitStep; }
            set { SetValue(ref _profitStep, value); }
        }
        public float LossStep
        {
            get { return _lossStep; }
            set { SetValue(ref _lossStep, value); }
        }
        public float TriggerPriceGray
        {
            get { return _triggerPriceGray; }
            set { SetValue(ref _triggerPriceGray, value); }
        }
        public string TradingPassword
        {
            get { return _tradingPassword; }
            set { SetValue(ref _tradingPassword, value); }
        }

        //Khai báo các Command
        public ICommand ToolbarItemCommand { get; private set; } //Hiển thị list mã giao dịch
        public ICommand ExpandGridCommand { get; private set; } //Mở rộng bảng dư mua,dư bán
        public ICommand ClickOnGestureRecognizerCommand { get; private set; } //Chọn các ô trong bảng dư mua-bán, Max khối lượng, 3 số dưới giá 
        public ICommand BuyOrSellCommand { get; private set; } //Click MUA hoặc BÁN
        public ICommand ChangeQuantityCommand { get; private set; } //Thay đổi khối lượng
        public ICommand ChangePriceCommand { get; set; }        //Thay đổi giá
        public ICommand ChangeTriggerPriceCommand { get; set; } //Thay đổi giá điều kiện
        public ICommand ChangeSpreadCommand { get; set; }       //Thay đổi biên trượt
        public ICommand ChangeProfitStepCommand { get; set; }   //Thay đổi khoảng lãi
        public ICommand ChangeLossStepCommand { get; set; }     //Thay đổi khoảng lỗ
        public ICommand ShowPassCommand { get; set; }           //ẩn hiện mật khẩu

        //============================================ Khởi tạo =======================================//
        public OrdersPageViewModel()
        {
            ListCode = _service.GetTradingCode();

            string s1 = "Lệnh UP";
            string s2 = "Lệnh DOWN";
            string s3 = "Lệnh OCO";
            string s4 = "Lệnh B&B";

            ListOrder.Add(s1);
            ListOrder.Add(s2);
            ListOrder.Add(s3);
            ListOrder.Add(s4);
            //--------------------------
            TradingCodeDisplay = ListCode[0];
            Percent1 = ((230 / 100) * TradingCodeDisplay.Percent1);
            Percent2 = 230 - Percent1;

            IsVisibleBoxViewBuy = true;
            IsVisibleBoxViewSell = false;
            IsVisibleListTradingCode = false;
            ImgbtnSourceExpand = "arrow2.png";
            IsVisibleGridExpand = false;
            LblColorMua = "#6ccf06"; _lblColorBan = "#f05c6a";
            BgColorMua = "#f2f2f2"; BgColorBan = "#f2f2f2";
            BgColorEntryGia = "White"; BgColorEntryKhoiLuong = "White";
            BgButtonConfirm = "#c9c9c9";
            IsVisibleConditionUPDOWN = true;
            IsVisibleConditionOCO = false;
            IsVisibleConditionUP = true;
            IsVisibleConditionBB = false;
            ImgbtnSourceShowPass = "hidepass.png";
            IsPassword = true;
            //--------------------------

            ToolbarItemCommand = new Command(() => ToolbarItem());
            ExpandGridCommand = new Command<string>((c) => ExpandGrid(c));
            ClickOnGestureRecognizerCommand = new Command<string>((c) => ClickOnGestureRecognize(c));
            BuyOrSellCommand = new Command<string>((c) => BuyOrSell(c));
            ChangeQuantityCommand = new Command<string>((c) => ChangeQuantity(c));
            ChangePriceCommand = new Command<string>((c) => ChangePrice(c));
            ChangeTriggerPriceCommand = new Command<string>((c) => ChangeTriggerPrice(c));
            ChangeSpreadCommand = new Command<string>((c) => ChangeSpread(c));
            ChangeProfitStepCommand = new Command<string>((c) => ChangeProfitStep(c));
            ChangeLossStepCommand = new Command<string>((c) => ChangeLossStep(c));
            ShowPassCommand = new Command<string>((c) => ShowPass(c));

        }

        private void ChangeQuantity(string c)
        {
            if (c == "minus")
            {
                if (Quantity > 0) Quantity = Quantity - 1;
            }
            else //(c=="plus")
            {
                if (Quantity < TradingCodeDisplay.Max) Quantity = Quantity + 1;
            }
            CheckConditions();
        }


        private void ChangePrice(string c)
        {

            if (IsVisibleConditionBB == true)
            {
                if (Price == 0) Price = TradingCodeDisplay.OrangeNumber;

                if (c == "minus")
                {
                    if (Price > TradingCodeDisplay.BlueNumber)
                    {
                        Price = Price - 1;
                        if (ProfitStep != 0) TakeprofitPrice = Price + ProfitStep;
                        if (LossStep != 0)
                        {
                            TriggerPriceGray = Price - LossStep;
                            AdjustedPrice = TriggerPriceGray - Spread;
                        }
                    }
                }
                else
                {
                    if (Price < TradingCodeDisplay.PinkNumber)
                    {
                        Price = Price + 1;
                        if (ProfitStep != 0) TakeprofitPrice = Price + ProfitStep;
                        if (LossStep != 0)
                        {
                            TriggerPriceGray = Price - LossStep;
                            AdjustedPrice = TriggerPriceGray - Spread;
                        }
                    }
                }
            }
            //------------------------------------------------------------------
            if (IsVisibleConditionOCO == true && IsVisibleConditionBB == false)
            {
                if (Price == 0) Price = TradingCodeDisplay.OrangeNumber;
                if (c == "minus")
                {
                    if (Price > TradingCodeDisplay.BlueNumber)
                    {
                        Price = Price - 1;
                        TakeprofitPrice = Price;
                    }
                }
                else
                {
                    if (Price < TradingCodeDisplay.PinkNumber)
                    {
                        Price = Price + 1;
                        TakeprofitPrice = Price;
                    }
                }
            }
            CheckConditions();
        }


        private void ChangeSpread(string c)
        {
            if (c == "plus")
            {
                Spread = Spread + 1;
                if (TriggerPrice != 0) AdjustedPrice = TriggerPrice + Spread;
                if (TriggerPriceGray != 0) AdjustedPrice = TriggerPriceGray - Spread;
            }
            else
            {
                if (Spread == 1)
                {
                    Spread = 0;
                    if (TriggerPrice != 0) AdjustedPrice = TriggerPrice + Spread;
                    if (TriggerPriceGray != 0) AdjustedPrice = TriggerPriceGray - Spread;
                }
                if (Spread == 0)
                {
                    Spread = 0;
                    if (TriggerPrice != 0) AdjustedPrice = TriggerPrice + Spread;
                    if (TriggerPriceGray != 0) AdjustedPrice = TriggerPriceGray - Spread;
                }
                else
                {
                    Spread = Spread - 1;
                    if (TriggerPrice != 0) AdjustedPrice = TriggerPrice + Spread;
                    if (TriggerPriceGray != 0) AdjustedPrice = TriggerPriceGray - Spread;
                }
            }
        }

        private async void ChangeTriggerPrice(string c)
        {
            if (IsVisibleConditionUP == true)
            {
                if (Price == 0) Price = TradingCodeDisplay.OrangeNumber;

                if (c == "minus")
                {
                    if (TriggerPrice <= 0 || TriggerPrice == Price)
                    {
                        await Application.Current.MainPage.DisplayAlert("Thông báo", "Giá điều kiện phải lớn hơn giá thị trường", "Ok");
                        TriggerPrice = 0; AdjustedPrice = 0;
                    }
                    else
                    {
                        TriggerPrice = TriggerPrice - 1;
                        AdjustedPrice = TriggerPrice + Spread;
                    }
                }
                else
                {
                    if (TriggerPrice == 0)
                    {
                        TriggerPrice = Price + 1;
                        AdjustedPrice = TriggerPrice + Spread;
                    }
                    else
                    {
                        TriggerPrice = TriggerPrice + 1;
                        AdjustedPrice = TriggerPrice + Spread;
                    }

                }

            }
            //-----------------------------------------------------
            if (IsVisiblleConditionDOWN == true)
            {
                if (c == "minus")
                {
                    if (TriggerPrice == 0) TriggerPrice = TradingCodeDisplay.OrangeNumber;
                    TriggerPrice = TriggerPrice - 1;
                    AdjustedPrice = TriggerPrice + Spread;
                }
                else //c=="plus"
                {
                    if (TriggerPrice == 0 || TriggerPrice == (TradingCodeDisplay.OrangeNumber - 1))
                    {
                        await Application.Current.MainPage.DisplayAlert("Thông báo", "Giá điều kiện phải nhỏ hơn giá thị trường", "OK");
                        TriggerPrice = 0; AdjustedPrice = 0;
                    }
                    else
                    {
                        TriggerPrice = TriggerPrice + 1;
                        AdjustedPrice = TriggerPrice + Spread;
                    }
                }
            }
            //-----------------------------------------------------
            if (IsVisibleConditionOCO == true)
            {
                if (TakeprofitPrice != 0)
                {
                    if (c == "minus")
                    {
                        if (TriggerPrice <= TakeprofitPrice)
                        {
                            await Application.Current.MainPage.DisplayAlert("Thông báo", "Giá điều kiện phải lớn hơn giá chốt lãi", "OK");
                            TriggerPrice = 0; AdjustedPrice = 0;
                        }
                        else
                        {
                            TriggerPrice = TriggerPrice - 1;
                            AdjustedPrice = TriggerPrice + Spread;
                        }
                    }
                    else //c=="plus"
                    {
                        if (TriggerPrice == 0) TriggerPrice = TakeprofitPrice;
                        TriggerPrice = TriggerPrice + 1;
                        AdjustedPrice = TriggerPrice + Spread;
                    }
                }
            }
            CheckConditions();
        }
        private void ChangeProfitStep(string c)
        {
            if (c == "minus")
            {
                if (ProfitStep > 0)
                {
                    ProfitStep = ProfitStep - 1;
                    if (Price != 0) TakeprofitPrice = Price + ProfitStep;
                }
                if (ProfitStep < 1)
                {
                    TakeprofitPrice = 0;
                }
            }
            else
            {
                ProfitStep = ProfitStep + 1;
                if (Price != 0) TakeprofitPrice = Price + ProfitStep;
            }
            CheckConditions();
        }

        private void ChangeLossStep(string c)
        {
            if (c == "minus")
            {
                if (LossStep > 0)
                {
                    LossStep = LossStep - 1;
                    if (Price != 0)
                    {
                        TriggerPriceGray = Price - LossStep;
                        AdjustedPrice = TriggerPriceGray + Spread;
                    }
                }
                if (LossStep < 1)
                {
                    TriggerPriceGray = 0;
                    AdjustedPrice = 0;
                }
            }
            else
            {
                LossStep = LossStep + 1;
                if (TakeprofitPrice != 0) TakeprofitPrice = Price + Spread;
                if (Price != 0)
                {
                    TriggerPriceGray = Price - LossStep;
                    AdjustedPrice = TriggerPriceGray - Spread;
                }
            }
            CheckConditions();
        }

        public async void Tapped(StackLayout x)
        {
            if (x.AutomationId == "hide")
            {
                IsVisibleListTradingCode = false;
                IsVisibleFrameCover = false;
            }
            if (x.AutomationId == "max")
            {
                x.BackgroundColor = Color.White; BgColorEntryKhoiLuong = "#928d8e"; Quantity = TradingCodeDisplay.Max;
                await Task.Delay(10);
                x.BackgroundColor = Color.FromHex("#808080"); BgColorEntryKhoiLuong = "White";
            }
            else
            {
                x.BackgroundColor = Color.FromHex("#928d8e");
                await Task.Delay(10);
                if (x.AutomationId == "n1" || x.AutomationId == "n2" || x.AutomationId == "n3")
                {
                    x.BackgroundColor = Color.FromHex("#edf7ec"); return;
                }
                if (x.AutomationId == "n4" || x.AutomationId == "n5" || x.AutomationId == "n6")
                {
                    x.BackgroundColor = Color.FromHex("#fde8eb"); return;
                }
                if (x.AutomationId == "m")
                {
                    x.BackgroundColor = Color.White; return;
                }
            }

        }
        public void SelectDropdown(int c)
        {

            if (c == 0)
            {
                IsVisibleConditionUPDOWN = true;
                IsVisibleConditionUP = true;
                IsVisiblleConditionDOWN = false;
                IsVisibleConditionOCO = false;
                IsVisibleConditionBB = false;
            }
            if (c == 1)
            {
                IsVisibleConditionUPDOWN = true;
                IsVisiblleConditionDOWN = true;
                IsVisibleConditionUP = false;
                IsVisibleConditionOCO = false;
                IsVisibleConditionBB = false;
            }
            if (c == 2)
            {
                IsVisibleConditionUPDOWN = false;
                IsVisibleConditionOCO = true;
                IsVisibleConditionUP = false;
                IsVisiblleConditionDOWN = false;
                IsVisibleConditionBB = false;
            }
            if (c == 3)
            {
                IsVisibleConditionUPDOWN = false;
                IsVisibleConditionOCO = true;
                IsVisibleConditionBB = true;
                IsVisibleConditionUP = false;
                IsVisiblleConditionDOWN = false;
            }
            RefreshVariables();

        }

        private void BuyOrSell(string c)
        {
            if (c == "buy")
            {
                LblColorMua = "#6ccf06";
                LblColorBan = "#f05c6a";
                IsVisibleBoxViewSell = false;
                IsVisibleBoxViewBuy = true;
            }
            else
            {
                LblColorMua = "#b8e986";
                LblColorBan = "#cf0614";
                IsVisibleBoxViewBuy = false;
                IsVisibleBoxViewSell = true;

            }
            CheckConditions();
        }

        private async void ClickOnGestureRecognize(string c)
        {
            BgColorEntryGia = "#928d8e";
            await Task.Delay(10);
            BgColorEntryGia = "White";

            if (c == "buy1" || c == "buy2" || c == "buy3")
            {

                IsVisibleBoxViewBuy = false;
                IsVisibleBoxViewSell = true;
                LblColorMua = "#b8e986";
                LblColorBan = "#cf0614";

                BgColorBan = "#928d8e";
                await Task.Delay(10);
                BgColorBan = "#f2f2f2";

                if (c == "buy1") Price = TradingCodeDisplay.Buy1; TakeprofitPrice = Price;
                if (c == "buy2") Price = TradingCodeDisplay.Buy2; TakeprofitPrice = Price;
                if (c == "buy3") Price = TradingCodeDisplay.Buy3; TakeprofitPrice = Price;
            }

            if (c == "sell1" || c == "sell2" || c == "sell3")
            {

                IsVisibleBoxViewSell = false;
                IsVisibleBoxViewBuy = true;
                LblColorMua = "#6ccf06";
                LblColorBan = "#f05c6a";

                BgColorMua = "#928d8e";
                await Task.Delay(10);
                BgColorMua = "#f2f2f2";

                if (c == "sell1") Price = TradingCodeDisplay.Sell1; TakeprofitPrice = Price;
                if (c == "sell2") Price = TradingCodeDisplay.Sell2; TakeprofitPrice = Price;
                if (c == "sell3") Price = TradingCodeDisplay.Sell3; TakeprofitPrice = Price;
            }
            if (c == "pink" || c == "orange" || c == "blue")
            {
                BgColorEntryGia = "#928d8e";
                await Task.Delay(10);
                BgColorEntryGia = "White";

                if (c == "pink") Price = TradingCodeDisplay.PinkNumber; TakeprofitPrice = Price;
                if (c == "orange") Price = TradingCodeDisplay.OrangeNumber; TakeprofitPrice = Price;
                if (c == "blue") Price = TradingCodeDisplay.BlueNumber; TakeprofitPrice = Price;
            }
            CheckConditions();
        }

        //Hàm xử lí chọn item trong list mã giao dịch
        public void SelectTradingCode(TradingCode c)
        {
            IsVisibleFrameCover = false;
            if (c == null)
            {
                return;
            }
            SelectedItem = null;
            TradingCodeDisplay = c;
            IsVisibleListTradingCode = false;

            Percent1 = ((230 / 100) * TradingCodeDisplay.Percent1);
            Percent2 = ((230 / 100) * TradingCodeDisplay.Percent2);

            RefreshVariables();
        }

        private void ToolbarItem()
        {
            IsVisibleFrameCover = true;
            IsVisibleListTradingCode = !IsVisibleListTradingCode;

        }


        private void ExpandGrid(string c)
        {
            if (ImgbtnSourceExpand == "arrow2.png")
            {
                ImgbtnSourceExpand = "arrow.png";
                IsVisibleGridExpand = true;
            }
            else
            {
                IsVisibleGridExpand = false;
                ImgbtnSourceExpand = "arrow2.png";
            }
        }

        private void ShowPass(string c)
        {
            if (ImgbtnSourceShowPass == "hidepass.png")
            {
                ImgbtnSourceShowPass = "showpass.png";
                IsPassword = false;
            }
            else
            {
                ImgbtnSourceShowPass = "hidepass.png";
                IsPassword = true;
            }
        }
        //Hàm kiểm tra các điều kiện để sáng button xác nhận mua và bán
        public void CheckConditions()
        {

            if (IsVisibleConditionUPDOWN == true)
            {

                if (Quantity != 0 && TriggerPrice != 0 && TradingPassword != "")
                {
                    if (IsVisibleBoxViewBuy == true) BgButtonConfirm = "#6ccf06";
                    if (IsVisibleBoxViewSell == true) BgButtonConfirm = "#cf0614";
                }
                if (Quantity == 0 || TriggerPrice == 0 || TradingPassword == "")
                    BgButtonConfirm = "#c9c9c9";
            }
            if (IsVisibleConditionOCO == true)
            {
                if (Quantity != 0 && Price != 0 && TriggerPrice != 0 && TradingPassword != "")
                {
                    if (IsVisibleBoxViewBuy == true) BgButtonConfirm = "#6ccf06";
                    if (IsVisibleBoxViewSell == true) BgButtonConfirm = "#cf0614";
                }
                if (Quantity == 0 || Price == 0 || TriggerPrice == 0 || TradingPassword == "")
                    BgButtonConfirm = "#c9c9c9";
            }
            if (IsVisibleConditionBB == true)
            {
                if (Quantity != 0 && TriggerPriceGray != 0 && TakeprofitPrice != 0 && TradingPassword != "")
                {
                    if (IsVisibleBoxViewBuy == true) BgButtonConfirm = "#6ccf06";
                    if (IsVisibleBoxViewSell == true) BgButtonConfirm = "#cf0614";
                }
                if (Quantity == 0 || TriggerPriceGray == 0 || TakeprofitPrice == 0 || TradingPassword == "")
                    BgButtonConfirm = "#c9c9c9";
            }
        }

        //Hàm làm mới các biến khi chọn lệnh hoặc mã giao dịch mới
        public void RefreshVariables()
        {
            Price = 0; Quantity = 0;
            TriggerPrice = 0; TriggerPriceGray = 0;
            Spread = 0; LossStep = 0; ProfitStep = 0;
            AdjustedPrice = 0; TakeprofitPrice = 0; TradingPassword = "";

            CheckConditions();
        }
    }
}
