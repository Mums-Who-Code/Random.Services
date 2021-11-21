// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Random.Services.Tests.Acceptance.Apis.Home
{
    public partial class HomeApiTests
    {
        [Fact]
        public async Task ShouldReturnHomeMessageAsync()
        {
            // given
            string expectedHomeMessage =
                "Hello from Random Services Api.";

            // when
            string actualHomeMessage =
                await this.randomApiBroker.GetHomeMessageAsync();

            // then
            actualHomeMessage.Should().BeEquivalentTo(expectedHomeMessage);
        }
    }
}
