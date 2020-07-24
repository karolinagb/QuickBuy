using QuickBuy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contracts
{
    //Contrato específico para a classe usuário
    public interface IUserRepository :  IBaseRepository<User>
    {

    }
}
