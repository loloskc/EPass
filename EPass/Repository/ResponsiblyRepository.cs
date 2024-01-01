using EPass.Data;
using EPass.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPass.Repository
{
    public class ResponsiblyRepository
    {
        private readonly ApplicationDbContext _context;
        public ResponsiblyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Responsible res)
        {
            _context.Add(res);
            return Save();
        }

        public bool Delete(Responsible res)
        {
            _context.Remove(res);
            return Save();
        }

        public async Task<IEnumerable<Responsible>> GetAllAsync()
        {
            return await _context.Responsibles.ToListAsync();
        }

        public List<Responsible> GetAll()
        {
            return _context.Responsibles.ToList();
        }

        public async Task<Responsible?> GetByIdAsync(int id)
        {
            return await _context.Responsibles.FirstOrDefaultAsync(i => i.Id == id);

        }

        public Responsible GetById(int id)
        {
            return _context.Responsibles.FirstOrDefault(i => i.Id == id);
        }

        public int GetIdByFio(string fio)
        {
            Responsible? res = _context.Responsibles.FirstOrDefault(i => i.FIO == fio);
            if(res == null)
            {
                return 0;
            }
            return res.Id;
        }

        public string GetFioResponsiblyById(int id)
        {
            Responsible? res = _context.Responsibles.FirstOrDefault(i => i.Id == id);
            return res.FIO;
        }
        public List<string> GetAllFio()
        {
            var list =GetAll();
            List<string> result = new List<string>();
            foreach(var item in list)
            {
                result.Add(item.FIO);
            }
            return result;
            
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Responsible res)
        {
            _context.Update(res);
            return Save();
        }
    }
}
