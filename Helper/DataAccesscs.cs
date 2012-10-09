using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class DataAccess
    {
        public static List<helps> GetAllHelp()
        {
            using (Entities context = new Entities())
            {
                return context.helps.Include("helpType").ToList();
            }
        }
    }
}
