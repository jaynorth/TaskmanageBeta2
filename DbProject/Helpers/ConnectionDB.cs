using DbProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helpers
{
    public class ConnectionDB
    {
        public TaskManDBEntities1 _entity { get; set; }

        public ConnectionDB()
        {
            _entity = new TaskManDBEntities1();
        }
    }
}
