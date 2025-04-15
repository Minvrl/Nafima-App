using Nafima.Core.Entities;
using Nafima.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Data.Repositories.Implementatitons
{
    public class DonationRepository : Repository<Donation>, IDonationRepository
    {
        public DonationRepository(AppDbContext context) : base(context)
        {
        }
    }
}
