using Sample_MVC_and_WebAPI.Attributes;
using Sample_MVC_and_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample_MVC_and_WebAPI.Controllers.Services
{
    public class TestController : ApiController
    {
     
        /// <summary>
        /// TestController Ctr
        /// </summary>
        public TestController()
        {
           
        }


        /// <summary>
        /// TestController - Get
        /// </summary>
        /// <returns></returns>
        [CustomTest]
        public int Get()
        {
            var count = 0;
            using (var context = new OrderDBContext())
            {
                var selected = from i in context.Items
                               select i;
                count = selected.Count();
            }
            return count;
        }


        /// <summary>
        /// TestController = POST
        /// </summary>
        /// <returns></returns>
        public bool Post()
        {
            using (var context = new OrderDBContext())
            {
                var item = new Item()
                {
                    Name = "Item Name",
                    Description = "Item Desc"
                };

                context.Items.Add(item);
                context.SaveChanges();
            }
            return true;
        }

    }
}
