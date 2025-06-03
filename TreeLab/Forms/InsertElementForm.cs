using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TreeLab.Forms
{
    public partial class InsertElementForm : Form
    {
        private DichotomyTree tree;
        private TreeViewCustom treeViewControl;
        public InsertElementForm(DichotomyTree tr, TreeViewCustom view)
        {
            InitializeComponent();

            treeViewControl = view;

            tree = tr;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            char selectedChar = '\0';
            int key = 0;
            bool isValid = true;

            if (charTextBox.Text != null && charTextBox.Text.Length == 1)
            {
                selectedChar = charTextBox.Text.ToString()[0];
            }
            else
            {
                MessageBox.Show(
                    "Ошибка ввода! Введите один символ.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                isValid = false;
            }

            string keyText = keyTextBox.Text.Trim();

            if (!int.TryParse(keyText, out key))
            {
                MessageBox.Show(
                    "Ошибка ввода! Введите корректное целое число.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                isValid = false;
            }

            if (isValid && tree.Find(tree.Root, key) != null)
            {
                MessageBox.Show(
                    "Элемент с таким ключом уже существует.",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                isValid = false;
            }

            if (isValid)
            {
                tree.Root = tree.Insert(tree.Root, selectedChar, key);

                treeViewControl.Invalidate();
                treeViewControl.Refresh();

            }
        }
    }
}
