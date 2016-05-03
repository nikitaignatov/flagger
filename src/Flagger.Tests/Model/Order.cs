using System.Collections.Generic;

namespace Flagger.Tests.Model
{
    class Order : IHaveFlags
    {
        public Order()
        {
            Flags = new List<IFlag>();
        }

        public ICollection<IFlag> Flags { get; }
        public ICollection<IFlag> FlagsAll => Flags;
    }
}