namespace work.ctrl3d.OS
{
    public struct WS_EX
    {
        // Extended Window Styles 정의
        // https://learn.microsoft.com/ko-kr/windows/win32/winmsg/extended-window-styles

        public const uint ACCEPTFILES = 0x00000010;

        public const uint APPWINDOW = 0x00040000;

        public const uint CLIENTEDGE = 0x00000200;

        public const uint COMPOSITED = 0x02000000;

        public const uint CONTEXTHELP = 0x00000400;

        public const uint CONTROLPARENT = 0x00010000;

        public const uint DLGMODALFRAME = 0x00000001;

        public const uint LAYERED = 0x00080000;

        public const uint LAYOUTRTL = 0x00400000;

        public const uint LEFT = 0x00000000;

        public const uint LEFTSCROLLBAR = 0x00004000;

        public const uint LTRREADING = 0x00000000;

        public const uint MDICHILD = 0x00000040;

        public const uint NOACTIVATE = 0x08000000;

        public const uint NOINHERITLAYOUT = 0x00100000;

        public const uint NOPARENTNOTIFY = 0x00000004;

        public const uint WX_EX_NOREDIRECTIONBITMAP = 0x00200000;

        public const uint OVERLAPPEDWINDOW = WINDOWEDGE | CLIENTEDGE;

        public const uint PALETTEWINDOW = WINDOWEDGE | TOOLWINDOW | TOPMOST;

        public const uint RIGHT = 0x00001000;

        public const uint RIGHTSCROLLBAR = 0x00000000;

        public const uint RTLREADING = 0x00002000;

        public const uint STATICEDGE = 0x00020000;

        public const uint TOOLWINDOW = 0x00000080;

        public const uint TOPMOST = 0x00000008;

        public const uint TRANSPARENT = 0x00000020;

        public const uint WINDOWEDGE = 0x00000100;
    }
}