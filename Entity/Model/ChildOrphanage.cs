namespace Entity.Model
{
    public class ChildOrphanage : BaseModel
    {
        public int child_id { get; set; }
        public int orphanage_id { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }

        public Child Child { get; set; }
        public Orphanage Orphanage { get; set; }
    }
}
