using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tarea.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Message { get; set; }

        public bool MessageSent { get; set; }

        public void OnGet()
        {
            // Lógica para cargar la página de contacto
        }

        public void OnPost()
        {
            // Aquí podrías agregar la lógica para procesar el formulario, por ejemplo, enviarlo por correo o guardarlo en una base de datos.
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Message))
            {
                // Simulamos que el mensaje fue enviado correctamente
                MessageSent = true;
            }
        }
    }
}
