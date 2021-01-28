using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.Data.Models
{
    public class RepairOrder
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
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
        
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(500)]
        public string Description { get; set; }
        
    }
}
