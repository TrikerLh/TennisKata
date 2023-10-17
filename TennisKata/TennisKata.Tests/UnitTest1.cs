using FluentAssertions;

namespace TennisKata.Tests {
    public class ResultGiven {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Love_should_be_the_first_score()
        {
            var result = new Score().Result;

            result.Should().Be("love");
        }
    }

    public class Score {

        public string Result => "love";
    }
}