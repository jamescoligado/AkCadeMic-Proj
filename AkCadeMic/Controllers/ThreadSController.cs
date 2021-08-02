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
    public class ThreadSController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ThreadSController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.ThreadsS.Include(x => x.UserS).ToList();
            var comment = _context.ThreadsS.Include(y => y.RepliesS).ToList();
            return View(list);
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ThreadS record)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Where(u => u.Id == userId).SingleOrDefault();

            var threadS = new ThreadS()
            {
                SubjectS = record.SubjectS,
                BodyS = record.BodyS,
                UserS = user,
                DateAdded = DateTime.Now
            };

            _context.ThreadsS.Add(threadS);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Comment(ReplyS record)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Where(u => u.Id == userId).SingleOrDefault();
            var Email = User.FindFirstValue(ClaimTypes.Email);
            var comment = new ReplyS()
            {
                TextS = record.TextS,
                ThreadIdS = record.ThreadIdS,
                UserS = user,
                EmailS = Email,
                DateAdded = DateTime.Now
            };

            _context.RepliesS.Add(comment);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var threadS = _context.ThreadsS.Where(i => i.PostIdS == id).SingleOrDefault();
            if (threadS == null)
            {
                return RedirectToAction("Index");
            }

            return View(threadS);
        }

        [HttpPost]
        public IActionResult Edit(int? id, ThreadS record)
        {
            var threadS = _context.ThreadsS.Where(i => i.PostIdS == id).SingleOrDefault();
            threadS.SubjectS = record.SubjectS;
            threadS.BodyS = record.BodyS;

            _context.ThreadsS.Update(threadS);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var threadS = _context.ThreadsS.Where(i => i.PostIdS == id).SingleOrDefault();
            if (threadS == null)
            {
                return RedirectToAction("Index");
            }

            _context.ThreadsS.Remove(threadS);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteComment(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var comment = _context.RepliesS.Where(i => i.IdS == id).SingleOrDefault();
            if (comment == null)
            {
                return RedirectToAction("Index");
            }

            _context.RepliesS.Remove(comment);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ManageComments()
        {
            var list = _context.RepliesS.ToList();
            return View(list);
        }

        public IActionResult Manage()
        {
            var list = _context.ThreadsS.ToList();
            return View(list);
        }
    }
}
