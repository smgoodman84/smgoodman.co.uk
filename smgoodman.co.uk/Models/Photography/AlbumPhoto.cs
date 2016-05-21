namespace smgoodman.co.uk.Models.Photography
{
    public class AlbumPhoto
    {
        public Photo Photo { get; set; }
        public AlbumPhoto Previous { get; set; }
        public AlbumPhoto Next { get; set; }
    }
}