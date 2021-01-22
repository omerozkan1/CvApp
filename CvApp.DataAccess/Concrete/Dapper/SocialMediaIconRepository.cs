using CvApp.Entities.Concrete;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CvApp.DataAccess.Interfaces;


namespace CvApp.DataAccess.Concrete.Dapper
{
    public class SocialMediaIconRepository : GenericRepository<SocialMediaIcon>, ISocialMediaIconRepository
    {
        private readonly IDbConnection _connection;
        public SocialMediaIconRepository(IDbConnection connection) : base(connection)
        {
            _connection = connection;
        }

        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _connection.Query<SocialMediaIcon>("select * from SocialMediaIcons where AppUserId=@id", new
            {
                id = userId
            }).ToList();
        }
    }
}
