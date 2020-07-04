using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace novo
namespace QuintoDia.Extensions
{
    // classe static
    public static class StringEtensions
    {
        // metodo statico + palavra reservada "this" como argemento do método
        public static string Pluralize(this string texto)
        {
            if (texto.EndsWith("s"))
            {
                return texto;
            }
            else
            {
                return texto + "s";
            }
        }
    }
}
