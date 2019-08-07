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
	public class sysdiagramsDaoImpl : Abstracts.BaseDaoImpl, sysdiagramsDao
	{
		public List<sysdiagrams> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<sysdiagrams>("dbo.usp_sysdiagramsSelect @diagram_id={0}", parameters).ToList();
		}

		public sysdiagrams SelectByKey(sysdiagrams entity)
		{
			object[] parameters = new object[] { entity.diagram_id };
			return Context.Database.SqlQuery<sysdiagrams>("dbo.usp_sysdiagramsSelect @diagram_id={0}", parameters).FirstOrDefault();
		}

		public sysdiagrams Update(sysdiagrams entity)
		{
			object[] parameters = new object[] { entity.name, entity.principal_id, entity.diagram_id, entity.version, entity.definition };
			return Context.Database.SqlQuery<sysdiagrams>("dbo.usp_sysdiagramsUpdate @name={0}, @principal_id={1}, @diagram_id={2}, @version={3}, @definition={4}", parameters).FirstOrDefault();
		}

		public sysdiagrams Insert(sysdiagrams entity)
		{
			object[] parameters = new object[] { entity.name, entity.principal_id, entity.version, entity.definition };
			return Context.Database.SqlQuery<sysdiagrams>("dbo.usp_sysdiagramsInsert @name={0}, @principal_id={1}, @version={2}, @definition={3}", parameters).FirstOrDefault();
		}

		public bool Delete(sysdiagrams entity)
		{
			object[] parameters = new object[] { entity.diagram_id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_sysdiagramsDelete @diagram_id={0}", parameters) == -1 ? true : false);
		}

	}
}
