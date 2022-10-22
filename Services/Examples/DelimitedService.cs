namespace Portafolio.Services.Examples
{
    public class DelimitedService
    {
        public DelimitedService()
        {
            GetGuid = Guid.NewGuid();
        }

        public Guid GetGuid { get; set; }
    }
}
