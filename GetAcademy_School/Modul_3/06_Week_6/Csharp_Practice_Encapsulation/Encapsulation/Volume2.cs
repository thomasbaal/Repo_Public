public class Volume2
{
    public double Height { get; private set; }
    public double Width { get; private set; }
    public double Depth { get; private set; }
    public double Volume 
    { get
        {
            return Volume;

        }
        private set
        {
            Volume = Height * Width * Depth;
        }
    }

    public Volume2(double height, double width, double depth)
    {
        Height = height;
        Width = width;
        Depth = depth;


    }

  

}
