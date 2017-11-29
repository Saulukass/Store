﻿using Store.Production.ProductionDomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.IntegrationServices
    {
    public class PhoneAdministratorNotifier : IAdministratorNotifier
        {
        public void NotifyAdministrator(string changes)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + "  Notifying administrator about: " + changes);
            }
        }
    }
