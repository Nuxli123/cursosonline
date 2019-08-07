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
	public class UsuariosRolesServiceController : ApiController
	{
		[HttpGet]
		public List<UsuariosRoles> GetAll()
		{
		UsuariosRolesBo UsuariosRolesBo = new UsuariosRolesBo();
		return UsuariosRolesBo.GetAll();
		}
		[HttpGet]
		public UsuariosRoles GetOne(int UsuarioId, int RoleId)
		{
		UsuariosRolesBo UsuariosRolesBo = new UsuariosRolesBo();
		UsuariosRoles entity = new UsuariosRoles() { UsuarioId = UsuarioId, RoleId = RoleId };
		return UsuariosRolesBo.SelectByKey(entity);
		}
		[HttpPost]
		public UsuariosRoles New(UsuariosRoles entity)
		{
		UsuariosRolesBo UsuariosRolesBo = new UsuariosRolesBo();
		return UsuariosRolesBo.Insert(entity);
		}
		[HttpPut]
		public UsuariosRoles Update(UsuariosRoles entity)
		{
		UsuariosRolesBo UsuariosRolesBo = new UsuariosRolesBo();
		return UsuariosRolesBo.Update(entity);
		}
		[HttpDelete]
		public bool Delete(int UsuarioId, int RoleId)
		{
		UsuariosRolesBo UsuariosRolesBo = new UsuariosRolesBo();
		UsuariosRoles entity = new UsuariosRoles() { UsuarioId = UsuarioId, RoleId = RoleId };
		return UsuariosRolesBo.Delete(entity);
		}
	}
}
