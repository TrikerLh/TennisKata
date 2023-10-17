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

        [Test]
        public void Score_result_should_be_15_when_incrementing_one_time()
        {
            var score = new Score();

            score.Increment();
            var result = score.Result;

            result.Should().Be("15");
        }
    }

    public class Score
    {

        private string result = "love";

        public string Result
        {
            get => result;
            set => result = value;
        }

        public void Increment()
        {
            result = "15";
        }
    }
}