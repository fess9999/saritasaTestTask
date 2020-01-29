using Cummins.Model.Base;

namespace Cummins.Model.Elements
{
    public class UpfitElementBinding : Entity
    {
        public double Order { get; set; }

        public UpfitElement UpfitElement { get; set; }

        public UpfitRecord UpfitRecord { get; set; }
    }
}