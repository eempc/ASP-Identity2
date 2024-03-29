﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Pages.Countries
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly WebApplication2.Data.WebApplication2CountryContext _context;
        public string userId; // Declare the user ID in order to assign it later

        public CreateModel(WebApplication2.Data.WebApplication2CountryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value; // Initialise user ID, then can use it in the CSHMTL file
            return Page();
        }

        [BindProperty]
        public Country Country { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Country.Add(Country);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
