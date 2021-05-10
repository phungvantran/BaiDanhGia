using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using BaiTapDanhGia.Models;

namespace BaiTapDanhGia.Services
{
    public class TradingCodeService
    {
        public ObservableCollection<TradingCode> GetTradingCode()
        {
            return new ObservableCollection<TradingCode>
            {
                new TradingCode{CodeName="VN30F2106",PinkNumber=1409,OrangeNumber=1317,BlueNumber=1224,Percent1=64,Percent2=36,OpenDoor=1277,High=1317,Low=(float)1272.3,HD=908,OI=489,Buy1=(float)1310.8,Buy2=(float)1310.6,Buy3=(float)1309.1,Buyr1=1,Buyr2=5,Buyr3=1,Sell1=1314,Sell2=1315,Sell3=(float)1316.9,Sellr1=7,Sellr2=4,Sellr3=5,Max=23 },
                new TradingCode{CodeName="VN30F2105",PinkNumber=1403,OrangeNumber=1312,BlueNumber=1220,Percent1=20,Percent2=80,OpenDoor=1276,High=1312,Low=1320, HD=174538,OI=26151,Buy1=(float)1318.8,Buy2=(float)1318.7,Buy3=(float)1318.5,Buyr1=46,Buyr2=5,Buyr3=60,Sell1=(float)1318.2,Sell2=(float)1318.1,Sell3=(float)1318.3,Sellr1=4,Sellr2=20,Sellr3=13,Max=10},
                new TradingCode{CodeName="VN30F2112",PinkNumber=1400,OrangeNumber=1309,BlueNumber=1217,Percent1=45,Percent2=55,OpenDoor=1275,High=1309,Low=(float)1271.7,HD=60,OI=46,Buy1=(float)1309.1,Buy2=(float)1308.6,Buy3=(float)1305.2,Buyr1=3,Buyr2=1,Buyr3=2,Sell1=(float)1313.9,Sell2=(float)1314.4,Sell3=1315,Sellr1=1,Sellr2=1,Sellr3=1,Max=40},
                new TradingCode{CodeName="VN30F2109",PinkNumber=1401,OrangeNumber=1309,BlueNumber=1215,Percent1=39,Percent2=61,OpenDoor=1278,High=1310,Low=1273,HD=161,OI=240,Buy1=(float)1311.1,Buy2=1311,Buy3=(float)1301.4,Buyr1=6,Buyr2=1,Buyr3=1,Sell1=1319,Sell2=(float)1319.9, Sell3=1320,Sellr1=4, Sellr2=2, Sellr3=12,Max=4},
                new TradingCode{CodeName="GB05F2112",PinkNumber=117991,OrangeNumber=114555,BlueNumber=111119,Percent1=90,Percent2=10,Max=3},
                new TradingCode{CodeName="GB05F2109",PinkNumber=1409,OrangeNumber=1309,BlueNumber=1218,Percent1=11,Percent2=89,Max=15},
                new TradingCode{CodeName="GB05F2106",PinkNumber=117751,OrangeNumber=114322,BlueNumber=110893,Percent1=29,Percent2=71,Max=20},
                new TradingCode{CodeName="GB10F2112",PinkNumber=117991,OrangeNumber=114555,BlueNumber=111119,Percent1=67,Percent2=33,Max=25},
                new TradingCode{CodeName="GB10F2109",PinkNumber=119213,OrangeNumber=115751,BlueNumber=112269,Percent1=56,Percent2=44,Max=30},
                new TradingCode{CodeName="GB10F2106",PinkNumber=117751,OrangeNumber=114322,BlueNumber=110893,Percent1=78,Percent2=22,Max=15}
            };
        }
    }
}
