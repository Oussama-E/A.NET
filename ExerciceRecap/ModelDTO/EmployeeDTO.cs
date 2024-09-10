using ExerciceRecap.Entities;

namespace ExerciceRecap.ModelDTO
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Title { get; set; }
        public string? TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }

    }
}
