namespace Dapper_Apis.Models
{
    public class Designation
    {
        public int DesgId { get; set; }

        public string Name { get; set; } = string.Empty;

        public int DeptId { get; set; }
    }
}