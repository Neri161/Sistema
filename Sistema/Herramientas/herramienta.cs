using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Sistema.Herramientas
{
    public class herramienta
    {
        public string GetSHA256(string str)
        {
            SHA256 sha256 = new SHA256Managed();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public int convertirEpoch(DateTime fecha)
        {
            DateTime fechaInicial = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            int epoch = (int)Math.Round((fecha.ToUniversalTime() - fechaInicial).TotalSeconds, 0);
            return epoch;
        }
        public DateTime convertirFecha(int epoch)
        {
            DateTime fechaInicial = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            fechaInicial = fechaInicial.AddSeconds((double)epoch).ToLocalTime();

            return fechaInicial;
        }
    }
}