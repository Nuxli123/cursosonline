using System;
using CursosOnline.DAL.IGenerics;
using CursosOnline.Domain;
namespace CursosOnline.DAL
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Interfaz para generar el CRUD
	/// </summary>
	public interface OpcionesPreguntasDao : ISelect<OpcionesPreguntas>, IUpdate<OpcionesPreguntas>, IInsert<OpcionesPreguntas>, IDelete<OpcionesPreguntas>
	{
	}
}
