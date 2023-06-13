using CleanArchitecture.Domain.Abstraction;
using CleanArchitecture.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitecture.Domain.AppEntities
{
    public class UserAndCompanyRelation:Entity
    {
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
