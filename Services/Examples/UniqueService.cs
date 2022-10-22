namespace Portafolio.Services.Examples
{
    public class UniqueService
    {
        public UniqueService()
        {
            GetGuid = Guid.NewGuid();
        }

        public Guid GetGuid { get; private set; }
    }
}
