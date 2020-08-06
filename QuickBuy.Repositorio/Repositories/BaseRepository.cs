using QuickBuy.Dominio.Contracts;
using QuickBuy.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Repositorio.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        //Referência ao DbContext a fim de que os repositórios possam ter acesso ao banco
        protected readonly QuickBuyContext QuickBuyContext;

        public BaseRepository(QuickBuyContext quickBuyContext)
        {
            QuickBuyContext = quickBuyContext;
        }

        public void Add(TEntity entity)
        {
            QuickBuyContext.Set<TEntity>().Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return QuickBuyContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            QuickBuyContext.Dispose();
        }
    }
}
