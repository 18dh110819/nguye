using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraThucHanh_Cau1
{
    class CuaHang:IPrice
    {
        double price;
        public CuaHang(double gia)
        {
            price = gia;
        }
        public void DisplayDetail(string product)
        {
            Console.WriteLine($"{product} gia o cua hang: {price} $");
        }
    }
}
