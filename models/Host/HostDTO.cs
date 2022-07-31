namespace ApplicationTier.Models.Host
{
    public class HostDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public HostDTO() { }
        public HostDTO(HostModel host) => (Id, Name) = (host.Id, host.Name);
    }
}