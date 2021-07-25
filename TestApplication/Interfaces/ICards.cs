using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Interfaces
{
    public interface ICards
    {
        IEnumerable<AllCards> _AllCards { get; }
        AllCards getObjectCards(int carId);
    }
}
