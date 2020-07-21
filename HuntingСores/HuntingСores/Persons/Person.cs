using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingСores
{
    public class Person
    {
        public string Name;

        public List<LocationVisit> Location;

        public Specialization Specialization;

        public List<Characteristic> Characteristics = new List<Characteristic>();
    }
}
