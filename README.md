# Orchard Core Multitenant Decouples Blazor InteractiveServer Example

**.NET8**

This example was made with the following tenants.js

``` json
{
  "Default": {
    "VersionId": "4bebppwpp0m3ts3f213g4584cm",
    "TenantId": "4cn6tq65x3cyn27y80ac6e95n3",
    "State": "Running"
  },
  "firsttenant": {
    "VersionId": "4gfc0j2ezgpyc7xxqth4r5sdwj",
    "TenantId": "49dw6s44shsxtt4y6ky6q5y05w",
    "RequestUrlPrefix": "first",
    "State": "Running"
  },
  "second": {
    "VersionId": "48mxfjxs9d17at1nxvp7w1944m",
    "TenantId": "4f2ppdm35cyrj67eaf71sw2x5s",
    "RequestUrlPrefix": "second",
    "State": "Running"
  }
}
```

Default, first and second. 

The content can be imported in each tenant after the tenants are created and setup.

See the ```Recipe.json``` in the Recipes folder.

(Use ```https://localhost:5001/Admin/DeploymentPlan/Import/Json``` to import it on the Default host, ```https://localhost:5001/first/Admin/DeploymentPlan/Import/Json``` on the tenant 'first' etc.)

## Base Url

Every SPA (including Blazor, even when running server side) needs to know the base Url.

To make sure the right base url is set, [ns8482e](https://github.com/ns8482e) pointed out here [oc github discussion](https://github.com/OrchardCMS/OrchardCore/discussions/14722#discussioncomment-7622743), that this could be done with little effort.

I created a MultiTenantBaseUrlProvider component that, used as markup, renders the correct ```<base />``` element for each tenant.

Not the best way, but for starters, I made sure each tenant can have its own favicon.
