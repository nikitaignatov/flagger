namespace Flagger.Tests.Model
{
    class OrderedThisMonthFlag : Flag
    {
        public override int Points { get; } = 20;
        public override string Description { get; } = "Ordered this month";
        public override FlagCategory Category { get; } = FlagCategory.Info;
    }
}