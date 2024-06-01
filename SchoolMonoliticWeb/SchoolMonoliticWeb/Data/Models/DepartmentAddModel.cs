namespace SchoolMonoliticWeb.Data.Models
{
    public class DepartmentAddModel
    {
        
        public string? Name { get; set; }

        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }

        public int? Administrator { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }     
    }
}
