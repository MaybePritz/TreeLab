using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TreeLab.Forms
{
    public partial class TreeViewCustom : UserControl
    {
        private DichotomyTree tree;
        public TreeViewCustom(DichotomyTree tree)
        {
            InitializeComponent();

            this.tree = tree;

            if (tree.Root != null)
            {
                avlCheck.Checked = tree.IsAVL(tree.Root);
                startUpText.Visible = false;
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            if (tree.Root != null)
            {
                avlCheck.Checked = tree.IsAVL(tree.Root);
                startUpText.Visible = false;
                tree.DrawTree(e.Graphics, tree.Root, splitContainer1.Panel1.Width / 2, 40, splitContainer1.Panel1.Width / 4);
            }
        }
    }
}
