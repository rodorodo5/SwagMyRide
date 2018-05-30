using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Buissnes
{
    public class PuttingCreatedDate
    {
        public DateTime SetCreatedDate()
        {
            return DateTime.UtcNow;

        }
    }
}
