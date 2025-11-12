namespace Entity.Dto
{
    public class AdoptionDetailDto : BaseDto
    {
        public int adoption_id { get; set; }
        public int parent_id { get; set; }
        public int child_id { get; set; }
    }
}
