using System;
using System.Collections;
using System.Collections.Generic;

namespace FTCli
{
    public interface ICli
    {
        void UseFormaterr(IFormatter formatter);

        void WriteLine(object value);

        string ReadLine();
    }
}
