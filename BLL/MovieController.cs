using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Entity;

namespace BLL
{
    public class MovieController
    {
        public List<Movie> GetMovies(DateTime date)
        {
            using (EntityData db = new EntityData())
            {
                //List<Movie> movieList = db.Movies.Include("Show").Where(x => x.Shows.Where(x => x.DateTime.Date == date.Date));
                List<Movie> movieList = db.Movies.Include(s => s.Shows).Where(x => x.Shows.Any(y => DbFunctions.TruncateTime(y.DateTime) == date.Date)).ToList();

                return movieList;
            }
        }
    }
}
