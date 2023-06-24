﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageParser.AST
{
    internal class VariableNode : ExpressionNode
    {
        public string Name { get; }

        public VariableNode(string name)
        {
            Name = name;
        }
    }
}
