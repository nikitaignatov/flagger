using System;

namespace Flagger
{
    public interface IFlag : IComparable<IFlag>
    {
        string Description { get; }
        int Points { get; }
        FlagCategory Category { get; }
    }
}