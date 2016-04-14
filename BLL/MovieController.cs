using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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

                var startDate = date;
                var endDate = startDate.AddDays(1);
                var movieList = db.Movies.Include(x => x.Shows).Where(x => x.Shows.Any(y => y.DateTime >= startDate && y.DateTime < endDate)).ToList();

                //var justDate = date.Date;
                //var movieList = db.Movies.Include(x => x.Shows).Where(y => y.Shows.Any(z => DbFunctions.TruncateTime(z.DateTime) == justDate)).ToList();

                return movieList;
            }
        }

        public Movie getMovie()
        {
            using (EntityData db = new EntityData())
            {
                return db.Movies.FirstOrDefault();
            }
        }
    }
}
