namespace work.ctrl3d.OS
{
    public struct SWP
    {
        // SetWindowPos 함수에 전달되는 상수 정의
    
        /// <summary>
        /// 창 위치 변경을 비동기적으로 처리합니다.
        /// </summary>
        public const uint ASYNCWINDOWPOS = 0x4000;
    
        /// <summary>
        /// 창 크기 변경 시 화면 지우기를 지연시킵니다.
        /// </summary>
        public const uint DEFERERASE = 0x2000;
    
        /// <summary>
        /// 창에 프레임을 그립니다.
        /// </summary>
        public const uint DRAWFRAME = 0x0020;
    
        /// <summary>
        /// 창의 프레임이 변경되었음을 알립니다.
        /// </summary>
        public const uint FRAMECHANGED = 0x0020;
    
        /// <summary>
        /// 창을 숨깁니다.
        /// </summary>
        public const uint HIDEWINDOW = 0x0080;
    
        /// <summary>
        /// 창을 활성화하지 않습니다.
        /// </summary>
        public const uint NOACTIVATE = 0x0010;
    
        /// <summary>
        /// 창의 비트를 복사하지 않습니다.
        /// </summary>
        public const uint NOCOPYBITS = 0x0100;
    
        /// <summary>
        /// 현재 위치를 유지합니다.
        /// </summary>
        public const uint NOMOVE = 0x0002;
    
        /// <summary>
        /// Z 순서에서 소유자 창의 위치를 변경하지 않습니다.
        /// </summary>
        public const uint NOOWNERZORDER = 0x0200;
    
        /// <summary>
        /// 변경 사항을 다시 그리지 않습니다.
        /// </summary>
        public const uint NOREDRAW = 0x0008;
    
        /// <summary>
        /// 창을 다시 배치하지 않습니다.
        /// </summary>
        public const uint NOREPOSITION = 0x0200;
    
        /// <summary>
        /// WM_WINDOWPOSCHANGING 메시지를 보내지 않습니다.
        /// </summary>
        public const uint NOSENDCHANGING = 0x0400;
    
        /// <summary>
        /// 현재 크기를 유지합니다.
        /// </summary>
        public const uint NOSIZE = 0x0001;
    
        /// <summary>
        /// 현재 Z 순서를 유지합니다.
        /// </summary>
        public const uint NOZORDER = 0x0004;
    
        /// <summary>
        /// 창을 표시합니다.
        /// </summary>
        public const uint SHOWWINDOW = 0x0040;
    
        /// <summary>
        /// 창을 Z 순서의 맨 위로 이동시킵니다.
        /// </summary>
        public const uint HWND_TOP = 0x00000000;

        /// <summary>
        /// 창을 Z 순서의 맨 아래로 이동시킵니다.
        /// </summary>
        public const uint HWND_BOTTOM = 0x00000001;
    
        /// <summary>
        /// 창을 모든 비-최상위 창 위에 배치합니다. 창이 비활성화 되어도 그 최상위 위치를 유지합니다.
        /// </summary>
        public const uint HWND_TOPMOST = 0xFFFFFFFF;
    
        /// <summary>
        /// 창을 최상위 창 바로 아래에 배치합니다. 창이 최상위 창이라면 그 상태를 잃고 모든 다른 창들 아래로 이동합니다.
        /// </summary>
        public const uint HWND_NOTOPMOST = 0xFFFFFFFE;
    }
}