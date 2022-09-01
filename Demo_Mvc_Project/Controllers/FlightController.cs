﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_Mvc_Project.Models;

namespace Demo_Mvc_Project.Controllers
{
    public class FlightController : Controller
    {
        DbistanbulAkademiFlightEntities db = new DbistanbulAkademiFlightEntities();
        public ActionResult CityList()
        {
            var values = db.TblCity.ToList();
            return View(values);
        }

        public ActionResult PassengerList()
        {
            var values = db.TblPassenger.ToList();
            return View(values);
        }
    }
}