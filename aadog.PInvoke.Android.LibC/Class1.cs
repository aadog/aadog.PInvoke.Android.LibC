using System.Runtime.InteropServices;

namespace aadog.PInvoke.Android.LibC
{
    public partial class LibC
    {
        [LibraryImport("libc")]
        public static partial void exit(int status);
        // 使用 P/Invoke 调用 Linux 的 syscall 函数
        [LibraryImport("libc")]
        public static partial int getpid();

        [LibraryImport("libc")]
        public static unsafe partial int open([MarshalAs(UnmanagedType.LPUTF8Str)]string pathname, int flags);

        [LibraryImport("libc")]
        public static unsafe partial IntPtr strcpy([MarshalAs(UnmanagedType.LPUTF8Str)] string destination, [MarshalAs(UnmanagedType.LPUTF8Str)] string source);

        [LibraryImport("libc")]
        public static unsafe partial IntPtr strstr([MarshalAs(UnmanagedType.LPUTF8Str)] string destination, [MarshalAs(UnmanagedType.LPUTF8Str)] string source);
    }
}
