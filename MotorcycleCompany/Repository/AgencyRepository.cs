using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;

namespace Repository
{
    public class AgencyRepository :RepositoryBase<Agency>, IAgencyRepository
    {
        public AgencyRepository(RepositoryContext context) 
            : base(context)
        {
        }

       public IEnumerable<Agency> GetAllAgencies(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(a => a.Name)
            .ToList();
    }
}
