namespace Flagger
{
    public abstract class Flag : IFlag
    {
        public virtual string Description { get; }
        public virtual int Points { get; }
        public virtual FlagCategory Category { get; }
        public virtual int CompareTo(IFlag other) => (Points * (int)Category).CompareTo(other.Points * (int)other.Category);
    }
}
