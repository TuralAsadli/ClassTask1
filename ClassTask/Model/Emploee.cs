using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Model
{
    public class Emploee
    {
        string _name;
        bool _is_successfull;
        int _salary;

        public string Name { get => _name;
            set
            {
                value = value.Trim();
                if (value.Length < 25 && value.Length > 1)
                {
                    _name = value;
                }
            }
        }
        public bool IsSuccessfull { get => _is_successfull; set => _is_successfull = value; }

        public int Salary { get => _salary; 
            set
            {
                if (value > 0)
                {
                    _salary = value;
                }
            }
        }

        public Emploee(string name, bool isSuccessfull, int salary)
        {
            Name = name;
            IsSuccessfull = isSuccessfull;
            Salary = salary;
        }
    }
}
