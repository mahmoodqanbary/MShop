using Microsoft.AspNetCore.Mvc;
using MShop.Data;
using MShop.Data.Repositories;
using MShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MShop.Components
{
    public class ProductGroupComponents : ViewComponent
    {
        private IGroupRepository _groupRepository;
        public ProductGroupComponents(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            return View("/Views/Components/ProductGroupsComponent.cshtml",_groupRepository.GetGroupForShow());
        }
    }
}
