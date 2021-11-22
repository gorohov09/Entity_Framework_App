using System;


namespace Environmental_monitoring_DateBase_ADO5.Net
{
    public class Emission
    {
        public int Id { get; set; }

        public int SourceId { get; set; }

        public float Count { get; set; }

        public string Text { get; set; }

        public DateTime Date { get; set; }

        public virtual Source Source { get; set; }
    }
}
