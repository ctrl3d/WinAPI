namespace work.ctrl3d
{
    public struct SW

    {
        // ShowWindow 함수에 전달되는 상수 정의

        /// <summary>
        /// 창을 숨기고 다른 창을 활성화합니다.
        /// </summary>
        public const int HIDE = 0;

        /// <summary>
        /// 창을 활성화하고 표시합니다. 창을 최소화, 최대화 또는 정렬하면 시스템은 창을 원래 크기와 위치로 복원합니다.
        /// 애플리케이션은 창을 처음으로 표시할 때 이 플래그를 지정해야 합니다.
        /// </summary>
        public const int SHOWNORMAL = 1;

        public const int NORMAL = 1;

        /// <summary>
        /// 창을 활성화하고 최소화된 창으로 표시합니다.
        /// </summary>
        public const int SHOWMINIMIZED = 2;

        /// <summary>
        /// 창을 활성화하고 최대화된 창으로 표시합니다.
        /// </summary>
        public const int SHOWMAXIMIZED = 3;

        public const int MAXIMIZE = 3;

        /// <summary>
        /// 창의 최근 크기와 위치를 표시합니다. 이 값은 창이 활성화되지 않았다는 점을 제외하고 SW_SHOWNORMAL 비슷합니다.
        /// </summary>
        public const int SHOWNOACTIVATE = 4;

        /// <summary>
        /// 창을 활성화하고 현재 크기와 위치에 표시합니다.
        /// </summary>
        public const int SHOW = 5;

        /// <summary>
        /// 지정된 창을 최소화하고 Z 순서로 다음 최상위 창을 활성화합니다.
        /// </summary>
        public const int MINIMIZE = 6;

        /// <summary>
        /// 창을 최소화된 창으로 표시합니다. 이 값은 창이 활성화되지 않은 경우를 제외하고 SW_SHOWMINIMIZED 비슷합니다.
        /// </summary>
        public const int SHOWMINNOACTIVE = 7;

        /// <summary>
        /// 창을 현재 크기와 위치로 표시합니다. 이 값은 창이 활성화되지 않았다는 점을 제외하고 SW_SHOW 비슷합니다.
        /// </summary>
        public const int SHOWNA = 8;

        /// <summary>
        /// 창을 활성화하고 표시합니다. 창을 최소화, 최대화 또는 정렬하면 시스템은 창을 원래 크기와 위치로 복원합니다.
        /// 애플리케이션은 최소화된 창을 복원할 때 이 플래그를 지정해야 합니다.
        /// </summary>
        public const int RESTORE = 9;

        /// <summary>
        /// 애플리케이션을 시작한 프로그램에서 CreateProcess 함수에 전달된
        /// STARTUPINFO 구조체에 지정된 SW_ 값을 기반으로 표시 상태를 설정합니다.
        /// </summary>
        public const int SHOWDEFAULT = 10;

        /// <summary>
        /// 창을 소유하는 스레드가 응답하지 않더라도 창을 최소화합니다.
        /// 이 플래그는 다른 스레드에서 창을 최소화할 때만 사용해야 합니다.
        /// </summary>
        public const int FORCEMINIMIZE = 11;
    }
}