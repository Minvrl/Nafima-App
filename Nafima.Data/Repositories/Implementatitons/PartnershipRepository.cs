using Nafima.Core.Entities;
using Nafima.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Data.Repositories.Implementatitons
{
    public class PartnershipRepository : Repository<Partnership>, IPartnershipRepository
    {
        public PartnershipRepository(AppDbContext context) : base(context)
        {
        }
    }
}
