using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using VirtualWork.Interfaces;
using VirtualWork.Persistence.Repositories;

namespace VirtualWork.WinForms.Extensions
{
	public static class TreeNodeExtensions
	{
		public static TreeNode CreateTreeNode(this IHaveName nodeObject, int imageIndex)
		{
			return CreateTreeNode(nodeObject.Name, nodeObject, imageIndex);
		}

		public static TreeNode CreateTreeNode(this IHaveTitle nodeObject, int imageIndex)
		{
			return CreateTreeNode(nodeObject.Title, nodeObject, imageIndex);
		}

		public static TreeNode CreateTreeNode(string nodeText, object nodeObject, int imageIndex)
		{
			return new TreeNode(nodeText)
			{
				Tag = nodeObject,
				ImageIndex = imageIndex,
				SelectedImageIndex = imageIndex
			};
		}

		public static void FillTreeNodeCollectionWithName<TDtoType, TEntityType>(
			this TreeNodeCollection treeNodeCollection,
			RepositoryBase<TDtoType, TEntityType> repository,
			int elementImageIndex = 0,
			Expression<Func<TEntityType, bool>> predicate = null)
			where TDtoType : class, IHaveIdentifier, IHaveName, new()
			where TEntityType : class, IHaveIdentifier, new()
		{
			var elements = repository.GetAll(predicate);
			foreach (var element in elements)
			{
				var treeNode = element.CreateTreeNode(elementImageIndex);
				treeNodeCollection.Add(treeNode);
			}
		}

		public static IEnumerable<TDtoType> FillTreeNodeCollectionWithTitle<TDtoType, TEntityType>(
			this TreeNodeCollection treeNodeCollection,
			RepositoryBase<TDtoType, TEntityType> repository,
			int elementImageIndex = 0,
			Expression<Func<TEntityType, bool>> predicate = null)
			where TDtoType : class, IHaveIdentifier, IHaveTitle, new()
			where TEntityType : class, IHaveIdentifier, new()
		{
			var elements = repository.GetAll(predicate);
			foreach (var element in elements)
			{
				var treeNode = element.CreateTreeNode(elementImageIndex);
				treeNodeCollection.Add(treeNode);
			}
			return elements;
		}
	}
}
