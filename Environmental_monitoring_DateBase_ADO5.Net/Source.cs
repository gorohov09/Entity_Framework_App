using System;
using System.Collections.Generic;

namespace Environmental_monitoring_DateBase_ADO5.Net
{
    public class Source
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Emission> Emissions { get; set; }
    }
}
