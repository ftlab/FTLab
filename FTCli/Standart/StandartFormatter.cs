using Newtonsoft.Json;
using System;

namespace FTCli.Standart
{
    public class StandartFormatter : IFormatter
    {
        public string Format(object value)
        {
            if (value == null) return null;
            if (value is string) return (string)value;
            if (value is Exception) return value.ToString();

            return JsonConvert
                .SerializeObject(value
                , Formatting.Indented
                , new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
        }
    }
}
