using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace tarea.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        // Lista de notas que se mostrarán
        public List<Note> Notes { get; set; }

        // Propiedades para capturar los datos del formulario
        [BindProperty]
        public string Subject { get; set; }

        [BindProperty]
        public int Grade { get; set; }

        // Constructor con el logger
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            // Inicializamos la lista de notas con algunas entradas
            Notes = new List<Note>
            {
                new Note { Subject = "Matemáticas", Grade = 8 },
                new Note { Subject = "Historia", Grade = 7 }
            };
        }

        // Método que maneja las solicitudes GET
        public void OnGet()
        {
            // Podrías cargar las notas desde una base de datos aquí
        }

        // Método que maneja las solicitudes POST (cuando se agrega una nueva nota)
        public void OnPost()
        {
            // Validamos y agregamos la nueva nota a la lista
            if (!string.IsNullOrEmpty(Subject) && Grade >= 0 && Grade <= 10)
            {
                Notes.Add(new Note { Subject = Subject, Grade = Grade });
            }
        }
    }

    // Modelo para las notas
    public class Note
    {
        public string Subject { get; set; }
        public int Grade { get; set; }
    }
}
