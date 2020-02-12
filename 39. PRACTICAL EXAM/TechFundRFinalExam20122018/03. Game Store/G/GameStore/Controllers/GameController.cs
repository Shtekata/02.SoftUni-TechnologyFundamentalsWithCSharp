using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDbContext())
            {
                var games = db.Games.ToList();
                return this.View(games);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            if (game.Name == null || game.Dlc == null) return RedirectToAction("Index");
            using (var db = new GameStoreDbContext())
            {
                var newGame = new Game
                {
                    Name = game.Name,
                    Dlc = game.Dlc,
                    Price = game.Price,
                    Platform = game.Platform
                };
                db.Add(newGame);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db=new GameStoreDbContext())
            {
                var gameToEdit = db.Games.Find(id);
                return View(gameToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            if (game.Name == null || game.Dlc == null) return RedirectToAction("Index");
            using (var db=new GameStoreDbContext())
            {
                db.Games.Update(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db=new GameStoreDbContext())
            {
                var gameToDelete = db.Games.Find(id);
                return View(gameToDelete);
            }

        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.Games.Remove(game);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}