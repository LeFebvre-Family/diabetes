using System;
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
            var food = new Core.Models.Food();
            var exception = default(Exception);

            // act
            try
            {
                food.Quantity = null;
            }
            catch (InvalidDataException ex)
            {
                exception = ex;
            }

            // assert
            exception.Should().NotBeNull();

        }


    }

}