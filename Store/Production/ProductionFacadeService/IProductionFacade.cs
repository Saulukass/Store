﻿namespace Store.Production.ProductionFacadeService
    {
    interface IProductionFacade
        {
        int OpenWarehouse(string location, int capacity);
        int GetPhoneQuantity(int phoneId);
        int AddPhone(string phoneName, int warehouseId);
        int GetTransportationPrice(int warehouseId, string destination);
        }
    }