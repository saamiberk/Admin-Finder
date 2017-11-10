namespace Admin_Finder
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
            this.lbl_Target = new System.Windows.Forms.Label();
            this.txb_Target = new System.Windows.Forms.TextBox();
            this.btn_AddTxt = new System.Windows.Forms.Button();
            this.lxb_Panels = new System.Windows.Forms.ListBox();
            this.lxb_Found = new System.Windows.Forms.ListBox();
            this.lbl_links = new System.Windows.Forms.Label();
            this.lbl_Found = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbl_Target
            // 
            this.lbl_Target.AutoSize = true;
            this.lbl_Target.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Target.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Target.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Target.Location = new System.Drawing.Point(16, 89);
            this.lbl_Target.Name = "lbl_Target";
            this.lbl_Target.Size = new System.Drawing.Size(63, 22);
            this.lbl_Target.TabIndex = 0;
            this.lbl_Target.Text = "Target";
            // 
            // txb_Target
            // 
            this.txb_Target.BackColor = System.Drawing.SystemColors.Window;
            this.txb_Target.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txb_Target.Location = new System.Drawing.Point(85, 89);
            this.txb_Target.Name = "txb_Target";
            this.txb_Target.Size = new System.Drawing.Size(348, 27);
            this.txb_Target.TabIndex = 2;
            this.txb_Target.Text = "example.com or www.example.com";
            this.txb_Target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Target.Enter += new System.EventHandler(this.txb_Target_Enter);
            this.txb_Target.Leave += new System.EventHandler(this.txb_Target_Leave);
            // 
            // btn_AddTxt
            // 
            this.btn_AddTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AddTxt.ForeColor = System.Drawing.Color.Black;
            this.btn_AddTxt.Location = new System.Drawing.Point(48, 426);
            this.btn_AddTxt.Name = "btn_AddTxt";
            this.btn_AddTxt.Size = new System.Drawing.Size(109, 39);
            this.btn_AddTxt.TabIndex = 4;
            this.btn_AddTxt.Text = "Add .txt";
            this.btn_AddTxt.UseVisualStyleBackColor = true;
            this.btn_AddTxt.Click += new System.EventHandler(this.btn_AddTxt_Click);
            // 
            // lxb_Panels
            // 
            this.lxb_Panels.FormattingEnabled = true;
            this.lxb_Panels.Location = new System.Drawing.Point(46, 182);
            this.lxb_Panels.Name = "lxb_Panels";
            this.lxb_Panels.Size = new System.Drawing.Size(196, 238);
            this.lxb_Panels.TabIndex = 6;
            // 
            // lxb_Found
            // 
            this.lxb_Found.FormattingEnabled = true;
            this.lxb_Found.Location = new System.Drawing.Point(261, 182);
            this.lxb_Found.Name = "lxb_Found";
            this.lxb_Found.Size = new System.Drawing.Size(196, 238);
            this.lxb_Found.TabIndex = 7;
            // 
            // lbl_links
            // 
            this.lbl_links.AutoSize = true;
            this.lbl_links.BackColor = System.Drawing.Color.Transparent;
            this.lbl_links.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_links.ForeColor = System.Drawing.Color.Red;
            this.lbl_links.Location = new System.Drawing.Point(105, 138);
            this.lbl_links.Name = "lbl_links";
            this.lbl_links.Size = new System.Drawing.Size(52, 22);
            this.lbl_links.TabIndex = 8;
            this.lbl_links.Text = "Links";
            // 
            // lbl_Found
            // 
            this.lbl_Found.AutoSize = true;
            this.lbl_Found.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Found.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Found.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Found.Location = new System.Drawing.Point(321, 138);
            this.lbl_Found.Name = "lbl_Found";
            this.lbl_Found.Size = new System.Drawing.Size(61, 22);
            this.lbl_Found.TabIndex = 9;
            this.lbl_Found.Text = "Found";
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Start.ForeColor = System.Drawing.Color.Black;
            this.btn_Start.Location = new System.Drawing.Point(133, 535);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(109, 39);
            this.btn_Start.TabIndex = 10;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Stop.ForeColor = System.Drawing.Color.Black;
            this.btn_Stop.Location = new System.Drawing.Point(273, 535);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(109, 39);
            this.btn_Stop.TabIndex = 11;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 484);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(409, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 597);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_Found);
            this.Controls.Add(this.lbl_links);
            this.Controls.Add(this.lxb_Found);
            this.Controls.Add(this.lxb_Panels);
            this.Controls.Add(this.btn_AddTxt);
            this.Controls.Add(this.txb_Target);
            this.Controls.Add(this.lbl_Target);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Admin Finder";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Target;
        private System.Windows.Forms.TextBox txb_Target;
        private System.Windows.Forms.Button btn_AddTxt;
        private System.Windows.Forms.ListBox lxb_Panels;
        private System.Windows.Forms.ListBox lxb_Found;
        private System.Windows.Forms.Label lbl_links;
        private System.Windows.Forms.Label lbl_Found;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

