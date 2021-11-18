// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Random.Services.Tests.Acceptance.Brokers;
using Xunit;

namespace Random.Services.Tests.Acceptance.Apis.Home
{
    [Collection(nameof(ApiTestCollection))]
    public partial class HomeApiTests
    {
        private readonly RandomApiBroker randomApiBroker;

        public HomeApiTests(RandomApiBroker randomApiBroker) =>
            this.randomApiBroker = randomApiBroker;
    }
}
