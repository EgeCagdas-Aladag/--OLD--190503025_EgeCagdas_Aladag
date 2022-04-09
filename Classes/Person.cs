using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Musikschule_Verwaltungsanwendung
{
    class Person
    {
        //Get&Set Functions
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected string Surname { get; set; }

    //Constructors
        protected Person()
        {

        }
        public Person(int id, string name, string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;

        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

    //Functions:
    }
}
