using System.Drawing;

namespace CXLIB
{
    public interface IEditBox
    {
        Color EmptyBackColor { get; set; }
        Color EmptyForeColor { get; set; }

        Color FilledBackColor { get; set; }
        Color FilledForeColor { get; set; }

        Color FocusBackColor { get; set; }
        Color FocusForeColor { get; set; }

        Color ReadOnlyBackColor { get; set; }
        Color ReadOnlyForeColor { get; set; }
    }
}
