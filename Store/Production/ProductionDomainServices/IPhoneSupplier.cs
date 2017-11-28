using Store.Production.ProductionDomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Production.ProductionDomainServices
    {
    interface IPhoneSupplier
        {
        void SupplyPhonesToWarehouse(IPhone phone, IWarehouse warehouse);
        }
    }
