﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Src.Models.Handshake;
internal enum HandshakeStatus : byte
{
    Failed,
    Success,
    Authenticate
}
