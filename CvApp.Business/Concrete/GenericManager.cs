using CvApp.Business.Interfaces;
using CvApp.DataAccess.Interfaces;
using CvApp.Entities.Interfaces;
using System.Collections.Generic;

namespace CvApp.Business.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T:class,ITable, new()
    {
        private readonly IGenericRepository<T> genericRepository;
        public GenericManager(IGenericRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }
        public void Delete(T entity)
        {
            genericRepository.Delete(entity);
        }

        public List<T> GetAll()
        {
            return genericRepository.GetAll();
        }

        public T GetById(int id)
        {
            return genericRepository.GetById(id);
        }

        public void Insert(T entity)
        {
            genericRepository.Insert(entity);
        }

        public void Update(T entity)
        {
            genericRepository.Update(entity);
        }
    }
}
