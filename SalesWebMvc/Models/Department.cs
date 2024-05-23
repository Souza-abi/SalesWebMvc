namespace SalesWebMvc.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public ICollection<Seller> Seller { get; set; }
    }
}
