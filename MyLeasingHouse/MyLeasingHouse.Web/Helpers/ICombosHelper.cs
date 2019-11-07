using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyLeasingHouse.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPropertyTypes();
    }
}