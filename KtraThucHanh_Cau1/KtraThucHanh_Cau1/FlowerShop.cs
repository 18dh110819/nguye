using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraThucHanh_Cau1
{
    public abstract class FlowerShop
    {
        public string FloraType { get; set; }
        public IPrice Price { get; set; }
        public abstract void DisplayDetail();
    }
}
