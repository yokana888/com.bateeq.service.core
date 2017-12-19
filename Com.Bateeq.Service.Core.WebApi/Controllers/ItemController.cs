﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Com.Bateeq.Service.Core.Lib.Services;
using Com.Bateeq.Service.Core.Lib.Models;
using Com.Bateeq.Service.Core.Lib.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Com.Bateeq.Service.Core.WebApi.Controllers
{
    [Route("v1/master/item")]
    public class ItemController : BaseController<ItemService, Item, CoreDbContext>
    {
        public ItemController(ItemService service) : base(service)
        {
        }
    }
}
