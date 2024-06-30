using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class Adress
    {
        public int AdressId { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string BusinessHoursWeek { get; set; }
        public string BusinessHoursWeekend { get; set; }
    }
}
