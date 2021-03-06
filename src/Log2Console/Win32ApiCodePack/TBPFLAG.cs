using System.Diagnostics.CodeAnalysis;

namespace Log2Console.Win32ApiCodePack
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    internal enum TBPFLAG
    {
        TBPF_NOPROGRESS = 0,
        TBPF_INDETERMINATE = 0x1,
        TBPF_NORMAL = 0x2,
        TBPF_ERROR = 0x4,
        TBPF_PAUSED = 0x8
    }
}