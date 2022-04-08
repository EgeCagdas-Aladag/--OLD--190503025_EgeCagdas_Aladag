using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Musikschule_Verwaltungsanwendung
{
    class Person
    {
        protected int id;
        protected string name;
        protected string surname;

    //Constructors
        protected Person()
        {

        }
        public Person(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;

        }

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

    //Functions:
        //Get&Set Functions
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //Others

    }
}
