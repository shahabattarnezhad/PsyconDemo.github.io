using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.web.Models
{
    public class appointment
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public string DoctorName { get; set; }
    }
}
