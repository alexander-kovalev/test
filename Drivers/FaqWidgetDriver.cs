using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.JiraExtension.Models;

namespace Orchard.JiraExtension.Drivers
{
    public class FaqWidgetDriver : ContentPartDriver<FaqWidgetPart>
    {
        protected override DriverResult Display(FaqWidgetPart part, string displayType, dynamic shapeHelper)
        {
           

            return ContentShape("Parts_FaqWidget",
                                () => shapeHelper.Parts_FaqWidget());
        }

        protected override DriverResult Editor(FaqWidgetPart part, dynamic shapeHelper)
        {
            var temp = ContentShape("Parts_FaqWidget_Edit",
                                () => shapeHelper.EditorTemplate(
                                    TemplateName: "Parts/FaqWidget",
                                    Model: part,
                                    Prefix: Prefix));
            return temp;
        }

        //POST
        protected override DriverResult Editor(FaqWidgetPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);

            return Editor(part, shapeHelper);
        }

        protected override string Prefix
        {
            get { return "FaqWidget"; }
        }

    }
}