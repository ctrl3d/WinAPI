namespace work.ctrl3d.OS
{
    public struct MB
    {
        /// <summary>
        /// 메시지 상자에는 중단, 다시 시도 및 무시의 세 가지 푸시 단추가 포함되어 있습니다.
        /// </summary>
        public const uint ABORTRETRYIGNORE = 0x00000002;

        /// <summary>
        /// 메시지 상자에는 취소, 다시 시도, 계속이라는 세 개의 푸시 단추가 포함되어 있습니다.
        /// MB_ABORTRETRYIGNORE 대신 이 메시지 상자 유형을 사용합니다.
        /// </summary>
        public const uint CANCELTRYCONTINUE = 0x00000006;

        /// <summary>
        /// 메시지 상자에 도움말 단추를 추가합니다.
        /// 사용자가 도움말 단추를 클릭하거나 F1 키를 누르면 시스템에서 소유자에게 WM_HELP 메시지를 보냅니다.
        /// </summary>
        public const uint HELP = 0x00004000;

        /// <summary>
        /// 메시지 상자에는 확인이라는 하나의 푸시 단추가 포함되어 있습니다. 이것이 기본값입니다.
        /// </summary>
        public const uint OK = 0x00000000;

        /// <summary>
        /// 메시지 상자에는 확인 및 취소라는 두 개의 푸시 단추가 있습니다.
        /// </summary>
        public const uint OKCANCEL = 0x00000001;

        /// <summary>
        /// 메시지 상자에는 두 개의 푸시 단추인 다시 시도 및 취소가 포함되어 있습니다.
        /// </summary>
        public const uint RETRYCANCEL = 0x00000005;

        /// <summary>
        /// 메시지 상자에는 예 및 아니요라는 두 개의 푸시 단추가 있습니다.
        /// </summary>
        public const uint YESNO = 0x00000004;

        /// <summary>
        /// 메시지 상자에는 예, 아니요 및 취소라는 세 개의 푸시 단추가 포함되어 있습니다.
        /// </summary>
        public const uint YESNOCANCEL = 0x00000003;
    }
}