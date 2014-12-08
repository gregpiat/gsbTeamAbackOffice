using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace ppeGsbCSharp
{
    class daoClient
    {
        private string server;
        private string database;
        private string uid;
        private string password;


        private void Initialize()
        {
            SqlConnection myConnection = new SqlConnection("user id=piat;" +
                                       "password=btssio;server=172.17.21.10;" +
                                       "Trusted_Connection=yes;" +
                                       "database=gbsTeamA; " +
                                       "connection timeout=15");
        }


    }
}
