// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Random.Services.Api.Models.Categories;

namespace Random.Services.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Category> Categories { get; set; }
    }
}
