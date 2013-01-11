using System;
using System.Collections.Generic;

using System.Text;
using Xunit;

namespace tESTLibrary1 

{
    public class Class1
    {
        [Fact(Skip="to test")]
        public void testc()
        {
            Assert.True(1 == 1);
        }

    }
}
