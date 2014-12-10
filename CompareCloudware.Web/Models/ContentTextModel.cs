using CompareCloudware.Web;
using System;
using System.Runtime.CompilerServices;
using CompareCloudware.Web.Helpers;

namespace CompareCloudware.Web.Models
{
    public class ContentTextModel : BaseModel
    {
        public ContentTextModel()
        {
        }

        public ContentTextModel(ICustomSession session)
        {
            base.CustomSession = session;
        }

        public int ContentTextID { get; set; }
        public string ContentTextData { get; set; }
        public byte[] ContentTextGraphic { get; set; }
        public ContentTextTypeModel ContentTextType { get; set; }
        public int BodyOrder { get; set; }
        public string CompositeID { get; set; }
        public string NiceName { get; set; }
        public bool IsEmailLink { get; set; }
        public bool IsUnderline { get; set; }
        public bool IsBold { get; set; }
        public bool IsHyperLink { get; set; }
        public string HyperLinkURL { get; set; }
        public bool IsBulleted { get; set; }
        public bool IsNumbered { get; set; }
        public string NumberSuffix { get; set; }
        public int NumberOrder { get; set; }
        public bool? IsDate { get; set; }
        public bool IsVisible { get; set; }
        public HeaderTagType HeaderTagType { get; set; }
        public bool IsCollapsible { get; set; }
        public bool IsFirstInCollection { get; set; }
        public bool IsLastInCollection { get; set; }
        public ContentDataPage ContentDataPage { get; set; }
        public bool LineBreakBefore { get; set; }
        public bool LineBreakAfter { get; set; }
        public string FontStyle { get; set; }
        public bool IsWidget { get; set; }
        public string WidgetName { get; set; }
        public bool IsImage { get; set; }
        public string ImageURL { get; set; }
        public bool ParagraphBreakAfter { get; set; }

    }

    public class ContentTextModelWithWidget<T> : ContentTextModel
    {
        private T _theModel;

        public ContentTextModelWithWidget()
        {
        }

        public ContentTextModelWithWidget(T theModel, ICustomSession session)
        {
            base.CustomSession = session;
            _theModel = theModel;
        }

        public T GetModel()
        {
            return _theModel;
        }
    }
}

