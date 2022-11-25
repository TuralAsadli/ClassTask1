using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Model
{
    internal class Asistans : Manager
    {
        public void GetFeedBack(Emploee emploee)
        {
            if (!emploee.IsSuccessfull)
            {
                var res =  GetPromotion(emploee);
                
                Console.WriteLine(res.Name + " sucsesfull, your salary" + " " + emploee.Salary);
            }
            else
            {
                Console.WriteLine("We haven't money for you");
            }
        }
    }
}
