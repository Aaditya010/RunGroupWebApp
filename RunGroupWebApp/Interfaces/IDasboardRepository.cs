using RunGroupWebApp.Models;

namespace RunGroupWebApp.Interfaces
{
    public interface IDasboardRepository
    {
        Task<List<Race>> GetAllUserRaces();
        Task<List<Club>>GetAllUserClubs();
    }
}
