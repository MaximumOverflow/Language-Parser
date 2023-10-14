﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moth.AST.Node;

public class IncrementVarNode : ExpressionNode
{
    public RefNode RefNode { get; set; }

    public IncrementVarNode(RefNode refNode)
    {
        RefNode = refNode;
    }
}
