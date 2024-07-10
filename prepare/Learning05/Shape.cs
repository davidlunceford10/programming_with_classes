abstract class Shape
{
    private string _paperColor = null;

    public Shape(string paperColor)
    {
        _paperColor = paperColor;
    }

    public string GetColor()
    {
        return _paperColor;
    }

    public abstract double GetArea();

}