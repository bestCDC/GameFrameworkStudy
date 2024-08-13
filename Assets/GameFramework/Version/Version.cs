namespace GameFramework.Version
{
    /// <summary>
    /// 版本号类
    /// </summary>
    public static partial class Version
    {
        private const string GameFrameworkVersionString = "1.0.0";
        private static IVersionHelper s_VersionHelper = null;
        
        /// <summary>
        /// 获取游戏框架版本号
        /// </summary>
        public static string GameFrameworkVersion
        {
            get
            {
                return GameFrameworkVersionString;
            }
        }
        
        /// <summary>
        /// 获取游戏版本号
        /// </summary>
        public static string GameVersion
        {
            get
            {
                if (s_VersionHelper == null)
                {
                    return string.Empty;
                }

                return s_VersionHelper.GameVersion;
            }
        }
        
        /// <summary>
        /// 获取内部游戏版本号
        /// </summary>
        public static int InternalGameVersion
        {
            get
            {
                if (s_VersionHelper == null)
                {
                    return 0;
                }

                return s_VersionHelper.InternalGameVersion;
            }
        }
        
        /// <summary>
        /// 设置版本号辅助器
        /// </summary>
        /// <param name="versionHelper"></param>
        public static void SetVersionHelper(IVersionHelper versionHelper)
        {
            s_VersionHelper = versionHelper;
        }
    }    
}

