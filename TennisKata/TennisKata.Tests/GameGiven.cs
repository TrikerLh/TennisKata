using FluentAssertions;

namespace TennisKata.Tests {
    public class GameGiven {

        [SetUp]
        public void Setup() {
           
        }

        [Test]
        public void Show_love_love_when_is_a_new_game()
        {
            var result = new Game().Result;

            result.Should().Be("Player1:love-Player2:love");
        }
    }

    public class Game
    {
        public string Result => "Player1:love-Player2:love";
    }
}
