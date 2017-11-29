using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionDomainServices
    {
    public interface IPhoneSupplier
        {
        void SupplyPhonesToWarehouse(IPhone phone, IWarehouse warehouse);
        }
    }
