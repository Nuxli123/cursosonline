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
	public class CursosDaoImpl : Abstracts.BaseDaoImpl, CursosDao
	{
		public List<Cursos> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Cursos>("dbo.usp_CursosSelect @Id={0}", parameters).ToList();
		}

		public Cursos SelectByKey(Cursos entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Database.SqlQuery<Cursos>("dbo.usp_CursosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public Cursos Update(Cursos entity)
		{
			object[] parameters = new object[] { entity.Id, entity.Nombre, entity.Icono, entity.Color, entity.Instructor,entity.ImagenPortada,entity.Descripcion,entity.Duracion,entity.Precio };
			return Context.Database.SqlQuery<Cursos>("dbo.usp_CursosUpdate @Id={0}, @Nombre={1}, @Icono={2}, @Color={3}, @Instructor={4},@ImagenPortada={5},@Descripcion={6},@Duracion={7},@Precio={8}", parameters).FirstOrDefault();
		}

		public Cursos Insert(Cursos entity)
		{
			object[] parameters = new object[] { entity.Nombre, entity.Icono, entity.Color, entity.Instructor, entity.ImagenPortada, entity.Descripcion, entity.Duracion, entity.Precio };
			return Context.Database.SqlQuery<Cursos>("dbo.usp_CursosInsert @Nombre={0}, @Icono={1}, @Color={2}, @Instructor={3},@ImagenPortada={4},@Descripcion={5},@Duracion{6},@Precio={7}", parameters).FirstOrDefault();
		}

		public bool Delete(Cursos entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_CursosDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
