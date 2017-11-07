using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Arborescence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHD_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(textBoxWay.Text);
            bool state = false;
            if (directoryInfo.Exists)
            {
                state = true;
                TreeNode rootNode = new TreeNode(directoryInfo.Name);

                        treeView1.Nodes.Add(rootNode);
                        GetDirectories(directoryInfo.GetDirectories(), rootNode);
                        toolStripStatusLabel1.Text = "Exploration du dossier terminée : " + treeView1.GetNodeCount(state) + " objets trouvés";
                        buttonExpansion.Enabled = true;
                        buttonReduction.Enabled = true;
            }
            else
                MessageBox.Show("Le répertoire saisi n'existe pas");
        }
        private void GetDirectories(DirectoryInfo[] directoryInfo, TreeNode node)
        {
            DirectoryInfo[] directory;
            TreeNode treeNode;
            foreach (DirectoryInfo subdir in directoryInfo)
            {
                directory = subdir.GetDirectories();
                treeNode = new TreeNode(subdir.Name);
                node.Nodes.Add(treeNode);
                GetDirectories(directory, treeNode);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxWay.Text = @"c:\inetpub";
            buttonReduction.Enabled = false;
            buttonExpansion.Enabled = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ActiveForm.Text = "Vous avez sélectionné : " + treeView1.SelectedNode.Text;
        }

        private void buttonExpansion_Click(object sender, EventArgs e)
        {
                treeView1.ExpandAll();
        }

        private void buttonReduction_Click(object sender, EventArgs e)
        {
                treeView1.CollapseAll();
        }
    }
}
