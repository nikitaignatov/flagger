using Flagger.Tests.Model;
using FluentAssertions;
using NUnit.Framework;

namespace Flagger.Tests
{
    [TestFixture]
    public class HasFlagsTests
    {
        private User user;

        [SetUp]
        public void Setup()
        {
            user = new User
            {
                Flags = { new OrderedThisMonthFlag() },
                Orders =
                {
                    new Order
                    {
                        Flags = { new CancelledOrderFlag() }
                    }
                }
            };
        }

        [Test]
        public void should_load_flags_from_the_root_object()
        {
            user.HasFlag<OrderedThisMonthFlag>().Should().BeTrue();
        }

        [Test]
        public void should_load_flags_from_nested_objects()
        {
            user.HasFlag<CancelledOrderFlag>().Should().BeTrue();
        }
    }
}
