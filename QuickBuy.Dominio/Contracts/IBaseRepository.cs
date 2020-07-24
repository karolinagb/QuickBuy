using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contracts
{
    /*Definindo uma interface de nome IBaseRepository que trabalhará com o tipo genérico personalizado
     TEntity. Essa interface herda da interface IDisposable.
    where TEntity : class  == defini que TEntity é um class*/
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        //Na interface definiremos todos os métodos que servirão como base de contrato

        void Add(TEntity entity);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
