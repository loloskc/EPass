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
    public class PassRepository
    {
        private readonly ApplicationDbContext _context;
        public PassRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(PassLab pass)
        {
            _context.Add(pass);
            return Save();
        }

        public bool Delete(PassLab pass)
        {
            _context.Remove(pass);
            return Save();
        }

        public async Task<IEnumerable<PassLab>> GetAll()
        {
            return await _context.Pass.ToListAsync();
        }

        public IEnumerable<PassLab> GetPassLabsByAddress(int address)
        {
            return _context.Pass.Where(i=>i.AddressLabId == address).ToList();
        }

        public IEnumerable<PassLab> GetPassLabsByNum(int num)
        {
            return _context.Pass.Where(i=>i.NumLab == num).ToList();
        }
        public IEnumerable<PassLab> GetPassByFIO(int id)
        {
            return _context.Pass.Where(i=>i.ResponsibleId == id).ToList();
        }

        public async Task<PassLab?> GetByIdAsync(int id)
        {
            return await _context.Pass.FirstOrDefaultAsync(i=>i.Id == id);

        }
        public PassLab? GetById(int id)
        {
            return _context.Pass.FirstOrDefault(i=>i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(PassLab pass)
        {
            _context.Pass.Update(pass);
            return Save();
        }
    }
}
