﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Singleton
{
    public enum YiyecekTuru
    {
        MANTI,
        CORBA
    }

    public interface IAsci
    {
        IYiyecek Hazirla(YiyecekTuru yiyecekTuru);
    }
}
