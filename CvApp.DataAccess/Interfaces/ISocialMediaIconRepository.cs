using CvApp.Entities.Concrete;
using System.Collections.Generic;

namespace CvApp.DataAccess.Interfaces
{
    public interface ISocialMediaIconRepository : IGenericRepository<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
