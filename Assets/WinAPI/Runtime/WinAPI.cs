using System;
using System.Runtime.InteropServices;
using System.Text;

namespace work.ctrl3d.OS
{
    public static class WinAPI
    {
        /// <summary>
        ///
        /// https://learn.microsoft.com/ko-kr/windows/win32/api/winuser/nf-winuser-getwindowtextw
        /// </summary>
        /// <param name="hWnd">텍스트를 포함하는 창 또는 컨트롤에 대한 핸들입니다.</param>
        /// <param name="lpString">텍스트를 받을 버퍼입니다. 문자열이 버퍼보다 길거나 긴 경우 문자열이 잘리고 null 문자로 종료됩니다.</param>
        /// <param name="nMaxCount">null 문자를 포함하여 버퍼에 복사할 최대 문자 수입니다. 텍스트가 이 제한을 초과하면 잘립니다.</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        /// <summary>
        /// 창에 제목 표시줄이 있는 경우 지정된 창의 제목 표시줄 텍스트의 길이를 문자 단위로 검색합니다.
        /// 지정된 창이 컨트롤인 경우 함수는 컨트롤 내의 텍스트 길이를 검색합니다.
        /// 그러나 GetWindowTextLength 다른 애플리케이션에서 편집 컨트롤의 텍스트 길이를 검색할 수 없습니다.
        /// https://learn.microsoft.com/ko-kr/windows/win32/api/winuser/nf-winuser-getwindowtextlengthw
        /// </summary>
        /// <param name="hWnd">창 또는 컨트롤에 대한 핸들입니다.</param>
        /// <returns>
        /// 함수가 성공하면 반환 값은 텍스트의 길이(문자)입니다. 특정 조건에서 이 값은 텍스트 길이보다 클 수 있습니다(주의 참조).
        /// 창에 텍스트가 없으면 반환 값은 0입니다.
        /// 함수 오류는 반환 값이 0이고 0이 아닌 GetLastError 결과로 표시됩니다.
        /// </returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowTextLength(IntPtr hWnd);
        
        /// <summary>
        /// 전경 창(사용자가 현재 작업 중인 창)에 대한 핸들을 검색합니다.
        /// https://learn.microsoft.com/ko-kr/windows/win32/api/winuser/nf-winuser-getforegroundwindow
        /// </summary>
        /// <returns>포그라운드 창에 대한 핸들</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// 창을 전경으로 설정하는 함수입니다.
        /// </summary>
        /// <param name="hWnd">전경으로 설정할 창의 핸들</param>
        /// <returns>설정 성공 여부</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// 클래스 이름과 창 이름으로 창 핸들을 검색하는 함수입니다.
        /// </summary>
        /// <param name="lpClassName">찾을 창의 클래스 이름</param>
        /// <param name="lpWindowName">찾을 창의 이름</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// 지정된 창의 표시 상태를 설정합니다.
        /// https://learn.microsoft.com/ko-kr/windows/win32/api/winuser/nf-winuser-showwindow
        /// </summary>
        /// <param name="hWnd">창에 대한 핸들</param>
        /// <param name="nCmdShow">창을 표시하는 방법을 제어합니다.</param>
        /// <returns>창이 이전에 표시된 경우 반환 값은 0이 아닌 값입니다. 창이 이전에 숨겨져 있으면 반환 값은 0입니다.</returns>
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpString"></param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int RegisterWindowMessage(string lpString);
        
        /// <summary>
        /// 창에 메시지를 전송하는 함수입니다.
        /// </summary>
        /// <param name="hWnd">메시지를 받을 창의 핸들</param>
        /// <param name="Msg">전송할 메시지</param>
        /// <param name="wParam">메시지에 대한 추가 정보</param>
        /// <param name="lParam">메시지에 대한 추가 정보</param>
        /// <returns>메시지 처리 결과</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        

        /// <summary>
        /// 창에 메시지를 전송하는 함수입니다.
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="message"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int message, IntPtr wParam, IntPtr lParam);
        
