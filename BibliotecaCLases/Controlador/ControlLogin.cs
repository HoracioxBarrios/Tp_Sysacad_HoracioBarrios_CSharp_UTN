using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;


namespace BibliotecaCLases.Controlador
{
    /// <summary>
    /// Clase que gestiona la autenticación de usuarios y la carga de usuarios desde un archivo JSON.
    /// </summary>
    public class ControlLogin
    {
        private Usuario? _usuario;
        private readonly Dictionary<int, Usuario> dictUsuarios;
        private string _path;
        private bool _existeUsuario;

        /// <summary>
        /// Inicializa una nueva instancia de la clase ControlLogin.
        /// </summary>
        /// <remarks>
        /// Este CONSTRUCTOR se utiliza para gestionar la carga de usuarios desde un archivo JSON.
        /// Si el archivo no existe o está vacío, se crea una lista de usuarios predeterminada
        /// y se guarda en el archivo JSON especificado.
        /// </remarks>
        public ControlLogin()
        {
            int nivelesARetroceder = 4;
            _path = PathManager.ObtenerRuta("Data", "DataUsuarios.json", nivelesARetroceder);

            dictUsuarios = Serializador.LeerJson<Dictionary<int, Usuario>>(_path);

            _existeUsuario = true;
            if (dictUsuarios == null || dictUsuarios.Count == 0)
            {

                string pathUltimoLegajo = PathManager.ObtenerRuta("Data", "Legajo.json");
                int ultimoLegajoEnArchivo = Serializador.LeerJson<int>(pathUltimoLegajo);
                ultimoLegajoEnArchivo++;

                _existeUsuario = false;

                dictUsuarios = new Dictionary<int, Usuario>();
                String contrasena  =PasswordHashing.GetHash("11");
                
                Administrador administrador = new Administrador("matias", "cantero", "011", "correo@nuevo.com",contrasena);
                String contrasenaDos = PasswordHashing.GetHash("11");

                Administrador administradorDos = new Administrador("dian", "iry", "022", "correo@nuevo.com", contrasenaDos);
                ultimoLegajoEnArchivo++;
                administrador.Legajo = ultimoLegajoEnArchivo;
                ultimoLegajoEnArchivo++;
                administradorDos.Legajo = ultimoLegajoEnArchivo;
                int dniadmin1 = int.Parse(administrador.Dni);
                int dniadmin2 = int.Parse(administradorDos.Dni);
                dictUsuarios.Add(administrador.Legajo, administrador);
                dictUsuarios.Add(administradorDos.Legajo, administradorDos);
              

                Serializador.GuardarAJson(ultimoLegajoEnArchivo, pathUltimoLegajo);
                Serializador.GuardarAJson(dictUsuarios, _path);
            }

        }

        /// <summary>
        /// verifica si en la lista usuarios uno que coincide con la contraseña y el dni
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="contrasena"></param>
        /// <returns>bool</returns>
        public bool AutenticarUsuario(string dni, string contrasena)
        {
            _usuario = dictUsuarios.FirstOrDefault(pair => pair.Value.Dni == dni).Value;

            if (_usuario != null)
            {
                if (PasswordHashing.ValidatePassword(contrasena, _usuario.Clave))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Obtiene el valor usuraio.
        /// </summary>
        public Usuario GetUsuario
        {
            get { return _usuario; }
        }

        /// <summary>
        /// Obtiene un valor que indica si existe al menos un usuario en la lista.
        /// </summary>
        public bool ExisteUsuario
        {
            get { return _existeUsuario; }

        }
    }
}
