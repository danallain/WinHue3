﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinHue3.LIFX.Payloads;

namespace WinHue3.LIFX.Responses.States.Device
{
    public class StateLabel : Payload
    {
        private readonly byte[] _label;

        public string Label => Encoding.UTF8.GetString(_label).TrimEnd('\0');

        public StateLabel()
        {
            _label = new byte[32];
        }

        public StateLabel(byte[] bytes)
        {
            _label = bytes;
        }

        public StateLabel(string label)
        {
            _label = Encoding.UTF8.GetBytes(label).Reverse().ToArray();
        }

        public override int Length => _label.Length;
        
        public override byte[] GetBytes()
        {
            return _label;
        }
    }
}