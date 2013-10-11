using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guidance.Models
{
    public class PublicEvent
    {
        public virtual int Id { get; set; }
        public virtual string  EventName { get; set; }
        public virtual string Sponsor { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
    }
}