﻿using EntityFramework_Slider.Services.Interface;
using EntityFramework_Slider.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;

namespace EntityFramework_Slider.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ILayoutService _layoutService;
        public HeaderViewComponent(ILayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            return await Task.FromResult(View(_layoutService.GetSettingDatas()));
              
        }
    }
}
