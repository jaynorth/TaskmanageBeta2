using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DbProject
{
    public partial class Project
    {
        public override string ToString()
        {
            return string.Format("{0}" ,Name);
        }

    }
}
