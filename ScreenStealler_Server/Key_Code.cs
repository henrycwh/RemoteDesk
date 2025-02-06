//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

namespace ScreenStealler_Network
{
    public enum Key_Code
    {
        //
        // 摘要:
        //     No key pressed.
        None = 0,
        //
        // 摘要:
        //     The Cancel key.
        Cancel = 1,
        //
        // 摘要:
        //     The Backspace key.
        Back = 2,
        //
        // 摘要:
        //     The Tab key.
        Tab = 3,
        //
        // 摘要:
        //     The Linefeed key.
        LineFeed = 4,
        //
        // 摘要:
        //     The Clear key.
        Clear = 5,
        //
        // 摘要:
        //     The Enter key.
        Enter = 6,
        //
        // 摘要:
        //     The Return key.
        Return = 6,
        //
        // 摘要:
        //     The Pause key.
        Pause = 7,
        //
        // 摘要:
        //     The Caps Lock key.
        Capital = 8,
        //
        // 摘要:
        //     The Caps Lock key.
        CapsLock = 8,
        //
        // 摘要:
        //     The IME Hangul mode key.
        HangulMode = 9,
        //
        // 摘要:
        //     The IME Kana mode key.
        KanaMode = 9,
        //
        // 摘要:
        //     The IME Junja mode key.
        JunjaMode = 10,
        //
        // 摘要:
        //     The IME Final mode key.
        FinalMode = 11,
        //
        // 摘要:
        //     The IME Hanja mode key.
        HanjaMode = 12,
        //
        // 摘要:
        //     The IME Kanji mode key.
        KanjiMode = 12,
        //
        // 摘要:
        //     The ESC key.
        Escape = 13,
        //
        // 摘要:
        //     The IME Convert key.
        ImeConvert = 14,
        //
        // 摘要:
        //     The IME NonConvert key.
        ImeNonConvert = 15,
        //
        // 摘要:
        //     The IME Accept key.
        ImeAccept = 16,
        //
        // 摘要:
        //     The IME Mode change request.
        ImeModeChange = 17,
        //
        // 摘要:
        //     The Spacebar key.
        Space = 18,
        //
        // 摘要:
        //     The Page Up key.
        PageUp = 19,
        //
        // 摘要:
        //     The Page Up key.
        Prior = 19,
        //
        // 摘要:
        //     The Page Down key.
        Next = 20,
        //
        // 摘要:
        //     The Page Down key.
        PageDown = 20,
        //
        // 摘要:
        //     The End key.
        End = 21,
        //
        // 摘要:
        //     The Home key.
        Home = 22,
        //
        // 摘要:
        //     The Left Arrow key.
        Left = 23,
        //
        // 摘要:
        //     The Up Arrow key.
        Up = 24,
        //
        // 摘要:
        //     The Right Arrow key.
        Right = 25,
        //
        // 摘要:
        //     The Down Arrow key.
        Down = 26,
        //
        // 摘要:
        //     The Select key.
        Select = 27,
        //
        // 摘要:
        //     The Print key.
        Print = 28,
        //
        // 摘要:
        //     The Execute key.
        Execute = 29,
        //
        // 摘要:
        //     The Print Screen key.
        PrintScreen = 30,
        //
        // 摘要:
        //     The Print Screen key.
        Snapshot = 30,
        //
        // 摘要:
        //     The Insert key.
        Insert = 31,
        //
        // 摘要:
        //     The Delete key.
        Delete = 32,
        //
        // 摘要:
        //     The Help key.
        Help = 33,
        //
        // 摘要:
        //     The 0 (zero) key.
        D0 = 34,
        //
        // 摘要:
        //     The 1 (one) key.
        D1 = 35,
        //
        // 摘要:
        //     The 2 key.
        D2 = 36,
        //
        // 摘要:
        //     The 3 key.
        D3 = 37,
        //
        // 摘要:
        //     The 4 key.
        D4 = 38,
        //
        // 摘要:
        //     The 5 key.
        D5 = 39,
        //
        // 摘要:
        //     The 6 key.
        D6 = 40,
        //
        // 摘要:
        //     The 7 key.
        D7 = 41,
        //
        // 摘要:
        //     The 8 key.
        D8 = 42,
        //
        // 摘要:
        //     The 9 key.
        D9 = 43,
        //
        // 摘要:
        //     The A key.
        A = 44,
        //
        // 摘要:
        //     The B key.
        B = 45,
        //
        // 摘要:
        //     The C key.
        C = 46,
        //
        // 摘要:
        //     The D key.
        D = 47,
        //
        // 摘要:
        //     The E key.
        E = 48,
        //
        // 摘要:
        //     The F key.
        F = 49,
        //
        // 摘要:
        //     The G key.
        G = 50,
        //
        // 摘要:
        //     The H key.
        H = 51,
        //
        // 摘要:
        //     The I key.
        I = 52,
        //
        // 摘要:
        //     The J key.
        J = 53,
        //
        // 摘要:
        //     The K key.
        K = 54,
        //
        // 摘要:
        //     The L key.
        L = 55,
        //
        // 摘要:
        //     The M key.
        M = 56,
        //
        // 摘要:
        //     The N key.
        N = 57,
        //
        // 摘要:
        //     The O key.
        O = 58,
        //
        // 摘要:
        //     The P key.
        P = 59,
        //
        // 摘要:
        //     The Q key.
        Q = 60,
        //
        // 摘要:
        //     The R key.
        R = 61,
        //
        // 摘要:
        //     The S key.
        S = 62,
        //
        // 摘要:
        //     The T key.
        T = 63,
        //
        // 摘要:
        //     The U key.
        U = 64,
        //
        // 摘要:
        //     The V key.
        V = 65,
        //
        // 摘要:
        //     The W key.
        W = 66,
        //
        // 摘要:
        //     The X key.
        X = 67,
        //
        // 摘要:
        //     The Y key.
        Y = 68,
        //
        // 摘要:
        //     The Z key.
        Z = 69,
        //
        // 摘要:
        //     The left Windows logo key (Microsoft Natural Keyboard).
        LWin = 70,
        //
        // 摘要:
        //     The right Windows logo key (Microsoft Natural Keyboard).
        RWin = 71,
        //
        // 摘要:
        //     The Application key (Microsoft Natural Keyboard). Also known as the Menu key,
        //     as it displays an application-specific context menu.
        Apps = 72,
        //
        // 摘要:
        //     The Computer Sleep key.
        Sleep = 73,
        //
        // 摘要:
        //     The 0 key on the numeric keypad.
        NumPad0 = 74,
        //
        // 摘要:
        //     The 1 key on the numeric keypad.
        NumPad1 = 75,
        //
        // 摘要:
        //     The 2 key on the numeric keypad.
        NumPad2 = 76,
        //
        // 摘要:
        //     The 3 key on the numeric keypad.
        NumPad3 = 77,
        //
        // 摘要:
        //     The 4 key on the numeric keypad.
        NumPad4 = 78,
        //
        // 摘要:
        //     The 5 key on the numeric keypad.
        NumPad5 = 79,
        //
        // 摘要:
        //     The 6 key on the numeric keypad.
        NumPad6 = 80,
        //
        // 摘要:
        //     The 7 key on the numeric keypad.
        NumPad7 = 81,
        //
        // 摘要:
        //     The 8 key on the numeric keypad.
        NumPad8 = 82,
        //
        // 摘要:
        //     The 9 key on the numeric keypad.
        NumPad9 = 83,
        //
        // 摘要:
        //     The Multiply key.
        Multiply = 84,
        //
        // 摘要:
        //     The Add key.
        Add = 85,
        //
        // 摘要:
        //     The Separator key.
        Separator = 86,
        //
        // 摘要:
        //     The Subtract key.
        Subtract = 87,
        //
        // 摘要:
        //     The Decimal key.
        Decimal = 88,
        //
        // 摘要:
        //     The Divide key.
        Divide = 89,
        //
        // 摘要:
        //     The F1 key.
        F1 = 90,
        //
        // 摘要:
        //     The F2 key.
        F2 = 91,
        //
        // 摘要:
        //     The F3 key.
        F3 = 92,
        //
        // 摘要:
        //     The F4 key.
        F4 = 93,
        //
        // 摘要:
        //     The F5 key.
        F5 = 94,
        //
        // 摘要:
        //     The F6 key.
        F6 = 95,
        //
        // 摘要:
        //     The F7 key.
        F7 = 96,
        //
        // 摘要:
        //     The F8 key.
        F8 = 97,
        //
        // 摘要:
        //     The F9 key.
        F9 = 98,
        //
        // 摘要:
        //     The F10 key.
        F10 = 99,
        //
        // 摘要:
        //     The F11 key.
        F11 = 100,
        //
        // 摘要:
        //     The F12 key.
        F12 = 101,
        //
        // 摘要:
        //     The F13 key.
        F13 = 102,
        //
        // 摘要:
        //     The F14 key.
        F14 = 103,
        //
        // 摘要:
        //     The F15 key.
        F15 = 104,
        //
        // 摘要:
        //     The F16 key.
        F16 = 105,
        //
        // 摘要:
        //     The F17 key.
        F17 = 106,
        //
        // 摘要:
        //     The F18 key.
        F18 = 107,
        //
        // 摘要:
        //     The F19 key.
        F19 = 108,
        //
        // 摘要:
        //     The F20 key.
        F20 = 109,
        //
        // 摘要:
        //     The F21 key.
        F21 = 110,
        //
        // 摘要:
        //     The F22 key.
        F22 = 111,
        //
        // 摘要:
        //     The F23 key.
        F23 = 112,
        //
        // 摘要:
        //     The F24 key.
        F24 = 113,
        //
        // 摘要:
        //     The Num Lock key.
        NumLock = 114,
        //
        // 摘要:
        //     The Scroll Lock key.
        Scroll = 115,
        //
        // 摘要:
        //     The left Shift key.
        LeftShift = 116,
        //
        // 摘要:
        //     The right Shift key.
        RightShift = 117,
        //
        // 摘要:
        //     The left CTRL key.
        LeftCtrl = 118,
        //
        // 摘要:
        //     The right CTRL key.
        RightCtrl = 119,
        //
        // 摘要:
        //     The left ALT key.
        LeftAlt = 120,
        //
        // 摘要:
        //     The right ALT key.
        RightAlt = 121,
        //
        // 摘要:
        //     The Browser Back key.
        BrowserBack = 122,
        //
        // 摘要:
        //     The Browser Forward key.
        BrowserForward = 123,
        //
        // 摘要:
        //     The Browser Refresh key.
        BrowserRefresh = 124,
        //
        // 摘要:
        //     The Browser Stop key.
        BrowserStop = 125,
        //
        // 摘要:
        //     The Browser Search key.
        BrowserSearch = 126,
        //
        // 摘要:
        //     The Browser Favorites key.
        BrowserFavorites = 127,
        //
        // 摘要:
        //     The Browser Home key.
        BrowserHome = 128,
        //
        // 摘要:
        //     The Volume Mute key.
        VolumeMute = 129,
        //
        // 摘要:
        //     The Volume Down key.
        VolumeDown = 130,
        //
        // 摘要:
        //     The Volume Up key.
        VolumeUp = 131,
        //
        // 摘要:
        //     The Media Next Track key.
        MediaNextTrack = 132,
        //
        // 摘要:
        //     The Media Previous Track key.
        MediaPreviousTrack = 133,
        //
        // 摘要:
        //     The Media Stop key.
        MediaStop = 134,
        //
        // 摘要:
        //     The Media Play Pause key.
        MediaPlayPause = 135,
        //
        // 摘要:
        //     The Launch Mail key.
        LaunchMail = 136,
        //
        // 摘要:
        //     The Select Media key.
        SelectMedia = 137,
        //
        // 摘要:
        //     The Launch Application1 key.
        LaunchApplication1 = 138,
        //
        // 摘要:
        //     The Launch Application2 key.
        LaunchApplication2 = 139,
        //
        // 摘要:
        //     The OEM 1 key.
        Oem1 = 140,
        //
        // 摘要:
        //     The OEM Semicolon key.
        OemSemicolon = 140,
        //
        // 摘要:
        //     The OEM Addition key.
        OemPlus = 141,
        //
        // 摘要:
        //     The OEM Comma key.
        OemComma = 142,
        //
        // 摘要:
        //     The OEM Minus key.
        OemMinus = 143,
        //
        // 摘要:
        //     The OEM Period key.
        OemPeriod = 144,
        //
        // 摘要:
        //     The OEM 2 key.
        Oem2 = 145,
        //
        // 摘要:
        //     The OEM Question key.
        OemQuestion = 145,
        //
        // 摘要:
        //     The OEM 3 key.
        Oem3 = 146,
        //
        // 摘要:
        //     The OEM Tilde key.
        OemTilde = 146,
        //
        // 摘要:
        //     The ABNT_C1 (Brazilian) key.
        AbntC1 = 147,
        //
        // 摘要:
        //     The ABNT_C2 (Brazilian) key.
        AbntC2 = 148,
        //
        // 摘要:
        //     The OEM 4 key.
        Oem4 = 149,
        //
        // 摘要:
        //     The OEM Open Brackets key.
        OemOpenBrackets = 149,
        //
        // 摘要:
        //     The OEM 5 key.
        Oem5 = 150,
        //
        // 摘要:
        //     The OEM Pipe key.
        OemPipe = 150,
        //
        // 摘要:
        //     The OEM 6 key.
        Oem6 = 151,
        //
        // 摘要:
        //     The OEM Close Brackets key.
        OemCloseBrackets = 151,
        //
        // 摘要:
        //     The OEM 7 key.
        Oem7 = 152,
        //
        // 摘要:
        //     The OEM Quotes key.
        OemQuotes = 152,
        //
        // 摘要:
        //     The OEM 8 key.
        Oem8 = 153,
        //
        // 摘要:
        //     The OEM 102 key.
        Oem102 = 154,
        //
        // 摘要:
        //     The OEM Backslash key.
        OemBackslash = 154,
        //
        // 摘要:
        //     A special key masking the real key being processed by an IME.
        ImeProcessed = 155,
        //
        // 摘要:
        //     A special key masking the real key being processed as a system key.
        System = 156,
        //
        // 摘要:
        //     The DBE_ALPHANUMERIC key.
        DbeAlphanumeric = 157,
        //
        // 摘要:
        //     The OEM ATTN key.
        OemAttn = 157,
        //
        // 摘要:
        //     The DBE_KATAKANA key.
        DbeKatakana = 158,
        //
        // 摘要:
        //     The OEM FINISH key.
        OemFinish = 158,
        //
        // 摘要:
        //     The DBE_HIRAGANA key.
        DbeHiragana = 159,
        //
        // 摘要:
        //     The OEM COPY key.
        OemCopy = 159,
        //
        // 摘要:
        //     The DBE_SBCSCHAR key.
        DbeSbcsChar = 160,
        //
        // 摘要:
        //     The OEM AUTO key.
        OemAuto = 160,
        //
        // 摘要:
        //     The DBE_DBCSCHAR key.
        DbeDbcsChar = 161,
        //
        // 摘要:
        //     The OEM ENLW key.
        OemEnlw = 161,
        //
        // 摘要:
        //     The DBE_ROMAN key.
        DbeRoman = 162,
        //
        // 摘要:
        //     The OEM BACKTAB key.
        OemBackTab = 162,
        //
        // 摘要:
        //     The ATTN key.
        Attn = 163,
        //
        // 摘要:
        //     The DBE_NOROMAN key.
        DbeNoRoman = 163,
        //
        // 摘要:
        //     The CRSEL key.
        CrSel = 164,
        //
        // 摘要:
        //     The DBE_ENTERWORDREGISTERMODE key.
        DbeEnterWordRegisterMode = 164,
        //
        // 摘要:
        //     The DBE_ENTERIMECONFIGMODE key.
        DbeEnterImeConfigureMode = 165,
        //
        // 摘要:
        //     The EXSEL key.
        ExSel = 165,
        //
        // 摘要:
        //     The DBE_FLUSHSTRING key.
        DbeFlushString = 166,
        //
        // 摘要:
        //     The ERASE EOF key.
        EraseEof = 166,
        //
        // 摘要:
        //     The DBE_CODEINPUT key.
        DbeCodeInput = 167,
        //
        // 摘要:
        //     The PLAY key.
        Play = 167,
        //
        // 摘要:
        //     The DBE_NOCODEINPUT key.
        DbeNoCodeInput = 168,
        //
        // 摘要:
        //     The ZOOM key.
        Zoom = 168,
        //
        // 摘要:
        //     The DBE_DETERMINESTRING key.
        DbeDetermineString = 169,
        //
        // 摘要:
        //     A constant reserved for future use.
        NoName = 169,
        //
        // 摘要:
        //     The DBE_ENTERDLGCONVERSIONMODE key.
        DbeEnterDialogConversionMode = 170,
        //
        // 摘要:
        //     The PA1 key.
        Pa1 = 170,
        //
        // 摘要:
        //     The OEM Clear key.
        OemClear = 171,
        //
        // 摘要:
        //     The key is used with another key to create a single combined character.
        DeadCharProcessed = 172
}
}
