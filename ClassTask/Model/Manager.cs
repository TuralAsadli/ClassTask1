using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Model
{
    internal class Manager
    {
        protected Emploee GetPromotion(Emploee emploee)
        {
            
            emploee.Salary += 100;
            emploee.IsSuccessfull = true;
            return emploee;
        }
    }
}
