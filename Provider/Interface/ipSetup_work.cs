using System.Collections.Generic;
using System.Threading.Tasks;
using T_Service.Models;

namespace T_Service.Providers
{
    public interface IpSetup_work
    {
        List<cList_Tservice_type> getServiceList();
    }
}