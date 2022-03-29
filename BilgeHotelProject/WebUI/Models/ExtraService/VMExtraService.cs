using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ExtraService
{
    public class VMExtraService : BaseVM
    {
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        private decimal _totalPrice;
        public decimal TotalPrice
        {
            get
            {
                _totalPrice = 0;
                if (Quantity!=0)
                {
                    _totalPrice = Price * Quantity;
                }
                return _totalPrice;
            }
        }
        public int Quantity { get; set; }
    }
}
