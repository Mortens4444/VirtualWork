using System;
using System.Linq.Expressions;

namespace VirtualWork.Core.Expressions
{
	internal sealed class ExpressionDelegateVisitor : ExpressionVisitor
	{

		private readonly Func<Expression, Expression> visitor;
		private readonly bool recursive;

		public static Expression Visit(Expression exp, Func<Expression, Expression> visitor, bool recursive)
		{
			return new ExpressionDelegateVisitor(visitor, recursive).Visit(exp);
		}

		private ExpressionDelegateVisitor(Func<Expression, Expression> visitor, bool recursive)
		{
			this.visitor = visitor ?? throw new ArgumentNullException(nameof(visitor));
			this.recursive = recursive;
		}

		public override Expression Visit(Expression node)
		{
			if (recursive)
			{
				return base.Visit(visitor(node));
			}
			else
			{
				var visited = visitor(node);
				if (visited == node)
				{
					return base.Visit(visited);
				}
				return visited;
			}
		}
	}
}
