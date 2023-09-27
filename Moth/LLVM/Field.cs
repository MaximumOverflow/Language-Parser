﻿using LLVMSharp.Interop;
using Moth.AST.Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moth.LLVM;

public class Field : CompilerData
{
    public uint FieldIndex { get; set; }
    public LLVMTypeRef LLVMType { get; set; }
    public PrivacyType Privacy { get; set; }
    public Class ClassOfType { get; set; }
    public bool IsConstant { get; set; }
    public LLVMValueRef DefaultValue { get; }

    public Field(uint index, LLVMTypeRef lLVMType, PrivacyType privacy,
        Class classOfType, bool isConstant, LLVMValueRef defaultValue)
    {
        FieldIndex = index;
        LLVMType = lLVMType;
        Privacy = privacy;
        ClassOfType = classOfType;
        IsConstant = isConstant;
        DefaultValue = defaultValue;
    }
}
