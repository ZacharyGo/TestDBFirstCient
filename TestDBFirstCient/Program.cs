using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDBFirstCient
{
    class Program
    {
        static TohogasDataContext context = new TohogasDataContext();

        static void Main(string[] args)
        {
            /*List<TGZZZDba16.Dba16Accept4> dba16Accept4 = new List<TGZZZDba16.Dba16Accept4>();
            List<TGZZZDba17.Dba17Accept1> dba17Accept2 = new List<TGZZZDba17.Dba17Accept1>();
            TGZZZDba17 tGZZZDba17 = new TGZZZDba17(context);
            Console.WriteLine("Result : {0}", tGZZZDba17.GetENEDOStoreInformationWithOrganizationNumber("0000001", DateTime.Now, true, out dba17Accept2));
            */
            // bool areaStorePresenceFlag;
            TGZZZGyo20 tGZZZGyo20 = new TGZZZGyo20(context);
            int contractSafetyServiceSubscriptionStatus;
            Console.WriteLine("Result : {0}", tGZZZGyo20.DeterminationOfSafetyServiceSubscriptionStatus("9710670005", "memberId", false, out contractSafetyServiceSubscriptionStatus));
            Console.ReadLine();
        }

        
    }
}
