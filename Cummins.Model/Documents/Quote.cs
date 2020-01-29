using System.ComponentModel.DataAnnotations;

namespace Cummins.Model.Documents
{
    public class Quote : Document
    {
        [Required] public StartTestInformation StartTestInformation { get; set; }

        [Required] public PMA PMA { get; set; }
    }
}