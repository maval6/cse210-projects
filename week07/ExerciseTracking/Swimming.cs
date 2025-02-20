class Swimming : Activity
{
    private int _laps;
    private const double LapLength = 50.0 / 1000; // 50 meters per lap, converted to km

    public Swimming(DateTime date, int minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * LapLength;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();
}
