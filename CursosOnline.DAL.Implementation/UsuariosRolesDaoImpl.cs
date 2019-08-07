using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursosOnline.Domain;
using CursosOnline.DAL;
using CursosOnline.DataContext;
namespace CursosOnline.DAL.Implementation
{
	public class UsuariosRolesDaoImpl : Abstracts.BaseDaoImpl, UsuariosRolesDao
	{
		public List<UsuariosRoles> SelectAll()
		{
			object[] parameters = new object[] { null, null };
			return Context.Database.SqlQuery<UsuariosRoles>("dbo.usp_UsuariosRolesSelect @UsuarioId={0}, @RoleId={1}", parameters).ToList();
		}

		public UsuariosRoles SelectByKey(UsuariosRoles entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.RoleId };
			return Context.Database.SqlQuery<UsuariosRoles>("dbo.usp_UsuariosRolesSelect @UsuarioId={0}, @RoleId={1}", parameters).FirstOrDefault();
		}

		public UsuariosRoles Update(UsuariosRoles entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.RoleId };
			return Context.Database.SqlQuery<UsuariosRoles>("dbo.usp_UsuariosRolesUpdate @UsuarioId={0}, @RoleId={1}", parameters).FirstOrDefault();
		}

		public UsuariosRoles Insert(UsuariosRoles entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.RoleId };
			return Context.Database.SqlQuery<UsuariosRoles>("dbo.usp_UsuariosRolesInsert @UsuarioId={0}, @RoleId={1}", parameters).FirstOrDefault();
		}

		public bool Delete(UsuariosRoles entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.RoleId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_UsuariosRolesDelete @UsuarioId={0}, @RoleId={1}", parameters) == -1 ? true : false);
		}

	}
}
