public class Volume
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }

    public Volume(double height, double width, double depth)
    {
        Height = height;
        Width = width;
        Depth = depth;

    }

    public double TotalVolume()
    {
        return Height * Width * Depth;
    }

}
