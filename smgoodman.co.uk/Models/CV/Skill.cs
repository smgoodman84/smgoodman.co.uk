using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smgoodman.co.uk.Models.CV
{
    public class Skill
    {
        private string _name;

        public Skill(string name)
        {
            _name = name;
        }

        public string name {get { return _name; } }
    }
}