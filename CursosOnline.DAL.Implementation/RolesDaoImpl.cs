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
	public class RolesDaoImpl : Abstracts.BaseDaoImpl, RolesDao
	{
		public List<Roles> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Roles>("dbo.usp_RolesSelect @Id={0}", parameters).ToList();
		}

		public Roles SelectByKey(Roles entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Database.SqlQuery<Roles>("dbo.usp_RolesSelect @Id={0}", parameters).FirstOrDefault();
		}

		public Roles Update(Roles entity)
		{
			object[] parameters = new object[] { entity.Id, entity.Nombre };
			return Context.Database.SqlQuery<Roles>("dbo.usp_RolesUpdate @Id={0}, @Nombre={1}", parameters).FirstOrDefault();
		}

		public Roles Insert(Roles entity)
		{
			object[] parameters = new object[] { entity.Nombre };
			return Context.Database.SqlQuery<Roles>("dbo.usp_RolesInsert @Nombre={0}", parameters).FirstOrDefault();
		}

		public bool Delete(Roles entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_RolesDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
