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
    public class TitleGenresController : ApiController
    {
        private TitlesDBContext db = new TitlesDBContext();

        
        public IQueryable<TitleGenre> GetTitleGenres()
        {
            return db.TitleGenres;
        }


        
        [ResponseType(typeof(TitleGenre))]
        public IQueryable<TitleGenre> GetTitleGenrebyid(string id)
        {
            int titleid= Int32.Parse(id);
            return  db.TitleGenres.Where(x => x.TitleId == titleid);


            
        }


    }
}