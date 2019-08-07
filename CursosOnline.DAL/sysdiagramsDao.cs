using System;
using CursosOnline.DAL.IGenerics;
using CursosOnline.Domain;
namespace CursosOnline.DAL
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Interfaz para generar el CRUD
	/// </summary>
	public interface sysdiagramsDao : ISelect<sysdiagrams>, IUpdate<sysdiagrams>, IInsert<sysdiagrams>, IDelete<sysdiagrams>
	{
	}
}
