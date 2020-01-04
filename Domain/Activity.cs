using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }    // Guid allows us to create the Id either from the service or client side code
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}
