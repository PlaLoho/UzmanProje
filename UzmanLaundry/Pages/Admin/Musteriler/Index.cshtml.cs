using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UzmanLaundry.Pages.Admin.Musteriler
{
    public class IndexModel : PageModel
    {
        private readonly UzmanLaundry.Data.ApplicationDbContext _context;

        public IndexModel(UzmanLaundry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<UzmanLaundry.Models.Musteriler> Musteriler { get; set; }

        public async Task OnGetAsync()
        {
            Musteriler = await _context.Musteriler
                .Include(m => m.islem).ToListAsync();
        }
    }
}
