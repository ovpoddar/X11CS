﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Src.Models.Handshake;

[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
internal struct HandshakeResponseHeadSuccess
{
    public HandshakeStatus HandshakeStatus;
    public byte Pad0;
    public short MajorVersion;
    public short MinorVersion;
    public short AdditionalDataLength;
}