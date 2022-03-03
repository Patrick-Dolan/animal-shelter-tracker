using AnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalShelterController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}