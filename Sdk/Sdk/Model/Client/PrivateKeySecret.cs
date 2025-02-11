﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratumn.Sdk.Model.Client
{
    public class PrivateKeySecret : Secret

    {
        public string PrivateKey { get; set; }

        public PrivateKeySecret(string privateKey)
        {
            if (string.ReferenceEquals(privateKey, null))
            {
                throw new System.ArgumentException("privateKey cannot be null in PrivateKeySecret");
            }
            this.PrivateKey = privateKey;
        }


    }

}
