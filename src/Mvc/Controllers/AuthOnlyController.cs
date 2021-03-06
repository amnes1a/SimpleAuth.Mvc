﻿using Microsoft.AspNetCore.Mvc;
using ServiceStack;
using ServiceStack.Mvc;

namespace Mvc.Controllers
{
    [Authenticate]
    public class AuthOnlyController : ServiceStackController
    {
        public ActionResult Index()
        {
            var session = SessionAs<CustomUserSession>();
            return View(session);
        }
    }
}