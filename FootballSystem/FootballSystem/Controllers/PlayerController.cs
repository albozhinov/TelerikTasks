using FootballSystem.Models;
using FootballSystem.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FootballSystem.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerServices playerService;

        public PlayerController(IPlayerServices service)
        {
            this.playerService = service;
        }

        public IActionResult Details(int Id)
        {
            var player = this.playerService.GetPlayerById(Id);

            var viewModel = new PlayerViewModel(player);

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PlayerViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View();
            }

            var newPlayer = this.playerService.CreatePlayer(model.FirstName, model.LastName);

            return RedirectToAction("Details", "Player", new { id = newPlayer.Id });
        }
    }
}