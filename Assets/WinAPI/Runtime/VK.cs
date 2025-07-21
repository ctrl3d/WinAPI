namespace work.ctrl3d
{
    public struct VK
    {
        public const int KEYEVENTF_KEYDOWN = 0x0000;
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        public const int KEYEVENTF_KEYUP = 0x0002;
        public const int KEYEVENTF_UNICODE = 0x0004;
        public const int KEYEVENTF_SCANCODE = 0x0008;

        public const byte LBUTTON = 0x01; // left mouse button
        public const byte RBUTTON = 0x02; // right mouse button
        public const byte CANCEL = 0x03; // Control-break processing
        public const byte MBUTTON = 0x04; // Middle mouse button (three-button mouse)
        public const byte XBUTTON1 = 0x05; // Windows 2000/XP: X1 mouse button
        public const byte XBUTTON2 = 0x06; // Windows 2000/XP: X2 mouse button

        public const byte BACK = 0x08;
        public const byte TAB = 0x09;

        public const byte CLEAR = 0x0C;
        public const byte RETURN = 0x0D;

        public const byte SHIFT = 0x10;
        public const byte CONTROL = 0x11;
        public const byte MENU = 0x12; // alt key
        public const byte PAUSE = 0x13; // pause key
        public const byte CAPITAL = 0x14; // CAPS LOCK key
        public const byte KANA = 0x15; // IME Kana mode
        public const byte HANGUEL = 0x15; // IME Hanguel mode (maintained for compatibility; use HANGUL)
        public const byte HANGUL = 0x15; // IME Hangul mode
        public const byte JUNJA = 0x17; // IME Junja mode
        public const byte FINAL = 0x18; // IME final mode
        public const byte HANJA = 0x19; // IME Hanja mode
        public const byte KANJI = 0x19; // IME Kanji mode
        public const byte IME_OFF = 0x1A; // IME off

        public const byte ESCAPE = 0x1B;
        public const byte CONVERT = 0x1C; // IME convert
        public const byte NONCONVERT = 0x1D; // IME nonconvert
        public const byte ACCEPT = 0x1E; // IME accept
        public const byte MODECHANGE = 0x1F; // IME mode change request
        public const byte SPACE = 0x20; // SPACEBAR
        public const byte PRIOR = 0x21; // PAGE UP key
        public const byte NEXT = 0x22; // PAGE DOWN key
        public const byte END = 0x23; // END key
        public const byte HOME = 0x24; // HOME key
        public const byte LEFT = 0x25; // LEFT ARROW key
        public const byte UP = 0x26; // UP ARROW key
        public const byte RIGHT = 0x27; // RIGHT ARROW key
        public const byte DOWN = 0x28; // DOWN ARROW key
        public const byte SELECT = 0x29; // SELECT key
        public const byte PRINT = 0x2A; // PRINT key
        public const byte EXECUTE = 0x2B; // EXECUTE key
        public const byte SNAPSHOT = 0x2C; // PRINT SCREEN key
        public const byte INSERT = 0x2D; // INS key
        public const byte DELETE = 0x2E; // DEL key
        public const byte HELP = 0x2F; // HELP key
        public const byte _0 = 0x30; // 0 key
        public const byte _1 = 0x31; // 1 key
        public const byte _2 = 0x32; // 2 key
        public const byte _3 = 0x33; // 3 key
        public const byte _4 = 0x34; // 4 key
        public const byte _5 = 0x35; // 5 key
        public const byte _6 = 0x36; // 6 key
        public const byte _7 = 0x37; // 7 key
        public const byte _8 = 0x38; // 8 key
        public const byte _9 = 0x39; // 9 key

        public const byte A = 0x41; // A key
        public const byte B = 0x42; // B key
        public const byte C = 0x43; // C key
        public const byte D = 0x44; // D key
        public const byte E = 0x45; // E key
        public const byte F = 0x46; // F key
        public const byte G = 0x47; // G key
        public const byte H = 0x48; // H key
        public const byte I = 0x49; // I key
        public const byte J = 0x4A; // J key
        public const byte K = 0x4B; // K key
        public const byte L = 0x4C; // L key
        public const byte M = 0x4D; // M key
        public const byte N = 0x4E; // N key
        public const byte O = 0x4F; // O key
        public const byte P = 0x50; // P key
        public const byte Q = 0x51; // Q key
        public const byte R = 0x52; // R key
        public const byte S = 0x53; // S key
        public const byte T = 0x54; // T key
        public const byte U = 0x55; // U key
        public const byte V = 0x56; // V key
        public const byte W = 0x57; // W key
        public const byte X = 0x58; // X key
        public const byte Y = 0x59; // Y key
        public const byte Z = 0x5A; // Z key

        public const byte LWIN = 0x5B; // Left Windows key (Natural keyboard)
        public const byte RWIN = 0x5C; // Right Windows key (Natural keyboard)
        public const byte APPS = 0x5D; // Applications key (Natural keyboard)

        public const byte SLEEP = 0x5F; // Computer Sleep key
        public const byte NUMPAD0 = 0x60; // Numeric keypad 0 key
        public const byte NUMPAD1 = 0x61; // Numeric keypad 1 key
        public const byte NUMPAD2 = 0x62; // Numeric keypad 2 key
        public const byte NUMPAD3 = 0x63; // Numeric keypad 3 key
        public const byte NUMPAD4 = 0x64; // Numeric keypad 4 key
        public const byte NUMPAD5 = 0x65; // Numeric keypad 5 key
        public const byte NUMPAD6 = 0x66; // Numeric keypad 6 key
        public const byte NUMPAD7 = 0x67; // Numeric keypad 7 key
        public const byte NUMPAD8 = 0x68; // Numeric keypad 8 key
        public const byte NUMPAD9 = 0x69; // Numeric keypad 9 key
        public const byte MULTIPLY = 0x6A; // Multiply key
        public const byte ADD = 0x6B; // Add key
        public const byte SEPARATOR = 0x6C; // Separator key
        public const byte SUBTRACT = 0x6D; // Subtract key
        public const byte DECIMAL = 0x6E; // Decimal key
        public const byte DIVIDE = 0x6F; // Divide key
        public const byte F1 = 0x70; // F1 key
        public const byte F2 = 0x71; // F2 key
        public const byte F3 = 0x72; // F3 key
        public const byte F4 = 0x73; // F4 key
        public const byte F5 = 0x74; // F5 key
        public const byte F6 = 0x75; // F6 key
        public const byte F7 = 0x76; // F7 key
        public const byte F8 = 0x77; // F8 key
        public const byte F9 = 0x78; // F9 key
        public const byte F10 = 0x79; // F10 key
        public const byte F11 = 0x7A; // F11 key
        public const byte F12 = 0x7B; // F12 key
        public const byte F13 = 0x7C; // F13 key
        public const byte F14 = 0x7D; // F14 key
        public const byte F15 = 0x7E; // F15 key
        public const byte F16 = 0x7F; // F16 key
        public const byte F17 = 0x80; // F17 key
        public const byte F18 = 0x81; // F18 key
        public const byte F19 = 0x82; // F19 key
        public const byte F20 = 0x83; // F20 key
        public const byte F21 = 0x84; // F21 key
        public const byte F22 = 0x85; // F22 key
        public const byte F23 = 0x86; // F23 key
        public const byte F24 = 0x87; // F24 key

        public const byte NUMLOCK = 0x90; // NUM LOCK key
        public const byte SCROLL = 0x91; // SCROLL LOCK key

        public const byte LSHIFT = 0xA0; // Left SHIFT key
        public const byte RSHIFT = 0xA1; // Right SHIFT key
        public const byte LCONTROL = 0xA2; // Left CONTROL key
        public const byte RCONTROL = 0xA3; // Right CONTROL key
        public const byte LMENU = 0xA4; // Left ALT key
        public const byte RMENU = 0xA5; // Right ALT key
        public const byte BROWSER_BACK = 0xA6; // Browser Back key
        public const byte BROWSER_FORWARD = 0xA7; // Browser Forward key
        public const byte BROWSER_REFRESH = 0xA8; // Browser Refresh key
        public const byte BROWSER_STOP = 0xA9; // Browser Stop key
        public const byte BROWSER_SEARCH = 0xAA; // Browser Search key
        public const byte BROWSER_FAVORITES = 0xAB; // Browser Favorites key
        public const byte BROWSER_HOME = 0xAC; // Browser Start and Home key
        public const byte VOLUME_MUTE = 0xAD; // Volume Mute key
        public const byte VOLUME_DOWN = 0xAE; // Volume Down key
        public const byte VOLUME_UP = 0xAF; // Volume Up key
        public const byte MEDIA_NEXT_TRACK = 0xB0; // Next Track key
        public const byte MEDIA_PREV_TRACK = 0xB1; // Previous Track key
        public const byte MEDIA_STOP = 0xB2; // Stop Media key
        public const byte MEDIA_PLAY_PAUSE = 0xB3; // Play/Pause Media key
        public const byte LAUNCH_MAIL = 0xB4; // Start Mail key
        public const byte LAUNCH_MEDIA_SELECT = 0xB5; // Select Media key
        public const byte LAUNCH_APP1 = 0xB6; // Start Application 1 key
        public const byte LAUNCH_APP2 = 0xB7; // Start Application 2 key

        public const byte OEM_1 = 0xBA; // 기타 문자에 사용되며 키보드에 따라 다를 수 있습니다. 미국 표준 키보드의 경우 ';:' 키입니다.
        public const byte OEM_PLUS = 0xBB; // 모든 국가/지역의 경우 '+' 키를 입력합니다.
        public const byte OEM_COMMA = 0xBC; // 모든 국가/지역에서 ',' 키를 입력합니다.
        public const byte OEM_MINUS = 0xBD; // 모든 국가/지역에 대해 '-' 키를 입력합니다.
        public const byte OEM_PERIOD = 0xBE; // 모든 국가/지역에 대해 '.' 키를 입력합니다.
        public const byte OEM_2 = 0xBF; // 기타 문자에 사용되며 키보드에 따라 다를 수 있습니다. 미국 표준 키보드의 경우 '/?' 키입니다.
        public const byte OEM_3 = 0xC0; // 기타 문자에 사용되며 키보드에 따라 다를 수 있습니다. 미국 표준 키보드의 경우 '`~' 키입니다.

        public const byte OEM_4 = 0xDB; // 기타 문자에 사용되며 키보드에 따라 다를 수 있습니다. 미국 표준 키보드의 경우 '[{' 키입니다.
        public const byte OEM_5 = 0xDC; // 기타 문자에 사용되며 키보드에 따라 다를 수 있습니다. 미국 표준 키보드의 경우 '\|' 키입니다.
        public const byte OEM_6 = 0xDD; // 기타 문자에 사용되며 키보드에 따라 다를 수 있습니다. 미국 표준 키보드의 경우 ']}' 키입니다.

        public const byte
            OEM_7 = 0xDE; // 기타 문자에 사용되며 키보드에 따라 다를 수 있습니다. 미국 표준 키보드의 경우 'single-quote/double-quote' 키입니다.

        public const byte OEM_8 = 0xDF; // 기타 문자에 사용되며 키보드에 따라 다를 수 있습니다. US 표준 키보드의 경우, OEM 8 키는 미지정입니다.

        public const byte OEM_102 = 0xE2; // RT 102키 키보드의 꺾쇠 괄호 키 또는 백슬래시 키 중 하나입니다.

        public const byte PROCESSKEY = 0xE5; // IME PROCESS key

        public const byte
            PACKET = 0xE7; // 유니코드 문자를 키 입력처럼 전달하는 데 사용됩니다. PACKET 키는 키보드가 아닌 입력 방식에 사용되는 32비트 가상 키 값의 하위 워드입니다. 자세한 내용은 KEYBDINPUT, SendInput, WM_KEYDOWN 및 WM_KEYUP의 비고를 참조하세요.

        public const byte ATTN = 0xF6; // Attn key
        public const byte CRSEL = 0xF7; // CrSel key
        public const byte EXSEL = 0xF8; // ExSel key
        public const byte EREOF = 0xF9; // Erase EOF key
        public const byte PLAY = 0xFA; // Play key
        public const byte ZOOM = 0xFB; // Zoom key
        public const byte NONAME = 0xFC; // Reserved
        public const byte PA1 = 0xFD; // PA1 key
        public const byte OEM_CLEAR = 0xFE; // Clear key
    }
}