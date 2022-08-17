using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInventryManagement
{
    public class Rice
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfPulse> typesOfPulse;
        public List<TypesOfWheat> typesOfWheat;
    }
    public class TypesOfRice
    {
        public string name;
        public string weight;
        public string price;
    }
    public class TypesOfPulse
    {
        public string name;
        public string weight;
        public string price;
    }
    public class TypesOfWheat
    {
        public string name;
        public string weight;
        public string price;
    }

}