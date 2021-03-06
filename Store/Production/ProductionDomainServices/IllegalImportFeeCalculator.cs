﻿using Store.Production.ProductionDomainEntities;
using System;

namespace Store.Production.ProductionDomainServices
    {
    public class IllegalImportFeeCalculator : IImportFeeCalculator
        {
        public int CalculateImportFee(IWarehouse warehouse, string destination)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Calculating fee for importing phones illegaly");
            int standardSmugglingPrice = 100;

            // unlucky there you were fined
            if (new Random().NextDouble() > 0.6)
                standardSmugglingPrice += 1000;

            return standardSmugglingPrice;
            }
        }
    }
