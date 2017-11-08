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
        DirectoryInfo directoryInfo;
        private void buttonHD_Click(object sender, EventArgs e)
        {
            textBoxLog.Text = DateTime.Now.ToLongTimeString() + " Log started";
            try
            {
                folderBrowserDialog1.ShowDialog();
                textBoxWay.Text = folderBrowserDialog1.SelectedPath;
                textBoxLog.AppendText("\r\n" + DateTime.Now.ToLongTimeString() + " Début scan " + folderBrowserDialog1.SelectedPath);
                directoryInfo = new DirectoryInfo(textBoxWay.Text);
                bool state = false;
                if (directoryInfo.Exists)
                {
                    state = true;
                    TreeNode rootNode = new TreeNode(directoryInfo.Name);

                    treeView1.Nodes.Add(rootNode);
                    GetDirectories(directoryInfo.GetDirectories(), rootNode);
                    toolStripStatusLabel1.Text = "Exploration du dossier terminée : " + treeView1.GetNodeCount(state) + " objet(s) trouvé(s)";
                    buttonExpansion.Enabled = true;
                    buttonReduction.Enabled = true;
                    textBoxLog.AppendText("\r\n" + DateTime.Now.ToLongTimeString() + " Fin Scan " + folderBrowserDialog1.SelectedPath);

                }
                else
                    MessageBox.Show("Le répertoire saisi n'existe pas");
            }
            catch (DirectoryNotFoundException _e)
            {
                textBoxLog.AppendText("\r\n" + DateTime.Now.ToLongTimeString() + "Dossier introuvable" + _e.ToString());
            }
            catch(AccessViolationException _e)
            {
                textBoxLog.AppendText("\r\n" + DateTime.Now.ToLongTimeString() + " L'accès au chemin d'accès " + directoryInfo.Name + " est refusé" + _e.ToString());
            }
            catch(UnauthorizedAccessException _e)
            {
                textBoxLog.AppendText("\r\n" + DateTime.Now.ToLongTimeString() + " L'accès au chemin d'accès " + directoryInfo.Name + " est refusé" + _e.ToString());
            }
            catch (Exception _e)
            {
                textBoxLog.AppendText("\r\n" + DateTime.Now.ToLongTimeString() + " Erreur" + _e.ToString());
            }
        }
        private void GetDirectories(DirectoryInfo[] directoryInfo, TreeNode node)
        {
            try
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
            catch (DirectoryNotFoundException _e)
            {
                textBoxLog.AppendText("\r\n" + DateTime.Now.ToLongTimeString() + "Dossier introuvable" + _e.ToString());
            }
            catch (AccessViolationException _e)
            {
                textBoxLog.AppendText("\r\n" + DateTime.Now.ToLongTimeString() + " L'accès au chemin d'accès " + folderBrowserDialog1.SelectedPath + " est refusé" + _e.ToString());
            }
            catch (UnauthorizedAccessException _e)
            {
                textBoxLog.AppendText("\r\n" + DateTime.Now.ToLongTimeString() + " L'accès au chemin d'accès " + folderBrowserDialog1.SelectedPath + " est refusé" + _e.ToString());
            }
            catch (Exception _e)
            {
                textBoxLog.AppendText("\r\n" + DateTime.Now.ToLongTimeString() + " Erreur" + _e.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxWay.Text = string.Empty;
            buttonReduction.Enabled = false;
            buttonExpansion.Enabled = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ActiveForm.Text = "Vous avez sélectionné : " + treeView1.SelectedNode.Text;
            groupBoxSelec.Text = "Sélection : " + folderBrowserDialog1.SelectedPath + @"\" + treeView1.SelectedNode.Text;
            FileInfo[] dirs = new FileInfo[Directory.GetFiles(directoryInfo.FullName).Length];

            for (int i = 0; i < dirs.Length; i++)
            {
                dirs = directoryInfo.GetFiles();
                listBox1.Items.Add(dirs[i]);
            }

        }

        private void buttonExpansion_Click(object sender, EventArgs e)
        {
                treeView1.ExpandAll();
        }

        private void buttonReduction_Click(object sender, EventArgs e)
        {
                treeView1.CollapseAll();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo open = new System.Diagnostics.ProcessStartInfo(folderBrowserDialog1.SelectedPath + @"\" + listBox1.SelectedItem.ToString());
            System.Diagnostics.Process.Start(open);
        }
    }
}
