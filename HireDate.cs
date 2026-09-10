using System;
 
public class HireDate
{
    private int _day;
    private int _month;
    private int _year;
 
    public int Day
    {
        get { return _day; }
        set { _day = (value >= 1 && value <= 31) ? value : 1; }
    }
 
    public int Month
    {
        get { return _month; }
        set { _month = (value >= 1 && value <= 12) ? value : 1; }
    }
 
    public int Year
    {
        get { return _year; }
        set { _year = value > 0 ? value : 2000; }
    }
 
    public HireDate()
    {
        Day = 1;
        Month = 1;
        Year = 2000;
    }
 
    public HireDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }
 
    public override string ToString()
    {
        return $"{Day}/{Month}/{Year}";
    }
}