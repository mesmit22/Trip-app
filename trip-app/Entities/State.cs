using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace trip_app.Entities
{
    [Table("State")]
    public class State
    {
        public int StateId { get; set; }

        public string StateTitle { get; set; }
    }
}