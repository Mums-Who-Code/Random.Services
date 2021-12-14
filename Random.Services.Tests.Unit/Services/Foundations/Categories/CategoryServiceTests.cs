// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using Moq;
using Random.Services.Api.Brokers.Storages;
using Random.Services.Api.Models.Categories;
using Random.Services.Api.Services.Foundations.Categories;
using Tynamix.ObjectFiller;

namespace Random.Services.Tests.Unit.Services.Foundations.Categories
{
    public partial class CategoryServiceTests
    {
        private readonly ICategoryService categoryService;
        private readonly Mock<IStorageBroker> storageBrokerMock;

        public CategoryServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.categoryService = new CategoryService(
                storageBroker: this.storageBrokerMock.Object);
        }

        private static DateTimeOffset GetRandomDateTime() =>
            new DateTimeRange(earliestDate: new DateTime()).GetValue();

        private static Category CreateRandomCategory() =>
            CreateCategoryFiller().Create();

        private static Filler<Category> CreateCategoryFiller()
        {
            var filler = new Filler<Category>();

            filler.Setup()
                .OnType<DateTimeOffset>().Use(GetRandomDateTime());

            return filler;
        }
    }
}
