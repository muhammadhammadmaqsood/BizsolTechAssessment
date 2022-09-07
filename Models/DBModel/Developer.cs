using System.ComponentModel.DataAnnotations;

namespace BizsolTechAssessment.Models.DBModels
{
    public class Developer
    {
        [Key]
        public int DeveloperId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string JobTitle { get; set; }
    }
}
