using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class ClientService : IClientService
    {

        private readonly IRepositoryManager repository;
        private readonly ILoggerManager loggerManager;

        public ClientService(IRepositoryManager repository, ILoggerManager loggerManager)
        {
            this.repository = repository;
            this.loggerManager = loggerManager;
        }
    }
}
