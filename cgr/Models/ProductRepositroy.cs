using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cgr.Models;

namespace cgr.Models
{
    public class ProductRepositroy
    {
        ProductModel firstProduct = new ProductModel()
        {
            Id = 1,
            Name = "Rainbow Dash",
            Category = "Leader",
            Description = "I love to Dash over Rainbows!"  
        };

        ProductModel secondProduct = new ProductModel()
        {
            Id = 2,
            Name = "Ranty",
            Category = "Team Leader",
            Description = "I love to be Ranty!"
        };

        Dictionary<int, ProductModel> dictionaryProducts = new Dictionary<int, ProductModel>();

        public void AddToDictionary()
        {
            dictionaryProducts.Add(firstProduct.Id, firstProduct);
            dictionaryProducts.Add(secondProduct.Id, secondProduct);
        }

        public void ReturnDictionary()
        {

        }

    }
}
