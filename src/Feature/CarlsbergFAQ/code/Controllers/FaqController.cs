namespace Carlsberg.Feature.Faq.Controllers
{
    using Glass.Mapper.Sc.Web.Mvc;
    using System.Web.Mvc;

    public class FaqController : GlassController
    {
        public ActionResult FaqOverview()
        {
            var model = new Models.FaqOverviewModel
            {
                FaqOverview = GetDataSourceItem<Templates.IFaqOverview>(),
            };

            return View(model);
        }

        public ActionResult FaqCategoryPage()
        {
            var model = new Models.FaqCategoryPageModel
            {
                FaqCategory = SitecoreContext.GetCurrentItem<Templates.IFaqCategory>(),
                FaqCategoryMenu = SitecoreContext.GetCurrentItem<Templates.IFaqCategoryMenu>()
            };

            return View(model);
        }
    }
}
