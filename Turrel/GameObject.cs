using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turrel
{
   public  class GameObject
    {
        public string obj_name { get; set; }
        public int obj_life_lev { get; set; }
        public bool obj_dead { get; set; }

        public GameObject()
        {
            obj_dead = false;
            obj_life_lev = 800;
            obj_name = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8);
        }
    }
}
