using System;
using System.Collections.Generic;
using System.Text;

namespace LocalDataCompany.Core
{
    interface IInput
    {
        List<string> Parse();
        string removeCharacters(string item, string[] charsToRemove);
        string removeDuplicateChars(string str);
    }
}
