using System.IO;
using Diabetes.Core.Models;
using FluentAssertions;
using Xunit;

namespace Diabetes.Tests.Models
{
    public class User
    {

        [Fact]
        public void EmptyName_ThrowsException()
        {
            // arrange isolation

            // arrange test
            var user = new Core.Models.User();

            // act
            var exception = Assert.Throws<InvalidDataException>(() =>
            {
                user.Name = default(string);
            });

            // assert
            exception.Message.Should().Be("The User Name cannot be empty.");

            // clean-up
        }


       
    }
}
