namespace TennisKata;

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

    public static bool operator == (Score score, Score other)
    {
        return score.Result == other.Result;
    }

    public static bool operator !=(Score score, Score other)
    {
        return !(score == other);
    }
}