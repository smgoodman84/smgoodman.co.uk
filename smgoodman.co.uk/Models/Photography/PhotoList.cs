using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smgoodman.co.uk.Models.Photography
{
    public class PhotoList
    {
        private List<PhotoList> _photoLists { get; set; }
        private List<AlbumPhoto> _photos { get; set; }

        public PhotoList(List<AlbumPhoto> photos)
        {
            _photos = photos;
        }

        public List<AlbumPhoto> Photos { get { return _photos; } }




        private class MeasuredPhotoList
        {
            private int _margin = 0;
            private int _height = 0;
            private List<AlbumPhoto> _photos = new List<AlbumPhoto>();

            public int Height { get { return _height; } }
            public List<AlbumPhoto> Photos { get { return _photos.ToList(); } }

            public MeasuredPhotoList(int margin)
            {
                _margin = margin;
            }

            public void Add(AlbumPhoto photo)
            {
                _height += (int)photo.Photo.Height + _margin;
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
            for (int i = 0; i < columns; i++)
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