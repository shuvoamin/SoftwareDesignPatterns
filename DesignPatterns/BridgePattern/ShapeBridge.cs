﻿using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern
{
    public abstract class ShapeBridge
    {
        protected IDrawApi _drawApi;

        protected ShapeBridge(IDrawApi drawApi)
        {
            _drawApi = drawApi;
        }

        public abstract void Draw();
    }
}