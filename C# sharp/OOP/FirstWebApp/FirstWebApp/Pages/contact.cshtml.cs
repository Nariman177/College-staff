using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class contactModel : PageModel
    {
        public bool hasdata = false;
        public string firstname = " ";
        public string lastname = " ";
        public string message = " ";
        public void OnGet()
        {
        }

        public void Onpost()
        {
            hasdata = false;
            firstname = Request.Form["firstname"];
            lastname = Request.Form["lastname"];
            message = Request.Form["message"];


        }

           





         
    }
}
