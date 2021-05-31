using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS442_TermOutline_JTabares
{
    public class Incident
    {
            public string IncidentID { get; set; }

            public string CustomerID { get; set; }

            public string ProductCode { get; set; }

            public string TechID { get; set; }

            public DateTime DateOpened { get; set; }

            public DateTime DateClosed { get; set; }

            public string Title { get; set; }

            public string Description { get; set; }

        }
}