using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace IntroToCSharp
{
    class CustomSerializer
    {
        public string Serialize(object obj)
        {
            var objType = obj.GetType();
            IList<FieldInfo> field = new List<FieldInfo>(objType.GetFields());

            string result = "<?\n";

            foreach(var val in field)
            {
                var propValue = val.GetValue(obj);
                result += val.Name + "=" + propValue + "\n";
            }
            result += "?>";

            return result;
        }
    }
}
