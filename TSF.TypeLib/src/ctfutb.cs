using System;

namespace TSF.TypeLib
{
    [Flags]
    public enum TF_LBI : uint
    {
        TF_LBI_ICON = 0x00000001,
        TF_LBI_TEXT = 0x00000002,
        TF_LBI_TOOLTIP = 0x00000004,
        TF_LBI_BITMAP = 0x00000008,
        TF_LBI_BALLOON = 0x00000010,
        TF_LBI_CUSTOMUI = 0x00000020,
        TF_LBI_BMPALL = TF_LBI_BITMAP | TF_LBI_TOOLTIP,
        TF_LBI_BMPBTNALL = TF_LBI_BITMAP | TF_LBI_TEXT | TF_LBI_TOOLTIP,
        TF_LBI_BTNALL = TF_LBI_ICON | TF_LBI_TEXT | TF_LBI_TOOLTIP,
        TF_LBI_STATUS = 0x00010000,
    }

    [Flags]
    public enum TF_LBI_STYLE : uint
    {
        TF_LBI_STYLE_HIDDENSTATUSCONTROL = 0x00000001,
        TF_LBI_STYLE_SHOWNINTRAY = 0x00000002,
        TF_LBI_STYLE_HIDEONNOOTHERITEMS = 0x00000004,
        TF_LBI_STYLE_SHOWNINTRAYONLY = 0x00000008,
        TF_LBI_STYLE_HIDDENBYDEFAULT = 0x00000010,
        TF_LBI_STYLE_TEXTCOLORICON = 0x00000020,
        TF_LBI_STYLE_BTN_BUTTON = 0x00010000,
        TF_LBI_STYLE_BTN_MENU = 0x00020000,
        TF_LBI_STYLE_BTN_TOGGLE = 0x00040000,
    }

    [Flags]
    public enum TF_LBI_STATUS : uint
    {
        TF_LBI_STATUS_HIDDEN = 0x00000001,
        TF_LBI_STATUS_DISABLED = 0x00000002,
        TF_LBI_STATUS_BTN_TOGGLED = 0x00010000,
    }

    [Flags]
    public enum TF_SFT : uint
    {
        TF_SFT_SHOWNORMAL = 0x00000001,
        TF_SFT_DOCK = 0x00000002,
        TF_SFT_MINIMIZED = 0x00000004,
        TF_SFT_HIDDEN = 0x00000008,
        TF_SFT_NOTRANSPARENCY = 0x00000010,
        TF_SFT_LOWTRANSPARENCY = 0x00000020,
        TF_SFT_HIGHTRANSPARENCY = 0x00000040,
        TF_SFT_LABELS = 0x00000080,
        TF_SFT_NOLABELS = 0x00000100,
        TF_SFT_EXTRAICONSONMINIMIZED = 0x00000200,
        TF_SFT_NOEXTRAICONSONMINIMIZED = 0x00000400,
        TF_SFT_DESKBAND = 0x00000800,
    }

    public static class LangBarDeclarations
    {
        public static readonly string TF_FLOATINGLANGBAR_WNDTITLE = "TF_FloatingLangBar_WndTitle";

        [Obsolete("Not used.")]
        public static readonly int TF_LBI_BMPF_VERTICAL = 0x00000001;

        [Obsolete("Not used.")]
        public static readonly int TF_INVALIDMENUITEM = -1;

        public const int TF_LBI_DESC_MAXLEN = 32;
    }

    [Flags]
    public enum TF_DTLBI : uint
    {
        TF_DTLBI_NONE = 0,
        TF_DTLBI_USEPROFILEICON = 0x00000001,
    }

    [Flags]
    public enum TF_LBMENUF : uint
    {
        TF_LBMENUF_CHECKED = 0x01,
        TF_LBMENUF_SUBMENU = 0x02,
        TF_LBMENUF_SEPARATOR = 0x04,
        TF_LBMENUF_RADIOCHECKED = 0x08,
        TF_LBMENUF_GRAYED = 0x10,
    }
}