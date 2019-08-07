using System;
using CursosOnline.DAL.IGenerics;
using CursosOnline.Domain;
namespace CursosOnline.DAL
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Interfaz para generar el CRUD
	/// </summary>
	public interface CursosDao : ISelect<Cursos>, IUpdate<Cursos>, IInsert<Cursos>, IDelete<Cursos>
	{
	}
}
