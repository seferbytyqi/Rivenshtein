
namespace Rivenshtein
{
    partial class frmRivenshtein
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubstitution = new System.Windows.Forms.TextBox();
            this.txtInsertion = new System.Windows.Forms.TextBox();
            this.txtStringuDistances = new System.Windows.Forms.TextBox();
            this.txtDistanca2 = new System.Windows.Forms.TextBox();
            this.txtVija = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDistanca1 = new System.Windows.Forms.TextBox();
            this.txtKutia2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDeletion = new System.Windows.Forms.TextBox();
            this.txtKutia1 = new System.Windows.Forms.TextBox();
            this.btnShfaqRadhitjen = new System.Windows.Forms.Button();
            this.btnShfaqGjurmet = new System.Windows.Forms.Button();
            this.btnShfaqTabelen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvTabelaLevenshtainit = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaLevenshtainit)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rivenshtein 1.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Substitute:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Deletion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Insertion:";
            // 
            // txtSubstitution
            // 
            this.txtSubstitution.Location = new System.Drawing.Point(79, 86);
            this.txtSubstitution.Name = "txtSubstitution";
            this.txtSubstitution.Size = new System.Drawing.Size(40, 23);
            this.txtSubstitution.TabIndex = 11;
            this.txtSubstitution.Text = "2";
            this.txtSubstitution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInsertion
            // 
            this.txtInsertion.Location = new System.Drawing.Point(79, 24);
            this.txtInsertion.Name = "txtInsertion";
            this.txtInsertion.Size = new System.Drawing.Size(40, 23);
            this.txtInsertion.TabIndex = 9;
            this.txtInsertion.Text = "1";
            this.txtInsertion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStringuDistances
            // 
            this.txtStringuDistances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStringuDistances.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStringuDistances.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtStringuDistances.Location = new System.Drawing.Point(11, 95);
            this.txtStringuDistances.Name = "txtStringuDistances";
            this.txtStringuDistances.Size = new System.Drawing.Size(599, 24);
            this.txtStringuDistances.TabIndex = 10;
            this.txtStringuDistances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDistanca2
            // 
            this.txtDistanca2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistanca2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDistanca2.Location = new System.Drawing.Point(11, 71);
            this.txtDistanca2.Name = "txtDistanca2";
            this.txtDistanca2.Size = new System.Drawing.Size(599, 24);
            this.txtDistanca2.TabIndex = 9;
            this.txtDistanca2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVija
            // 
            this.txtVija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVija.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVija.Location = new System.Drawing.Point(11, 47);
            this.txtVija.Name = "txtVija";
            this.txtVija.Size = new System.Drawing.Size(599, 24);
            this.txtVija.TabIndex = 8;
            this.txtVija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStringuDistances);
            this.groupBox2.Controls.Add(this.txtDistanca2);
            this.groupBox2.Controls.Add(this.txtVija);
            this.groupBox2.Controls.Add(this.txtDistanca1);
            this.groupBox2.Location = new System.Drawing.Point(12, 486);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 134);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Krahasimi ne radhitje";
            // 
            // txtDistanca1
            // 
            this.txtDistanca1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistanca1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDistanca1.Location = new System.Drawing.Point(11, 23);
            this.txtDistanca1.Name = "txtDistanca1";
            this.txtDistanca1.Size = new System.Drawing.Size(599, 24);
            this.txtDistanca1.TabIndex = 7;
            this.txtDistanca1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKutia2
            // 
            this.txtKutia2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtKutia2.Location = new System.Drawing.Point(11, 74);
            this.txtKutia2.Name = "txtKutia2";
            this.txtKutia2.Size = new System.Drawing.Size(277, 23);
            this.txtKutia2.TabIndex = 5;
            this.txtKutia2.Text = "Execution";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSubstitution);
            this.groupBox3.Controls.Add(this.txtDeletion);
            this.groupBox3.Controls.Add(this.txtInsertion);
            this.groupBox3.Location = new System.Drawing.Point(317, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 125);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rregullimi i Kostove";
            // 
            // txtDeletion
            // 
            this.txtDeletion.Location = new System.Drawing.Point(79, 56);
            this.txtDeletion.Name = "txtDeletion";
            this.txtDeletion.Size = new System.Drawing.Size(40, 23);
            this.txtDeletion.TabIndex = 10;
            this.txtDeletion.Text = "1";
            this.txtDeletion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKutia1
            // 
            this.txtKutia1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtKutia1.Location = new System.Drawing.Point(23, 87);
            this.txtKutia1.Name = "txtKutia1";
            this.txtKutia1.Size = new System.Drawing.Size(277, 23);
            this.txtKutia1.TabIndex = 13;
            this.txtKutia1.Text = "Intention";
            // 
            // btnShfaqRadhitjen
            // 
            this.btnShfaqRadhitjen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShfaqRadhitjen.Location = new System.Drawing.Point(470, 137);
            this.btnShfaqRadhitjen.Name = "btnShfaqRadhitjen";
            this.btnShfaqRadhitjen.Size = new System.Drawing.Size(152, 27);
            this.btnShfaqRadhitjen.TabIndex = 12;
            this.btnShfaqRadhitjen.Text = "Shfaq Radhitjen";
            this.btnShfaqRadhitjen.UseVisualStyleBackColor = false;
            this.btnShfaqRadhitjen.Click += new System.EventHandler(this.btnShfaqRadhitjen_Click);
            // 
            // btnShfaqGjurmet
            // 
            this.btnShfaqGjurmet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShfaqGjurmet.Location = new System.Drawing.Point(470, 105);
            this.btnShfaqGjurmet.Name = "btnShfaqGjurmet";
            this.btnShfaqGjurmet.Size = new System.Drawing.Size(152, 27);
            this.btnShfaqGjurmet.TabIndex = 11;
            this.btnShfaqGjurmet.Text = "Shfaq Gjurmet ne Tabele";
            this.btnShfaqGjurmet.UseVisualStyleBackColor = false;
            this.btnShfaqGjurmet.Click += new System.EventHandler(this.btnShfaqGjurmet_Click);
            // 
            // btnShfaqTabelen
            // 
            this.btnShfaqTabelen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShfaqTabelen.Location = new System.Drawing.Point(470, 74);
            this.btnShfaqTabelen.Name = "btnShfaqTabelen";
            this.btnShfaqTabelen.Size = new System.Drawing.Size(152, 27);
            this.btnShfaqTabelen.TabIndex = 10;
            this.btnShfaqTabelen.Text = "Shfaq Distance ne Tabele";
            this.btnShfaqTabelen.UseVisualStyleBackColor = false;
            this.btnShfaqTabelen.Click += new System.EventHandler(this.btnShfaqTabelen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKutia2);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 125);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kutiat per Krahasim";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(455, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 125);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Butonat";
            this.groupBox4.UseCompatibleTextRendering = true;
            // 
            // dgvTabelaLevenshtainit
            // 
            this.dgvTabelaLevenshtainit.AllowUserToAddRows = false;
            this.dgvTabelaLevenshtainit.AllowUserToDeleteRows = false;
            this.dgvTabelaLevenshtainit.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTabelaLevenshtainit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTabelaLevenshtainit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaLevenshtainit.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTabelaLevenshtainit.Location = new System.Drawing.Point(12, 191);
            this.dgvTabelaLevenshtainit.Name = "dgvTabelaLevenshtainit";
            this.dgvTabelaLevenshtainit.ReadOnly = true;
            this.dgvTabelaLevenshtainit.RowHeadersVisible = false;
            this.dgvTabelaLevenshtainit.RowTemplate.Height = 25;
            this.dgvTabelaLevenshtainit.Size = new System.Drawing.Size(624, 282);
            this.dgvTabelaLevenshtainit.TabIndex = 9;
            this.dgvTabelaLevenshtainit.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvTabelaLevenshtainit_SortCompare);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRefresh);
            this.groupBox5.Location = new System.Drawing.Point(11, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(625, 44);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.Location = new System.Drawing.Point(0, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(38, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "⟳";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmRivenshtein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtKutia1);
            this.Controls.Add(this.btnShfaqRadhitjen);
            this.Controls.Add(this.btnShfaqGjurmet);
            this.Controls.Add(this.btnShfaqTabelen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvTabelaLevenshtainit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRivenshtein";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rivenshtein";
            this.Load += new System.EventHandler(this.frmRivenshtein_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaLevenshtainit)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubstitution;
        private System.Windows.Forms.TextBox txtInsertion;
        private System.Windows.Forms.TextBox txtStringuDistances;
        private System.Windows.Forms.TextBox txtDistanca2;
        private System.Windows.Forms.TextBox txtVija;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDistanca1;
        private System.Windows.Forms.TextBox txtKutia2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDeletion;
        private System.Windows.Forms.TextBox txtKutia1;
        private System.Windows.Forms.Button btnShfaqRadhitjen;
        private System.Windows.Forms.Button btnShfaqGjurmet;
        private System.Windows.Forms.Button btnShfaqTabelen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvTabelaLevenshtainit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRefresh;
    }
}

