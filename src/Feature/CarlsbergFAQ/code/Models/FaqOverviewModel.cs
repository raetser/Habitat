using static Carlsberg.Feature.Faq.Templates;

namespace Carlsberg.Feature.Faq.Models
{
    public class FaqOverviewModel
    {
        public IFaqOverview FaqOverview { get; set; }
    }

    public class FaqCategoryPageModel
    {
        public IFaqCategory FaqCategory { get; set; }
        public IFaqCategoryMenu FaqCategoryMenu { get; set; }
    }
}
