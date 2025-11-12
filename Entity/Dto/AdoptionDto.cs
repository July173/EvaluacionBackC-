namespace Entity.Dto
{
    public class AdoptionDto : BaseDto
    {
        public DateTime AdoptionDate { get; set; }
        public string Status { get; set; }
        public int socialworker_id { get; set; }
    }
}
