using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Services.Services;
using Services.Support;
using SocietyAnalysisWeb.DataBase;
using SocietyAnalysisWeb.DataModel;
using SocietyAnalysisWeb.DataModelDTO;
using SocietyAnalysisWeb_v3.Models;

namespace SocietyAnalysisWeb_v3.Controllers
{
    public class QuestionnaireMainController : Controller
    {
        public ActionResult Index()
        {
            GetServices services = new GetServices(new UnitOfWork("connectionString"));
            List<PersonDTO> persons = services.GetAllPersons().ToList();
            return View(persons);
        }

        [HttpGet]
        public ActionResult Create()
        {
            GetServices services = new GetServices(new UnitOfWork("connectionString"));

            List<CityDTO> list = services.GetAllCities().ToList();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var it in list)
            {
                items.Add(new SelectListItem() { Text = it.CityName, Value = it.Id.ToString() });
            }

            List<LanguageDTO> languages = services.GetAllLanguages().ToList();
            List<SelectListItem> lanItems = new List<SelectListItem>();
            lanItems.Add(new SelectListItem(){Text = string.Empty, Value = "-1"});
            foreach (var item in languages)
            {
                lanItems.Add(new SelectListItem(){Text = item.LanguageName, Value = item.Id.ToString()});
            }

            List<EducationalEstablishmentDTO> educational = services.GetAllEducationalEstablishments().ToList();
            
            List<SelectListItem> eduItems = new List<SelectListItem>();
            eduItems.Add(new SelectListItem(){Text = string.Empty, Value = "-1"});
            foreach (var item in educational)
            {
                eduItems.Add(new SelectListItem(){Text = item.Name, Value = item.Id.ToString()});
            }

            ModelView view = new ModelView() { Cities = items, Languages = lanItems, Edu = eduItems };
            return View(view);
        }

        [HttpPost]
        public ActionResult Create(ModelView modelView)
        {
            PersonDTO current = modelView.Person;
            SetServices services = new SetServices(new UnitOfWork("connectionString"));

            services.AddPerson(modelView);

            return RedirectToAction("Index");
        }

        public ActionResult SexStatistic()
        {
            SelectServices services = new SelectServices(new UnitOfWork("connectionString"));
            StatisticalData statistic = new StatisticalData();
            statistic.Male = services.GetBySex(true).ToList();
            statistic.Female = services.GetBySex(false).ToList();
            statistic.MalePercentage = statistic.Male.Count()*100/(statistic.Male.Count() + statistic.Female.Count());
            statistic.FemalePercentage = 100 - statistic.MalePercentage;
            return View(statistic);
        }

        public ActionResult AgeStatistic()
        {
            SelectServices services = new SelectServices(new UnitOfWork("connectionString"));
            StatisticalData statistic = new StatisticalData();
            statistic.AgesStatistic = services.GetBySexByAge();
            return View(statistic);
        }

        public ActionResult RaceStatistic()
        {
            SelectServices services = new SelectServices(new UnitOfWork("connectionString"));
            StatisticalData statistic = new StatisticalData();
            statistic.RaceStatistic = services.GetByRaceAndAge();
            return View(statistic);
        }

        public ActionResult ReligionStatistic()
        {
            SelectServices services = new SelectServices(new UnitOfWork("connectionString"));
            StatisticalData statistic = new StatisticalData();
            statistic.RaceStatistic = services.GetByReligion();
            return View(statistic);
        }

        public ActionResult NationalityStatistic()
        {
            SelectServices services = new SelectServices(new UnitOfWork("connectionString"));
            StatisticalData statistic = new StatisticalData();
            statistic.RaceStatistic = services.GetByNationality();
            return View(statistic);
        }

        public ActionResult EducationStatistic()
        {
            SelectServices services = new SelectServices(new UnitOfWork("connectionString"));
            StatisticalData statistic = new StatisticalData();
            statistic.RaceStatistic = services.GetByEducation();
            return View(statistic);
        }
    }
}