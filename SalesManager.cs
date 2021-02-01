using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Buy(Sale sale)
        {
            Console.WriteLine("Satın alınan oyun: " + sale.GameName + " Fiyat: " + sale.GamePrice);
        }
    }
}
