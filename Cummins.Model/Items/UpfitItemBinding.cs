using Cummins.Model.Base;
using Cummins.Model.Elements;

namespace Cummins.Model.Items
{
    public class UpfitItemBinding : Entity
    {
        public double Order { get; set; }

        public UpfitItem UpfitItem { get; set; }

        public UpfitElement UpfitElement { get; set; }
    }
}