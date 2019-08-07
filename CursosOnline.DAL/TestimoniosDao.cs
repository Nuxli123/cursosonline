using System;
using CursosOnline.DAL.IGenerics;
using CursosOnline.Domain;
namespace CursosOnline.DAL
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Interfaz que rige la estructura del CRUD
	/// </summary>
	public interface TestimoniosDao : ISelect<Testimonios>, IUpdate<Testimonios>, IInsert<Testimonios>, IDelete<Testimonios>
	{
	}
}
