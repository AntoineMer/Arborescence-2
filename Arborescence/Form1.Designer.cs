namespace Arborescence
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonExpansion = new System.Windows.Forms.Button();
            this.buttonReduction = new System.Windows.Forms.Button();
            this.textBoxWay = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonParcourir = new System.Windows.Forms.Button();
            this.buttonExplore = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxSelec = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSelec.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 61);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(437, 375);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // buttonExpansion
            // 
            this.buttonExpansion.Location = new System.Drawing.Point(12, 442);
            this.buttonExpansion.Name = "buttonExpansion";
            this.buttonExpansion.Size = new System.Drawing.Size(90, 57);
            this.buttonExpansion.TabIndex = 2;
            this.buttonExpansion.Text = "Expansion de l\'arbre";
            this.buttonExpansion.UseVisualStyleBackColor = true;
            this.buttonExpansion.Click += new System.EventHandler(this.buttonExpansion_Click);
            // 
            // buttonReduction
            // 
            this.buttonReduction.Location = new System.Drawing.Point(108, 442);
            this.buttonReduction.Name = "buttonReduction";
            this.buttonReduction.Size = new System.Drawing.Size(90, 57);
            this.buttonReduction.TabIndex = 3;
            this.buttonReduction.Text = "Réduction de l\'arbre";
            this.buttonReduction.UseVisualStyleBackColor = true;
            this.buttonReduction.Click += new System.EventHandler(this.buttonReduction_Click);
            // 
            // textBoxWay
            // 
            this.textBoxWay.Location = new System.Drawing.Point(12, 12);
            this.textBoxWay.Name = "textBoxWay";
            this.textBoxWay.Size = new System.Drawing.Size(437, 20);
            this.textBoxWay.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // buttonParcourir
            // 
            this.buttonParcourir.Location = new System.Drawing.Point(12, 32);
            this.buttonParcourir.Name = "buttonParcourir";
            this.buttonParcourir.Size = new System.Drawing.Size(75, 23);
            this.buttonParcourir.TabIndex = 7;
            this.buttonParcourir.Text = "Parcourir";
            this.buttonParcourir.UseVisualStyleBackColor = true;
            this.buttonParcourir.Click += new System.EventHandler(this.buttonHD_Click);
            // 
            // buttonExplore
            // 
            this.buttonExplore.Location = new System.Drawing.Point(374, 32);
            this.buttonExplore.Name = "buttonExplore";
            this.buttonExplore.Size = new System.Drawing.Size(75, 23);
            this.buttonExplore.TabIndex = 8;
            this.buttonExplore.Text = "Explorer";
            this.buttonExplore.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Enabled = false;
            this.textBoxLog.Location = new System.Drawing.Point(6, 19);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(523, 162);
            this.textBoxLog.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLog);
            this.groupBox1.Location = new System.Drawing.Point(455, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // groupBoxSelec
            // 
            this.groupBoxSelec.Controls.Add(this.listBox1);
            this.groupBoxSelec.Location = new System.Drawing.Point(455, 61);
            this.groupBoxSelec.Name = "groupBoxSelec";
            this.groupBoxSelec.Size = new System.Drawing.Size(535, 182);
            this.groupBoxSelec.TabIndex = 11;
            this.groupBoxSelec.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(523, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 530);
            this.Controls.Add(this.groupBoxSelec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExplore);
            this.Controls.Add(this.buttonParcourir);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxWay);
            this.Controls.Add(this.buttonReduction);
            this.Controls.Add(this.buttonExpansion);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSelec.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonExpansion;
        private System.Windows.Forms.Button buttonReduction;
        private System.Windows.Forms.TextBox textBoxWay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonParcourir;
        private System.Windows.Forms.Button buttonExplore;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxSelec;
        private System.Windows.Forms.ListBox listBox1;
    }
}

