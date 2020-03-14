using AssignmentNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentNew.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult IndiaTime()
        {
            ViewBag.countryList = GetCountries();
            ViewBag.IndiaTime = GetCountryTime("India");
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult UKTime()
        {
            ViewBag.countryList = GetCountries();
            ViewBag.UkTime = GetCountryTime("United Kingdom");
            return PartialView();
        }
        public ActionResult GetTimeByCountry(int countryId)
        {
            return PartialView();
        }

        private List<Country> GetCountries()
        {
            var countries  = new List<Country>();
            countries.Add(new Country { Id = 1, Name = "India" });
            countries.Add(new Country { Id = 2, Name = "United Kingdom" });
            countries.Add(new Country { Id = 3, Name = "United States Of America" });
            countries.Add(new Country { Id = 4, Name = "Australia" });
            return countries;
        }
        private string GetCountryTime(string country)
        {
            DateTime gmt = default(DateTime);
            var value = default(System.DateTime);
            gmt = DateTime.Now.AddMinutes(-330);

            switch (country)
            {
                case "India":
                case "Sri Lanka":
                    return DateTime.Now.ToString();
                case "United Kingdom":
                case "Portugal":
                case "Sierra Leone":
                case "Senegal":
                case "Morocco":
                case "Mali":
                    return gmt.ToString();
                case "France":
                case "Spain":
                case "Slovenia":
                case "Slovakia":
                case "Poland":
                case "Nigeria":
                case "Niger":
                case "Hungary":
                case "Denmark":
                case "Czech Republic":
                    return gmt.AddMinutes(60).ToString();
                case "Botswana":
                case "Moldova":
                case "South Africa":
                case "Malawi":
                case "Lithuania":
                case "Libya":
                case "Turkey":
                case "Finland":
                case "Egypt":
                    return gmt.AddMinutes(120).ToString(); ;
                case "Bahrain":
                case "Somalia":
                case "Saudi Arabia":
                case "Russia":
                case "Qatar":
                case "Sudan":
                case "Madagascar":
                case "Iraq":
                    return gmt.AddMinutes(180).ToString();
                case "Iran":
                    return gmt.AddMinutes(220).ToString();
                case "Armenia":
                case "Seychelles":
                case "Reunion":
                case "Oman":
                case "Mauritius":
                case "United Arab Emirates":
                case "Georgia":
                case "Azerbaijan":
                    return gmt.AddMinutes(240).ToString();
                case "Afghanistan":
                    return gmt.AddMinutes(270).ToString();
                case "Pakistan":
                case "Maldives":
                case "Kyrgyzstan":
                    return gmt.AddMinutes(300).ToString();
                case "Nepal":
                    return gmt.AddMinutes(345).ToString();
                case "Bangladesh":
                case "Kazakhstan":
                    return gmt.AddMinutes(360).ToString();
                case "Myanmar":
                    return gmt.AddMinutes(390).ToString();
                case "Cambodia":
                case "Laos":
                    return gmt.AddMinutes(420).ToString();
                case "Philippines":
                case "Malaysia":
                case "Hong Kong":
                case "China":
                    return gmt.AddMinutes(480).ToString();
                case "Japan":
                case "Korea":
                    return gmt.AddMinutes(540).ToString();
                case "Micronesia":
                    return gmt.AddMinutes(720).ToString();
                case "Papua New Guinea":
                case "Australia":
                    return gmt.AddMinutes(600).ToString();
                case "New Caledonia":
                    return gmt.AddMinutes(660).ToString();
                case "New Zealand":
                case "Fiji":
                    return gmt.AddMinutes(720).ToString();
                case "Argentina":
                case "Brazil":
                    return gmt.AddMinutes(-180).ToString();
                case "Cuba":
                    return gmt.AddMinutes(-300).ToString();
                case "Aruba":
                case "Paraguay":
                case "Netherlands Antilles":
                case "Barbados":
                case "Chile":
                case "Dominican Republic":
                case "Guyana":
                    return gmt.AddMinutes(-240).ToString();
                case "Bahamas":
                    return gmt.AddMinutes(-240).ToString();
                case "Peru":
                case "Panama":
                case "Jamaica":
                case "Haiti":
                case "Colombia":
                case "Canary Islands":
                    return gmt.AddMinutes(-300).ToString();
                case "Bhutan":
                    return gmt.AddMinutes(360).ToString();
                case "Belize":
                case "Mexico":
                case "Honduras":
                case "Canada":
                    return gmt.AddMinutes(-360).ToString();
                case "Nicaragua":
                    return gmt.AddMinutes(-300).ToString();

                case "United States Of America":
                    return gmt.AddMinutes(-480).ToString();
                case "French Polynesia":
                    return gmt.AddMinutes(720).ToString();
                case "Samoa":
                    return gmt.AddMinutes(-660).ToString();
                case "Singapore":
                    return gmt.AddMinutes(480).ToString();
                case "Slovak Republic":
                    return gmt.AddMinutes(60).ToString();
                case "Solomon Islands":
                    return gmt.AddMinutes(660).ToString();
                case "St Helena":
                    return gmt.AddMinutes(0).ToString();
                case "St Kitts & Nevia":
                    return gmt.AddMinutes(-240).ToString();
                case "St Lucia":
                    return gmt.AddMinutes(-240).ToString();
                case "Surinam":
                    return gmt.AddMinutes(-180).ToString();
                case "Swaziland":
                    return gmt.AddMinutes(120).ToString();
                case "Sweden":
                    return gmt.AddMinutes(60).ToString();
                case "Switzerland":
                    return gmt.AddMinutes(60).ToString();
                case "Syria":
                    return gmt.AddMinutes(120).ToString();
                case "Taiwan":
                    return gmt.AddMinutes(480).ToString();
                case "Tajikistan":
                    return gmt.AddMinutes(300).ToString();
                case "Tanzania":
                    return gmt.AddMinutes(180).ToString();
                case "Thailand":
                    return gmt.AddMinutes(420).ToString();
                case "Tonga":
                    return gmt.AddMinutes(0).ToString();
                case "Trinidad & Tobago":
                    return gmt.AddMinutes(-240).ToString();
                case "Tunisia":
                    return gmt.AddMinutes(60).ToString();
                case "Turkmenistan":
                    return gmt.AddMinutes(300).ToString();
                case "Turks & Caicos Islands":
                    return gmt.AddMinutes(-240).ToString();
                case "Tuvalu":
                    return gmt.AddMinutes(720).ToString();
                case "Uganda":
                    return gmt.AddMinutes(180).ToString();
                case "Ukraine":
                    return gmt.AddMinutes(120).ToString();
                case "Uruguay":
                    return gmt.AddMinutes(-180).ToString();
                case "USA":
                    return gmt.AddMinutes(-480).ToString();
                case "Uzbekistan":
                    return gmt.AddMinutes(300).ToString();
                case "Vanuatu":
                    return gmt.AddMinutes(660).ToString();
                case "Venezuela":
                    return gmt.AddMinutes(-240).ToString();
                case "Vietnam":
                    return gmt.AddMinutes(420).ToString();
                case "Wallis & Futuna Islands":
                    return gmt.AddMinutes(720).ToString();
                case "Yemen":
                    return gmt.AddMinutes(180).ToString();
                case "Zambia":
                    return gmt.AddMinutes(120).ToString();
                case "Zimbabwe":
                    return gmt.AddMinutes(120).ToString();
                default:
                    return "";
            }
        }
    }
}