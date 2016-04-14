using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Movie
    {
        [Key, Required, DataMember]
        public Guid Id { get; set; }

        [Required, DataMember]
        public string Name { get; set; }

        [DataMember]
        public ICollection<Show> Shows { get; set; }

        [DataMember]
        public string IMDBID { get; set; }
    }
}
