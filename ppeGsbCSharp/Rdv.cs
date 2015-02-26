using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppeGsbCSharp
{
    class Rdv
    {
        int id;
        Client client;
        DateTime date;

        public Rdv(int unId, Client unClient, DateTime uneDate){
            id = unId;
            client = unClient;
            date = uneDate;
        }
    }
}
