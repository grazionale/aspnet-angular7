using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SotranTeste.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SotranTeste.Controllers
{
    [RoutePrefix("api/Cidade")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CidadeController : ApiController
    {
        private static List<Cidade> cidades = new List<Cidade>();

        public List<Cidade> Get()
        {   
            return cidades;
        }


        public void Post(string logradouro)
        {
            if(!string.IsNullOrEmpty(logradouro))
                cidades.Add(new Cidade(logradouro));
        }

        public void Delete(string logradouro)
        {
            try
            {
                cidades.RemoveAt(cidades.IndexOf(cidades.First(x => x.logradouro.Equals(logradouro))));
            }
            catch(Exception e)
            {
                
            }
            
        }

        [HttpGet]
        [Route("BuscarLogradouro/{log}")]
        public IHttpActionResult BuscarLogradouro(String log)
        {
            Cidade x = new Cidade();
            string url = "http://apps.widenet.com.br/busca-cep/api/cep/" + log;

            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            var json = client.DownloadString(url);
            x.logradouro = json;

            return Ok(x);
        }
    }
}
