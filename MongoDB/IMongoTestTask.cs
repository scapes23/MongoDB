﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    public interface IMongoTestTask
    {
        void Run(MongoDatabase database);
    }
}
