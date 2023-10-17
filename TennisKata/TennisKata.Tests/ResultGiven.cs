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

        [TestCase(1, "15")]
        [TestCase(2, "30")]
        [TestCase(3, "40")]
        public void Test_increment(int times, string expectedResult)
        {
            for (var i = 0; i < times; i++)
            {
                score.Increment();
            }
            var result = score.Result;

            result.Should().Be(expectedResult);
        }

        [Test]
        public void True_if_are_equal()
        {
            var result = score.IsEqual(new Score());

            result.Should().BeTrue();
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
            else if (_result == "30")
                _result = "40";
            else
                _result = "15";
        }

        public bool IsEqual(Score score)
        {
            throw new NotImplementedException();
        }
    }
}