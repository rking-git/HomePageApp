using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePageApp.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections;

namespace HomePageApp.Models
{
    //generates get requests for 12 links in the links panel.
    public class HttpGetClass
    {
        private readonly LinksDbContext _context;
        public HttpGetClass(LinksDbContext context)
        {
           _context = context;
        }


        public List<Link> HttpGetMethod()
        {
            Link[] getData = new Link[12];

            for (int x = 0; x < getData.Length; x++)
            {
                getData[x] = _context.Links.Find(x + 1);
            }

            var getList = getData.ToList();

            return getList;
        }
    }
}