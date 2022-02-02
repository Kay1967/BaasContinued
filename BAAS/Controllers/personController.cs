#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BAAS.Data;
using BAAS.Models;
using System.Dynamic;
using Newtonsoft.Json;




namespace BAAS.Controllers
{
    public class personController : Controller
    {
        private readonly ApplicationDbContext _context;

        public personController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: person
        public async Task<IActionResult> Index()
        {
            return View(await _context.person.ToListAsync());
        }
       
      

       
            //Get: person/activity
        public async Task<IActionResult> Activity(int? id)
        {
            return View(await _context.activity_information.Where(p=> p.person == id).ToListAsync());
        }


        //GET: person/exercise

        public async Task<IActionResult> Exercise(int? id)
        {
            return View(await _context.exercise_information.Where(p => p.person == id).ToListAsync());
        }

        //Get: person/heart rate
        public async Task<IActionResult> Heartrate(int? id)
        {
            return View(await _context.heartrate_information.Where(p => p.person == id).ToListAsync());
        }
        //Get: person/heartrate daily
        public async Task<IActionResult> Heartratedaily(int? id)
        {
            return View(await _context.heartrate_daily.Where(p => p.person == id).ToListAsync());
        }
        //Get: person/sleep
        public async Task<IActionResult> Sleep(int? id)
        {
            return View(await _context.sleep_information.Where(p => p.person == id).ToListAsync());
        }

    }
}