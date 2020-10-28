using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.web.Models
{
    public class FollowUps
    {
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public string FirstVisitDate { get; set; }
        public string PrevVisitDate { get; set; }
        public string NextVisitDate { get; set; }
        public string EndDateOfMedicine { get; set; }
        public string StartDateOfMedicine { get; set; }
        public string MedicineName { get; set; }
        public string FirstTestDate { get; set; }
        public string PrevTestDate { get; set; }
        public string NextTestDate { get; set; }
        public string Description { get; set; }
    }
}
