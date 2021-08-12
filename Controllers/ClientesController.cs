using Microsoft.AspNetCore.Mvc;
using Services.Validators;

namespace StandBy.Controllers
{
    public class ClientesController : Controller
    {
        private IBaseService<Cliente> _baseUserService;

        public ClientesController(IBaseService<Cliente> baseUserService)
        {
            _baseUserService = baseUserService;
        }

        //ClienteViewModel clienteView = new ClienteViewModel();

        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create([FromBody] Cliente cliente)
        {
            if (cliente == null)
                return NotFound();

            var u = _baseUserService.Add<ClienteValidator>(cliente).Id;
            
            return View(u);
              
        }


























    }
}
