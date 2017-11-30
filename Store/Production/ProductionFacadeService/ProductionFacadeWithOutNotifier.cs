using Store.Production.ProductionDomainEntities;
using Store.Production.ProductionDomainServices;
using Store.Production.ProductionRepository;
using System;
using System.Collections.Generic;

namespace Store.Production.ProductionFacadeService
    {
    public class ProductionFacadeWithoutNotifier : IProductionFacade
        {
        IPhoneRepository phones;
        IWarehouseRepository warehouses;
        IImportFeeCalculator importCalculator;
        IProductionFactory productionFactory;
        IPhoneSupplier phoneSupplier;

        public ProductionFacadeWithoutNotifier(IPhoneRepository phones, IWarehouseRepository warehouses, IImportFeeCalculator importCalculator,
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
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating phone");
            IPhone newPhone = productionFactory.CreatePhone(phoneName);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for warehouse in repository");
            IWarehouse warehouse = warehouses.Find(warehouseId);
            if (null == warehouse)
                return -1;

            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Supplying phones to warehouse");
            phoneSupplier.SupplyPhonesToWarehouse(newPhone, warehouse);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Updating warehouse in repository");
            warehouses.Update(warehouseId, warehouse);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving phone to repository");
            int phoneId = phones.Save(newPhone);
            return phoneId;
            }

        public int GetTransportationPrice(int warehouseId, string destination)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for warehouse in repository");
            IWarehouse warehouse = warehouses.Find(warehouseId);
            if (null == warehouse)
                {
                Console.WriteLine("Warehouse is not found!");
                return -1;
                }

            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Calculating fee");
            return importCalculator.CalculateImportFee(warehouse, destination);
            }

        public int OpenWarehouse(string location, int capacity)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating warehouse");
            IWarehouse newWarehouse = productionFactory.CreateWarehouse(location, capacity);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving warehouse to repository");
            int warehouseId = warehouses.Save(newWarehouse);
            return warehouseId;
            }
        }
    }
