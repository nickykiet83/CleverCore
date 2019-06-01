using CleverCore.Utilities.Helpers;
using Xunit;

namespace CleverCore.Utilities.Test.Helpers
{
    public class TextHelperTest
    {
        [Theory]
        [InlineData("KIETPHAM - FULL STACK DEVELOPER")]
        [InlineData("KIETPHAM -- FULL STACK DEVELOPER")]
        [InlineData("KIETPHAM -- FULL STACK DEVELOPER?")]
        public void ToUnsignString_UpperCaseInput_LowerCaseOutput(string input)
        {
            var result = TextHelper.ToUnsignString(input);
            Assert.Equal("kietpham-full-stack-developer", result);
        }
        
        [Fact]
        public void ToString_NumberInput_CharactersNumber()
        {
            var result = TextHelper.ToString(120);
            Assert.Equal("một trăm hai mươi đồng chẵn", result);
        }
    }
}