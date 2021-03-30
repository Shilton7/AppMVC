using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Shilton",
                Email = "shi@gmail.com",
                DataNascimento = DateTime.Now
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}
