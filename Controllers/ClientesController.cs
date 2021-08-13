using Microsoft.AspNetCore.Mvc;
using Services.Validators;
using StandBy.Models;

namespace StandBy.Controllers
{
    public class ClientesController : Controller
    {
        private IBaseService<Cliente> _baseUserService;

        public ClientesController(IBaseService<Cliente> baseUserService)
        {
            _baseUserService = baseUserService;
        }

       
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create([FromBody] ClienteViewModel cliente)
        {
            if (cliente == null)
                return NotFound();

            var clienteCriado = _baseUserService.Add<ClienteValidator>(new Cliente()
             {
                 Capital=cliente.Capital,
                 Classificacao= cliente.Classificacao,
                 Cnpj=cliente.Cnpj,
                 Data_Fundacao = cliente.Data_Fundacao,
                 Quarentena =cliente.Quarentena,
                 Status_Cliente = cliente.Status_Cliente,
                 Razao_Social = cliente.Razao_Social
                 
             });
            
            return View(clienteCriado);
              
        }


























    }
}
