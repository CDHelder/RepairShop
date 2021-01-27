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

        [Required]
        [Display(Name="Begin date")]
        [DataType(DataType.Date)]
        public DateTime BeginDate { get; set; }
        
        [Required]
        [Display(Name = "End date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}
