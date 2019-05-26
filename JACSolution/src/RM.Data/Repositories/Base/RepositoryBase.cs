using RM.Data.Context;
using RM.Domain.Interfaces.Repositories.Base;
using RM.Shared.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Linq;

namespace RM.Data.Repositories.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected RMContext _context;
        protected DbSet<TEntity> _DbSet;
        public RepositoryBase(RMContext context)
        {
            _context = context;
            _DbSet = _context.Set<TEntity>();
        }
        public TEntity Adicionar(TEntity obj)
        {
            _DbSet.Add(obj);
            return obj;
        }

        public TEntity Atualizar(TEntity obj)
        {
            var entry = _context.Entry(obj);
            _DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            return obj;
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return _DbSet.Where(predicate);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
       
        public TEntity ObterPorId(Guid id)
        {
            return _DbSet.Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _DbSet.ToList();
        }

        public void Remover(Guid id)
        {
            _DbSet.Remove(_DbSet.Find(id));
        }
    }
}
