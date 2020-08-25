using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using VirtualWork.Interfaces;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Extensions;

namespace VirtualWork.WinForms.Providers
{
	public abstract class ListProviderBase<TDtoType, TEntityType>
		where TDtoType : class, IHaveIdentifier, IHaveTitle
		where TEntityType : class, IHaveIdentifier
	{
		protected CancellationToken cancellationToken;
		private readonly RepositoryBase<TDtoType, TEntityType> repository;
		private CancellationTokenSource cancellationTokenSource;

		public ListProviderBase(RepositoryBase<TDtoType, TEntityType> repository)
		{
			this.repository = repository;
		}

		public IEnumerable<TDtoType> GetNodes(TreeView treeView, string rootNodeName, int nodeIndex, Func<TEntityType, bool> predicate, bool appendItems = false)
		{
			StopTasks();
			var rootNode = treeView.Nodes[rootNodeName];
			var nodes = rootNode.Nodes;
			if (!appendItems)
			{
				nodes.Clear();
			}
			var items = nodes.FillTreeNodeCollectionWithTitle(repository, nodeIndex, predicate);
			ProcessItems(items);
			rootNode.ExpandAll();
			return items;
		}

		protected virtual void ProcessItems(IEnumerable<TDtoType> items)
		{
			cancellationTokenSource = new CancellationTokenSource();
			cancellationToken = cancellationTokenSource.Token;
		}

		public void StopTasks()
		{
			if (cancellationTokenSource != null)
			{
				cancellationTokenSource.Cancel();
			}
		}
	}
}
