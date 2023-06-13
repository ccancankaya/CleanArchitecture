using CleanArchitecture.Domain.Abstraction;

namespace CleanArchitecture.Domain.CompanyEntity
{
    public class UniformChartOfAccount:Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }
        public string CompanyId { get; set; }
    }
}
