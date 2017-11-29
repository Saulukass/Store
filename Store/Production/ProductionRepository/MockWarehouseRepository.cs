using Store.Production.ProductionFacadeService;
using Store.Production.ProductionDomainEntities;
using System.Collections.Generic;

namespace Store.Production.ProductionRepository
    {
    class MockWarehouseRepository : IWarehouseRepository
        {
        IWarehouse instance = null;

        public void Delete(int warehouseId)
            {
            return;
            }

        public IWarehouse Find(int warehouseId)
            {
            if (null != instance)
                return instance;
            return null;
            }

        public IEnumerator<IWarehouse> GetAll()
            {
            return new List<IWarehouse> { instance }.GetEnumerator();
            }

        public int Save(IWarehouse warehouse)
            {
            instance = warehouse;
            return 1;
            }

        public void Update(int warehouseId, IWarehouse warehouse)
            {
            return;
            }
        }
    }
