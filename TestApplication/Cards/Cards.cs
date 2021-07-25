using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Interfaces;

namespace TestApplication
{
    public class Cards : ICards
    {
        public IEnumerable<Cards> AllCards { get ;}

        public Cards getObjectCards(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
