﻿using System;

namespace StoreQueueApp
{
    class Product
    {
        public string Code { get; set; } = Guid.NewGuid().ToString();

        public override string ToString()
        {
            return Code;
        }
    }
}
