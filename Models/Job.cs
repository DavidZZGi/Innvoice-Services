using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Innvoice_Services.Models
{
    public class Job
    {
        public int jobid { get; set; }
        public int facility { get; set; }
        public int JobMainClient { get; set; }
        public int merchantvesel { get; set; }
        public String stevedore { get; set; }
        public String size { get; set; }
        public String dateininventory { get; set; }
        public String datefreetimeexpires { get; set; }
        public Boolean completion { get; set; }
        








    }
}