using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TreeLab
{
    public class DTreeNode
    {
        private char info;
        private int key;
        private DTreeNode left;
        private DTreeNode right;

        public char Info { get; set; }
        public int Key { get; set; }
        public DTreeNode Left { get; set; }
        public DTreeNode Right { get; set; }

        public DTreeNode() { }
        public DTreeNode(char info, int key) { Info = info; Key = key; }
        public DTreeNode(char info, int key, DTreeNode left, DTreeNode right) { Info = info; Key = key; Left = left; Right = right; }

    }

    public class DichotomyTree
    {
        private DTreeNode root;

        public DTreeNode Root { get; set; }
        public DichotomyTree() { Root = null; }

        public DTreeNode Find(DTreeNode _root, int key)
        {
            DTreeNode p;

            if (_root != null)
            {
                if (key < _root.Key)
                {
                    p = Find(_root.Left, key);
                }
                else
                {
                    if (key > _root.Key)
                    {
                        p = Find(_root.Right, key);
                    }
                    else p = _root;
                }
            }
            else p = null;

            return p;
        }

        public DTreeNode Insert(DTreeNode _root, char info, int key)
        {
            if (_root == null)
            {
                _root = new DTreeNode(info, key);
            }
            else
            {
                if (key < _root.Key)
                {
                    _root.Left = Insert(_root.Left, info, key);
                }
                else
                {
                    _root.Right = Insert(_root.Right, info, key);
                }
            }

            return _root;
        }

        public bool IsAVL(DTreeNode _root)
        {
            bool avl = false;

            int leftHeight = GetHeight(_root.Left);
            int rightHeight = GetHeight(_root.Right);

            if (Math.Abs(leftHeight - rightHeight) > 1)
                avl = false;
            else
                avl = true;

                return avl;
        }

        public int GetHeight(DTreeNode _root)
        {
            int height = 0;
            int leftHeight = 0;
            int rightHeight = 0;

            if (_root == null)
                height = 0;
            else
            {
                leftHeight = GetHeight(_root.Left);
                rightHeight = GetHeight(_root.Right);

                height = Math.Max(leftHeight, rightHeight) + 1;
            }

            return height;
        }

        public void Delete()
        {
            Root = null;
        }

        public void DrawTree(Graphics g, DTreeNode _root, int x, int y, int dx)
        {
            int elWidth = 60;
            int elHeight = 30;
            int verSpace = 60;

            Font font = new Font("Segoe UI", 9);

            Rectangle rect = new Rectangle(x - elHeight / 2, y, elWidth, elHeight);
            g.FillRectangle(Brushes.AliceBlue, rect);
            g.DrawRectangle(Pens.Black, rect);

            string text = $"{_root.Key}({_root.Info})";
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            g.DrawString(text, font, Brushes.Black, x, y + 5, sf);

            if (_root.Left != null)
            {
                int childX = x - dx / 2;
                int childY = y + verSpace;
                g.DrawLine(Pens.Black, x, y + elHeight, childX, childY);
                DrawTree(g, _root.Left, childX, childY, dx / 2);
            }

            if (_root.Right != null)
            {
                int childX = x + dx / 2;
                int childY = y + verSpace;
                g.DrawLine(Pens.Black, x, y + elHeight, childX, childY);
                DrawTree(g, _root.Right, childX, childY, dx / 2);
            }
        }

    }
}
