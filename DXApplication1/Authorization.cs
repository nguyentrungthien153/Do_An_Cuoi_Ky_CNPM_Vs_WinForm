using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    internal class Authorization
    {
        private static Authorization authorization;

        public int UserType { get; set; }
        //Su dung singleton 
        public static Authorization Instance
        {
            get { return authorization ?? (authorization = new Authorization()); }
        }

        private Authorization()
        {
            //private constructor makes it where this class can only be created by itself
        }
    }
}
