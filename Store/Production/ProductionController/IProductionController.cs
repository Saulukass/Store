using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Production.ProductionController
    {
    public interface IProductionController
        {
        int OpenWarehouse(string location, int capacity);
        int GetPhoneQuantity(int phoneId);
        int AddPhone(string phoneName, int warehouseId);
        int GetTransportationPrice(int warehouseId, string destination);
        }
    }
