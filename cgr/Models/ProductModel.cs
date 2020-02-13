using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
    
namespace cgr.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Review { get; set; }
        public DateTime DateTimeGroup { get; set; }
        public string Description { get; set; }

    }
}
