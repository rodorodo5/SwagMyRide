using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Data.Models
{
    public class State
    {
        public long StateId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }


        public Country CountryId { get; set; }
    }
}
