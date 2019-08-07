using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CursosOnline.Business;
using CursosOnline.Domain;
namespace CursosOnline.Services
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Clase de servicio Restful que soporta CRUD
	/// </summary>
	public class sysdiagramsServiceController : ApiController
	{
		[HttpGet]
		public List<sysdiagrams> GetAll()
		{
		sysdiagramsBo sysdiagramsBo = new sysdiagramsBo();
		return sysdiagramsBo.GetAll();
		}
		[HttpGet]
		public sysdiagrams GetOne(int diagram_id)
		{
		sysdiagramsBo sysdiagramsBo = new sysdiagramsBo();
		sysdiagrams entity = new sysdiagrams() { diagram_id = diagram_id };
		return sysdiagramsBo.SelectByKey(entity);
		}
		[HttpPost]
		public sysdiagrams New(sysdiagrams entity)
		{
		sysdiagramsBo sysdiagramsBo = new sysdiagramsBo();
		return sysdiagramsBo.Insert(entity);
		}
		[HttpPut]
		public sysdiagrams Update(sysdiagrams entity)
		{
		sysdiagramsBo sysdiagramsBo = new sysdiagramsBo();
		return sysdiagramsBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int diagram_id)
		{
		sysdiagramsBo sysdiagramsBo = new sysdiagramsBo();
		sysdiagrams entity = new sysdiagrams() { diagram_id = diagram_id };
		return sysdiagramsBo.Delete(entity);
		}
	}
}
