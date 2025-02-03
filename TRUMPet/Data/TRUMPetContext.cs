using System;
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
    }
}
