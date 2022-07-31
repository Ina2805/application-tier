using ApplicationTier.Models.Host;

namespace ApplicationTier.Services.Hosts
{
    public class HostsService : IHostsService
    {
        public async Task<HostDTO> CreateHostAsync()
        {
            return new HostDTO { Id = 0, Name = "John Doe" };
        }

        public async Task<HostDTO?> GetHostByIdAsync(int id)
        {
            return new HostDTO { Id = id, Name = "John Doe" };
        }
    }
}