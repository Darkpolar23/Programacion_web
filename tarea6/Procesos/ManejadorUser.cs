//En esta parte se manejan los usuarios

using System.Text.Json;

class ManejadorUsuario
{
    public static ServerResult RegistroIncidencia(Incidencia incidencia)
    {
        if (!Directory.Exists("incidencias"))
        {
            Directory.CreateDirectory("incidencias");
        }

        var miId = Guid.NewGuid().ToString();
        var archivo = $"incidencias/{miId}.json";

        var json = JsonSerializer.Serialize(incidencia);

        File.WriteAllText(archivo, json);

        return new ServerResult(true, "Incidencia registrada");
    }

    public static ServerResult IniciarSesion(DatosLogin datos)
    {
        var cedula = datos.Cedula;
        var clave = datos.Clave;

        // Validación de la cédula
        if (cedula.Length != 11)
        {
            return new ServerResult(false, "La cédula debe tener 11 dígitos");
        }

        // Validación de la clave
        if (clave.Length == 0)
        {
            return new ServerResult(false, "La clave es obligatoria");
        }

        // Construcción de la ruta al archivo del usuario
        var archivo = $"usuarios/{cedula}.json";

        // Verificar si el archivo del usuario existe
        if (!File.Exists(archivo))
        {
            return new ServerResult(false, "Usuario no encontrado");
        }

        // Leer el contenido del archivo JSON
        var json = File.ReadAllText(archivo);

        // Deserializar el JSON en un objeto Usuario
        var usuario = JsonSerializer.Deserialize<Usuario>(json);

        // Validar la clave ingresada
        if (usuario.Clave != clave)
        {
            return new ServerResult(false, "Clave incorrecta");
        }

        usuario.Clave = "*********";

        // Si todas las validaciones son correctas, iniciar sesión
        return new ServerResult(true, "Sesión iniciada", usuario);
    }


    public static ServerResult Registro(Usuario usuario)
    {
        List<string> errores = new List<string>();

        if (usuario.Cedula.Length != 11)
        {
            errores.Add("La cedula debe de tener 11 digitos");
        };

        if (usuario.Nombre.Length == 0)
        {
            errores.Add("El nombre es obligatorio");
        };

        if (errores.Count > 0)
        {
            Console.WriteLine("errores en el registro");

            foreach (var error in errores)
            {
                Console.WriteLine(error);
            }

            return new ServerResult(false, "Errores en el registro", errores);
        };

        if (!Directory.Exists("usuarios"))
        {
            Directory.CreateDirectory("usuarios");
        }

        var archivo = $"usuarios/{usuario.Cedula}.json";

        if (File.Exists(archivo))
        {
            return new ServerResult(false, "El usuario ya existe");
        }

        var json = JsonSerializer.Serialize(usuario);

        File.WriteAllText(archivo, json);

        return new ServerResult(true, "usuario registrado");
    }
}