using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Aliens.Models;

namespace AliensTest.Models
{
    public class RaygunTest
    {
        [Fact]
        public void IsFullyCharged_ShouldReturnTrue_WhenCurrentChargeEqualsMaxCharge()
        {
            var raygun = new Raygun(100, 100); // Fully charged
            bool result = raygun.IsFullyCharged();
            Assert.True(result);
        }

        [Fact]
        public void IsFullyCharged_ShouldReturnFalse_WhenCurrentChargeIsLessThanMaxCharge()
        {
            var raygun = new Raygun(100, 50); // Partially charged
            bool result = raygun.IsFullyCharged();
            Assert.False(result);
        }
    }
}
