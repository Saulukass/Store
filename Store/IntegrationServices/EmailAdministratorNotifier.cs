using Store.Production.ProductionDomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.IntegrationServices
    {
    class EmailAdministratorNotifier : IAdministratorNotifier
        {
        public void NotifyAdministrator(string changes)
            {
            Console.WriteLine(this.GetType().ToString() + " notifying administrator about changes: " + changes);
            }
        }
    }
