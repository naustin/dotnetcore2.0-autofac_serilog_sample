using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy;

namespace SerilogAutofacApiTemplate.Controllers
{
    public class HelloNancy : NancyModule
    {
        public HelloNancy()
        {
            Get("/", args => "Hello World");
        }

    }
}
