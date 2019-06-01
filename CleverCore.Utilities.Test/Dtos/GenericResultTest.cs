using CleverCore.Utilities.Dtos;
using Xunit;

namespace CleverCore.Utilities.Test.Dtos
{
    public class GenericResultTest
    {
        [Fact]
        public void Constructor_CreateObjectNotNull_NoParam()
        {
            var genericResult = new GenericResult();
            Assert.NotNull(genericResult);
        }
        
        [Fact]
        public void Constructor_SuccessIsTrue_OneParam()
        {
            var genericResult = new GenericResult(true);
            Assert.True(genericResult.Success);
        }
        
        [Fact]
        public void Constructor_SuccessAndDataHasValue_TwoParam()
        {
            var genericResult = new GenericResult(true, new object());
            Assert.NotNull(genericResult.Data);
        }
        
        [Fact]
        public void Constructor_CreateObjectNotNull_ValidObjectWithMessage()
        {
            var genericResult = new GenericResult(true, "test");
            Assert.Equal("test", genericResult.Message);
        }
        
    }
}