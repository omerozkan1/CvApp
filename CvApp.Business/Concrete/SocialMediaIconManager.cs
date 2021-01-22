using CvApp.Business.Interfaces;
using CvApp.DataAccess.Interfaces;
using CvApp.Entities.Concrete;
using System.Collections.Generic;

namespace CvApp.Business.Concrete
{
    public class SocialMediaIconManager : GenericManager<SocialMediaIcon>, ISocialMediaIconService
    {
        private readonly IGenericRepository<SocialMediaIcon> _genericSocialMediaIconRepository;
        private readonly ISocialMediaIconRepository _socialMediaIconRepository;
        public SocialMediaIconManager(IGenericRepository<SocialMediaIcon> genericSocialMediaIconRepository, ISocialMediaIconRepository socialMediaIconRepository ) : base(genericSocialMediaIconRepository)
        {
            _genericSocialMediaIconRepository = genericSocialMediaIconRepository;
            _socialMediaIconRepository = socialMediaIconRepository;
        }
        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _socialMediaIconRepository.GetByUserId(userId);
        }
    }
}
