using CvApp.Entities.Concrete.Base;
using CvApp.Entities.Interfaces;
using Dapper.Contrib.Extensions;

namespace CvApp.Entities.Concrete
{
    [Table("Educations")]
    public class Education : BaseEntity, ITable
    {
    }
}
