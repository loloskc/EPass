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
    public class FurnRepository
    {
        private readonly ApplicationDbContext _context;
        public FurnRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Furniture furn)
        {
            _context.Add(furn);
            return Save();
        }

        public bool Delete(Furniture furn)
        {
            _context.Remove(furn);
            return Save();
        }

        public async Task<IEnumerable<Furniture>> GetAll()
        {
            return await _context.Furnitures.ToListAsync();
        }

        public Furniture[] GetAllById(int id)
        {
           
            return _context.Furnitures.Where(i => i.passLabId == id).ToArray();

        }

        public async Task<Furniture?> GetByIdAsync(int id)
        {
            return await _context.Furnitures.FirstOrDefaultAsync(i => i.Id == id);

        }
        public Furniture? GetById(int id)
        {
            return _context.Furnitures.FirstOrDefault(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Furniture furn)
        {
            _context.Furnitures.Update(furn);
            return Save();
        }
    }
}
