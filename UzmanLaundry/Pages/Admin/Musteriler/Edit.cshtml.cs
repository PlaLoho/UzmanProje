using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace UzmanLaundry.Pages.Admin.Musteriler
{
    public class EditModel : PageModel
    {
        private readonly UzmanLaundry.Data.ApplicationDbContext _context;

        public EditModel(UzmanLaundry.Data.ApplicationDbContext context)
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
            ViewData["islemID"] = new SelectList(_context.Islem, "ID", "islemTuru");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Musteriler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusterilerExists(Musteriler.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MusterilerExists(int id)
        {
            return _context.Musteriler.Any(e => e.ID == id);
        }
    }
}
