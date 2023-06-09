﻿using Levva.Newbies.Coins.Data.Interfaces;
using Levva.Newbies.Coins.Domain.Models;

namespace Levva.Newbies.Coins.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly Context _context;
        public CategoriaRepository(Context context)
        {
            _context = context;
        }

        public void Create(Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var categoria = _context.Categoria.Find(Id);
            _context.SaveChanges();
        }

        public Categoria Get(int Id)
        {
            return _context.Categoria.Find(Id);
        }

        public List<Categoria> GetAll()
        {
            return _context.Categoria.ToList();
        }

        public void Update(Categoria categoria)
        {
            _context.Categoria.Update(categoria);
            _context.SaveChanges();
        }
    }
}
