using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionDomainServices
    {
    interface IImportFeeCalculator
        {
        int CalculateImportFee(IWarehouse warehouse, string destination);
        }
    }
