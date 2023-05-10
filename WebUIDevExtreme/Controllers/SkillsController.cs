using Microsoft.AspNetCore.Mvc;
using Core.Entities;
using Core.InterFace;

namespace WebUIDevExtreme.Controllers
{
    public class SkillsController : BaseController<Skills>
    {
        public SkillsController(IUnitOfWork<Skills> context) : base(context)
        {
        }
    }
}
