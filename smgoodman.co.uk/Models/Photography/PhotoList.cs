using System.Collections.Generic;
using System.Linq;

namespace smgoodman.co.uk.Models.Photography
{
    public class PhotoList
    {
        public List<AlbumPhoto> Photos { get; }

        public PhotoList(List<AlbumPhoto> photos)
        {
            Photos = photos;
        }

        private class MeasuredPhotoList
        {
            private readonly int _margin;
            private readonly List<AlbumPhoto> _photos = new List<AlbumPhoto>();

            public int Height { get; private set; }

            public MeasuredPhotoList(int margin)
            {
                _margin = margin;
            }

            public void Add(AlbumPhoto photo)
            {
                Height += photo.Photo.Height + _margin;
                _photos.Add(photo);
            }

            public PhotoList ToPhotoList()
            {
                return new PhotoList(_photos);
            }
        }

        public static List<PhotoList> SortIntoColumns(List<AlbumPhoto> photos, int columns = 2)
        {
            var measuredPhotoLists = new List<MeasuredPhotoList>();
            for (var i = 0; i < columns; i++)
            {
                measuredPhotoLists.Add(new MeasuredPhotoList(30));
            }

            foreach (var photo in photos)
            {
                var smallestPhotoList = measuredPhotoLists.OrderBy(x => x.Height).First();
                smallestPhotoList.Add(photo);
            }

            return measuredPhotoLists
                .Select(x => x.ToPhotoList())
                .ToList();
        }
    }
}