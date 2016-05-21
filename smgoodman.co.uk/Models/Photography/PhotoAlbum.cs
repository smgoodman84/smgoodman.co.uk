using System.Collections.Generic;
using System.Linq;

namespace smgoodman.co.uk.Models.Photography
{
    public class PhotoAlbum
    {
        public PhotoAlbum(IEnumerable<Photo> photos)
        {
            Photos = photos.ToList();
        }

        public List<Photo> Photos { get; }

        public List<PhotoList> AsColumns(int columns)
        {
            var albumPhotos = AlbumPhotos();
            return PhotoList.SortIntoColumns(albumPhotos, columns);
        }

        public List<AlbumPhoto> AlbumPhotos()
        {
            var result = new List<AlbumPhoto>();
            var head = AlbumPhoto(Photos, null);

            var curr = head;
            while (true)
            {
                result.Add(curr);
                if (curr.Next == null)
                {
                    curr.Next = head;
                    head.Previous = curr;
                    break;
                }
                curr = curr.Next;
            }
            return result;
        }

        private static AlbumPhoto AlbumPhoto(IReadOnlyCollection<Photo> photos, AlbumPhoto previous)
        {
            if (photos.Count == 0)
            {
                return null;
            }

            var head = photos.First();
            var tail = photos.Skip(1).ToList();

            var headPhoto = new AlbumPhoto
            {
                Photo = head,
                Previous = previous
            };

            var tailPhotos = AlbumPhoto(tail, headPhoto);

            headPhoto.Next = tailPhotos;

            return headPhoto;
        }
    }
}