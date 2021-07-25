using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Interfaces
{
    public interface ICards
    {
        IEnumerable<Cards> AllCards { get; }
        Cards getObjectCards(int carId);
    }
}
