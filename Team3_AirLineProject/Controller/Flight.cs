//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Controller
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        public Flight()
        {
            this.Departures = new HashSet<Departure>();
        }
    
        public string idFlight { get; set; }
        public string startCity { get; set; }
        public string endCity { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan endTime { get; set; }
        public double price { get; set; }
        public int totalSeatNo { get; set; }
        public string status { get; set; }
    
        public virtual ICollection<Departure> Departures { get; set; }
    }
}