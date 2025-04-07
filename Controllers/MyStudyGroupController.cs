using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myStudyGroup.Controllers
{
    public class MyStudyGroupController : Controller
    {
        // GET: MyStudyGroup
        public ActionResult MyStudyGroupView()
        {
            List<Models.MyStudyGroupModel> People = new List<Models.MyStudyGroupModel>();

            People.Add(new Models.MyStudyGroupModel
            {
                StudentNumber = "u23934794",
                Name = "John",
                Surname = "Doe",
                EmailAddress = "John.Doe@gmail.com",
                MyLink = "~/HTML/JohnDoeHTML.html"
            });
            People.Add(new Models.MyStudyGroupModel
            {
                StudentNumber = "u2261456",
                Name = "Jane",
                Surname = "Doe",
                EmailAddress = "Jane.Doe@gmail.com",
                MyLink = "~/HTML/JaneDoeHTML.html"
            });
            People.Add(new Models.MyStudyGroupModel
            {
                StudentNumber = "u24999794",
                Name = "Joan",
                Surname = "Pieterse",
                EmailAddress = "Joan.Pieterse@gmail.com",
                MyLink = "~/HTML/JoanPieterseHTML.html"
            });
            People.Add(new Models.MyStudyGroupModel
            {
                StudentNumber = "u21234794",
                Name = "Lemmetjie",
                Surname = "Groenewalt",
                EmailAddress = "Lemmetjie.Groenewalt@gmail.com",
                MyLink = "~/HTML/LemmetjieGroenewaltHTML.html"
            });
            People.Add(new Models.MyStudyGroupModel
            {
                StudentNumber = "u24614794",
                Name = "Slewaldo",
                Surname = "Ross",
                EmailAddress = "Lewaldo.Ross@gmail.com",
                MyLink = "~/HTML/LewaldoRossHTML.html"
            });

            return View(People);
        }
    }
}