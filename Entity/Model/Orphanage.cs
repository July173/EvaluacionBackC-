namespace Entity.Model
{
    public class Orphanage : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Capacity { get; set; }
        public DateTime FoundationDate { get; set; }

        public ICollection<ChildOrphanage> ChildOrphanage { get; set; }
    }
}
