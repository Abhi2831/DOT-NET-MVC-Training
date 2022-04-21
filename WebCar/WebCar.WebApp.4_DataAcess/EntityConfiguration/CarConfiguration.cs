using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCar.WebApp._4_DataAcess.Entities;

namespace WebCar.WebApp._4_DataAcess.EntityConfiguration
{
    internal class CarConfiguration : IEntityTypeConfiguration<CarEntity>

    {
        public void Configure(EntityTypeBuilder<CarEntity> builder)
        {
            builder.ToTable("Table_2");
            builder.HasKey(PrimaryKey => PrimaryKey.Id);
        }
    }
}
