#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorClassServer.Models;

namespace BlazorClassServer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly DataContext _context;

        public DataController(DataContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students
                .ToListAsync();
        }

        [HttpGet("{studentId}", Name = "GetStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Student>> GetStudent(string studentId)
        {
            var student = await _context.Students.FindAsync(studentId);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }
        
        [HttpGet(Name = "GetStudentContacts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<StudentContact>>> GetStudentContacts()
        {
            return await _context.StudentContacts
                .Include(x => x.Contact)
                .ThenInclude(y => y.Address)
                .ToListAsync();
        }
        
        [HttpGet("{studentId}", Name = "GetStudentContact")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<StudentContact>>> GetStudentContact(string studentId)
        {
            var studentContact = await _context.StudentContacts
                .Include(x => x.Contact)
                .ThenInclude(y => y.Address)
                .Where(z => z.StudentId == studentId)
                .ToListAsync();

            if (studentContact.Count < 1)
            {
                return NotFound();
            }
            
            return studentContact;
        }

        private bool StudentExists(string id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}
