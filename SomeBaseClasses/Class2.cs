using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SomeBaseClasses
{
    public class Class2
    {
        [JsonIgnore]
        public Class1 Class1 => new Class1();
    }
}
