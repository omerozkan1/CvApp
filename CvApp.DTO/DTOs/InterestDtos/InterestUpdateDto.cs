using CvApp.DTO.Interfaces;

namespace CvApp.DTO.DTOs.InterestDtos
{
    public class SkillUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
