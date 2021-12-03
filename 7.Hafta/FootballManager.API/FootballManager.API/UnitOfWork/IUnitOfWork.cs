using FootballManager.API.Services.Abstract;
using System.Threading.Tasks;

namespace FootballManager.API.UnitOfWork
{
    public interface IUnitOfWork
    {
        public ICoachService CoachService { get; set; }
        public IFootballerService FootballerService { get; set; }
        public IManagementPositionService ManagementPositionService { get; set; }
        public IManagerService ManagerService { get; set; }
        public INationalTeamService NationalTeamService { get; set; }
        public IPositionService PositionService { get; set; }
        public ITacticService TacticService { get; set; }
        public ITeamService TeamService { get; set; }

        Task SaveChangesAsync();
    }
}
