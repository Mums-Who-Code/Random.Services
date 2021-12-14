// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Threading.Tasks;
using Random.Services.Api.Brokers.Storages;
using Random.Services.Api.Models.Categories;

namespace Random.Services.Api.Services.Foundations.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly IStorageBroker storageBroker;

        public CategoryService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public async ValueTask<Category> AddCategoryAsync(Category category) =>
            await this.storageBroker.InsertCategoryAsync(category);
    }
}
