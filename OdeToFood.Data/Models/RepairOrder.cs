using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class RepairOrder
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name="Repair status")]
        public Status StatusRepair { get; set; }
    }
}
