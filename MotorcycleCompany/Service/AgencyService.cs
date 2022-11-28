using Contracts;
using Entities.Models;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class AgencyService : IAgencyService
    {

        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _loggerManager;

        public AgencyService(IRepositoryManager repository, 
            ILoggerManager loggerManager)
        {
            this._repository = repository;
            this._loggerManager = loggerManager;
        }

        public IEnumerable<Agency> GetAllAgencies(bool trackChanges)
        {
            try
            {
                var agencies = _repository.Agency.GetAllAgencies(trackChanges);
                return agencies;
                
            }
            catch (Exception ex)
            {
                _loggerManager.LogError($"Something went wrong in the {nameof(GetAllAgencies)} service method {ex}");
                throw;
            }
        }

        IEnumerable<IAgencyService> IAgencyService.GetAllAgencies(bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
