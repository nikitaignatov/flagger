using System.Collections.Generic;
using System.Linq;

namespace Flagger.Tests.Model
{
    class User : IHaveFlags
    {
        public User()
        {
            Orders = new List<Order>();
            Flags = new List<IFlag>();
        }

        public ICollection<Order> Orders { get; }
        public ICollection<IFlag> Flags { get; }
        public ICollection<IFlag> FlagsAll => Flags.Concat(Orders.SelectMany(x => x.Flags)).ToList();
    }
}
