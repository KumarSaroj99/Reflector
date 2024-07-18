using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POConReflection.Models
{
    internal class Reflector
    {
        public string ShowDetails(Type type)
        {

            return $"Class Name : {type.Name}\n" +
                $"Properties : {type.GetProperties().Length}\n" +
                $"Constructors : {type.GetConstructors().Length}\n" +
                $"Methods : {type.GetMethods().Length}\n"
                ;
        }
    }
}
