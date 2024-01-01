using EPass.Data;
using EPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPass.Repository
{
    public class EqRepository
    {
        private readonly ApplicationDbContext context;

        public EqRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Add(Equipment equipment)
        {
            context.Add(equipment);
            return Save();
        }
        public bool Delete(Equipment equipment) 
        {
            context.Remove(equipment);
            return Save();
        }

        public List<Equipment> GetAll()
        {
            return context.Equipments.ToList();
        }

        public Equipment[] GetAllEquipmentById(int id)
        {
            return context.Equipments.Where(i=>i.passLabId==id).ToArray();
        }

        public Equipment? GetById(int id)
        {
            return context.Equipments.FirstOrDefault(i=>i.Id==id);

        }
        public bool Save()
        {
            var saved = context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Equipment equipment)
        {
            context.Update(equipment);
            return Save();
        }
    }
}
