using CINE_ACT2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CINE_ACT2.Pages
{
    public class PeliculasModel : PageModel
    {
        private readonly CineDbAct2Context _context;

        // Propiedad para almacenar la lista de pel�culas
        public List<Pelicula> Peliculas { get; set; } = new List<Pelicula>();

        // Constructor para inicializar el contexto
        public PeliculasModel(CineDbAct2Context context) => _context = context;

        // M�todo OnGet para obtener las pel�culas
        public async Task OnGetAsync()
        {
            try
            {
                Peliculas = await _context.Peliculas.ToListAsync();
                if (Peliculas == null || Peliculas.Count == 0)
                {
                    Console.WriteLine("No se encontraron pel�culas.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las pel�culas: {ex.Message}");
            }
        }
    }
}