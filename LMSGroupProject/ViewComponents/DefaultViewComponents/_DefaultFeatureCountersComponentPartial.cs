﻿using Microsoft.AspNetCore.Mvc;

namespace GroupProject.UI.ViewComponents.DefaultViewComponents
{
    public class _DefaultFeatureCountersComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Counters");
        }
    }
}