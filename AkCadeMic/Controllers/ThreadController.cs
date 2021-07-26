using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AkCadeMic.Data;
using AkCadeMic.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace AkCadeMic.Controllers
{
    public class ThreadController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThreadController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Threads.Include(x => x.User).ToList();
            var comment = _context.Threads.Include(y => y.Replies).ToList();
            return View(list);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create (Thread record)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user =  _context.Users.Where(u => u.Id == userId).SingleOrDefault();
            var thread = new Thread()
            {
                Subject = record.Subject,
                Body = record.Body,
                User = user,
                DateAdded = DateTime.Now
            };

            _context.Threads.Add(thread);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Comment(Reply record)
        {
            var comment = new Reply()
            {
                Text = record.Text,
                ThreadId = record.ThreadId
            };

            _context.Replies.Add(comment);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var thread = _context.Threads.Where(i => i.PostId == id).SingleOrDefault();
            if (thread == null)
            {
                return RedirectToAction("Index");
            }

            return View(thread);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Thread record)
        {
            var thread = _context.Threads.Where(i => i.PostId == id).SingleOrDefault();
            thread.Subject = record.Subject;
            thread.Body = record.Body;

            _context.Threads.Update(thread);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var thread = _context.Threads.Where(i => i.PostId == id).SingleOrDefault();
            if (thread == null)
            {
                return RedirectToAction("Index");
            }

            _context.Threads.Remove(thread);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Manage()
        {
            var list = _context.Threads.ToList();
            return View(list);
        }

    }
}
