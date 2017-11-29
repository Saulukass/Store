using Store.Production.ProductionFacadeService;
using System.Collections.Generic;
using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionRepository
    {
    class InMemoryWarehouseRepository : IWarehouseRepository
        {
        Dictionary<int, IWarehouse> storage;
        static int id = 0;

        public InMemoryWarehouseRepository()
            {
            storage = new Dictionary<int, IWarehouse>();
            }

        public void Delete(int warehouseId)
            {
            storage.Remove(warehouseId);
            }

        public int Save(IWarehouse warehouse)
            {
            int newId = ++id;
            storage.Add(newId, warehouse);
            return newId;
            }

        public void Update(int warehouseId, IWarehouse warehouse)
            {
            storage[warehouseId] = warehouse;
            }

        public IWarehouse Find(int warehouseId)
            {
            if (storage.ContainsKey(warehouseId))
                return storage[warehouseId];
            return null;
            }

        public IEnumerator<IWarehouse> GetAll()
            {
            return storage.Values.GetEnumerator();
            }
        }
    }
