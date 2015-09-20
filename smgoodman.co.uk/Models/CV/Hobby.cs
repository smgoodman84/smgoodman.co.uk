using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smgoodman.co.uk.Models.CV
{
    public class Hobby
    {
        private string _name;

        public Hobby(string name)
        {
            _name = name;
        }

        public string name {get { return _name; } }
    }
}