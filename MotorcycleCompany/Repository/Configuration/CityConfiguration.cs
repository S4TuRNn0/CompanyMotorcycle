using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    internal class CityConfiguration  : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(

                new City
                {
                    CityId = Guid.NewGuid(),
                    Name = "Manizales",
                    Department = "Caldas",
                    Inhabitants =  12
                },

                new City
                {
                    CityId = Guid.NewGuid(),
                    Name = "Manzanares",
                    Department = "Caldas",
                    Inhabitants = 45

                }

                );
        }
    }
}
