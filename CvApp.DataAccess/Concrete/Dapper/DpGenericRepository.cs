using CvApp.DataAccess.Interfaces;
using CvApp.Entities.Interfaces;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CvApp.DataAccess.Concrete.Dapper
{
    public class DpGenericRepository<T> : IGenericRepository<T> where T : class, ITable, new()
    {
        private readonly IDbConnection dbConnection;

        public DpGenericRepository(IDbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public void Delete(T entity)
        {
            dbConnection.Delete(entity);
        }

        public List<T> GetAll()
        {
            return dbConnection.GetAll<T>().ToList();
        }

        public T GetById(int id)
        {
            return dbConnection.Get<T>(id);
        }

        public void Insert(T entity)
        {
            dbConnection.Insert(entity);
        }

        public void Update(T entity)
        {
            dbConnection.Update(entity);
        }
    }
}
