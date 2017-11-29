using Store.Production.ProductionFacadeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Production.ProductionController
    {
    public class ProductionControllerImplementation : IProductionController
        {
        IProductionFacade facade;

        public ProductionControllerImplementation(IProductionFacade facade)
            {
            this.facade = facade;
            }

        public int AddPhone(string phoneName, int warehouseId)
            {
            return facade.AddPhone(phoneName, warehouseId);
            }

        public int GetPhoneQuantity(int phoneId)
            {
            return facade.GetPhoneQuantity(phoneId);
            }

        public int GetTransportationPrice(int warehouseId, string destination)
            {
            return facade.GetTransportationPrice(warehouseId, destination);
            }

        public int OpenWarehouse(string location, int capacity)
            {
            return facade.OpenWarehouse(location, capacity);
            }
        }
    }
