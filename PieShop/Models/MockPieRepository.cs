using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> Pies { get; }
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}