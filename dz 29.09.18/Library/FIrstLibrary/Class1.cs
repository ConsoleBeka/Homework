using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrstLibrary
{
    public class Class1
    {
        public string StaticMethod(FIrstLibrary.Person person) {
            return $"{person.Name} + {person.LastName}"; ;
        }
    }
}
