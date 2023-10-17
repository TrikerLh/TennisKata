using FluentAssertions;

namespace TennisKata.Tests {
    public class ResultGiven
    {
        private Score score;

        [SetUp] 
        public void Setup() {
            score = new Score();
        }

        [Test]
        public void Love_should_be_the_first_score()
        {
            var result = score.Result;

            result.Should().Be("love");
        }

        [Test]
        public void Score_result_should_be_15_when_incrementing_one_time()
        {
            score.Increment();
            var result = score.Result;

            result.Should().Be("15");
        }

        [Test]
        public void Score_result_should_be_30_when_incrementing_twice() {
            score.Increment();
            score.Increment();
            var result = score.Result;

            result.Should().Be("30");
        }
    }

    public class Score
    {

        private string _result = "love";

        public string Result
        {
            get => _result;
            set => _result = value;
        }

        public void Increment()
        {
            if (_result == "15")
                _result = "30";
            else
                _result = "15";
        }
    }
}