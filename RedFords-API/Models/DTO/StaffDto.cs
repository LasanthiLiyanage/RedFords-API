namespace RedFords_API.Models.DTO
{
    public class StaffDto
    {
        public Guid Id { get; set; }
        public Guid StaffType { get; set; }
        public Guid Title { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MiddleInitial { get; set; } = string.Empty;
        public string HomePhone { get; set; } = string.Empty;
        public string CellPhone { get; set; } = string.Empty;
        public int OfficeExtension { get; set; }
        public int IRDNumber { get; set; }
        public string Status { get; set; }
        public Guid ManagerId { get; set; }
    }
}
