using System.IO;
using Diabetes.Core.Models;
using FluentAssertions;
using Xunit;

namespace Diabetes.Tests.Models
{
    public class Food
    {

        [Fact]
        public void EmptyName_ThrowsException()
        {
            // arrange isolation

            // arrange test
            var food = new Core.Models.Food();

            // act
            var exception = Assert.Throws<InvalidDataException>(() =>
            {
                food.Name = default(string);
            });

            // assert
            exception.Message.Should().Be(expected: "The Food Name cannot be empty.");

            // clean-up
        }

        [Fact]
        public void EmptyQuantity_ThrowsException()
        {
            // arrange isolation

            // arrange test
            var foodQuantity = new Core.Models.Food();
            // act
            var exception = Assert.Throws<InvalidDataException>(() =>
            {
                foodQuantity.Equals(-1);

            });

            // assert
            exception.Message.Should().Be("The quantity of food cannot be empty.");

        }


    }

}