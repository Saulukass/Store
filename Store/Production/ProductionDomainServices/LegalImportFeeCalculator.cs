using Store.Production.ProductionDomainEntities;
using System;

namespace Store.Production.ProductionDomainServices
    {
    public class LegalImportFeeCalculator : IImportFeeCalculator
        {
        public int CalculateImportFee(IWarehouse warehouse, string destination)
            {
            int baseImportFee = 250;
            if (!destination.Equals(warehouse.Location))
                baseImportFee += new Random().Next(100, 301);

            if (warehouse.HasBoardersRestrictions())
                baseImportFee = (int)(baseImportFee * 1.2);

            return baseImportFee;
            }
        }
    }
