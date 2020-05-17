namespace MuSQLConnect
{
    partial class Form1
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
            this.host = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.btnSQL = new System.Windows.Forms.Button();
            this.lvGrid = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // host
            // 
            this.host.AutoSize = true;
            this.host.Location = new System.Drawing.Point(54, 33);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(27, 13);
            this.host.TabIndex = 0;
            this.host.Text = "host";
            this.host.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "user";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "sasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "password";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "classicmodels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DBname";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(57, 245);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(168, 61);
            this.btn.TabIndex = 8;
            this.btn.Text = "Polącz";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // tbSQL
            // 
            this.tbSQL.Location = new System.Drawing.Point(262, 32);
            this.tbSQL.Multiline = true;
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.Size = new System.Drawing.Size(268, 110);
            this.tbSQL.TabIndex = 9;
            this.tbSQL.Text = "select customername from customers";
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(551, 33);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(105, 59);
            this.btnSQL.TabIndex = 10;
            this.btnSQL.Text = "wykonaj zapytanie";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // lvGrid
            // 
            this.lvGrid.HideSelection = false;
            this.lvGrid.Location = new System.Drawing.Point(262, 172);
            this.lvGrid.Name = "lvGrid";
            this.lvGrid.Size = new System.Drawing.Size(394, 247);
            this.lvGrid.TabIndex = 11;
            this.lvGrid.UseCompatibleStateImageBehavior = false;
            this.lvGrid.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 431);
            this.Controls.Add(this.lvGrid);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.tbSQL);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.host);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label host;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox tbSQL;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.ListView lvGrid;
    }
}

