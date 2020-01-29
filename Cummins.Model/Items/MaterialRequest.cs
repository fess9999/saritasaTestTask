using System.Collections.Generic;
using Cummins.Model.Base;

namespace Cummins.Model.Items
{
    public class MaterialRequest : Entity
    {
        public List<MaterialRequestItem> MaterialRequestItems { get; set; }
    }
}