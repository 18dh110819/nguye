using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraThucHanh_Cau1
{
    public class Online : IPrice
    {
        double price;
        public Online(double gia)
        {
            price = gia;
        }
        public void DisplayDetail(string product)
        {
            Console.WriteLine($"{product} gia o cua hang: {price} $");
        }
    }
}
