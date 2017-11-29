using Store.Production.ProductionDomainEntities;
using Store.Production.ProductionDomainServices;
using System;
using System.Collections.Generic;

namespace Store.Production.ProductionFacadeService
    {
    public class ProductionFacadeImplementation : IProductionFacade
        {
        IPhoneRepository phones;
        IWarehouseRepository warehouses;
        IImportFeeCalculator importCalculator;
        IProductionFactory productionFactory;
        IPhoneSupplier phoneSupplier;
        IAdministratorNotifier administratorNotifier;

        public ProductionFacadeImplementation(IPhoneRepository phones, IWarehouseRepository warehouses, IImportFeeCalculator importCalculator,
            IProductionFactory productionFactory, IPhoneSupplier phoneSupplier, IAdministratorNotifier administratorNotifier)
            {
            this.phones = phones;
            this.warehouses = warehouses;
            this.importCalculator = importCalculator;
            this.productionFactory = productionFactory;
            this.phoneSupplier = phoneSupplier;
            this.administratorNotifier = administratorNotifier;
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

        public int GetPhoneQuantity(int phoneId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for phone in repository");
            IPhone phone = phones.Find(phoneId);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Taking all warehouse and calculating phones quantity");
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
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Notifying administrator about new warehouse");
            administratorNotifier.NotifyAdministrator("New warehouse was opened at " + location + "\nCapacity of new factory is " + capacity);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving warehouse to repository");
            int warehouseId = warehouses.Save(newWarehouse);
            return warehouseId;
            }
        }
    }
