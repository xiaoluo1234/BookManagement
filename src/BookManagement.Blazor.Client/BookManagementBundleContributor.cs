﻿using Volo.Abp.Bundling;

namespace BookManagement.Blazor.Client;

/* Add your global styles/scripts here.
 * See https://abp.io/docs/latest/framework/ui/blazor/global-scripts-styles to learn how to use it
 */
public class BookManagementBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
