using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artari.entities
{
    internal class Products
    {

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string height { get; set; }
        public string imageUrl { get; set; }
        public bool isNew { get; set; }
        public bool isSoldout { get; set; }
        public double price { get; set; }
        public string typeName { get; set; }
        public int priority { get; set; }
        public string propagation {  get; set; }
        public string speciesName { get; set; }
        public string cultivar { get; set; }





    /*

  type: ProductType; //acer, ginkgo, kaki
  species: ProductSpecies; //palmatum, palmatum dissectum, shirasawanum, japonicum
    */

}
}
