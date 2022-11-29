using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class GarageConfiguration : IEntityTypeConfiguration<Garage>
    {
        public void Configure(EntityTypeBuilder<Garage> builder)
        {
            builder.HasData(

                new Garage
                {
                    GarageId = Guid.NewGuid(),
                    Address = "Calle El Zancudo",
                    Name = "El silecio",
                    CityId = 1
                },
                new Garage
                {
                    GarageId = Guid.NewGuid(),
                    Address = "Cll 34-b 56",
                    Name = "Frenos Y Muelles",
                    CityId = 2
                }

                );
        }
    }
}
