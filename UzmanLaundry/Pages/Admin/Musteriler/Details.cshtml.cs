using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace UzmanLaundry.Pages.Admin.Musteriler
{
    public class DetailsModel : PageModel
    {
        private readonly UzmanLaundry.Data.ApplicationDbContext _context;

        public DetailsModel(UzmanLaundry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
