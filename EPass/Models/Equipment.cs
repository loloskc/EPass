using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPass.Models
{
    public class Equipment
    {
        
        public int Id { get; set; }
        [ForeignKey("PassLab")]
        public int passLabId { get; set; }
        public PassLab passLab { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int InventoryNum { get; set; }
    }
}
