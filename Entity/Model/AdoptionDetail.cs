namespace Entity.Model
{
    public class AdoptionDetail : BaseModel
    {
        public int adoption_id { get; set; }
        public int parent_id { get; set; }
        public int child_id { get; set; }

        public Adoption Adoption { get; set; }
        public Parent Parent { get; set; }
        public Child Child { get; set; }
    }
}
