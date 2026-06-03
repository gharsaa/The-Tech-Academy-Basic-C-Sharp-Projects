using System;
using System.Linq;
using System.Web.Mvc;
using CarInsurance.Models;

public class InsureeController : Controller
{
    private ApplicationDbContext db = new ApplicationDbContext();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Insuree insuree)
    {
        decimal quote = 50;

        int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
        if (insuree.DateOfBirth > DateTime.Now.AddYears(-age)) age--;

        if (age <= 18) quote += 100;
        else if (age <= 25) quote += 50;
        else quote += 25;

        if (insuree.CarYear < 2000) quote += 25;
        if (insuree.CarYear > 2015) quote += 25;

        if (insuree.CarMake != null && insuree.CarMake.ToLower() == "porsche")
        {
            quote += 25;
            if (insuree.CarModel != null && insuree.CarModel.ToLower() == "911 carrera")
                quote += 25;
        }

        quote += insuree.SpeedingTickets * 10;

        if (insuree.DUI) quote *= 1.25m;
        if (insuree.CoverageType) quote *= 1.50m;

        insuree.Quote = quote;

        db.Insurees.Add(insuree);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public ActionResult Admin()
    {
        return View(db.Insurees.ToList());
    }
}
