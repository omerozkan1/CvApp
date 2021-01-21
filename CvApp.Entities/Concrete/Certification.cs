using CvApp.Entities.Concrete.Base;
using CvApp.Entities.Interfaces;
using Dapper.Contrib.Extensions;

namespace CvApp.Entities.Concrete
{
    [Table("Certifications")]
    public class Certification : BaseEntityOther, ITable
    {
    }
}
