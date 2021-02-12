using Microsoft.AspNetCore.Mvc;
namespace instadev2.Controllers
{
    public class CadastroControler : Controllers
    {
        public IActionResult Index(){
            return View();
        }
    }
}