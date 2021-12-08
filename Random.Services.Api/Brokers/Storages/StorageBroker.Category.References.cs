// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Random.Services.Api.Models.Categories;

namespace Random.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        private static void SetCategoryReferences(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasOne(category => category.CreatedByUser)
                .WithMany(user => user.CreatedCategories)
                .HasForeignKey(category => category.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>()
                .HasOne(Category => Category.UpdatedByUser)
                .WithMany(user => user.UpdatedCategories)
                .HasForeignKey(category => category.UpdatedBy)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
