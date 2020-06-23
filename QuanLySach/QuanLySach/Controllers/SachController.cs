using QuanLySach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySach.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach {Id = 1, Title = "Sách 1", AuthorName = "TG 1", Price = 10000, Content = "aaaaaaaaaaaaaaaaaaaaaaaaa"  },
            new Sach {Id = 2, Title = "Sách 2", AuthorName = "TG 2", Price = 20000, Content = "bbbbbbbbbbbbbbbbbbbbbbbbb"},
        }; 
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id );
            if(sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
}
}
