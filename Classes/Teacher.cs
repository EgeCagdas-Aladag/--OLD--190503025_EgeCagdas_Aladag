using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Musikschule_Verwaltungsanwendung.Classes
{
    class Teacher : Person
    {
        private int teacherId;
        private List<int> offeredCourses = new List<int>();
        private DateTime workStart;

    //Constructors 
        

        public Teacher(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }

    }
}
