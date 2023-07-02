using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT.BinarySearchTree
{
    public class BinarySearchTree
    {
        public TreeNode? Root {  get; set; }

        public void Insert(int key, string value)
        {
            Root = InsertItem(Root, key, value);
        }

        public TreeNode InsertItem(TreeNode? node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);

            //If this is the first time, node will be null
            if(node ==  null)
            {
                node = newNode;
                return node;
            }

            //If this isn't the first time, Traverse, Null, Insert
            if(key < node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild,key,value);
            }
            else
            {
                node.RightChild = InsertItem(node.RightChild,key, value);
            }
            return node;
        }
    }
}
