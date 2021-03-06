﻿namespace NursingHomeApplication
{
    partial class Rooms
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.broj_soba_nepok = new System.Windows.Forms.TextBox();
            this.broj_soba_pok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combonepok = new System.Windows.Forms.ComboBox();
            this.combopok = new System.Windows.Forms.ComboBox();
            this.trazi_nepok = new System.Windows.Forms.TextBox();
            this.trazi_pok = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.broj_sobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrsta_sobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broj_slobodnih_kreveta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaduzena_cistacica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // broj_soba_nepok
            // 
            this.broj_soba_nepok.BackColor = System.Drawing.SystemColors.Control;
            this.broj_soba_nepok.Cursor = System.Windows.Forms.Cursors.Default;
            this.broj_soba_nepok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.broj_soba_nepok.Location = new System.Drawing.Point(588, 358);
            this.broj_soba_nepok.Name = "broj_soba_nepok";
            this.broj_soba_nepok.ReadOnly = true;
            this.broj_soba_nepok.Size = new System.Drawing.Size(33, 22);
            this.broj_soba_nepok.TabIndex = 23;
            // 
            // broj_soba_pok
            // 
            this.broj_soba_pok.BackColor = System.Drawing.SystemColors.Control;
            this.broj_soba_pok.Cursor = System.Windows.Forms.Cursors.Default;
            this.broj_soba_pok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.broj_soba_pok.Location = new System.Drawing.Point(91, 358);
            this.broj_soba_pok.Name = "broj_soba_pok";
            this.broj_soba_pok.ReadOnly = true;
            this.broj_soba_pok.Size = new System.Drawing.Size(33, 22);
            this.broj_soba_pok.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(503, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Broj soba:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Broj soba:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(486, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Polu/Nepokretni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pokretni";
            // 
            // combonepok
            // 
            this.combonepok.FormattingEnabled = true;
            this.combonepok.Items.AddRange(new object[] {
            "Sve",
            "Pune",
            "Slobodne",
            "Prazne"});
            this.combonepok.Location = new System.Drawing.Point(490, 68);
            this.combonepok.Name = "combonepok";
            this.combonepok.Size = new System.Drawing.Size(116, 21);
            this.combonepok.TabIndex = 17;
            this.combonepok.SelectedIndexChanged += new System.EventHandler(this.ChangeData);
            // 
            // combopok
            // 
            this.combopok.FormattingEnabled = true;
            this.combopok.Items.AddRange(new object[] {
            "Sve",
            "Pune",
            "Slobodne",
            "Prazne"});
            this.combopok.Location = new System.Drawing.Point(19, 68);
            this.combopok.Name = "combopok";
            this.combopok.Size = new System.Drawing.Size(116, 21);
            this.combopok.TabIndex = 16;
            this.combopok.SelectedIndexChanged += new System.EventHandler(this.ChangeData);
            // 
            // trazi_nepok
            // 
            this.trazi_nepok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trazi_nepok.Location = new System.Drawing.Point(681, 68);
            this.trazi_nepok.Name = "trazi_nepok";
            this.trazi_nepok.Size = new System.Drawing.Size(109, 26);
            this.trazi_nepok.TabIndex = 15;
            this.trazi_nepok.TextChanged += new System.EventHandler(this.ChangeData);
            // 
            // trazi_pok
            // 
            this.trazi_pok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trazi_pok.Location = new System.Drawing.Point(207, 68);
            this.trazi_pok.Name = "trazi_pok";
            this.trazi_pok.Size = new System.Drawing.Size(109, 26);
            this.trazi_pok.TabIndex = 14;
            this.trazi_pok.TextChanged += new System.EventHandler(this.ChangeData);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(490, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 42;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.Size = new System.Drawing.Size(369, 255);
            this.dataGridView2.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Broj sobe";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Vrsta sobe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Slobodni kreveti";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Čistaćica";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.broj_sobe,
            this.vrsta_sobe,
            this.broj_slobodnih_kreveta,
            this.zaduzena_cistacica});
            this.dataGridView1.Location = new System.Drawing.Point(19, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 42;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(369, 255);
            this.dataGridView1.TabIndex = 12;
            // 
            // broj_sobe
            // 
            this.broj_sobe.HeaderText = "Broj sobe";
            this.broj_sobe.Name = "broj_sobe";
            this.broj_sobe.ReadOnly = true;
            this.broj_sobe.Width = 35;
            // 
            // vrsta_sobe
            // 
            this.vrsta_sobe.HeaderText = "Vrsta sobe";
            this.vrsta_sobe.Name = "vrsta_sobe";
            this.vrsta_sobe.ReadOnly = true;
            // 
            // broj_slobodnih_kreveta
            // 
            this.broj_slobodnih_kreveta.HeaderText = "Slobodni kreveti";
            this.broj_slobodnih_kreveta.Name = "broj_slobodnih_kreveta";
            this.broj_slobodnih_kreveta.ReadOnly = true;
            this.broj_slobodnih_kreveta.Width = 60;
            // 
            // zaduzena_cistacica
            // 
            this.zaduzena_cistacica.HeaderText = "Čistaćica";
            this.zaduzena_cistacica.Name = "zaduzena_cistacica";
            this.zaduzena_cistacica.ReadOnly = true;
            this.zaduzena_cistacica.Width = 130;
            // 
            // sobe_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.broj_soba_nepok);
            this.Controls.Add(this.broj_soba_pok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combonepok);
            this.Controls.Add(this.combopok);
            this.Controls.Add(this.trazi_nepok);
            this.Controls.Add(this.trazi_pok);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sobe_uc";
            this.Size = new System.Drawing.Size(877, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox broj_soba_nepok;
        private System.Windows.Forms.TextBox broj_soba_pok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combonepok;
        private System.Windows.Forms.ComboBox combopok;
        private System.Windows.Forms.TextBox trazi_nepok;
        private System.Windows.Forms.TextBox trazi_pok;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_sobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrsta_sobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_slobodnih_kreveta;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaduzena_cistacica;
    }
}
