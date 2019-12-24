using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using UzmanLaundry.Models;

namespace UzmanLaundry.Pages.Admin.Islemler
{
    public class EditModel : PageModel
    {
        private readonly UzmanLaundry.Data.ApplicationDbContext _context;

        public EditModel(UzmanLaundry.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Islem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IslemExists(Islem.ID))
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

        private bool IslemExists(int id)
        {
            return _context.Islem.Any(e => e.ID == id);
        }
    }
}
