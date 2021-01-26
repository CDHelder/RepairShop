using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace OdeToFood.Web.Api
{
    public class RepairOrderController : ApiController
    {
        private readonly IRepairOrderData db;
        public RepairOrderController(IRepairOrderData db)
        {
            this.db = db;
        }
        public IEnumerable<RepairOrder> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
