using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovApi.Domain.Models;

namespace MovApi.DomainTests.Models
{
    [TestClass]
    public class MovieTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidRatingException))]
        public void SettingInvalidRating_Should_ThrowExeption()
        {
            // Arrange
            var movie = new Movie("12 Angry Men", 8);

            // Act -- Set a rating larger then 10
            movie.SetRating(14);

            // Assert -- see ExpectedExceptionAttribute
        }
    }
}
