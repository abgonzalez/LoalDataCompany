using Xunit;
using LocalDataCompany.Core;
using System.Collections.Generic;

namespace UnitTestProject
{
    public class UnitTest
    {
        [Fact]
        public void TestRemoveDuplicate()
        {
            string[] data = new string[]
              {
                 "AAAc91 % cWwWkLq$1ci3_848v3d__K",
                 "AAAc91AAA",
                 "A_4A_A4c941",
                 ""
            };
            Input input = new Input(data);

            
            List<string> result = new List<string>
            {
                "Ac91 % cWwWkLq£",
                "Ac91A",
                "Ac91"
            };


            Assert.Equal(result, input.Parse());
        }
       

    }
}
