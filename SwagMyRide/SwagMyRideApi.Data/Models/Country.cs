using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Data.Models
{
    public class Country
    {
        public long CountryId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
