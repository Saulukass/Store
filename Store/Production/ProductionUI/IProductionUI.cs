using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Production.ProductionUI
    {
    public interface IProductionUI
        {
        void OpenWarehouse();
        void GetPhoneQuantity();
        void AddPhone();
        void GetTransportationPrice();
        }
    }
