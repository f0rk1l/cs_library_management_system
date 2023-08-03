using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    [Serializable]
    class Reader
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public int Fine { get; set; }

        public Reader(string Name, string Surname, int age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = age;
            this.Fine = 0;
        }

    }
}
