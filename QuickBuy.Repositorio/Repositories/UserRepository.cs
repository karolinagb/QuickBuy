﻿using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositories
{
    class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {

        }
    }
}
