using System.Collections.Generic;
using Cummins.Model.Base;

namespace Cummins.Model.Elements
{
    public class ProductGroup : Entity
    {
        public string Name { get; set; }

        public ProductGroup ParentProductGroup { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}