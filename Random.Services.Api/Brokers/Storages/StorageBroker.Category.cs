// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Random.Services.Api.Models.Categories;

namespace Random.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Category> Categories { get; set; }

        public async ValueTask<Category> InsertCategoryAsync(Category category)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Category> entityEntry =
                await broker.Categories.AddAsync(category);

            await broker.SaveChangesAsync();

            return entityEntry.Entity;
        }
    }
}
