﻿using CvApp.DataAccess.Interfaces;
using CvApp.Entities.Concrete;
using Dapper;
using System.Data;

namespace CvApp.DataAccess.Concrete.Dapper
{
    public class AppUserRepository : GenericRepository<AppUser>,IAppUserRepository
    {
        private readonly IDbConnection dbConnection;
        public AppUserRepository(IDbConnection dbConnection):base(dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public bool CheckUser(string userName, string password)
        {
            var user = dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where UserName=@userName and Password=@password");
            return user != null;
        }
    }
}
