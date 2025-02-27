﻿using LLVMSharp.Interop;
using Moth.AST.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moth.LLVM.Data;

public class Parameter : CompilerData
{
    public int ParamIndex { get; set; }
    public string Name { get; set; }
    public Type Type { get; set; }

    public Parameter(int paramIndex, string name, Type type)
    {
        ParamIndex = paramIndex;
        Name = name;
        Type = type;
    }
}
