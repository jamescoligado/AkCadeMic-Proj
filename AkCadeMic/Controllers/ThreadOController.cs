using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AkCadeMic.Models;
using AkCadeMic.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace AkCadeMic.Controllers
{
    public class ThreadOController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ThreadOController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.ThreadsO.Include(x => x.UserO).ToList();
            var comment = _context.ThreadsO.Include(y => y.RepliesO).ToList();
            return View(list);
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ThreadO record)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Where(u => u.Id == userId).SingleOrDefault();
            var ThreadO = new ThreadO()
            {
                SubjectO = record.SubjectO,
                BodyO = record.BodyO,
                UserO = user,
                DateAdded = DateTime.Now
            };

            _context.ThreadsO.Add(ThreadO);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Comment(ReplyO record)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.Where(u => u.Id == userId).SingleOrDefault();
            var Email = User.FindFirstValue(ClaimTypes.Email);
            var comment = new ReplyO()
            {
                TextO = record.TextO,
                ThreadIdO = record.ThreadIdO,
                UserO = user,
                EmailH = Email,
                DateAdded = DateTime.Now
            };

            _context.RepliesO.Add(comment);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var ThreadO = _context.ThreadsO.Where(i => i.PostIdO == id).SingleOrDefault();
            if (ThreadO == null)
            {
                return RedirectToAction("Index");
            }

            return View(ThreadO);
        }

        [HttpPost]
        public IActionResult Edit(int? id, ThreadO record)
        {
            var ThreadO = _context.ThreadsO.Where(i => i.PostIdO == id).SingleOrDefault();
            ThreadO.SubjectO = record.SubjectO;
            ThreadO.BodyO = record.BodyO;

            _context.ThreadsO.Update(ThreadO);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var ThreadO = _context.ThreadsO.Where(i => i.PostIdO == id).SingleOrDefault();
            if (ThreadO == null)
            {
                return RedirectToAction("Index");
            }

            _context.ThreadsO.Remove(ThreadO);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteComment(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var comment = _context.RepliesO.Where(i => i.IdO == id).SingleOrDefault();
            if (comment == null)
            {
                return RedirectToAction("Index");
            }

            _context.RepliesO.Remove(comment);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult ManageComments()
        {
            var list = _context.RepliesO.ToList();
            return View(list);
        }

        public IActionResult Manage()
        {
            var list = _context.ThreadsO.ToList();
            return View(list);
        }
    }
}
