using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UzmanLaundry.Pages.Admin.Islemler
{
    public class IndexModel : PageModel
    {
        private readonly UzmanLaundry.Data.ApplicationDbContext _context;

        public IndexModel(UzmanLaundry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<UzmanLaundry.Models.Islem> Islem { get; set; }

        public async Task OnGetAsync()
        {
            Islem = await _context.Islem.ToListAsync();
        }
    }
}
