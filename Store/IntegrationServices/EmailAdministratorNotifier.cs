using Store.Production.ProductionDomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.IntegrationServices
    {
    public class EmailAdministratorNotifier : IPhonesSuppliedListener
        {
        public void OnPhonesSupplied(string changes)
            {
            Console.WriteLine("["+this.GetType().ToString()+"]" + " notifying administrator via email about changes: " + changes);
            }
        }
    }
