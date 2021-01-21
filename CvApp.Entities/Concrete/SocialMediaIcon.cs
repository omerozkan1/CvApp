using CvApp.Entities.Interfaces;
using Dapper.Contrib.Extensions;

namespace CvApp.Entities.Concrete
{
    [Table("SocialMediaIcons")]
    public class SocialMediaIcon : ITable
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
