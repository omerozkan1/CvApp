using Dapper.Contrib.Extensions;

namespace CvApp.Entities.Concrete.Base
{
    public class BaseEntityOther
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
