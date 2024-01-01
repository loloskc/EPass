using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPass.Models
{
    public class Responsible
    {
        
        public int Id { get; set; }
        public string FIO { get; set; }
        [ForeignKey("PassLab")]
        public int passLabId { get; set; }
        public List<PassLab> passLab { get; set; }

    }
}
