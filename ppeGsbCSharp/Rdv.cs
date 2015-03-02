using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppeGsbCSharp
{
    class Rdv
    {
        Client client;
        DateTime date;

        public Rdv(Client unClient, DateTime uneDate){
            client = unClient;
            date = uneDate;
        }

    }
}
