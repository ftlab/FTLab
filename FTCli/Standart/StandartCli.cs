using System;

namespace FTCli.Standart
{
    public class StandartCli : ICli
    {
        private IFormatter _formatter;

        public void UseFormaterr(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public void WriteLine(object value) =>
            Console.WriteLine(_formatter?.Format(value) ?? value);
    }
}
