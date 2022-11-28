﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IAgencyRepository Agency { get; }
        IClientRepository Client { get; }
        ICityRepository City { get; }

        void Save();
    }
}
