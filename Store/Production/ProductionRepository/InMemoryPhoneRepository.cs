using Store.Production.ProductionDomainEntities;
using Store.Production.ProductionFacadeService;
using System;
using System.Collections.Generic;

namespace Store.Production.ProductionRepository
    {
    public class InMemoryPhoneRepository : IPhoneRepository
        {
        Dictionary<int, IPhone> storage;
        static int id = 0;

        public InMemoryPhoneRepository()
            {
            storage = new Dictionary<int, IPhone>();
            }

        public void Delete(int phoneId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Deleting phone");
            storage.Remove(phoneId);
            }

        public int Save(IPhone phone)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving phone");
            int newId = ++id;
            storage[newId] = phone;
            return newId;
            }

        public void Update(int phoneId, IPhone phone)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Updating phone");
            if (storage.ContainsKey(phoneId))
                storage[phoneId] = phone;
            }

        public IPhone Find(int phoneId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for phone");
            if (storage.ContainsKey(phoneId))
                return storage[phoneId];
            return null;
            }
        }
    }
