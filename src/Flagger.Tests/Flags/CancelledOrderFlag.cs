namespace Flagger.Tests.Model
{
    class CancelledOrderFlag : Flag
    {
        public override int Points { get; } = 1;
        public override string Description { get; } = "Cancelled order";
        public override FlagCategory Category { get; } = FlagCategory.Warning;
    }
}