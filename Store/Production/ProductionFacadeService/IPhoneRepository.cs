﻿using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionFacadeService
    {
    interface IPhoneRepository
        {
        IPhone Find(int phoneId);
        int Save(IPhone phone);
        void Update(int phoneId, IPhone phone);
        void Delete(int phoneId);
        }
    }
