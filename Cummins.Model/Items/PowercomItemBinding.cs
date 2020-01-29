using Cummins.Model.Base;
using Cummins.Model.Elements;

namespace Cummins.Model.Items
{
    public class PowercomItemBinding : Entity
    {
        public double Order { get; set; }

        public PowercomItem PowercomItem { get; set; }

        public PowercomElement PowercomElement { get; set; }
    }
}