using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Musikschule_Verwaltungsanwendung.Classes
{
    class Student : Person
    {
        public int StudentId { get; set; }
        public List<int> RegisteredCourses { get; set; }
        public int TotalFees { get; set; }

    //CONSTRUCTORS

    //FUNCTIONS
        public void AddFee(int amount)
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

        public void SubtractFee(int amount)
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

        public void AddCourse(int courseId)
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

        public void RemoveCourse(int courseId)
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
