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
            this.buttonHD = new System.Windows.Forms.Button();
            this.buttonExpansion = new System.Windows.Forms.Button();
            this.buttonReduction = new System.Windows.Forms.Button();
            this.textBoxWay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(89, 75);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(466, 260);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // buttonHD
            // 
            this.buttonHD.Location = new System.Drawing.Point(130, 12);
            this.buttonHD.Name = "buttonHD";
            this.buttonHD.Size = new System.Drawing.Size(90, 57);
            this.buttonHD.TabIndex = 1;
            this.buttonHD.Text = "Affichage du disque dur";
            this.buttonHD.UseVisualStyleBackColor = true;
            this.buttonHD.Click += new System.EventHandler(this.buttonHD_Click);
            // 
            // buttonExpansion
            // 
            this.buttonExpansion.Location = new System.Drawing.Point(130, 341);
            this.buttonExpansion.Name = "buttonExpansion";
            this.buttonExpansion.Size = new System.Drawing.Size(90, 57);
            this.buttonExpansion.TabIndex = 2;
            this.buttonExpansion.Text = "Expansion de l\'arbre";
            this.buttonExpansion.UseVisualStyleBackColor = true;
            this.buttonExpansion.Click += new System.EventHandler(this.buttonExpansion_Click);
            // 
            // buttonReduction
            // 
            this.buttonReduction.Location = new System.Drawing.Point(413, 341);
            this.buttonReduction.Name = "buttonReduction";
            this.buttonReduction.Size = new System.Drawing.Size(90, 57);
            this.buttonReduction.TabIndex = 3;
            this.buttonReduction.Text = "Réduction de l\'arbre";
            this.buttonReduction.UseVisualStyleBackColor = true;
            this.buttonReduction.Click += new System.EventHandler(this.buttonReduction_Click);
            // 
            // textBoxWay
            // 
            this.textBoxWay.Location = new System.Drawing.Point(455, 28);
            this.textBoxWay.Name = "textBoxWay";
            this.textBoxWay.Size = new System.Drawing.Size(100, 20);
            this.textBoxWay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chemin du dossier à examiner";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(648, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 417);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWay);
            this.Controls.Add(this.buttonReduction);
            this.Controls.Add(this.buttonExpansion);
            this.Controls.Add(this.buttonHD);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonHD;
        private System.Windows.Forms.Button buttonExpansion;
        private System.Windows.Forms.Button buttonReduction;
        private System.Windows.Forms.TextBox textBoxWay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

