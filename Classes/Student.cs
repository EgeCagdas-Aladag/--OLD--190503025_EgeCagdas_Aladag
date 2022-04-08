using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Musikschule_Verwaltungsanwendung.Classes
{
    class Student : Person
    {
        private int studentId;
        private List<int> registeredCourses = new List<int>();
        private int totalFees;

    //FUNCTIONS
        //Get&Set Functions
        public int StudentId { get; set; }
        public List<int> RegisteredCourses { get; set; }
        public int TotalFees { get; set; }

        //Other Functions
        public void addFee(int amount)
        {
            if (amount > 0)
            {
                TotalFees += amount;
            }
            else
            {
                //TODO: Alert user OR return -1 to tell previous function to alert
            }
        }

        public void subtractFee(int amount)
        {
            if (amount > 0)
            {
                TotalFees -= amount;
            }
            else
            {
                //TODO: Alert user OR return -1 to tell previous function to alert
            }
        }

        public void addCourse(int courseId)
        {
            if (!RegisteredCourses.Contains(courseId))
            {
                RegisteredCourses.Add(courseId);
            }
            else
            {
                //TODO: Alert user OR return -1 to tell previous function to alert
            }

        }

        public void removeCourse(int courseId)
        {
            if (RegisteredCourses.Contains(courseId))
            {
                RegisteredCourses.Remove(courseId);
            }
            else
            {
                //TODO: Alert user OR return -1 to tell previous function to alert
            }
        }

    }
}
