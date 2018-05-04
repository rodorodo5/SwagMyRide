﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;

namespace SwagMyRideApi.Services.Services
{
    public class BrandCatalogue:IBaseCall
    {
        private readonly ApplicationContext _db;
        public BrandCatalogue()
        {
            _db = new ApplicationContext();
            
        }

        public IEnumerable<Service> GetData(int id)
        {
            
            return _db.BrandCatalogue.Where(x => x.BrandId == id).ToList();
        }

        public IEnumerable<Service> GetAllData()
        {
            return _db.BrandCatalogue.ToList();

        }
    }
}
