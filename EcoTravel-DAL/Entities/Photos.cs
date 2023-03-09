using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Entities
{
    public class Photos
    {
        public int idPhotos { get; set; }
        public int idLogement { get; set; }
        public string photos { get; set; }
    }
}
