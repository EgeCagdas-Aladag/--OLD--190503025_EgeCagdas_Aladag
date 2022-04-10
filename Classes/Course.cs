using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Musikschule_Verwaltungsanwendung.Classes
{
    class Course
    {
        public int CourseId { get; set; }
        public int Price { get; set; }
        public List<string> RequiredInstruments { get; set; }
        public List<int> Sessions { get; set; }

    //FUNCTIONS
        //TODO
        public void AddInstrument(string instrument)
        {
            if (!this.RequiredInstruments.Contains(instrument))
            {
                this.RequiredInstruments.Add(instrument);
            }
            else
            {
                //TODO Throw exception?
            }

        }

        public void RemoveInstrument(string instrument)
        {
            if (this.RequiredInstruments.Contains(instrument))
            {
                this.RequiredInstruments.Remove(instrument);
            }
            else
            {
                //TODO Throw exception?
            }
        }

    }
}
