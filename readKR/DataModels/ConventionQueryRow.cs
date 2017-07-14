using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readKR.DataModels
{
    class ConventionQueryRow
    {
        public Guid GUID { get; set; }
        public DateTime ProductionDateLimit { get; set; }
        public DateTime ProductionDateLower { get; set; }
        public string ShipCategory { get; set; }
        public int GTLimit { get; set; }
        public int GTLower { get; set; }
        public int ShipLenghtLimit { get; set; }
        public int ShipLenghtLower { get; set; }
        public DateTime ApplicableTime { get; set; }
        public int Category { get; set; }
        public DateTime LastEditDate { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
