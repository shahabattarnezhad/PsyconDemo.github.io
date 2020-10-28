using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.web.Models
{
    public class TestReports
    {
        public int Id { get; set; }
        public string ReportDate { get; set; }
        public string DocotrName { get; set; }
        public string ReportText { get; set; }
        public string TestDate { get; set; }
        public string Description { get; set; }
    }
}
