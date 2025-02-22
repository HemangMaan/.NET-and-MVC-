﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DatawindDataAccess.Infrastructure;
using DatawindDataAccess.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        iCategoryRepository<Category, int> _repository;

        public CategoryController(iCategoryRepository<Category,int> repository)
        {
            _repository = repository;
        }

        // GET: CategoryController
        public async Task<IActionResult> Index()
        {
            //var model = _repository.FindAll();
            //return View(model: model);
            string requestURL = "http://localhost:5091/Categories/list";
            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(requestURL, HttpCompletionOption.ResponseHeadersRead);
                var data = await response.Content.ReadAsStringAsync();
                var model = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Category>>(data);
                return View(model);
            }
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var model = _repository.FindById(id);
            if (model == null)
                return NotFound();
            return View(model);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            var model = new Category();
            return View(model);
        }

        // POST: CategoryController/Create
        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (!ModelState.IsValid)
                return View(model);
            try
            {
                _repository.AddNew(model);
            }
            catch (Exception ex)
            {
                return View(model);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _repository.FindById(id);
            if (model != null)
                return View(model);
            else
                return RedirectToAction(nameof(Index));
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        public ActionResult Edit(Category model)
        {
            if (!ModelState.IsValid)
                return View(model);
            try
            {
                _repository.Update(model);
            }
            catch (Exception ex)
            {
                return View(model);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _repository.FindById(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
                return View(model);
        }

        // POST: CategoryController/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _repository.DeleteById(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
