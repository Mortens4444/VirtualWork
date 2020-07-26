using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VirtualWork.Interfaces;
using VirtualWork.Persistence.Repositories;
using VirtualWork.WinForms.Extensions;

namespace VirtualWork.WinForms.Providers
{
	public class ListProviderBase<TDtoType, TEntityType>
		where TDtoType : class, IHaveIdentifier, IHaveTitle
		where TEntityType : class, IHaveIdentifier
	{
		private readonly RepositoryBase<TDtoType, TEntityType> repository;

		public ListProviderBase(RepositoryBase<TDtoType, TEntityType> repository)
		{
			this.repository = repository;
		}

		public IEnumerable<TDtoType> GetNodes(TreeView treeView, string rootNodeName, int nodeIndex, Func<TEntityType, bool> predicate, bool appendItems = false)
		{
			var rootNode = treeView.Nodes[rootNodeName];
			var nodes = rootNode.Nodes;
			if (!appendItems)
			{
				nodes.Clear();
			}
			var items = nodes.FillTreeNodeCollectionWithTitle(repository, nodeIndex, predicate);
			rootNode.ExpandAll();
			return items;
		}
	}
}
