using CvApp.DTO.Interfaces;

namespace CvApp.DTO.DTOs.SocialMediaIconDtos
{
    public class SocialMediaIconAddDto : IDto
    {
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
