using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGIKino_KP
{
    class FilmsLibraly
    {
        private string filmName;
        private string typrProjekciq;

        public string FilmName 
        { 
            get => filmName; 
            set => filmName = value; 
        }
        public string TyprProjekciq 
        { 
            get => typrProjekciq; 
            set => typrProjekciq = value; 
        }
    }
}
