using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace UzmanLaundry.Pages.Admin.Musteriler
{
    public class DeleteModel : PageModel
    {
        private readonly UzmanLaundry.Data.ApplicationDbContext _context;

        public DeleteModel(UzmanLaundry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UzmanLaundry.Models.Musteriler Musteriler { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Musteriler = await _context.Musteriler
                .Include(m => m.islem).FirstOrDefaultAsync(m => m.ID == id);

            if (Musteriler == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Musteriler = await _context.Musteriler.FindAsync(id);

            if (Musteriler != null)
            {
                _context.Musteriler.Remove(Musteriler);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
