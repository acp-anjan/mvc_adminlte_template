﻿using System.Web;
using System.Web.Mvc;

namespace mvc_admin_lte_template
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}