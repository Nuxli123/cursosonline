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
	public class RolesServiceController : ApiController
	{
		[HttpGet]
		public List<Roles> GetAll()
		{
		RolesBo RolesBo = new RolesBo();
		return RolesBo.GetAll();
		}
		[HttpGet]
		public Roles GetOne(int Id)
		{
		RolesBo RolesBo = new RolesBo();
		Roles entity = new Roles() { Id = Id };
		return RolesBo.SelectByKey(entity);
		}
		[HttpPost]
		public Roles New(Roles entity)
		{
		RolesBo RolesBo = new RolesBo();
		return RolesBo.Insert(entity);
		}
		[HttpPut]
		public Roles Update(Roles entity)
		{
		RolesBo RolesBo = new RolesBo();
		return RolesBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int Id)
		{
		RolesBo RolesBo = new RolesBo();
		Roles entity = new Roles() { Id = Id };
		return RolesBo.Delete(entity);
		}
	}
}
