namespace Entity.Model
{
    public class Parent : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identification { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }

        public ICollection<AdoptionDetail> AdoptionDetails { get; set; }
    }
}
