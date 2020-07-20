﻿using System;
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
			Func<TEntityType, bool> predicate = null)
			where TDtoType : class, IHaveIdentifier, IHaveName
			where TEntityType : class, IHaveIdentifier
		{
			var elements = repository.GetAll(predicate);
			foreach (var element in elements)
			{
				var treeNode = element.CreateTreeNode(elementImageIndex);
				treeNodeCollection.Add(treeNode);
			}
		}

		public static void FillTreeNodeCollectionWithTitle<TDtoType, TEntityType>(
			this TreeNodeCollection treeNodeCollection,
			RepositoryBase<TDtoType, TEntityType> repository,
			int elementImageIndex = 0,
			Func<TEntityType, bool> predicate = null)
			where TDtoType : class, IHaveIdentifier, IHaveTitle
			where TEntityType : class, IHaveIdentifier
		{
			var elements = repository.GetAll(predicate);
			foreach (var element in elements)
			{
				var treeNode = element.CreateTreeNode(elementImageIndex);
				treeNodeCollection.Add(treeNode);
			}
		}
	}
}
