using Hobby.DTO;
using Hobby.Services.Interfaces;
using Hobby.Web.Authorize;
using Hobby.Web.Models;
using Hobby.Web.Parts;
using Hobby.Web.Parts.Profile.Models;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Hobby.Web.Controllers
{
    public class ProfileController : BaseController
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private readonly IUserService _userService;
        private readonly IActivitiesService _activitiesService;

        public ProfileController(IUserService userService, IActivitiesService activitiesService)
        {
            _userService = userService;
            _activitiesService = activitiesService;
        }

        public ActionResult Index(ProfileViewModel model)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = _userService.GetUserDTO(User.UserId);
                var userActivities = _activitiesService.GetUserActivities(user.Id);
             }

            return View();
        }
    }
}