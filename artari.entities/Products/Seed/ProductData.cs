using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artari.entities.Products.Seed
{
    internal class ProductData
    {
        public static IEnumerable<Product> GetProducts() =>
        [
            new Product() { Id = 1, Name = "Acer palmatum Bloodgood", Cultivar = "Bloodgood", Description = "red leaves", Height = "22", ImageUrl = "img artar Bloodgood", 
                IsNew = false, IsSoldout = false, Price = 55.0, Priority = 1, Propagation = "propagation details for Bloodgood", Species = ProductSpecies.Palmatum, 
                SpeciesName = "Palmatum", Type = ProductType.Acer, TypeName = "Acer"},

            new Product() { Id = 2, Name = "Acer dissectum Atropurpureum", Cultivar = "Atropurpureum", Description = "red leaves", Height = "22", ImageUrl = "img artar Atropurpureum",
                IsNew = false, IsSoldout = false, Price = 58.0, Priority = 2, Propagation = "propagation details for Atropurpureum", Species = ProductSpecies.Dissectum,
                SpeciesName = "Dissectum", Type = ProductType.Acer, TypeName = "Acer"},

            new Product() { Id = 3, Name = "Acer japonicum Green Cascade", Cultivar = "Green Cascade", Description = "green leaves", Height = "22", ImageUrl = "img artar Green Cascade",
                IsNew = false, IsSoldout = false, Price = 12.8, Priority = 1, Propagation = "propagation details for Green Cascade", Species = ProductSpecies.Japonicum,
                SpeciesName = "Japonicum", Type = ProductType.Acer, TypeName = "Acer"}
        ];
    }
}
