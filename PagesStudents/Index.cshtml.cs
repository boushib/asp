using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentsManagement.Data;
using StudentsManagement.Models;

namespace web_app.PagesStudents
{
    public class IndexModel : PageModel
    {
        private readonly StudentsManagement.Data.StudentsManagementContext _context;

        public IndexModel(StudentsManagement.Data.StudentsManagementContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
