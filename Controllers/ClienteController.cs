using Services.Services;

namespace StandBy.Controllers
{
    public class ClienteController : BaseService<Cliente>
    {
        private IBaseService<Cliente> _baseUserService;

        public ClienteController(IBaseService<Cliente> baseUserService)
        {
            _baseUserService = baseUserService;
        }
    }
}
