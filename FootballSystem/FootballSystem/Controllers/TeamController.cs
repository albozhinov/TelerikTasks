using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballSystem.Models;
using FootballSystem.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FootballSystem.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamServices teamService;

        public TeamController(ITeamServices services)
        {
            this.teamService = services;
        }

        public IActionResult Details(int Id)
        {
            var team = this.teamService.GetTeamById(Id);

            var viewModel = new TeamVIewModel(team);

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TeamVIewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View();
            }

            var newTeam = this.teamService.CreateTeam(model.Name);

            return RedirectToAction("Details", "Team", new { id = newTeam.Id });
        }
    }
}