﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Microsoft.Practices.Unity;
using Examples.Common.Services;

namespace WebFormsDemo.UnityBuildUp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var container = new UnityContainer();
            Application["Container"] = container; // 把容器物件保存在共用變數裡

            // 註冊型別
            container.RegisterType<IMessageService, MessageService>();
        }
    }
}