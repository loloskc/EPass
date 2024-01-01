using EPass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPass.Data
{
    public class Seed
    {
        public static void SeedData()
        {
            using(ApplicationDbContext db = new ApplicationDbContext()) 
            {
                var pass = new PassLab()
                {
                    
                    NumLab = 203,
                    NameLab = "Компьютерная лаборатория",
                    AddressLab = Enum.Address.Lenina,
                    CodEquipment = 1,
                    ResponsibleId = 1,
                    FurnitureId = 1,
                };
                var pass1 = new PassLab()
                {
                    NumLab = 202,
                    NameLab = "Компьютерная лаборатория",
                    AddressLab = Enum.Address.Lenina,
                    CodEquipment = 1,
                    ResponsibleId = 1,
                    FurnitureId = 1,
                };
                var pass2 = new PassLab()
                {
                    NumLab = 204,
                    NameLab = "Лаборатория баз данных",
                    AddressLab = Enum.Address.Lenina,
                    CodEquipment = 1,
                    ResponsibleId = 1,
                    FurnitureId = 1,
                };

                var furn = new Furniture()
                {
                    Id = 1,
                    Name = "Стол",
                    Quantity = 20
                };
                var Eq = new Equipment()
                {
                    Id = 1,
                    Name = "Роутер",
                    Model = "Tp-Link",
                    InventoryNum = 112
                };
                var res = new Responsible()
                {
                    Id = 1,
                    FIO = "Кучеров Олег Анатольевич"
                };

                //db.Responsibles.Add(res);
                //db.Equipments.Add(Eq);
                //db.Furnitures.Add(furn);
                
                db.Pass.AddRange(pass1, pass2, pass);
                db.SaveChanges();
            }


        }

        public static void DeleteAll()
        {
            using(ApplicationDbContext db = new ApplicationDbContext()) 
            {
                var pass = db.Pass.ToList();
                var eq = db.Equipments.ToList();
                var fur = db.Furnitures.ToList();
                var res = db.Responsibles.ToList();

                foreach(var item in pass)
                {
                    db.Pass.Remove(item);
                }
                foreach(var item in eq)
                {
                    db.Equipments.Remove(item);
                }
                foreach( var item in fur)
                {
                    db.Furnitures.Remove(item);
                }
                foreach (var item in res)
                {
                    db.Responsibles.Remove(item);
                }
                db.SaveChanges();
            }

        }

    }
}
