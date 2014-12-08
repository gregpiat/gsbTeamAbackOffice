using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ppeGsbCSharp
{
    class daoFactory
    {
            SqlConnection myConnection = new SqlConnection("user id=piat;" +
                                       "password=btssio;server=172.17.21.10;" +
                                       "Trusted_Connection=yes;" +
                                       "database=gbsTeamA; " +
                                       "connection timeout=15");
        public static connexionBDD(){

        }
    }
}
