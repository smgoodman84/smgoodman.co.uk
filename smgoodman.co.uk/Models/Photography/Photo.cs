namespace smgoodman.co.uk.Models.Photography
{
    public class Photo
    {
        public Photo(string filename, int width, int height)
        {
            Filename = filename;
            Width = width;
            Height = height;
        }

        public string Filename { get; }
        public int Width { get; }
        public int Height { get; }

        public string AsJavaScriptObject()
        {
            return 
                    "{"
                + "Filename: \"" + Filename + "\", "
                + "Width: " + Width + ", "
                + "Height: " + Height
                +   "}";
        }
    }
}