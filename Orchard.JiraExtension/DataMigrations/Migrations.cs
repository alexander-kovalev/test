using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.Localization;

namespace Orchard.JiraExtension.DataMigrations
{
    public class Migrations : DataMigrationImpl
    {

        public Localizer T { get; set; }

        public Migrations()
        {
            T = NullLocalizer.Instance;
        }

        public int Create()
        {
            SchemaBuilder.CreateTable("FaqWidgetPartRecord", table => table.ContentPartRecord());

            ContentDefinitionManager.AlterTypeDefinition("FaqWidget",
                                                        cfg =>
                                                        cfg.WithPart("CommonPart", p => p.WithSetting("OwnerEditorSettings.ShowOwnerEditor", "False"))
                                                        .WithPart("WidgetPart")
                                                        .WithPart("FaqWidgetPart")
                                                        .WithSetting("Stereotype", "Widget"));
            return 1;
        }
    }
}