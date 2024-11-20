using System.ComponentModel.DataAnnotations.Schema;

namespace BaseProject.Domain.Entities.Cities_Tables
{
    public class Region : BaseEntity
    {

        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public virtual City City { get; set; }
    }
}
