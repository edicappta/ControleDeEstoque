using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = @"DESKTOP-0FP5CDN";
        public static String banco = "ControleDeEstoque";
        public static String usuario = "sa";
        public static String senha = "Qwerty@#$1515";
        public static String StringDeConexao
        {
            get 
            {
                return @"Data Source="+servidor+";Initial Catalog="+banco+";User ID="+usuario+";Password="+senha;
            }
        }
    }
}
