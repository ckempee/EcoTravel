using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_BLL.Entities
{
    public class Type: IType
    {
        public int idType { get; set; }
        public string type { get; set; }

    }
}
