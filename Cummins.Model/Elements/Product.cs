using System;
using Cummins.Model.Base;

namespace Cummins.Model.Elements
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public ProductGroup ProductGroup { get; set; }

        public Guid ProductGroupId { get; set; }
    }
}