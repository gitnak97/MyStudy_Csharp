
namespace C_Sharp_Study.Delegate_연습
{
    partial class Delegate1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDowThin = new System.Windows.Forms.RadioButton();
            this.rdoDowOriginal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoEdgeCheese = new System.Windows.Forms.RadioButton();
            this.rdoEdgeGold = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numEa = new System.Windows.Forms.NumericUpDown();
            this.cBoxTopping3 = new System.Windows.Forms.CheckBox();
            this.cBoxTopping2 = new System.Windows.Forms.CheckBox();
            this.cBoxTopping1 = new System.Windows.Forms.CheckBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lBoxOder = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDowThin);
            this.groupBox1.Controls.Add(this.rdoDowOriginal);
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도우";
            // 
            // rdoDowThin
            // 
            this.rdoDowThin.AutoSize = true;
            this.rdoDowThin.Location = new System.Drawing.Point(151, 20);
            this.rdoDowThin.Name = "rdoDowThin";
            this.rdoDowThin.Size = new System.Drawing.Size(91, 16);
            this.rdoDowThin.TabIndex = 1;
            this.rdoDowThin.TabStop = true;
            this.rdoDowThin.Text = "씬 (11000원)";
            this.rdoDowThin.UseVisualStyleBackColor = true;
            // 
            // rdoDowOriginal
            // 
            this.rdoDowOriginal.AutoSize = true;
            this.rdoDowOriginal.Location = new System.Drawing.Point(6, 20);
            this.rdoDowOriginal.Name = "rdoDowOriginal";
            this.rdoDowOriginal.Size = new System.Drawing.Size(127, 16);
            this.rdoDowOriginal.TabIndex = 0;
            this.rdoDowOriginal.TabStop = true;
            this.rdoDowOriginal.Text = "오리지널 (10000원)";
            this.rdoDowOriginal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoEdgeCheese);
            this.groupBox2.Controls.Add(this.rdoEdgeGold);
            this.groupBox2.Location = new System.Drawing.Point(26, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 53);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "엣지";
            // 
            // rdoEdgeCheese
            // 
            this.rdoEdgeCheese.AutoSize = true;
            this.rdoEdgeCheese.Location = new System.Drawing.Point(151, 20);
            this.rdoEdgeCheese.Name = "rdoEdgeCheese";
            this.rdoEdgeCheese.Size = new System.Drawing.Size(145, 16);
            this.rdoEdgeCheese.TabIndex = 1;
            this.rdoEdgeCheese.TabStop = true;
            this.rdoEdgeCheese.Text = "치즈크러스트 (2000원)";
            this.rdoEdgeCheese.UseVisualStyleBackColor = true;
            // 
            // rdoEdgeGold
            // 
            this.rdoEdgeGold.AutoSize = true;
            this.rdoEdgeGold.Location = new System.Drawing.Point(6, 20);
            this.rdoEdgeGold.Name = "rdoEdgeGold";
            this.rdoEdgeGold.Size = new System.Drawing.Size(121, 16);
            this.rdoEdgeGold.TabIndex = 0;
            this.rdoEdgeGold.TabStop = true;
            this.rdoEdgeGold.Text = "리치골드 (1000원)";
            this.rdoEdgeGold.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numEa);
            this.groupBox3.Controls.Add(this.cBoxTopping3);
            this.groupBox3.Controls.Add(this.cBoxTopping2);
            this.groupBox3.Controls.Add(this.cBoxTopping1);
            this.groupBox3.Location = new System.Drawing.Point(26, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 171);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "토핑";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "(EA)";
            // 
            // numEa
            // 
            this.numEa.Location = new System.Drawing.Point(207, 63);
            this.numEa.Name = "numEa";
            this.numEa.Size = new System.Drawing.Size(46, 21);
            this.numEa.TabIndex = 1;
            // 
            // cBoxTopping3
            // 
            this.cBoxTopping3.AutoSize = true;
            this.cBoxTopping3.Location = new System.Drawing.Point(6, 64);
            this.cBoxTopping3.Name = "cBoxTopping3";
            this.cBoxTopping3.Size = new System.Drawing.Size(116, 16);
            this.cBoxTopping3.TabIndex = 0;
            this.cBoxTopping3.Text = "치즈 (1ea 300원)";
            this.cBoxTopping3.UseVisualStyleBackColor = true;
            // 
            // cBoxTopping2
            // 
            this.cBoxTopping2.AutoSize = true;
            this.cBoxTopping2.Location = new System.Drawing.Point(6, 42);
            this.cBoxTopping2.Name = "cBoxTopping2";
            this.cBoxTopping2.Size = new System.Drawing.Size(116, 16);
            this.cBoxTopping2.TabIndex = 0;
            this.cBoxTopping2.Text = "감자 (1ea 200원)";
            this.cBoxTopping2.UseVisualStyleBackColor = true;
            // 
            // cBoxTopping1
            // 
            this.cBoxTopping1.AutoSize = true;
            this.cBoxTopping1.Location = new System.Drawing.Point(6, 20);
            this.cBoxTopping1.Name = "cBoxTopping1";
            this.cBoxTopping1.Size = new System.Drawing.Size(128, 16);
            this.cBoxTopping1.TabIndex = 0;
            this.cBoxTopping1.Text = "소세지 (1ea 500원)";
            this.cBoxTopping1.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(233, 349);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(114, 32);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lBoxOder
            // 
            this.lBoxOder.FormattingEnabled = true;
            this.lBoxOder.ItemHeight = 12;
            this.lBoxOder.Location = new System.Drawing.Point(12, 400);
            this.lBoxOder.Name = "lBoxOder";
            this.lBoxOder.Size = new System.Drawing.Size(331, 136);
            this.lBoxOder.TabIndex = 3;
            // 
            // Delegate1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 553);
            this.Controls.Add(this.lBoxOder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Delegate1";
            this.Text = "Delegate1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDowThin;
        private System.Windows.Forms.RadioButton rdoDowOriginal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoEdgeCheese;
        private System.Windows.Forms.RadioButton rdoEdgeGold;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numEa;
        private System.Windows.Forms.CheckBox cBoxTopping3;
        private System.Windows.Forms.CheckBox cBoxTopping2;
        private System.Windows.Forms.CheckBox cBoxTopping1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox lBoxOder;
    }
}