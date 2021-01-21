using CvApp.DTO.Interfaces;

namespace CvApp.DTO.DTOs.SkillDtos
{
    public class SkillListDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
