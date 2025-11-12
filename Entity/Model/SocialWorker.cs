namespace Entity.Model
{
    public class SocialWorker : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Adoption> Adoptions { get; set; }
    }
}
