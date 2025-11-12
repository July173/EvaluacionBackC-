namespace Entity.Model
{
    public class Adoption : BaseModel
    {
        public DateTime AdoptionDate { get; set; }
        public string Status { get; set; }

        public int socialworker_id { get; set; }
        public SocialWorker SocialWorker { get; set; }

        public ICollection<AdoptionDetail> AdoptionDetails { get; set; }
    }
}