        /// <summary>
        /// 키보드 이벤트를 시뮬레이트하는 함수입니다.
        /// </summary>
        /// <param name="bVk">가상 키 코드</param>
        /// <param name="bScan">하드웨어 스캔 코드</param>
        /// <param name="dwFlags">이벤트 제어 플래그</param>
        /// <param name="dwExtraInfo">추가 정보</param>
        /// <returns>성공 시 0, 실패 시 오류 코드</returns>
        [DllImport("user32.dll")]
        public static extern uint keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        /// <summary>
        /// 창의 위치와 크기를 설정합니다.
        /// </summary>
        /// <param name="hWnd">윈도우 핸들</param>
        /// <param name="hWndInsertAfter">Z순서 변경 핸들</param>
        /// <param name="x">창의 새로운 X 위치</param>
        /// <param name="y">창의 새로운 Y 위치</param>
        /// <param name="cx">창의 새 너비</param>
        /// <param name="cy">창의 새 높이</param>
        /// <param name="uFlags">창 크기 및 위치 플래그</param>
        /// <returns>창 재배치 성공 시 true, 실패 시 false</returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy,
            uint uFlags);
        
        /// <summary>
        /// 지정된 창의 위치와 크기를 변경합니다.
        /// 최상위 창의 경우 위치와 차원은 화면의 왼쪽 위 모서리를 기준으로 합니다.
        /// 자식 창의 경우 부모 창 클라이언트 영역의 왼쪽 위 모서리를 기준으로 합니다.
        /// https://learn.microsoft.com/ko-kr/windows/win32/api/winuser/nf-winuser-movewindow
        /// </summary>
        /// <param name="hWnd">창에 대한 핸들입니다.</param>
        /// <param name="x">창 왼쪽의 새 위치입니다.</param>
        /// <param name="y">창 위쪽의 새 위치입니다.</param>
        /// <param name="nWidth">창의 새 너비입니다.</param>
        /// <param name="nHeight">창의 새 높이입니다.</param>
        /// <param name="bRepaint">창을 다시 칠할지 여부를 나타냅니다.
        /// 이 매개 변수가 TRUE이면 창에 메시지가 표시됩니다.
        /// 매개 변수가 FALSE이면 어떤 종류의 다시 그리기도 발생하지 않습니다.
        /// 이는 클라이언트 영역, 비클라이언트 영역(제목 표시줄 및 스크롤 막대 포함) 및 자식 창을 이동한 결과로
        /// 발견된 부모 창의 모든 부분에 적용됩니다.</param>
        /// <returns>함수가 성공하면 반환 값이 0이 아닙니다. 함수가 실패하면 반환 값은 0입니다.
        /// 확장 오류 정보를 가져오려면 GetLastError를 호출합니다.</returns>
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool bRepaint);
        
        /// <summary>
        /// 현재 창의 스타일을 가져오는 함수입니다.
        /// </summary>
        /// <param name="hWnd">윈도우 핸들</param>
        /// <param name="nIndex">설정할 윈도우 속성</param>
        /// <returns>윈도우 스타일</returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowLong(IntPtr hWnd, int nIndex);
        
        /// <summary>
        /// 현재 창의 스타일을 설정하는 함수입니다.
        /// </summary>
        /// <param name="hWnd">윈도우 핸들</param>
        /// <param name="nIndex">설정할 윈도우 속성</param>
        /// <param name="dwNewLong">새로운 윈도우 스타일</param>
        /// <returns>이전 윈도우 스타일</returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);
        
        /// <summary>
        /// 각 자식 창에 핸들을 차례로 애플리케이션 정의 콜백 함수에 전달하여 지정된 부모 창에 속하는 자식 창을 열거합니다.
        /// EnumChildWindows는 마지막 자식 창이 열거되거나 콜백 함수가 FALSE를 반환할 때까지 계속됩니다.
        ///
        /// https://learn.microsoft.com/ko-kr/windows/win32/api/winuser/nf-winuser-enumchildwindows
        /// </summary>
        /// <param name="hWndParent"></param>
        /// <param name="lpEnumFunc"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool EnumChildWindows(IntPtr hWndParent, WindowEnumProc lpEnumFunc, IntPtr lParam);
        
        /// <summary>
        /// EnumChildWindows 함수 와 함께 사용되는 애플리케이션 정의 콜백 함수입니다.
        /// 자식 창 핸들을 수신합니다. WNDENUMPROC 유형은 이 콜백 함수에 대한 포인터를 정의합니다.
        /// EnumChildProc 는 애플리케이션 정의 함수 이름의 플레이스홀더입니다.
        /// </summary>
        /// <param name="hWnd">EnumChildWindows에 지정된 부모 창의 자식 창에 대한 핸들입니다 </param>
        /// <param name="lParam">EnumChildWindows에 지정된 애플리케이션 정의 값입니다.</param>
        /// <returns>창이 열거되면 TRUE를 반환하고, 그렇지 않으면 FALSE를 반환합니다.</returns>
        public delegate int WindowEnumProc(IntPtr hWnd, IntPtr lParam);
        
        /// <summary>
        /// 시스템 아이콘, 단추 집합 및 상태 또는 오류 정보와 같은 간단한 애플리케이션 관련 메시지가 포함된 모달 대화 상자를 표시합니다.
        /// 메시지 상자는 사용자가 클릭한 단추를 나타내는 정수 값을 반환합니다.
        ///
        /// https://learn.microsoft.com/ko-kr/windows/win32/api/winuser/nf-winuser-messagebox
        /// </summary>
        /// <param name="hWnd">만들 메시지 상자의 소유자 창에 대한 핸들입니다.
        /// 이 매개 변수가 NULL이면 메시지 상자에 소유자 창이 없습니다.</param>
        /// <param name="lpText">표시할 메시지입니다.
        /// 문자열이 둘 이상의 줄로 구성된 경우 각 줄 사이에 캐리지 리턴 및/또는 줄 바꿈 문자를 사용하여 줄을 구분할 수 있습니다.</param>
        /// <param name="lpCaption">대화 상자 제목입니다. 이 매개 변수가 NULL이면 기본 제목은 Error입니다.</param>
        /// <param name="uType">대화 상자의 내용 및 동작입니다. 이 매개 변수는 다음 플래그 그룹의 플래그 조합일 수 있습니다.
        /// 메시지 상자에 표시되는 단추를 나타내려면 다음 값 중 하나를 지정합니다.</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        
        /// <summary>
        /// 계층적 창의 불투명도 및 투명도 색상 키를 설정합니다.
        ///
        /// https://learn.microsoft.com/ko-kr/windows/win32/api/winuser/nf-winuser-setlayeredwindowattributes
        /// </summary>
        /// <param name="hWnd">계층화된 창에 대한 핸들입니다. CreateWindowEx 함수를 사용하여 창을 만들 때 WS_EX_LAYERED 지정하거나 창을 만든 후 SetWindowLong을 통해 WS_EX_LAYERED 설정하여 계층화된 창을 만듭니다.
        /// Windows 8: 최상위 창 및 자식 창에 대해 WS_EX_LAYERED 스타일이 지원됩니다. 이전 Windows 버전은 최상위 창에 대해서만 WS_EX_LAYERED 지원합니다.</param>
        /// <param name="crKey">계층화된 창을 작성할 때 사용할 투명도 색 키를 지정하는 COLORREF 구조체입니다.
        /// 이 색의 창에 의해 그려진 모든 픽셀은 투명합니다. COLORREF를 생성하려면 RGB 매크로를 사용합니다.</param>
        /// <param name="bAlpha">계층화된 창의 불투명도를 설명하는 데 사용되는 알파 값입니다.
        /// BLENDFUNCTION 구조체의 SourceConstantAlpha 멤버와 유사합니다.
        /// bAlpha가 0이면 창이 완전히 투명합니다. bAlpha가 255이면 창이 불투명합니다.</param>
        /// <param name="dwFlags">수행할 작업입니다. 이 매개 변수는 다음 값 중 하나 이상일 수 있습니다.</param>
        /// <returns>함수가 성공하면 반환 값이 0이 아닙니다.
        /// 함수가 실패하면 반환 값은 0입니다. 확장 오류 정보를 가져오려면 GetLastError를 호출합니다.</returns>
        [DllImport("user32.dll")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, uint crKey, byte bAlpha, uint dwFlags);
        
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

    }
}