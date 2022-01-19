namespace BenzoApp.Models
{
    public class Logo : BaseEntity
    {
        public string Type { get; set; }

        public string Path { get; set; }

        public FuelStation FuelStation { get; set; }
    }
}
