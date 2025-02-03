﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TRUMPet.Domain;

namespace TRUMPet.Data
{
    public class TRUMPetContext(DbContextOptions<TRUMPetContext> options) : IdentityDbContext<TRUMPetUser>(options)
    {
        

        public DbSet<Genre> Genre { get; set; } = default!;
        public DbSet<TRUMPet.Domain.Artist> Artist { get; set; } = default!;
        public DbSet<TRUMPet.Domain.Song> Song { get; set; } = default!;
        public DbSet<TRUMPet.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<TRUMPet.Domain.User> User { get; set; } = default!;
    }
}
