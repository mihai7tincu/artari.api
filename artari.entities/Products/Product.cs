using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace artari.entities.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Height { get; set; }
        public string? ImageUrl { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsSoldout { get; set; }
        public double? Price { get; set; }
        public string? TypeName { get; set; }
        public int? Priority { get; set; }
        public string? Propagation { get; set; }
        public string? SpeciesName { get; set; }
        public string? Cultivar { get; set; }
        public ProductSpecies? Species { get; set; }
        public ProductType? Type { get; set; }
    }
}
