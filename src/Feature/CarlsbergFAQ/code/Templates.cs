using Sitecore.Foundation.Models.Abstract;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System.Collections.Generic;

namespace Carlsberg.Feature.Faq
{
  public struct Templates
  {

        [SitecoreType(TemplateId = "{8C9A0596-5C35-43BB-BB39-E5DB61516955}", AutoMap = true, EnforceTemplate = SitecoreEnforceTemplate.Template)]
        public interface IFaqOverview : IBaseItem
        {
            [SitecoreField("Title")]
            string Title { get; set; }

            [SitecoreField("Description")]
            string Description { get; set; }

            [SitecoreChildren(InferType = true)]
            IEnumerable<IFaqCategory> FaqCategories { get; set; }
        }

        [SitecoreType(TemplateId = "{6119D355-1BD5-40DE-94C2-34C9412ACC70}", AutoMap = true, EnforceTemplate = SitecoreEnforceTemplate.TemplateAndBase)]
        public interface IFaqCategory : IBaseItem
        {
            [SitecoreField("Title")]
            string Title { get; set; }

            [SitecoreField("Description")]
            string Description { get; set; }

            [SitecoreField("Questions and Answers")]
            IEnumerable<IFaqQuestionAndAnswer> QuestionsAnswers { get; set; }
        }

        public interface IFaqCategoryMenu : IBaseItem
        {
            [SitecoreParent(InferType = true)]
            IFaqOverview FaqOverview { get; set; }
        }

        [SitecoreType(TemplateId = "{C2396B50-EA20-41DC-ABA3-F2CBEFDB527D}", AutoMap = true, EnforceTemplate = SitecoreEnforceTemplate.Template)]
        public interface IFaqQuestionAndAnswer : IBaseItem
        {
            [SitecoreField("Question")]
            string Question { get; set; }

            [SitecoreField("Answer")]
            string Answer { get; set; }
        }
    }
}
