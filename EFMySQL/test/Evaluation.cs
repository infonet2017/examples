﻿using System;
using System.Collections.Generic;

namespace mysqltest.test
{
    public partial class Evaluation
    {
        public int IdEvaluation { get; set; }
        public int ModuleIdmodule { get; set; }

        public virtual Module ModuleIdmoduleNavigation { get; set; }
    }
}
