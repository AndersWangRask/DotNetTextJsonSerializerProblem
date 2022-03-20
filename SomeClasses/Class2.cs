using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SomeClasses
{
    public class Class2 : SomeBaseClasses.Class2
    {
        //The implementing class declares a new property with the same name,
        //but when this is set to Ignore,
        //it looks in the base class, which is also set to Ignore, but it comes to a probelm trying to add it twice

        [JsonIgnore]
        public new Class1 Class1 => new Class1();
    }
}
