using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Demo.web.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        public string MedicineName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string DoctorName { get; set; }
        public string Description { get; set; }
    }
}
