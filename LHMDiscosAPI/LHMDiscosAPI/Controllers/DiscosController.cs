using LHMDiscosAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LHMDiscosAPI.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DiscosController : ApiController
    {
        static readonly IDiscoRepositorio repositorio = new DiscoRepositorio();

        
        public IEnumerable<Disco> GetAllDiscos()
        {
            return repositorio.GetAll();
        }
        public Disco GetDisco(int id)
        {
            Disco item = repositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }

        public IEnumerable<Disco> GetDiscosPorGenero(string genero)
        {
            return repositorio.GetAll().Where(
                p => string.Equals(p.Genero, genero, StringComparison.OrdinalIgnoreCase));
        }

        public HttpResponseMessage PostDisco(Disco item)
        {
            item = repositorio.Add(item);
            var response = Request.CreateResponse<Disco>(HttpStatusCode.Created, item);

            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }

        public void PutDisco(int id, Disco disco)
        {
            disco.Id = id;
            if (!repositorio.Update(disco))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public void DeleteDisco(int id)
        {
            Disco item = repositorio.Get(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repositorio.Remove(id);
        }
    }
}