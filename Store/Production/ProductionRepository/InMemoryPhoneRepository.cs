using Store.Production.ProductionDomainEntities;
using Store.Production.ProductionFacadeService;
using System.Collections.Generic;

namespace Store.Production.ProductionRepository
    {
    class InMemoryPhoneRepository : IPhoneRepository
        {
        Dictionary<int, IPhone> storage;
        static int id = 0;

        public void Delete(int phoneId)
            {
            storage.Remove(phoneId);
            }

        public int Save(IPhone phone)
            {
            int newId = ++id;
            storage[newId] = phone;
            return newId;
            }

        public void Update(int phoneId, IPhone phone)
            {
            if (storage.ContainsKey(phoneId))
                storage[phoneId] = phone;
            }

        public IPhone Find(int phoneId)
            {
            if (storage.ContainsKey(phoneId))
                return storage[phoneId];
            return null;
            }
        }
    }
