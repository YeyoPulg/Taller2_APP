using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PyR.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            users = new List<User>();
            users.Add(new User(username: "YeyoP0", password: "123", email: "yessid@gmail.com", name: "Yessid"));
            users.Add(new User(username: "YeyoP1", password: "456", email: "yessid@gmail.com", name: "Yessid"));
            users.Add(new User(username: "YeyoP2", password: "789", email: "yessid@gmail.com", name: "Yessid"));
        }

        List<User> users;

        [HttpGet("login")]
        public dynamic Auth(string username, string password)
        {
            try
            {
                var user = users.Where(u => username == u.username).ToList();
                if (user.Count() == 0)
                {
                    return new
                    {
                        status = 404,
                        message = "Usuario no encontrado"
                    };
                }
                var passwordMatch = users.Where(u => password == u.password).ToList();
                if (passwordMatch.Count() == 0)
                {
                    return new
                    {
                        status = 401,
                        message = "Contraseña no es correcta"
                    };
                }

                return new
                {
                    status = 200,
                    message = "Autenticacion exitosa"
                };

            }
            catch (Exception err)
            {
                return new
                {
                    status = 500,
                    message = "Internal server error " + err
                };
            }
        }

        [HttpGet("user/{id}")]
        public ActionResult<User> getUser(int id)
        {
            return users[id];
        }
    }
}
