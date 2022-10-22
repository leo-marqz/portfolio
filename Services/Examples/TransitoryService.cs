namespace Portafolio.Services.Examples
{
    public class TransitoryService
    {
        public TransitoryService()
        {
            GetGuid = Guid.NewGuid();
        }

        public Guid GetGuid { get; set; }
    }
}
