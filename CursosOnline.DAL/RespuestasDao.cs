using System;
using CursosOnline.DAL.IGenerics;
using CursosOnline.Domain;
namespace CursosOnline.DAL
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Interfaz para generar el CRUD
	/// </summary>
	public interface RespuestasDao : ISelect<Respuestas>, IUpdate<Respuestas>, IInsert<Respuestas>, IDelete<Respuestas>
	{
	}
}
