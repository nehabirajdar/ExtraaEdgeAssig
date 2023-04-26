using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Repositories
{
    public interface IMobileRepository
    {
        IEnumerable<Mobile> GetAllMobiles();
        Mobile GetMobileById(int id);
        int AddMobile(Mobile mob);
        int UpdateMobile(Mobile mob);
        int DeleteMobile(int id);

    }
}
