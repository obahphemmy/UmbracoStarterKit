using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace SampleStarterKit.Core.Extensions
{
    public static class PublishedContentExtensions
    {
        public static int GetContentId(this IPublishedContent content)
        {
            return content.Id;
        }
    }
}
