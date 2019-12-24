using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace UzmanLaundry.Pages.Admin.Islemler
{
    public class CreateModel : PageModel
    {
        private readonly UzmanLaundry.Data.ApplicationDbContext _context;

        public CreateModel(UzmanLaundry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UzmanLaundry.Models.Islem Islem { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Islem.Add(Islem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
