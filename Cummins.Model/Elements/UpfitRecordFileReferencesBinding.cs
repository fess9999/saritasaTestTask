using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;

namespace Cummins.Model.Elements
{
    public class UpfitRecordFileReferencesBinding : Entity
    {
        [Required] public UpfitRecord UpfitRecord { get; set; }
        [Required] public FileReference FileReference { get; set; }
    }
}