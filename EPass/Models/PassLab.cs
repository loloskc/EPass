using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EPass.Data.Enum;

namespace EPass.Models
{
    public class PassLab
    {
        [Key]
        public int Id { get; set; }
        public int NumLab { get; set; }
        public string NameLab { get; set; }
        public Address AddressLab { get; set; }
        public int AddressLabId {  get; set; }
        public int CodEquipment { get; set; }
        public ICollection<Equipment?> Equipment { get; set; }
        public int ResponsibleId { get; set; }
        public int FurnitureId { get; set; } 
        public ICollection<Furniture?> Furniture { get; set; }
    }
}
