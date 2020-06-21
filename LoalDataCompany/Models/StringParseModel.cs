using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalDataCompany.Core;

namespace LocalDataCompany.Models
{
    public class StringParseViewModel
    {
        public List<string> Input { get; set; }
        public List<string> Output { get; set; }
        public StringParseViewModel(Input input)
        {
            Input = input.InputItems;
            Output = input.OutputItems;
        }

    }
}
