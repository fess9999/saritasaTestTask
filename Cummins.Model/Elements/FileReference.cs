using Cummins.Model.Base;

namespace Cummins.Model.Elements
{
    public class FileReference : Entity
    {
        public string Name { get; set; }

        public string Url { get; set; }
    }
}