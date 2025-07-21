namespace work.ctrl3d
{
    public struct WS
    {
        // Window Styles 정의
        // https://learn.microsoft.com/ko-kr/windows/win32/winmsg/window-styles

        /// <summary>
        /// 창에 얇은 테두리가 있습니다.
        /// </summary>
        public const uint BORDER = 0x00800000;

        /// <summary>
        /// 창에 제목 표시줄이 있습니다(WS_BORDER 스타일 포함).
        /// </summary>
        public const uint CAPTION = 0x00C00000;

        /// <summary>
        /// 창이 자식 창입니다. 이 스타일이 있는 창에는 메뉴 모음이 있을 수 없습니다.
        /// 이 스타일은 WS_POPUP 스타일과 함께 사용할 수 없습니다.
        /// </summary>
        public const uint CHILD = 0x40000000;

        /// <summary>
        /// WS_CHILD 스타일과 동일합니다.
        /// </summary>
        public const uint CHILDWINDOW = 0x40000000;

        /// <summary>
        /// 부모 창 내에서 그리기가 발생할 때 자식 창에서 차지하는 영역을 제외합니다.
        /// 이 스타일은 부모 창을 만들 때 사용됩니다.
        /// </summary>
        public const uint CLIPCHILDREN = 0x02000000;

        /// <summary>
        /// 자식 창을 서로 상대적으로 클리핑합니다.
        /// 즉, 특정 자식 창이 WM_PAINT 메시지를 받으면 WS_CLIPSIBLINGS 스타일은
        /// 업데이트할 자식 창의 영역에서 겹치는 다른 모든 자식 창을 클립합니다.
        /// WS_CLIPSIBLINGS 지정하지 않고 자식 창이 겹치는 경우
        /// 자식 창의 클라이언트 영역 내에서 그릴 때 인접한 자식 창의 클라이언트 영역 내에서 그릴 수 있습니다.
        /// </summary>
        public const uint CLIPSIBLINGS = 0x04000000;

        /// <summary>
        /// 창은 처음에 사용하지 않도록 설정되었습니다.
        /// 사용하지 않도록 설정된 창은 사용자로부터 입력을 받을 수 없습니다.
        /// 창을 만든 후 이를 변경하려면 EnableWindow 함수를 사용합니다.
        /// </summary>
        public const uint DISABLED = 0x08000000;

        /// <summary>
        /// 창에는 일반적으로 대화 상자와 함께 사용되는 스타일의 테두리가 있습니다.
        /// 이 스타일이 있는 창에는 제목 표시줄이 있을 수 없습니다.
        /// </summary>
        public const uint DLGFRAME = 0x00400000;

        /// <summary>
        /// 창은 컨트롤 그룹의 첫 번째 컨트롤입니다.
        /// 그룹은 이 첫 번째 컨트롤과 그 다음에 정의된 모든 컨트롤로 구성되며, WS_GROUP 스타일을 사용하여 다음 컨트롤까지 구성됩니다.
        /// 각 그룹의 첫 번째 컨트롤에는 일반적으로 사용자가 그룹에서 그룹으로 이동할 수 있도록 WS_TABSTOP 스타일이 있습니다.
        /// 이후에 사용자는 방향 키를 사용하여 그룹의 한 컨트롤에서 그룹의 다음 컨트롤로 키보드 포커스를 변경할 수 있습니다.
        /// 이 스타일을 켜고 끄면 대화 상자 탐색을 변경할 수 있습니다. 창을 만든 후 이 스타일을 변경하려면 SetWindowLong 함수를 사용합니다.
        /// </summary>
        public const uint GROUP = 0x00020000;

        /// <summary>
        /// 창에 가로 스크롤 막대가 있습니다.
        /// </summary>
        public const uint HSCROLL = 0x00100000;

        /// <summary>
        /// 창은 처음에 최소화됩니다. WS_MINIMIZE 스타일과 동일합니다.
        /// </summary>
        public const uint ICONIC = 0x20000000;

        /// <summary>
        /// 창은 처음에 최대화됩니다.
        /// </summary>
        public const uint MAXIMIZE = 0x01000000;

        /// <summary>
        /// 창에 최대화 단추가 있습니다. WS_EX_CONTEXTHELP 스타일과 결합할 수 없습니다. WS_SYSMENU 스타일도 지정해야 합니다.
        /// </summary>
        public const uint MAXIMIZEBOX = 0x00010000;

        /// <summary>
        /// 창은 처음에 최소화됩니다. WS_ICONIC 스타일과 동일합니다.
        /// </summary>
        public const uint MINIMIZE = 0x20000000;

        /// <summary>
        /// 창에 최소화 단추가 있습니다. WS_EX_CONTEXTHELP 스타일과 결합할 수 없습니다.
        /// WS_SYSMENU 스타일도 지정해야 합니다.
        /// </summary>
        public const uint MINIMIZEBOX = 0x00020000;

        /// <summary>
        /// 창이 겹치는 창입니다. 겹치는 창에는 제목 표시줄과 테두리가 있습니다. WS_TILED 스타일과 동일합니다.
        /// </summary>
        public const uint OVERLAPPED = 0x00000000;

        /// <summary>
        /// 창이 겹치는 창입니다. WS_TILEDWINDOW 스타일과 동일합니다.
        /// </summary>
        public const uint OVERLAPPEDWINDOW =
            OVERLAPPED | CAPTION | SYSMENU | THICKFRAME | MINIMIZEBOX | MAXIMIZEBOX;

        /// <summary>
        /// 창이 팝업 창입니다. 이 스타일은 WS_CHILD 스타일과 함께 사용할 수 없습니다.
        /// </summary>
        public const uint POPUP = 0x80000000;

        /// <summary>
        /// 창이 팝업 창입니다. 창 메뉴를 표시하려면 WS_CAPTION 및 WS_POPUPWINDOW 스타일을 결합해야 합니다.
        /// </summary>
        public const uint POPUPWINDOW = POPUP | BORDER | SYSMENU;

        /// <summary>
        /// 창에 크기 조정 테두리가 있습니다. WS_THICKFRAME 스타일과 동일합니다.
        /// </summary>
        public const uint SIZEBOX = 0x00040000;

        /// <summary>
        /// 창에는 제목 표시줄에 창 메뉴가 있습니다. WS_CAPTION 스타일도 지정해야 합니다.
        /// </summary>
        public const uint SYSMENU = 0x00080000;

        /// <summary>
        /// 창은 사용자가 TAB 키를 누를 때 키보드 포커스를 받을 수 있는 컨트롤입니다.
        /// TAB 키를 누르면 키보드 포커스가 WS_TABSTOP 스타일로 다음 컨트롤로 바뀝니다.
        /// 이 스타일을 켜고 끄면 대화 상자 탐색을 변경할 수 있습니다.
        /// 창을 만든 후 이 스타일을 변경하려면 SetWindowLong 함수를 사용합니다.
        /// 사용자가 만든 창 및 모덜리스 대화 상자가 탭 정지에서 작동하려면 메시지 루프를 변경하여 IsDialogMessage 함수를 호출합니다.
        /// </summary>
        public const uint TABSTOP = 0x00010000;

        /// <summary>
        /// 창에 크기 조정 테두리가 있습니다. WS_SIZEBOX 스타일과 동일합니다.
        /// </summary>
        public const uint THICKFRAME = 0x00040000;

        /// <summary>
        /// 창이 겹치는 창입니다. 겹치는 창에는 제목 표시줄과 테두리가 있습니다. WS_OVERLAPPED 스타일과 동일합니다.
        /// </summary>
        public const uint TILED = 0x00000000;

        /// <summary>
        /// 창이 겹치는 창입니다. WS_OVERLAPPEDWINDOW 스타일과 동일합니다.
        /// </summary>
        public const uint TILEDWINDOW =
            OVERLAPPED | CAPTION | SYSMENU | THICKFRAME | MINIMIZEBOX | MAXIMIZEBOX;

        /// <summary>
        /// 창이 처음에 표시됩니다. 이 스타일은 ShowWindow 또는 SetWindowPos 함수를 사용하여 설정 및 해제할 수 있습니다.
        /// </summary>
        public const uint VISIBLE = 0x10000000;

        /// <summary>
        /// 창에 세로 스크롤 막대가 있습니다.
        /// </summary>
        public const uint VSCROLL = 0x00200000;
    }
}