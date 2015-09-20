using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smgoodman.co.uk.Models.Photography
{
    public class Photography
    {
        public static PhotoAlbum Album =  new PhotoAlbum(
            new List<Photo>
            {
                new Photo("0001.jpg",225,150),
                new Photo("0002.jpg",225,150),
                new Photo("0003.jpg",225,150),
                new Photo("0004.jpg",225,150),
                new Photo("0005.jpg",225,150),
                new Photo("0006.jpg",225,93),
                new Photo("0007.jpg",225,225),
                new Photo("0008.jpg",225,150),
                new Photo("0009.jpg",225,225),
                new Photo("0010.jpg",225,150),
                new Photo("0011.jpg",225,225),
                new Photo("0012.jpg",225,150),
                new Photo("0013.jpg",225,113),
                new Photo("0014.jpg",225,338),
                new Photo("0015.jpg",225,225),
                new Photo("0016.jpg",225,225),
                new Photo("0017.jpg",225,150),
                new Photo("0018.jpg",225,75),
                new Photo("0019.jpg",225,338),
                new Photo("0020.jpg",225,150),
                new Photo("0021.jpg",225,225),
                new Photo("0022.jpg",225,150),
                new Photo("0023.jpg",225,150),
                new Photo("0024.jpg",225,150),
            });
    }
}