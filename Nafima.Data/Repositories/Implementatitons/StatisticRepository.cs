using Nafima.Core.Entities;
using Nafima.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nafima.Data.Repositories.Implementatitons
{
    public class StatisticRepository : Repository<Statistic>, IStatisticRepository
    {
        public StatisticRepository(AppDbContext context) : base(context)
        {
        }
    }
}
