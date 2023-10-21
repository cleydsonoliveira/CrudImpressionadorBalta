using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudImpressionadorBalta.Data;
using CrudImpressionadorBalta.Models;

namespace CrudImpressionadorBalta.Pages_Students
{
    public class IndexModel : PageModel
    {
        private readonly CrudImpressionadorBalta.Data.ApplicationDbContext _context;

        public IndexModel(CrudImpressionadorBalta.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Student = await _context.Students.ToListAsync();
            }
        }
    }
}
