using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB.Dto
{

    public class EventModel
    {
        [Required] public string Location { get; set; }
        [Required] public string Description { get; set; }
        [Required] public string Name { get; set; }
        [Required] public DateTime StartDate { get; set; }
        [Required] public DateTime EndDate { get; set; }
        public string Pin { get; set; }
    }

    public class EventPinModel
    {
        public string pin { get; set; }
    }

    public class EditEventModel
    {

        public string Location { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
