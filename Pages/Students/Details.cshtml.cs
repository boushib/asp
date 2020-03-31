using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentsManagement.Data;
using StudentsManagement.Models;

namespace web_app.Pages_Students
{
    public class DetailsModel : PageModel
    {
        private readonly StudentsManagement.Data.StudentsManagementContext _context;

        public DetailsModel(StudentsManagement.Data.StudentsManagementContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.Code == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
