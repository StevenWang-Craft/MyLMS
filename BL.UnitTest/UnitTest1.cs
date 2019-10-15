using System;
using Xunit;
using BL.Util;

namespace BL.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanHash()
        {
            //setup
            var password = "Password123";
            var exprectedResult = "662477317323124922514919171955516476175203";
            //run
            var result = HashHelper.GetMD5HashData(password);
            // assert
            Assert.Equal(exprectedResult, result);
        }
    }
}
