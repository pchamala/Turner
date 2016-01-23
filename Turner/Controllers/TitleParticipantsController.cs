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
    public class TitleParticipantsController : ApiController
    {
        private TitlesDBContext db = new TitlesDBContext();

        // GET: api/TitleParticipants
        public IQueryable<TitleParticipant> GetTitleParticipants()
        {
            return db.TitleParticipants;
        }

        
        [ResponseType(typeof(TitleParticipant))]
        public IQueryable<TitleParticipant> GetTitleParticipantByid(string id)
        {
            int titleid = Int32.Parse(id);
            return db.TitleParticipants.Where(x => x.TitleId == titleid);



        }


    }
}