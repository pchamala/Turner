using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Turner;
using System.Threading.Tasks;

namespace Turner.Controllers
{
    public class TitlesController : ApiController
    {
        private TitlesDBContext db = new TitlesDBContext();

        [HttpGet, Route("api/Titles")]
        [ResponseType(typeof(Title))]
        public async Task<IHttpActionResult> GetTitles()
        {
            var titles = await db.Titles.OrderBy(t => t.TitleName).ToListAsync();
            return Ok(titles);
        }

        [HttpGet, Route("api/TitlebyName")]
        [ResponseType(typeof(Title))]
        public async Task<IHttpActionResult> GetTitle(string name)
        {
            var title = await db.Titles.Where(t => t.TitleName.Contains(name)).OrderBy(t=>t.TitleName).AsNoTracking().ToListAsync();
            if (title == null)
            {
                return NotFound();
            }

            return Ok(title);
        }

        

       

        
    }
}