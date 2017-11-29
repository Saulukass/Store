using Store.Production.ProductionFacadeService;
using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionRepository
    {
    class MockPhoneRepository : IPhoneRepository
        {
        IPhone instance = null;

        public void Delete(int phoneId)
            {
            return;
            }

        public IPhone Find(int phoneId)
            {
            if (null != instance)
                return instance;
            return null;
            }

        public int Save(IPhone phone)
            {
            instance = phone;
            return 1;
            }

        public void Update(int phoneId, IPhone phone)
            {
            return;
            }
        }
    }
