using System.ComponentModel;

namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        //Composite key and foreign key
        [DisplayName("Department ID")]
        public int DepartmentID { get; set; }

        //Composite key and foreign key
        [DisplayName("Location ID")]
        public int LocationID { get; set; }

        //Navigation properties
        public Department? Department { get; set; }
        public Location? Location { get; set; }
    }
}
