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
	public class UsuariosServiceController : ApiController
	{
		[HttpGet]
		public List<Usuarios> GetAll()
		{
		UsuariosBo UsuariosBo = new UsuariosBo();
		return UsuariosBo.GetAll();
		}
		[HttpGet]
		public Usuarios GetOne(int Id)
		{
		UsuariosBo UsuariosBo = new UsuariosBo();
		Usuarios entity = new Usuarios() { Id = Id };
		return UsuariosBo.SelectByKey(entity);
		}
		[HttpPost]
		public Usuarios New(Usuarios entity)
		{
		UsuariosBo UsuariosBo = new UsuariosBo();
		return UsuariosBo.Insert(entity);
		}
		[HttpPut]
		public Usuarios Update(Usuarios entity)
		{
		UsuariosBo UsuariosBo = new UsuariosBo();
		return UsuariosBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int Id)
		{
		UsuariosBo UsuariosBo = new UsuariosBo();
		Usuarios entity = new Usuarios() { Id = Id };
		return UsuariosBo.Delete(entity);
		}
	}
}
