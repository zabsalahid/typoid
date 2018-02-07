using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using typoid.Utility;

namespace typoid.Models
{
    public class Command
    {
        [DbColumn(IsIdentity = true, IsPrimary = true)]
        public long id { get; set; }
        [DbColumn]
        public string name { get; set; }
        [DbColumn]
        public string message { get; set; }
        [DbColumn]
        public long interval { get; set; }
        [DbColumn]
        public long random_skip { get; set; }
        [DbColumn]
        public long random_double { get; set; }
        [DbColumn]
        public long threshold { get; set; }
        [DbColumn]
        public long break_minutes { get; set; }
        public bool isStarted { get; set; }
        public Thread process { get; set; }
        public bool onBreak { get; set; }
        public DateTime lastBreak { get; set; }
        public bool isEnabled { get; set; }
    }
}
