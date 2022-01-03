using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraThucHanh_Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerShop cuc = new Cuc();
            cuc.FloraType = "Hoa Cuc";
            IPrice onlinePrice = new Online(15.99);
            IPrice offlinePrice = new CuaHang(5.99);
            cuc.Price = onlinePrice;
            cuc.DisplayDetail();
            cuc.Price = offlinePrice;
            cuc.DisplayDetail();
            Console.WriteLine();

            FlowerShop hong = new Cuc();
            hong.FloraType = "Hoa Hong";
            IPrice hongOnlinePrice = new Online(14.99);
            IPrice hongOfflinePrice = new CuaHang(.99);
            hong.Price = hongOnlinePrice;
            hong.DisplayDetail();
            hong.Price = hongOfflinePrice;
            hong.DisplayDetail();
            Console.WriteLine();

            FlowerShop lan = new Cuc();
            lan.FloraType = "Hoa Lan";
            IPrice lanOnlinePrice = new Online(25.99);
            IPrice lanOfflinePrice = new CuaHang(10.99);
            lan.Price = lanOnlinePrice;
            lan.DisplayDetail();
            lan.Price = lanOfflinePrice;
            lan.DisplayDetail();
            Console.ReadKey();
        }
    }
}
