using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Aliens.Models;

namespace AliensTest.Models
{
    public class AlienTest
    {
        [Fact]
        public void Miss_ShouldSetDodgingToFalse()
        {
            var alien = new Alien(true, 50); // Alien is dodging
            alien.Miss();
            Assert.False(alien.Dodging);
        }

        [Fact]
        public void Miss_ShouldRemainFalse_WhenAlienIsNotDodging()
        {
            var alien = new Alien(false, 50); // Alien is NOT dodging
            alien.Miss();
            Assert.False(alien.Dodging); // Dodging should still be false
        }

    }
}
