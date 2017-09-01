using System;

namespace FTConf
{
    public static class Conf
    {
        private static IConf _conf;

        static Conf()
        {
            Init(b =>
                b.UseConf(() => null)
            );
        }

        public static void Init(Func<ConfBuilder, ConfBuilder> build)
        {
            var builder = new ConfBuilder();
            builder = build?.Invoke(builder);
            _conf = builder.Build();
        }
    }
}
