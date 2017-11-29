using Store.Production.ProductionDomainEntities;
using Store.Production.ProductionDomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Production.ProductionFacadeService
    {
    class ProductionFacadeImplementation : IProductionFacade
        {
        IPhoneRepository phones;
        IWarehouseRepository warehouses;
        IImportFeeCalculator importCalculator;
        IProductionFactory productionFactory;
        IPhoneSupplier phoneSupplier;

        public ProductionFacadeImplementation(IPhoneRepository phones, IWarehouseRepository warehouses, IImportFeeCalculator importCalculator,
            IProductionFactory productionFactory, IPhoneSupplier phoneSupplier)
            {
            this.phones = phones;
            this.warehouses = warehouses;
            this.importCalculator = importCalculator;
            this.productionFactory = productionFactory;
            this.phoneSupplier = phoneSupplier;
            }

        public int AddPhone(string phoneName, int warehouseId)
            {
            IPhone newPhone = productionFactory.CreatePhone(phoneName);
            IWarehouse warehouse = warehouses.Find(warehouseId);
            if (null == warehouse)
                return -1;

            phoneSupplier.SupplyPhonesToWarehouse(newPhone, warehouse);
            warehouses.Update(warehouseId, warehouse);
            int phoneId = phones.Save(newPhone);
            return phoneId;
            }

        public int GetPhoneQuantity(int phoneId)
            {
            IPhone phone = phones.Find(phoneId);
            IEnumerator<IWarehouse> activeWarehouses = warehouses.GetAll();
            int quantity = 0;
            while(activeWarehouses.MoveNext())
                {
                if (activeWarehouses.Current.IsPhoneStored(phone))
                    quantity += activeWarehouses.Current.GetPhoneQuantity(phone);
                }
            return quantity;
            }

        public int GetTransportationPrice(int warehouseId, string destination)
            {
            IWarehouse warehouse = warehouses.Find(warehouseId);
            if (null == warehouse)
                {
                Console.WriteLine("Warehouse is not found!");
                return -1;
                }

            return importCalculator.CalculateImportFee(warehouse, destination);
            }

        public int OpenWarehouse(string location, int capacity)
            {
            IWarehouse newWarehouse = productionFactory.CreateWarehouse(location, capacity);
            int warehouseId = warehouses.Save(newWarehouse);
            return warehouseId;
            }
        }
    }
