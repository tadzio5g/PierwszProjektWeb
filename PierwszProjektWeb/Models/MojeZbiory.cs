using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PierwszProjektWeb.Models
{
    public class MojeZbiory
    {
        public List<Ksiazka> Ksiazki { get; set; }
        public List<Film> Filmy { get; set; }
    }
}