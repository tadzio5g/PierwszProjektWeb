using PierwszProjektWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PierwszProjektWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult WszystkieKsiazki()
        {
            //tutaj można wczytać z bazy danych i przekazać do View

            var listaKsiazek = new List<Ksiazka>();
            for (int i = 0; i<10; i++)
            {
                var ksiazka1 = new Ksiazka() { Nazwa = "harry potter" + i, Autor = "rowling" + i, Rok = "2011" + i };
                listaKsiazek.Add(ksiazka1);
            }            

            return View(listaKsiazek); //tutaj w parametrze przekazujemy dane do View
        }


        public ActionResult BibliotekaFilmow()
        {
            //tutaj można wczytać z bazy danych i przekazać do View

            var bibliotekaFilmow = new List<Film>();  // nie kumam tego zapisu, nie jestem az tak wtajemniczony
            for (int i = 0; i < 10; i++) //tutaj jest 10 obrotów pętli
            {
                var dupa123 = new Film()
                {
                    Nazwa = "harry potter" + i, //tutaj jest sklejka "harry potter" plus indeks w p
                    Autor = "rowling" + i,
                    Rok = "2011" + i
                };
                bibliotekaFilmow.Add(dupa123); //tutaj dodaje do listy
            }

            var listaKsiazek = new List<Ksiazka>();
            for (int i = 0; i < 10; i++)
            {
                var ksiazka1 = new Ksiazka() { Nazwa = "harry potter" + i, Autor = "rowling" + i, Rok = "2011" + i };
                listaKsiazek.Add(ksiazka1);
            }


            var mojeZbiory = new MojeZbiory() { Ksiazki = listaKsiazek, Filmy = bibliotekaFilmow };

            return View(mojeZbiory); //tutaj w parametrze przekazujemy dane do View
        }


    }
}