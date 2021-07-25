using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Interfaces;

namespace TestApplication
{
    public class AllCards : ICards
    {
        public IEnumerable<AllCards> _AllCards { get ;}

        public AllCards getObjectCards(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
