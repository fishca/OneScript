﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneScript.Scripting
{
    abstract public class LexerState
    {
        abstract public Lexem ReadNextLexem(SourceCodeIterator iterator);
        
        public SyntaxErrorException CreateExceptionOnCurrentLine(string message, SourceCodeIterator iterator)
        {
            var cp = iterator.GetPositionInfo();
            return new SyntaxErrorException(cp, message);
        }
    }

    class EmptyParserState : LexerState
    {
        public override Lexem ReadNextLexem(SourceCodeIterator iterator)
        {
            return Lexem.Empty();
        }
    }
}