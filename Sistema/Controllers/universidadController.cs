using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sistema.Models;

namespace Sistema.Controllers
{
    public class universidadController : ApiController
    {
        [ActionName("inicioSesion")]
        [HttpPost]
        public Reply login(Universidad objeto)
        {
            using (DB conectar = new DB())
            {
                Reply rp = new Reply();
                try
                {
                    Universidad usuarioObtenido = conectar.Universidad.Where(x => x.ClaveUniversidad == objeto.ClaveUniversidad).First();
                    if (usuarioObtenido.ClaveUniversidad == objeto.ClaveUniversidad)
                    {
                        if (usuarioObtenido.Password == objeto.Password)
                        {
                            rp.result = 1;
                            rp.data = Guid.NewGuid().ToString();
                            rp.message = "Ingreso exitoso";
                            //rp.ID = usuarioObtenido.IdUsuario;
                            //usuarioObtenido.Token_ = (String)rp.data;
                            conectar.Entry(usuarioObtenido).State = System.Data.Entity.EntityState.Modified;
                            conectar.SaveChanges();
                            return rp;
                        }
                        else
                        {
                            rp.result = 0;
                            rp.message = "Datos incorrectos";
                            return rp;
                        }
                    }
                    else
                    {
                        rp.result = 0;
                        rp.message = "Usuario inexistente";
                        return rp;
                    }
                }
                catch (Exception ex)
                {
                    rp.result = 0;
                    rp.message = "Ha ocurrido un error: "+ex;
                    return rp;
                }
            }

        }
    }
}