namespace Entity.Dto
{
    public class ChildOrphanageDto : BaseDto
    {
        public int child_id { get; set; }
        public int orphanage_id { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
    }
}
