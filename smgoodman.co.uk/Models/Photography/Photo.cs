using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smgoodman.co.uk.Models.Photography
{
    public class Photo
    {
        private string _filename { get; set; }
        private int _width { get; set; }
        private int _height { get; set; }

        public Photo(string filename, int width, int height)
        {
            _filename = filename;
            _width = width;
            _height = height;
        }

        public string Filename { get { return _filename; } }
        public int Width { get { return _width; } }
        public int Height { get { return _height; } }

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