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

namespace OcBlazorSampleLib.Services;

public static class ContentItemsService
{
    public static async Task<string?> GetContentBodyByAlias(string alias, IContentHandleManager handleManager, IContentManager contentManager)
    {
        var id = await handleManager.GetContentItemIdAsync($"alias:{alias}");
        var contentItem = await contentManager.GetAsync(id, VersionOptions.Published);
        string? result;
        try
        {
            var bodyAspect = await contentManager.PopulateAspectAsync<BodyAspect>(contentItem);
            result = bodyAspect.Body.ToString();
        }
        catch (Exception ex)
        {
            result = ex.Message;
        }
        return result;
    }

    public static async Task<ContentItem?> GetContentItemWithBodyByAlias(string alias, IContentHandleManager handleManager, IContentManager contentManager)
    {
        var id = await handleManager.GetContentItemIdAsync($"alias:{alias}");

        var contentItem = await contentManager.GetAsync(id, VersionOptions.Published);

        try
        {
            var bodyAspect = await contentManager.PopulateAspectAsync<BodyAspect>(contentItem);
        }
        catch
        {
        }
        return contentItem;
    }

    public static async Task<string?> GetAspectBody(ContentItem? contentItem, IContentManager contentManager)
    {
        if (contentItem == null) return null;

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
