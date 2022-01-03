using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraThucHanh_Cau1
{
    public class Hong : FlowerShop
    {
        public override void DisplayDetail()
        {
            Price.DisplayDetail(FloraType);
        }
    }
}
