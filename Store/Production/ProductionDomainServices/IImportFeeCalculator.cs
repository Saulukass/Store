using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionDomainServices
    {
    public interface IImportFeeCalculator
        {
        int CalculateImportFee(IWarehouse warehouse, string destination);
        }
    }
