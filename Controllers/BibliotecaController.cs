using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    [ApiController]
    [Route("Biblioteca")]
    public class BibliotecaController : ControllerBase
    {
        private readonly ILogger<BibliotecaController> _logger;

        public BibliotecaController(ILogger<BibliotecaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetListCarti")]
        public IEnumerable<Carte> GetListCarti()
        {
            var carti = new List<Carte>
    {
        new Carte { Titlu = "REST API Design Rulebook", Autor = "Mark Masse", Sumar = "Un ghid pentru construirea API-urilor RESTful robuste și eficiente." },
        new Carte { Titlu = "Designing Web APIs", Autor = "Brenda Jin, Saurabh Sahni, Amir Shevat", Sumar = "Principii pentru proiectarea API-urilor web ce oferă experiențe excelente pentru utilizatori." },
        new Carte { Titlu = "API Security in Action", Autor = "Neil Madden", Sumar = "Explorarea conceptelor de securitate pentru protejarea API-urilor moderne." },
        new Carte { Titlu = "Node.js Design Patterns", Autor = "Mario Casciaro, Luciano Mammino", Sumar = "Un ghid complet pentru utilizarea Node.js pentru servere scalabile." },
        new Carte { Titlu = "You Don’t Know JS: Scope & Closures", Autor = "Kyle Simpson", Sumar = "Un studiu detaliat despre funcționalitățile avansate ale JavaScript-ului." },
        new Carte { Titlu = "Eloquent JavaScript", Autor = "Marijn Haverbeke", Sumar = "Un ghid profund despre limbajul JavaScript, destinat programatorilor de toate nivelurile." },
        new Carte { Titlu = "Pro MERN Stack", Autor = "Vasan Subramanian", Sumar = "Construirea aplicațiilor web utilizând MongoDB, Express.js, React și Node.js." },
        new Carte { Titlu = "Flask Web Development", Autor = "Miguel Grinberg", Sumar = "O introducere în dezvoltarea aplicațiilor web folosind Flask, un micro-framework Python." },
        new Carte { Titlu = "Django for APIs", Autor = "William S. Vincent", Sumar = "Crearea și utilizarea API-urilor eficiente cu Django și Django REST Framework." },
        new Carte { Titlu = "The Road to React", Autor = "Robin Wieruch", Sumar = "Un ghid pas cu pas pentru a învăța React și a dezvolta aplicații interactive." },
        new Carte { Titlu = "Learning PHP, MySQL & JavaScript", Autor = "Robin Nixon", Sumar = "Un ghid complet pentru dezvoltarea aplicațiilor web folosind PHP, MySQL și JavaScript." },
        new Carte { Titlu = "Mastering API Architecture", Autor = "James Higginbotham", Sumar = "O explorare aprofundată a arhitecturilor API scalabile și fiabile." },
        new Carte { Titlu = "Web Development with Go", Autor = "Shiju Varghese", Sumar = "Un ghid practic pentru dezvoltarea aplicațiilor web rapide și scalabile cu Go." },
        new Carte { Titlu = "High Performance Browser Networking", Autor = "Ilya Grigorik", Sumar = "Un ghid complet despre optimizarea performanței rețelei pentru aplicații web." },
        new Carte { Titlu = "Web API Design", Autor = "Brian Mulloy", Sumar = "Cele mai bune practici pentru proiectarea API-urilor care sunt ușor de utilizat și bine documentate." },
        new Carte { Titlu = "Clean Code", Autor = "Robert C. Martin", Sumar = "Un ghid esențial pentru a scrie cod curat și ușor de întreținut." },
        new Carte { Titlu = "Building Microservices", Autor = "Sam Newman", Sumar = "O carte despre arhitectura microserviciilor și cum să construim sisteme modulare." },
        new Carte { Titlu = "JavaScript: The Good Parts", Autor = "Douglas Crockford", Sumar = "Explorarea caracteristicilor esențiale ale limbajului JavaScript." },
        new Carte { Titlu = "Fullstack D3 and Data Visualization", Autor = "Amelia Wattenberger", Sumar = "Învață să creezi vizualizări de date dinamice folosind biblioteca D3.js." },
        new Carte { Titlu = "Vue.js Up & Running", Autor = "Callum Macrae", Sumar = "Un ghid rapid pentru a învăța și a folosi framework-ul Vue.js pentru aplicații web moderne." }
    };

            return carti;
        }




    }
}
