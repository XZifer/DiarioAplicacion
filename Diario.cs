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

        public Diario()
        {
            RutaDelArchivoDelDiario = @"C:\Users\Luis Fernando\Desktop\Diario";
        }

        //Regresa true si existe el archivo del diario en la ruta
        public bool ExisteArchivoDiario()
        {
            return NombreDelArchivoDelDiario != null;   
        }
        //Crea el archivo del diario si no existe, y regresa true si existe, o false si no existe
        public bool CrearArchivoDiario()
        {
            if (ExisteArchivoDiario())
            {
                return false;
            }
            else
            {
                RutaDelArchivoDelDiario = System.IO.Path.Combine(RutaDelArchivoDelDiario, NombreDelArchivoDelDiario);
                return true;
            }
        }    
        public string EscribirDiario(string RutaDelArchivoDelDiario)
        {
            if (ExisteArchivoDiario())
            {
                string EntradaDeTexto = Console.ReadLine();
                StreamWriter sw = new StreamWriter(NombreDelArchivoDelDiario, true);
                sw.WriteLine(EntradaDeTexto);
                sw.Close();
                return "Entrada Exitosa";
            }
            else
            {
                CrearArchivoDiario();
                string EntradaDeTexto = Console.ReadLine();
                StreamWriter sw = new StreamWriter(NombreDelArchivoDelDiario, true);
                sw.WriteLine(EntradaDeTexto);
                sw.Close();
                return "Entrada Exitosa";

            }

        }
        public string LeerDiario(string diarioNombre)
        {
            if (ExisteArchivoDiario())
            {
                StreamReader sr = new StreamReader(diarioNombre);
                string texto = null;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    texto += (line + "\n");
                    line = sr.ReadLine();
                }
                sr.Close();
                return texto;
            }
            else
            {
                return "UPS el Diario no se ha encointrado";
            }
           
        }

    }
}
