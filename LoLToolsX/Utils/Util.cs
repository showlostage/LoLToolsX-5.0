using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLToolsX.Utils
{
    class Util
    {
        public static IList<System.Reflection.PropertyInfo> GetProperties(Type type)
        {
            return type.GetProperties().ToList();
        }
    }
}
