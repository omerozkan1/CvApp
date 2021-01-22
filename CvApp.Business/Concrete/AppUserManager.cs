using CvApp.Business.Interfaces;
using CvApp.DataAccess.Interfaces;
using CvApp.Entities.Concrete;

namespace CvApp.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        private readonly IGenericRepository<AppUser> genericRepository;
        private readonly IAppUserRepository appUserRepository;
        public AppUserManager(IGenericRepository<AppUser> genericRepository, IAppUserRepository appUserRepository) :base(genericRepository)
        {
            this.genericRepository = genericRepository;
            this.appUserRepository = appUserRepository;
        }
        public bool CheckUser(string userName, string password)
        {
            return appUserRepository.CheckUser(userName, password);
        }
    }
}
