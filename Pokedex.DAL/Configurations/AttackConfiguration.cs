using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokedex.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.DAL.Configurations
{
    internal class AttackConfiguration : IEntityTypeConfiguration<Attack>
    {
        public void Configure(EntityTypeBuilder<Attack> builder)
        {
            builder.HasOne(a => a.Type)
                .WithMany(t => t.Attacks)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new Attack { Id = 1, Name = "Charge", TypeId = 7 },
                new Attack { Id = 2, Name = "Fatal Foudre", TypeId = 1 },
                new Attack { Id = 3, Name = "Tranche Herbe", TypeId = 4 }
            );
        }
    }
}
