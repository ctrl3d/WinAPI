namespace work.ctrl3d.OS
{
    public struct GWL
    {
        // SetWindowLong 함수에 전달되는 상수 정의
        // https://learn.microsoft.com/ko-kr/windows/win32/api/winuser/nf-winuser-setwindowlonga
        
        /// <summary>
        /// 새 확장 창 스타일을 설정합니다.
        /// </summary>
        public const int EXSTYLE = -20;
        
        /// <summary>
        /// 새 애플리케이션 instance 핸들을 설정합니다.
        /// </summary>
        public const int HINSTANCE = -6;
        
        /// <summary>
        /// 자식 창의 새 식별자를 설정합니다. 창은 최상위 창일 수 없습니다.
        /// </summary>
        public const int ID = -12;
        
        /// <summary>
        /// 새 창 스타일을 설정합니다.
        /// </summary>
        public const int STYLE = -16;
        
        /// <summary>
        /// 창과 연결된 사용자 데이터를 설정합니다.
        /// 이 데이터는 창을 만든 애플리케이션에서 사용하기 위한 것입니다. 해당 값은 처음에 0입니다.
        /// </summary>
        public const int USERDATA = -21;
        
        /// <summary>
        /// 창 프로시저의 새 주소를 설정합니다. 창이 호출 스레드와 동일한 프로세스에 속하지 않으면 이 특성을 변경할 수 없습니다.
        /// </summary>
        public const int WNDPROC = -4;
    }
}