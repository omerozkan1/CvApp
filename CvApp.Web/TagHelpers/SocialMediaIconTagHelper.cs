using AutoMapper;
using CvApp.Business.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CvApp.Web.TagHelpers
{
    [HtmlTargetElement("geticons")]
    public class SocialMediaIconTagHelper : TagHelper
    {
        private readonly IAppUserService _appUserService;
        private readonly ISocialMediaIconService _socialMediaIconService;
        private readonly IMapper _mapper;
        public SocialMediaIconTagHelper(IAppUserService appUserService, ISocialMediaIconService socialMediaIconService, IMapper mapper)
        {
            _appUserService = appUserService;
            _socialMediaIconService = socialMediaIconService;
            _mapper = mapper;
        }
        public int AppUserId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var icons = _socialMediaIconService.GetByUserId(AppUserId);
            string data = "<div class='social - icons'>";
            foreach (var item in icons)
            {
                data += $@"<a class='social-icon pr-2' href='{item.Link}'><i class='{item.Icon}'></i></a>";
            }

            data+="</div>";

            output.Content.SetHtmlContent(data);
        }
    }
}
