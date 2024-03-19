using OrchardCore;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.ContentManagement.Models;
using OrchardCore.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcBlazorSampleAppLib.Services;

public static class ContentItemsService
{
    public static async Task<ContentItem?> GetContentItemByAlias(string alias, IContentHandleManager handleManager, IContentManager contentManager)
    {
        var id = await handleManager.GetContentItemIdAsync($"alias:{alias}");
        try
        {
            var contentItem = await contentManager.GetAsync(id, VersionOptions.Published);
            return contentItem;
        }
        catch (Exception)
        {
            return null;
        }

    }

    public static async Task<string?> GetBodyAspect(ContentItem? contentItem, IContentManager contentManager)
    {
        if (contentItem is null) { return null; }

        try
        {
            var bodyAspect = await contentManager.PopulateAspectAsync<BodyAspect>(contentItem);
            return bodyAspect.Body.ToString();
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}
