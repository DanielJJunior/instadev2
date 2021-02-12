using System.IO;
using instadev2.Interface;

namespace instadev2.Models
{
    public class Usuario : Instadev, IUsuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }

        public const string PATH = "Database/Usuario.csv";
        public string PrepararLinha(Usuario u) 
        {
            return $"{u.IdUsuario};{u.nome};{u.Foto};{u.DataNascimento};{u.Email};{u.Username};{u.Senha}"; 
        }
        public void Cadastrar(Usuario user)
        {
            string[] linha = { PrepararLinha(u) };
            File.AppendAllLines(PATH, linha);
        }


    }
}