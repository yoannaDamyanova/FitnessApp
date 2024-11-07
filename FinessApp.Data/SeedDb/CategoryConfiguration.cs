using FitnessApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Data.SeedDb
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[] 
            {
                data.CyclingCategory, 
                data.YogaCategory, 
                data.HIITCategory, 
                data.CardioCategory, 
                data.PilatesCategory,
                data.FamilyFitnessCategory, 
                data.MartialArtsCategory
            });
        }
    }
}
