using Store.Production.ProductionDomainEntities;
using System.Collections.Generic;

namespace Store.Production.ProductionFacadeService
    {
    interface IWarehouseRepository
        {
        IWarehouse Find(int warehouseId);
        IEnumerator<IWarehouse> GetAll();
        int Save(IWarehouse warehouse);
        void Update(int warehouseId, IWarehouse warehouse);
        void Delete(int warehouseId);
        }
    }
