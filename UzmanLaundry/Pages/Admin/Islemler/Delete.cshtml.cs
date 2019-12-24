using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace UzmanLaundry.Pages.Admin.Islemler
{
    public class DeleteModel : PageModel
    {
        private readonly UzmanLaundry.Data.ApplicationDbContext _context;

        public DeleteModel(UzmanLaundry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UzmanLaundry.Models.Islem Islem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Islem = await _context.Islem.FirstOrDefaultAsync(m => m.ID == id);

            if (Islem == null)
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

            Islem = await _context.Islem.FindAsync(id);

            if (Islem != null)
            {
                _context.Islem.Remove(Islem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
