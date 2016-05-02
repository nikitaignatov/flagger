namespace Flagger
{
    public abstract class Flag : IFlag
    {
        public virtual int CompareTo(IFlag other) => (Points * (int)Category).CompareTo(other.Points * (int)other.Category);

        public string Description { get; set; }

        public int Points { get; set; }

        public FlagCategory Category { get; set; }
    }
}
