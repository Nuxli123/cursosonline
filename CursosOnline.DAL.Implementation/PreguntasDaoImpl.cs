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
	public class PreguntasDaoImpl : Abstracts.BaseDaoImpl, PreguntasDao
	{
		public List<Preguntas> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Preguntas>("dbo.usp_PreguntasSelect @Id={0}", parameters).ToList();
		}

		public Preguntas SelectByKey(Preguntas entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Database.SqlQuery<Preguntas>("dbo.usp_PreguntasSelect @Id={0}", parameters).FirstOrDefault();
		}

		public Preguntas Update(Preguntas entity)
		{
			object[] parameters = new object[] { entity.Id, entity.CursoId, entity.Numero, entity.Descripcion };
			return Context.Database.SqlQuery<Preguntas>("dbo.usp_PreguntasUpdate @Id={0}, @CursoId={1}, @Numero={2}, @Descripcion={3}", parameters).FirstOrDefault();
		}

		public Preguntas Insert(Preguntas entity)
		{
			object[] parameters = new object[] { entity.CursoId, entity.Numero, entity.Descripcion };
			return Context.Database.SqlQuery<Preguntas>("dbo.usp_PreguntasInsert @CursoId={0}, @Numero={1}, @Descripcion={2}", parameters).FirstOrDefault();
		}

		public bool Delete(Preguntas entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_PreguntasDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
