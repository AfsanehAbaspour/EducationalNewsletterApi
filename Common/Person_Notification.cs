using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Person_Notification
    {
        public int ID { get; set; }
        public int PersonID { get; set; }
        public Int64 NotificationID { get; set; }
        public DateTime SendingTime { get; set; }
        public DateTime RecievingTime { get; set; }
        public DateTime ViewTime { get; set; }

    }
}
