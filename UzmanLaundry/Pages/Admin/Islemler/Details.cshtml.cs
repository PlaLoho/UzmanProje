﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace UzmanLaundry.Pages.Admin.Islemler
{
    public class DetailsModel : PageModel
    {
        private readonly UzmanLaundry.Data.ApplicationDbContext _context;

        public DetailsModel(UzmanLaundry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
