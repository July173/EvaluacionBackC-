namespace Entity.Model
{
    public class Child : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string CurrentStatus { get; set; }

        public ICollection<ChildOrphanage> ChildOrphanage { get; set; }
        public ICollection<AdoptionDetail> AdoptionDetails { get; set; }
    }
}
