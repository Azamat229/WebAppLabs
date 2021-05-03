﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace Azamat_id_999.TagHelpers
{

    [HtmlTargetElement(tag: "img", Attributes = "img-action, img-controller")]
    
public class ImageTagHelper : TagHelper
    {
        public string ImgAction { get; set; }
        public string ImgController { get; set; }
        LinkGenerator _linkGenerator;
        public ImageTagHelper(LinkGenerator linkGenerator)
        {
            _linkGenerator = linkGenerator;
        }
        public override void Process(TagHelperContext context,
        TagHelperOutput output)
        {
            var uri = _linkGenerator.GetPathByAction(ImgAction,
            ImgController);
            output.Attributes.Add("src", uri);
        }
    }
}