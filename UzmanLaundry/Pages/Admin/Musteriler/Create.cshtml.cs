using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace UzmanLaundry.Pages.Admin.Musteriler
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
            ViewData["islemID"] = new SelectList(_context.Islem, "ID", "islemTuru");
            return Page();
        }

        [BindProperty]
        public UzmanLaundry.Models.Musteriler Musteriler { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Musteriler.Add(Musteriler);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
