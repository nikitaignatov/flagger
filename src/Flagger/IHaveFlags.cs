using System.Collections.Generic;

namespace Flagger
{
    public interface IHaveFlags
    {
        ICollection<IFlag> Flags { get; }
        ICollection<IFlag> FlagsAll { get; }
    }
}