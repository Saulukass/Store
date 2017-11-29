using Store.Production.ProductionFacadeService;
using System.Collections.Generic;
using Store.Production.ProductionDomainEntities;
using System;

namespace Store.Production.ProductionRepository
    {
    public class InMemoryWarehouseRepository : IWarehouseRepository
        {
        Dictionary<int, IWarehouse> storage;
        static int id = 0;

        public InMemoryWarehouseRepository()
            {
            storage = new Dictionary<int, IWarehouse>();
            }

        public void Delete(int warehouseId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Deleting warehouse");
            storage.Remove(warehouseId);
            }

        public int Save(IWarehouse warehouse)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving warehouse");
            int newId = ++id;
            storage.Add(newId, warehouse);
            return newId;
            }

        public void Update(int warehouseId, IWarehouse warehouse)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Updating warehouse");
            storage[warehouseId] = warehouse;
            }

        public IWarehouse Find(int warehouseId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for warehouse");
            if (storage.ContainsKey(warehouseId))
                return storage[warehouseId];
            return null;
            }

        public IEnumerator<IWarehouse> GetAll()
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Getting all warehouses");
            return storage.Values.GetEnumerator();
            }
        }
    }
