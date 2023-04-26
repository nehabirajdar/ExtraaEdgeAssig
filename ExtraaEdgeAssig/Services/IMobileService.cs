using ExtraaEdgeAssig.Models;

namespace ExtraaEdgeAssig.Services
{
    public interface IMobileService
    {
        IEnumerable<Mobile> GetAllMobiles();
        Mobile GetMobileById(int id);
        int AddMobile(Mobile mob);
        int UpdateMobile(Mobile mob);
        int DeleteMobile(int id);


    }
}
