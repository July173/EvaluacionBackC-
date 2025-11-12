namespace Entity.Dto
{
    public class OrphanageDto : BaseDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Capacity { get; set; }
        public DateTime FoundationDate { get; set; }
    }
}
