using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AkCadeMic.Data;
using AkCadeMic.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace AkCadeMic.Controllers
{
    public class ThreadHController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ThreadHController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.ThreadsH.Include(x => x.UserH).ToList();
            return View(list);
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ThreadH record)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Where(u => u.Id == userId).SingleOrDefault();
            var threadH = new ThreadH()
            {
                SubjectH = record.SubjectH,
                BodyH = record.BodyH,
                UserH = user,
                DateAdded = DateTime.Now
            };

            _context.ThreadsH.Add(threadH);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var threadH = _context.ThreadsH.Where(i => i.PostIdH == id).SingleOrDefault();
            if (threadH == null)
            {
                return RedirectToAction("Index");
            }

            return View(threadH);
        }

        [HttpPost]
        public IActionResult Edit(int? id, ThreadH record)
        {
            var threadH = _context.ThreadsH.Where(i => i.PostIdH == id).SingleOrDefault();
            threadH.SubjectH = record.SubjectH;
            threadH.BodyH = record.BodyH;

            _context.ThreadsH.Update(threadH);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var threadH = _context.ThreadsH.Where(i => i.PostIdH == id).SingleOrDefault();
            if (threadH == null)
            {
                return RedirectToAction("Index");
            }

            _context.ThreadsH.Remove(threadH);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Manage()
        {
            var list = _context.ThreadsH.ToList();
            return View(list);
        }
    }
}
