using FootballManager.API.Data;
using FootballManager.API.Services.Abstract;
using System.Threading.Tasks;

namespace FootballManager.API.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EfContext _dbContext;

        public UnitOfWork(EfContext dbContext, ICoachService coachService, IFootballerService footballerService,
            IManagementPositionService managementPositionService,
            IManagerService managementService, INationalTeamService nationalTeamService,
            IPositionService positionService, ITacticService tacticService, ITeamService teamService)
        {
            _dbContext = dbContext;
            CoachService = coachService;
            FootballerService = footballerService;
            ManagementPositionService = managementPositionService;
            ManagerService = managementService;
            NationalTeamService = nationalTeamService;
            PositionService = positionService;
            TacticService = tacticService;
            TeamService = teamService;

        }

        public ICoachService CoachService { get; set; }
        public IFootballerService FootballerService { get; set; }
        public IManagementPositionService ManagementPositionService { get; set; }
        public IManagerService ManagerService { get; set; }
        public INationalTeamService NationalTeamService { get; set; }
        public IPositionService PositionService { get; set; }
        public ITacticService TacticService { get; set; }
        public ITeamService TeamService { get; set; }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
