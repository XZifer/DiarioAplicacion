using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioAplicacion
{
    public class Diario
    {
        //Constructor<Valida si existe el archivo y si no lo crea

        public string RutaDelArchivoDelDiario { get; set; }
        public string NombreDelArchivoDelDiario { get; set; }

        //Regresa true si existe el archivo del diario en la ruta
        public bool ExisteArchivoDiario()
        {
            return NombreDelArchivoDelDiario != null;   
        }
        //Crea el archivo del diario si no existe, y regresa true si existe, o false si no existe
        public bool CrearArchivoDiario()
        {
            return ExisteArchivoDiario != null;
        }    
        public bool EscribirDiario(string texto)
        {
            return true;
        }
        public string LeerDiario(string texto)
        {
            return texto;
        }

    }
}
