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

namespace Turner.Controllers
{
    public class AwardsController : ApiController
    {
        private TitlesDBContext db = new TitlesDBContext();

        // GET: api/Awards
        public IQueryable<Award> GetAwards()
        {
            return db.Awards;
        }


        [ResponseType(typeof(Award))]
        public IQueryable<Award> GetAwardid(string id)
        {
            int titleid = Int32.Parse(id);
            return db.Awards.Where(x => x.TitleId == titleid);



        }

  
    }
}