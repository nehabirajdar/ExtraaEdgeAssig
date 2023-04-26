using ExtraaEdgeAssig.Models;
using ExtraaEdgeAssig.Repositories;

namespace ExtraaEdgeAssig.Services
{
    public class MobileService : IMobileService
    {
        private readonly IMobileRepository _repo;
        public MobileService(IMobileRepository repo)
        {
            _repo = repo;
        }
        public int AddMobile(Mobile mob)
        {
            return _repo.AddMobile(mob);
        }
        public int DeleteMobile(int id)
        {
            return _repo.DeleteMobile(id);
        }
        
        public Mobile GetMobileById(int id)
        {
            return _repo.GetMobileById(id);
        }
        public IEnumerable<Mobile> GetAllMobiles()
        {
            return _repo.GetAllMobiles();
        }

        public int UpdateMobile(Mobile mob)
        {
            return _repo.UpdateMobile(mob);
        }

    }
}
