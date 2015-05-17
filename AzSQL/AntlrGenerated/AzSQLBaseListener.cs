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


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IAzSQLListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5")]
[System.CLSCompliant(false)]
public partial class AzSQLBaseListener : IAzSQLListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStat([NotNull] AzSQLParser.StatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.stat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStat([NotNull] AzSQLParser.StatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.select_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_clause([NotNull] AzSQLParser.Select_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.select_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_clause([NotNull] AzSQLParser.Select_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_list([NotNull] AzSQLParser.Column_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_list([NotNull] AzSQLParser.Column_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_name([NotNull] AzSQLParser.Column_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_name([NotNull] AzSQLParser.Column_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_name([NotNull] AzSQLParser.Table_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_name([NotNull] AzSQLParser.Table_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.where_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhere_clause([NotNull] AzSQLParser.Where_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.where_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhere_clause([NotNull] AzSQLParser.Where_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.notExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotExpr([NotNull] AzSQLParser.NotExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.notExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotExpr([NotNull] AzSQLParser.NotExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.paranthesizedExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParanthesizedExpr([NotNull] AzSQLParser.ParanthesizedExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.paranthesizedExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParanthesizedExpr([NotNull] AzSQLParser.ParanthesizedExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.orExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrExpr([NotNull] AzSQLParser.OrExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.orExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrExpr([NotNull] AzSQLParser.OrExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.baseComparison"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBaseComparison([NotNull] AzSQLParser.BaseComparisonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.baseComparison"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBaseComparison([NotNull] AzSQLParser.BaseComparisonContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.andExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAndExpr([NotNull] AzSQLParser.AndExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.andExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAndExpr([NotNull] AzSQLParser.AndExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AzSQLParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] AzSQLParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AzSQLParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] AzSQLParser.LiteralContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
