using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Modelos.requestResponse;
using Modelos;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using Utilitarios;

namespace back_gasper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        UsuarioLogic userLogica = new UsuarioLogic();

        /// <summary>
        /// indica que el servicio esta activo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult get()
        {
            return Ok("servicio en escucha");
        }

        /// <summary>
        /// realiza el proceso de login
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult post([FromBody] LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            UsuarioModel user = userLogica.ObtenerUsuarioPorUserrName(request.num_documento);

            if (
                !( // "!" significa negación
                user.num_documento == request.num_documento
                && user.password == UtilSecurity.encriptar_AES(request.password))
                )
            {
                return BadRequest("Usuario y/o password incorrecto");
            }

            user.password = "";
            string token = generateToken(user, 200);
            response.token = token;
            response.user = user;

            return Ok(response);
        }

        private string generateToken(UsuarioModel user, int expireInMinutes)
        {
            //create claims details based on the user information
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.AddJsonFile("appsettings.json");
            IConfiguration configurationFile = configurationBuild.Build();
            // Leemos el archivo de configuración.
            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, configurationFile["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("idusuario", user.idusuario.ToString()),
                        new Claim("nombres", user.nombres),
                        new Claim("numerodocumento", user.num_documento),
                        new Claim(ClaimTypes.Role, user.idrol.ToString()),
                        new Claim("Email", user.email)
                    };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configurationFile["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                configurationFile["Jwt:Issuer"],
                configurationFile["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(expireInMinutes),
                signingCredentials: signIn);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
