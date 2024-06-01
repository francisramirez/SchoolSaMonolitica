namespace SchoolMonoliticWeb.Data.Models
{
    public class DepartmentUpdateModel
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }
        public DateTime ModifyDate { get; set; }
        public int ModifyUser { get; set; }     

    }
}
