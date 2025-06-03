using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeLab.Forms;

namespace TreeLab
{
    public partial class Main : Form
    {
        private DichotomyTree tree = new DichotomyTree();
        private TreeViewCustom currentTreeView;
        public Main()
        {
            InitializeComponent();

            panel.Controls.Clear();

            About about = new About();
            panel.Controls.Add(about);
            about.Dock = DockStyle.Fill;
        }

        private void menu_taskBtn_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            currentTreeView = new TreeViewCustom(tree);
            panel.Controls.Add(currentTreeView);
            currentTreeView.Dock = DockStyle.Fill;
        }

        private void menu_exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Вы хотите завершить работу?",
               "Завершение работы",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void taskBtn_delete_Click(object sender, EventArgs e)
        {
            tree.Delete();
            MessageBox.Show("Дерево разрушено", "Разрушить дерево");

            panel.Controls.Clear();

            currentTreeView = new TreeViewCustom(tree);
            panel.Controls.Add(currentTreeView);
            currentTreeView.Dock = DockStyle.Fill;
        }

        private void menu_aboutBtn_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();

            About about = new About();
            panel.Controls.Add(about);
            about.Dock = DockStyle.Fill;
        }

        private void taskBtn_create_Click(object sender, EventArgs e)
        {
            if (currentTreeView == null)
            {
                MessageBox.Show("Сначала откройте задачу (кнопка «Дерево»).");
            }
            else
            {
                InsertElementForm form = new InsertElementForm(tree, currentTreeView);
                form.ShowDialog(this);
            }
        }

        private void taskBtn_mainTask_Click(object sender, EventArgs e)
        {
            bool isAVL = tree.IsAVL(tree.Root);

            if (isAVL)
            {
                MessageBox.Show("Дерево АВЛ", "Проверка дерева");
            }
            else
            {
                MessageBox.Show("Дерево не АВЛ", "Проверка дерева");
            }
        }
    }
}
