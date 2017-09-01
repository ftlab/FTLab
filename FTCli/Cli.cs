using System;

namespace FTCli
{
    public static class Cli
    {
        private static ICli _cli;

        static Cli()
        {
            Init(b =>
                b.UseCli(() => null)
            );
        }

        public static void Init(Func<CliBuilder, CliBuilder> build)
        {
            _cli =
            (build?.Invoke(
                new CliBuilder())
            ?? new CliBuilder())
            .Build();
        }
    }
}
