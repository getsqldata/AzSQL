//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from AzSQL.g4 by ANTLR 4.5

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public partial class AzSQLLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, COMPARISON_OP=4, STRING_LITERAL=5, NUMERIC_LITERAL=6, 
		BOOLEAN_LITERAL=7, K_SELECT=8, K_WHERE=9, K_FROM=10, K_AND=11, K_OR=12, 
		K_NOT=13, TRUE=14, FALSE=15, COMMA=16, ORDER=17, GROUP=18, BY=19, ID=20, 
		NEGATION=21, SINGLE_LINE_COMMENT=22, MULTILINE_COMMENT=23, SPACES=24;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "COMPARISON_OP", "STRING_LITERAL", "NUMERIC_LITERAL", 
		"BOOLEAN_LITERAL", "K_SELECT", "K_WHERE", "K_FROM", "K_AND", "K_OR", "K_NOT", 
		"TRUE", "FALSE", "COMMA", "ORDER", "GROUP", "BY", "ID", "NEGATION", "SINGLE_LINE_COMMENT", 
		"MULTILINE_COMMENT", "SPACES", "DIGIT", "A", "B", "C", "D", "E", "F", 
		"G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", 
		"U", "V", "W", "X", "Y", "Z"
	};


	public AzSQLLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'*'", "'('", "')'", null, null, null, null, null, null, null, null, 
		null, null, null, null, "','", "'order'", "'group'", "'by'", null, "'-'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "COMPARISON_OP", "STRING_LITERAL", "NUMERIC_LITERAL", 
		"BOOLEAN_LITERAL", "K_SELECT", "K_WHERE", "K_FROM", "K_AND", "K_OR", "K_NOT", 
		"TRUE", "FALSE", "COMMA", "ORDER", "GROUP", "BY", "ID", "NEGATION", "SINGLE_LINE_COMMENT", 
		"MULTILINE_COMMENT", "SPACES"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "AzSQL.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2\x1A\x150\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4"+
		"\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3"+
		"\x5\x3\x5\x3\x5\x5\x5}\n\x5\x3\x6\x3\x6\x3\x6\x3\x6\a\x6\x83\n\x6\f\x6"+
		"\xE\x6\x86\v\x6\x3\x6\x3\x6\x3\a\x6\a\x8B\n\a\r\a\xE\a\x8C\x3\a\x3\a\a"+
		"\a\x91\n\a\f\a\xE\a\x94\v\a\x5\a\x96\n\a\x3\a\x3\a\x5\a\x9A\n\a\x3\a\x6"+
		"\a\x9D\n\a\r\a\xE\a\x9E\x5\a\xA1\n\a\x3\a\x3\a\x6\a\xA5\n\a\r\a\xE\a\xA6"+
		"\x3\a\x3\a\x5\a\xAB\n\a\x3\a\x6\a\xAE\n\a\r\a\xE\a\xAF\x5\a\xB2\n\a\x5"+
		"\a\xB4\n\a\x3\b\x3\b\x5\b\xB8\n\b\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3"+
		"\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3"+
		"\f\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF"+
		"\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12"+
		"\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13"+
		"\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\a\x15\xF5\n\x15\f\x15\xE\x15\xF8\v"+
		"\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x17\a\x17\x100\n\x17\f\x17"+
		"\xE\x17\x103\v\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\a\x18\x10B"+
		"\n\x18\f\x18\xE\x18\x10E\v\x18\x3\x18\x3\x18\x3\x18\x5\x18\x113\n\x18"+
		"\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3\x1B"+
		"\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3 \x3 \x3!\x3"+
		"!\x3\"\x3\"\x3#\x3#\x3$\x3$\x3%\x3%\x3&\x3&\x3\'\x3\'\x3(\x3(\x3)\x3)"+
		"\x3*\x3*\x3+\x3+\x3,\x3,\x3-\x3-\x3.\x3.\x3/\x3/\x3\x30\x3\x30\x3\x31"+
		"\x3\x31\x3\x32\x3\x32\x3\x33\x3\x33\x3\x34\x3\x34\x3\x10C\x2\x35\x3\x3"+
		"\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r\x19\xE\x1B\xF\x1D"+
		"\x10\x1F\x11!\x12#\x13%\x14\'\x15)\x16+\x17-\x18/\x19\x31\x1A\x33\x2\x35"+
		"\x2\x37\x2\x39\x2;\x2=\x2?\x2\x41\x2\x43\x2\x45\x2G\x2I\x2K\x2M\x2O\x2"+
		"Q\x2S\x2U\x2W\x2Y\x2[\x2]\x2_\x2\x61\x2\x63\x2\x65\x2g\x2\x3\x2#\x3\x2"+
		"))\x4\x2--//\x4\x2\x43\\\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x4\x2\f\f"+
		"\xF\xF\x5\x2\v\r\xF\xF\"\"\x3\x2\x32;\x4\x2\x43\x43\x63\x63\x4\x2\x44"+
		"\x44\x64\x64\x4\x2\x45\x45\x65\x65\x4\x2\x46\x46\x66\x66\x4\x2GGgg\x4"+
		"\x2HHhh\x4\x2IIii\x4\x2JJjj\x4\x2KKkk\x4\x2LLll\x4\x2MMmm\x4\x2NNnn\x4"+
		"\x2OOoo\x4\x2PPpp\x4\x2QQqq\x4\x2RRrr\x4\x2SSss\x4\x2TTtt\x4\x2UUuu\x4"+
		"\x2VVvv\x4\x2WWww\x4\x2XXxx\x4\x2YYyy\x4\x2ZZzz\x4\x2[[{{\x4\x2\\\\||"+
		"\x14D\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2"+
		"\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2"+
		"\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19"+
		"\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2"+
		"\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)"+
		"\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3"+
		"\x2\x2\x2\x3i\x3\x2\x2\x2\x5k\x3\x2\x2\x2\am\x3\x2\x2\x2\t|\x3\x2\x2\x2"+
		"\v~\x3\x2\x2\x2\r\xB3\x3\x2\x2\x2\xF\xB7\x3\x2\x2\x2\x11\xB9\x3\x2\x2"+
		"\x2\x13\xC0\x3\x2\x2\x2\x15\xC6\x3\x2\x2\x2\x17\xCB\x3\x2\x2\x2\x19\xCF"+
		"\x3\x2\x2\x2\x1B\xD2\x3\x2\x2\x2\x1D\xD6\x3\x2\x2\x2\x1F\xDB\x3\x2\x2"+
		"\x2!\xE1\x3\x2\x2\x2#\xE3\x3\x2\x2\x2%\xE9\x3\x2\x2\x2\'\xEF\x3\x2\x2"+
		"\x2)\xF2\x3\x2\x2\x2+\xF9\x3\x2\x2\x2-\xFB\x3\x2\x2\x2/\x106\x3\x2\x2"+
		"\x2\x31\x116\x3\x2\x2\x2\x33\x11A\x3\x2\x2\x2\x35\x11C\x3\x2\x2\x2\x37"+
		"\x11E\x3\x2\x2\x2\x39\x120\x3\x2\x2\x2;\x122\x3\x2\x2\x2=\x124\x3\x2\x2"+
		"\x2?\x126\x3\x2\x2\x2\x41\x128\x3\x2\x2\x2\x43\x12A\x3\x2\x2\x2\x45\x12C"+
		"\x3\x2\x2\x2G\x12E\x3\x2\x2\x2I\x130\x3\x2\x2\x2K\x132\x3\x2\x2\x2M\x134"+
		"\x3\x2\x2\x2O\x136\x3\x2\x2\x2Q\x138\x3\x2\x2\x2S\x13A\x3\x2\x2\x2U\x13C"+
		"\x3\x2\x2\x2W\x13E\x3\x2\x2\x2Y\x140\x3\x2\x2\x2[\x142\x3\x2\x2\x2]\x144"+
		"\x3\x2\x2\x2_\x146\x3\x2\x2\x2\x61\x148\x3\x2\x2\x2\x63\x14A\x3\x2\x2"+
		"\x2\x65\x14C\x3\x2\x2\x2g\x14E\x3\x2\x2\x2ij\a,\x2\x2j\x4\x3\x2\x2\x2"+
		"kl\a*\x2\x2l\x6\x3\x2\x2\x2mn\a+\x2\x2n\b\x3\x2\x2\x2o}\a>\x2\x2pq\a>"+
		"\x2\x2q}\a?\x2\x2r}\a@\x2\x2st\a@\x2\x2t}\a?\x2\x2u}\a?\x2\x2vw\a?\x2"+
		"\x2w}\a?\x2\x2xy\a#\x2\x2y}\a?\x2\x2z{\a>\x2\x2{}\a@\x2\x2|o\x3\x2\x2"+
		"\x2|p\x3\x2\x2\x2|r\x3\x2\x2\x2|s\x3\x2\x2\x2|u\x3\x2\x2\x2|v\x3\x2\x2"+
		"\x2|x\x3\x2\x2\x2|z\x3\x2\x2\x2}\n\x3\x2\x2\x2~\x84\a)\x2\x2\x7F\x83\n"+
		"\x2\x2\x2\x80\x81\a)\x2\x2\x81\x83\a)\x2\x2\x82\x7F\x3\x2\x2\x2\x82\x80"+
		"\x3\x2\x2\x2\x83\x86\x3\x2\x2\x2\x84\x82\x3\x2\x2\x2\x84\x85\x3\x2\x2"+
		"\x2\x85\x87\x3\x2\x2\x2\x86\x84\x3\x2\x2\x2\x87\x88\a)\x2\x2\x88\f\x3"+
		"\x2\x2\x2\x89\x8B\x5\x33\x1A\x2\x8A\x89\x3\x2\x2\x2\x8B\x8C\x3\x2\x2\x2"+
		"\x8C\x8A\x3\x2\x2\x2\x8C\x8D\x3\x2\x2\x2\x8D\x95\x3\x2\x2\x2\x8E\x92\a"+
		"\x30\x2\x2\x8F\x91\x5\x33\x1A\x2\x90\x8F\x3\x2\x2\x2\x91\x94\x3\x2\x2"+
		"\x2\x92\x90\x3\x2\x2\x2\x92\x93\x3\x2\x2\x2\x93\x96\x3\x2\x2\x2\x94\x92"+
		"\x3\x2\x2\x2\x95\x8E\x3\x2\x2\x2\x95\x96\x3\x2\x2\x2\x96\xA0\x3\x2\x2"+
		"\x2\x97\x99\x5=\x1F\x2\x98\x9A\t\x3\x2\x2\x99\x98\x3\x2\x2\x2\x99\x9A"+
		"\x3\x2\x2\x2\x9A\x9C\x3\x2\x2\x2\x9B\x9D\x5\x33\x1A\x2\x9C\x9B\x3\x2\x2"+
		"\x2\x9D\x9E\x3\x2\x2\x2\x9E\x9C\x3\x2\x2\x2\x9E\x9F\x3\x2\x2\x2\x9F\xA1"+
		"\x3\x2\x2\x2\xA0\x97\x3\x2\x2\x2\xA0\xA1\x3\x2\x2\x2\xA1\xB4\x3\x2\x2"+
		"\x2\xA2\xA4\a\x30\x2\x2\xA3\xA5\x5\x33\x1A\x2\xA4\xA3\x3\x2\x2\x2\xA5"+
		"\xA6\x3\x2\x2\x2\xA6\xA4\x3\x2\x2\x2\xA6\xA7\x3\x2\x2\x2\xA7\xB1\x3\x2"+
		"\x2\x2\xA8\xAA\x5=\x1F\x2\xA9\xAB\t\x3\x2\x2\xAA\xA9\x3\x2\x2\x2\xAA\xAB"+
		"\x3\x2\x2\x2\xAB\xAD\x3\x2\x2\x2\xAC\xAE\x5\x33\x1A\x2\xAD\xAC\x3\x2\x2"+
		"\x2\xAE\xAF\x3\x2\x2\x2\xAF\xAD\x3\x2\x2\x2\xAF\xB0\x3\x2\x2\x2\xB0\xB2"+
		"\x3\x2\x2\x2\xB1\xA8\x3\x2\x2\x2\xB1\xB2\x3\x2\x2\x2\xB2\xB4\x3\x2\x2"+
		"\x2\xB3\x8A\x3\x2\x2\x2\xB3\xA2\x3\x2\x2\x2\xB4\xE\x3\x2\x2\x2\xB5\xB8"+
		"\x5\x1D\xF\x2\xB6\xB8\x5\x1F\x10\x2\xB7\xB5\x3\x2\x2\x2\xB7\xB6\x3\x2"+
		"\x2\x2\xB8\x10\x3\x2\x2\x2\xB9\xBA\x5Y-\x2\xBA\xBB\x5=\x1F\x2\xBB\xBC"+
		"\x5K&\x2\xBC\xBD\x5=\x1F\x2\xBD\xBE\x5\x39\x1D\x2\xBE\xBF\x5[.\x2\xBF"+
		"\x12\x3\x2\x2\x2\xC0\xC1\x5\x61\x31\x2\xC1\xC2\x5\x43\"\x2\xC2\xC3\x5"+
		"=\x1F\x2\xC3\xC4\x5W,\x2\xC4\xC5\x5=\x1F\x2\xC5\x14\x3\x2\x2\x2\xC6\xC7"+
		"\x5? \x2\xC7\xC8\x5W,\x2\xC8\xC9\x5Q)\x2\xC9\xCA\x5M\'\x2\xCA\x16\x3\x2"+
		"\x2\x2\xCB\xCC\x5\x35\x1B\x2\xCC\xCD\x5O(\x2\xCD\xCE\x5;\x1E\x2\xCE\x18"+
		"\x3\x2\x2\x2\xCF\xD0\x5Q)\x2\xD0\xD1\x5W,\x2\xD1\x1A\x3\x2\x2\x2\xD2\xD3"+
		"\x5O(\x2\xD3\xD4\x5Q)\x2\xD4\xD5\x5[.\x2\xD5\x1C\x3\x2\x2\x2\xD6\xD7\x5"+
		"[.\x2\xD7\xD8\x5W,\x2\xD8\xD9\x5]/\x2\xD9\xDA\x5=\x1F\x2\xDA\x1E\x3\x2"+
		"\x2\x2\xDB\xDC\x5? \x2\xDC\xDD\x5\x35\x1B\x2\xDD\xDE\x5K&\x2\xDE\xDF\x5"+
		"Y-\x2\xDF\xE0\x5=\x1F\x2\xE0 \x3\x2\x2\x2\xE1\xE2\a.\x2\x2\xE2\"\x3\x2"+
		"\x2\x2\xE3\xE4\aq\x2\x2\xE4\xE5\at\x2\x2\xE5\xE6\a\x66\x2\x2\xE6\xE7\a"+
		"g\x2\x2\xE7\xE8\at\x2\x2\xE8$\x3\x2\x2\x2\xE9\xEA\ai\x2\x2\xEA\xEB\at"+
		"\x2\x2\xEB\xEC\aq\x2\x2\xEC\xED\aw\x2\x2\xED\xEE\ar\x2\x2\xEE&\x3\x2\x2"+
		"\x2\xEF\xF0\a\x64\x2\x2\xF0\xF1\a{\x2\x2\xF1(\x3\x2\x2\x2\xF2\xF6\t\x4"+
		"\x2\x2\xF3\xF5\t\x5\x2\x2\xF4\xF3\x3\x2\x2\x2\xF5\xF8\x3\x2\x2\x2\xF6"+
		"\xF4\x3\x2\x2\x2\xF6\xF7\x3\x2\x2\x2\xF7*\x3\x2\x2\x2\xF8\xF6\x3\x2\x2"+
		"\x2\xF9\xFA\a/\x2\x2\xFA,\x3\x2\x2\x2\xFB\xFC\a/\x2\x2\xFC\xFD\a/\x2\x2"+
		"\xFD\x101\x3\x2\x2\x2\xFE\x100\n\x6\x2\x2\xFF\xFE\x3\x2\x2\x2\x100\x103"+
		"\x3\x2\x2\x2\x101\xFF\x3\x2\x2\x2\x101\x102\x3\x2\x2\x2\x102\x104\x3\x2"+
		"\x2\x2\x103\x101\x3\x2\x2\x2\x104\x105\b\x17\x2\x2\x105.\x3\x2\x2\x2\x106"+
		"\x107\a\x31\x2\x2\x107\x108\a,\x2\x2\x108\x10C\x3\x2\x2\x2\x109\x10B\v"+
		"\x2\x2\x2\x10A\x109\x3\x2\x2\x2\x10B\x10E\x3\x2\x2\x2\x10C\x10D\x3\x2"+
		"\x2\x2\x10C\x10A\x3\x2\x2\x2\x10D\x112\x3\x2\x2\x2\x10E\x10C\x3\x2\x2"+
		"\x2\x10F\x110\a,\x2\x2\x110\x113\a\x31\x2\x2\x111\x113\a\x2\x2\x3\x112"+
		"\x10F\x3\x2\x2\x2\x112\x111\x3\x2\x2\x2\x113\x114\x3\x2\x2\x2\x114\x115"+
		"\b\x18\x2\x2\x115\x30\x3\x2\x2\x2\x116\x117\t\a\x2\x2\x117\x118\x3\x2"+
		"\x2\x2\x118\x119\b\x19\x2\x2\x119\x32\x3\x2\x2\x2\x11A\x11B\t\b\x2\x2"+
		"\x11B\x34\x3\x2\x2\x2\x11C\x11D\t\t\x2\x2\x11D\x36\x3\x2\x2\x2\x11E\x11F"+
		"\t\n\x2\x2\x11F\x38\x3\x2\x2\x2\x120\x121\t\v\x2\x2\x121:\x3\x2\x2\x2"+
		"\x122\x123\t\f\x2\x2\x123<\x3\x2\x2\x2\x124\x125\t\r\x2\x2\x125>\x3\x2"+
		"\x2\x2\x126\x127\t\xE\x2\x2\x127@\x3\x2\x2\x2\x128\x129\t\xF\x2\x2\x129"+
		"\x42\x3\x2\x2\x2\x12A\x12B\t\x10\x2\x2\x12B\x44\x3\x2\x2\x2\x12C\x12D"+
		"\t\x11\x2\x2\x12D\x46\x3\x2\x2\x2\x12E\x12F\t\x12\x2\x2\x12FH\x3\x2\x2"+
		"\x2\x130\x131\t\x13\x2\x2\x131J\x3\x2\x2\x2\x132\x133\t\x14\x2\x2\x133"+
		"L\x3\x2\x2\x2\x134\x135\t\x15\x2\x2\x135N\x3\x2\x2\x2\x136\x137\t\x16"+
		"\x2\x2\x137P\x3\x2\x2\x2\x138\x139\t\x17\x2\x2\x139R\x3\x2\x2\x2\x13A"+
		"\x13B\t\x18\x2\x2\x13BT\x3\x2\x2\x2\x13C\x13D\t\x19\x2\x2\x13DV\x3\x2"+
		"\x2\x2\x13E\x13F\t\x1A\x2\x2\x13FX\x3\x2\x2\x2\x140\x141\t\x1B\x2\x2\x141"+
		"Z\x3\x2\x2\x2\x142\x143\t\x1C\x2\x2\x143\\\x3\x2\x2\x2\x144\x145\t\x1D"+
		"\x2\x2\x145^\x3\x2\x2\x2\x146\x147\t\x1E\x2\x2\x147`\x3\x2\x2\x2\x148"+
		"\x149\t\x1F\x2\x2\x149\x62\x3\x2\x2\x2\x14A\x14B\t \x2\x2\x14B\x64\x3"+
		"\x2\x2\x2\x14C\x14D\t!\x2\x2\x14D\x66\x3\x2\x2\x2\x14E\x14F\t\"\x2\x2"+
		"\x14Fh\x3\x2\x2\x2\x16\x2|\x82\x84\x8C\x92\x95\x99\x9E\xA0\xA6\xAA\xAF"+
		"\xB1\xB3\xB7\xF6\x101\x10C\x112\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}