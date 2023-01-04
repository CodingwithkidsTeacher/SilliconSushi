using Microsoft.AspNetCore.Mvc;
using SilliconSushi.Models;
using SilliconSushi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.Controllers
{
    public class SushiController : Controller
    {
        private readonly ISushiRepository _sushiRepository;
        private readonly ICategoryRepository _categoryRepository;

        public SushiController(ISushiRepository sushiRepository, ICategoryRepository categoryRepository)
        {
            _sushiRepository = sushiRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel {
                SushiOfTheDay = _sushiRepository.TopSushi
            };

            return View(homeViewModel);
        }

        public IActionResult AllSushi()
        {
            SushiListViewModel sushiListView = new SushiListViewModel();
            sushiListView.Sushis = _sushiRepository.AllSushi;
            sushiListView.CurrentCategory = "Vegetarian";

            return View(sushiListView);
        }

        public IActionResult Details(int id)
        {
            var sushi = _sushiRepository.getSushiById(id);

            if (sushi == null)
                return NotFound();

            return View(sushi);
        }
    }
}
