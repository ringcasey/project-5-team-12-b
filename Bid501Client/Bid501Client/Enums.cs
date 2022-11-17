using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bid501Client
{
    public enum Status
    {
        Open,
        Closed
    }

    public enum State
    {
        START,
        LOGGEDIN,
        PLACED,
        ADDED,
    }
}
