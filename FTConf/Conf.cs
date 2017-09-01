using System;

namespace FTConf
{
    public static class Conf
    {
        private static IConfiguration _conf;

        static Conf()
        {
            Init(b =>
                b.UseConfiguration(() => null)
            );
        }

        public static void Init(Func<ConfigurationBuilder, ConfigurationBuilder> build)
        {
            var builder = new ConfigurationBuilder();
            builder = build?.Invoke(builder);
            _conf = builder.Build();
        }
    }
}
