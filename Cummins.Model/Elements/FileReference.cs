using System;
using Cummins.Model.Base;

namespace Cummins.Model.Elements
{
    public class FileReference : Entity
    {
        public Guid EntityId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }
    }
}