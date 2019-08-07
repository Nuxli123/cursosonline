using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CursosOnline.Domain;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace CursosOnline.DataContext
{
	/// <summary>
	/// Autor: CursosOnline
	/// Comentarios: Clase de contexto de datos
	/// </summary>
	public class DataContext : DbContext
	{
		public DbSet<Cursos> Cursos { get; set; }
		public DbSet<Preguntas> Preguntas { get; set; }
		public DbSet<AplicacionesEvaluaciones> AplicacionesEvaluaciones { get; set; }
		public DbSet<OpcionesPreguntas> OpcionesPreguntas { get; set; }
		public DbSet<Respuestas> Respuestas { get; set; }
		public DbSet<Usuarios> Usuarios { get; set; }
		public DbSet<Roles> Roles { get; set; }
		public DbSet<UsuariosRoles> UsuariosRoles { get; set; }
		public DbSet<CalificacionCalidadCursos> CalificacionCalidadCursos { get; set; }
		public DbSet<sysdiagrams> sysdiagrams { get; set; }
		public DbSet<PagosOpenPay> PagosOpenPay { get; set; }
	}
}
