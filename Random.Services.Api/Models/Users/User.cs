// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Random.Services.Api.Models.Categories;

namespace Random.Services.Api.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public IEnumerable<Category> CreatedCategories { get; set; }

        [JsonIgnore]
        public IEnumerable<Category> UpdatedCategories { get; set; }
    }
}
