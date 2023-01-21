namespace UseDll
{
    public unsafe struct OsVersionInfo
    {
        public uint osVersionInfoSize;
        public uint majorVersion;
        public uint minorVersion;
        public uint buildNumber;
        public uint platformId;
        public fixed byte servicePackVersion[128];
    }
}
