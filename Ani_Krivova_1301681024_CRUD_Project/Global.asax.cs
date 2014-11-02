using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using Ani_Krivova_1301681024_CRUD_Project;
using System.Data.Entity;
using Ani_Krivova_1301681024_CRUD_Project.Models;


namespace Ani_Krivova_1301681024_CRUD_Project
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();

            // Initialize the product database. 
            Database.SetInitializer(new ProductDatabaseInitializer());
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
    }
}
