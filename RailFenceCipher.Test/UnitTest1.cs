namespace RailFenceCipher.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("WEAREDISCOVEREDFLEEATONCE", 3, "WECRLTEERDSOEEFEAOCAIVDEN")]
        [InlineData("Hello, World!", 3, "Hoo!el,Wrdl l")]
        [InlineData("Hello, World!", 4, "H !e,Wdloollr")]
        [InlineData("", 3, "")]
        public void Encode(string str, int num, string expected)
        {
            // Arrange - unnessecary for static method

            // Act
            var actual = Methods.Encode(str, num);

            // Assert
            Assert.Equal(expected, actual);
        }
        /*
        [Theory]
        [InlineData("WECRLTEERDSOEEFEAOCAIVDEN", 3, "WEAREDISCOVEREDFLEEATONCE")]
        [InlineData("Hoo!el, Wrdl l", 3, "Hello, World!")]
        [InlineData("H !e,Wdloollr", 4, "Hello, World!")]
        [InlineData("", 3, "")]
        public void Decode(string str, int num, string expected)
        {
            // Arrange - unnessecary for static method

            // Act
            var actual = Methods.Decode(str, num);

            // Assert
            Assert.Equal(expected, actual);
        }*/
    }
}