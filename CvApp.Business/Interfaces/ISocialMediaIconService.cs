using CvApp.Entities.Concrete;
using System.Collections.Generic;

namespace CvApp.Business.Interfaces
{
    public interface ISocialMediaIconService : IGenericService<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
