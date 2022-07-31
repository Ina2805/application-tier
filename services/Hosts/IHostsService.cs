using ApplicationTier.Models.Host;

namespace ApplicationTier.Services.Hosts
{
    public interface IHostsService
    {
        Task<HostDTO> CreateHostAsync();
        Task<HostDTO?> GetHostByIdAsync(int id);
        // Task<IEnumerable<HostDTO>> GetAllHostsAsync();
    }
}

