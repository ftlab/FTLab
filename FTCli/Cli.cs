using FTCli.Standart;
using System;
using System.Collections;
using System.Collections.Generic;

namespace FTCli
{
    public static class Cli
    {
        private static ICli _cli;

        static Cli()
        {
            Init(b =>
                b.UseCli(() => new StandartCli())
                .UseFormatter(new StandartFormatter())
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

        public static void WriteLine(object value) =>
            _cli.WriteLine(value);

        public static string ReadLine() =>
            _cli.ReadLine();

        public static IEnumerable<string> ConsumeLines(
            Func<string, bool> stop = null)
        {
            while (true)
            {
                var line = ReadLine();
                if (stop?.Invoke(line) == true)
                    yield break;
                yield return line;
            }
        }
    }
}
