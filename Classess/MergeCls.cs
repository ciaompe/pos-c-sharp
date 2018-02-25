using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeus.Classess
{
    static class MergeCls
    {
        static public IEnumerable<object> Combine<T, U>(this T one, U two)
        {
            var properties1 = one.GetType().GetProperties().Where(p => p.CanRead && p.GetValue(one, null) != null).Select(p => p.GetValue(one, null));
            var properties2 = two.GetType().GetProperties().Where(p => p.CanRead && p.GetValue(two, null) != null).Select(p => p.GetValue(two, null));

            return new List<object>(properties1.Concat(properties2));
        }

    }
}
