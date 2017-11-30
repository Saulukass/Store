using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Production.ProductionDomainServices
    {
    public interface IPhonesSuppliedListener
        {
        void OnPhonesSupplied(string changes);
        }
    }
