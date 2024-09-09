using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("31.570771, -84.10353, Taco Bell Albany...", -84.10353)]
        [InlineData("34.376395, -84.913185, Taco Bell Adairsvill...", -84.913185)]
        [InlineData("34.047374, -84.223918, Taco Bell Alpharetta...", -84.223918)]
        [InlineData("33.671982, -85.826674, Taco Bell Annisto...", -85.826674)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var longitude = new TacoParser();
            

            //Act
            var actual = longitude.Parse(line);
            

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("31.570771, -84.10353, Taco Bell Albany...", 31.570771)]
        [InlineData("34.376395, -84.913185, Taco Bell Adairsvill...", 34.376395)]
        [InlineData("34.047374, -84.223918, Taco Bell Alpharetta...", 34.047374)]
        [InlineData("33.671982, -85.826674, Taco Bell Annisto...", 33.671982)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //arrange
            var latitude = new TacoParser();
            
            //act
            var actual = latitude.Parse(line);
            
            
            //assert
            Assert.Equal(expected, actual.Location.Latitude);
            
            
            
        }
        
        
        
        
    }
}
