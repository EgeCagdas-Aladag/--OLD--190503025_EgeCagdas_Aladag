using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Musikschule_Verwaltungsanwendung.Classes
{
    class Teacher : Person
    {
        public int TeacherId { get; set; }
        public DateTime WorkStart { get; set; }
        public List<int> OfferedCourses { get; set; }
        public List<string> Instruments { get; set; }
        public string InfoText { get; set; }
        public bool IsAdmin { get; set; }

        //Constructors 
        public Teacher(int id, string name, string surname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }

        public Teacher(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    //Functions:
        public void AddInstrument(string instrument)
        {
            if (!Instruments.Contains(instrument))
            {
                Instruments.Add(instrument);
            }
            else
            {
                //TODO: Alert the user that item already exists
                //Return -1 here and call alert function from the previous func?
            }
        }

        public void RemoveInstrument(string instrument)
        {
            if (Instruments.Contains(instrument))
            {
                Instruments.Remove(instrument);
            }
            else
            {
                //TODO: Alert the user that item does not exist
                //Return -1 here and call alert function from the previous func?
            }
        }

        public void AddCourse(int courseId)
        {
            if (!OfferedCourses.Contains(courseId))
            {
                OfferedCourses.Add(courseId);
            }
            else
            {
                //TODO: Alert the user that course already exists
                //Return -1 here and call alert function from the previous func?
            }
        }

        public void RemoveCourse(int courseId)
        {
            if (OfferedCourses.Contains(courseId))
            {
                OfferedCourses.Remove(courseId);
            }
            else
            {
                //TODO: Alert the user that course does not exist
                //Return -1 here and call alert function from the previous func?
            }
        }

        public void MakeAdmin()
        {
            if (!IsAdmin)
            {
                IsAdmin = true;
            }
            else
            {
                ////TODO: Alert the user that user is already an Admin
                //Return -1 here and call alert function from the previous func?
            }
        }

        public void RemoveAdmin()
        {
            if (IsAdmin)
            {
                IsAdmin = false;
            }
            else
            {
                ////TODO: Alert the user that user is already NOT an Admin
                //Return -1 here and call alert function from the previous func?
            }
        }

    }
}
