using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.web.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string NotificationDate { get; set; }
        public string NotoficationBody { get; set; }
        public string NotificationHead { get; set; }
        public string SenderName { get; set; }
    }
}
