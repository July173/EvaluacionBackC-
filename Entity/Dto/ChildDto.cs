namespace Entity.Dto
{
    public class ChildDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string CurrentStatus { get; set; }
    }
}
