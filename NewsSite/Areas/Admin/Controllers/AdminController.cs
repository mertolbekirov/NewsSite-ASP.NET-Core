using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static NewsSite.Areas.Admin.AdminConstants;

namespace NewsSite.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdministratorRoleName)]
    public abstract class AdminController : Controller
    {
    }
}
