namespace Shrinkware
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            btnLinkFolder = new Button();
            label1 = new Label();
            txtLinkFolder = new TextBox();
            groupBox2 = new GroupBox();
            btnTarget = new Button();
            label4 = new Label();
            txtTarget = new TextBox();
            btnCreateShortcut = new Button();
            btnExit = new Button();
            target = new OpenFileDialog();
            link = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLinkFolder);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLinkFolder);
            groupBox1.Location = new Point(10, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 71);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Link Folder";
            // 
            // btnLinkFolder
            // 
            btnLinkFolder.Location = new Point(260, 36);
            btnLinkFolder.Name = "btnLinkFolder";
            btnLinkFolder.Size = new Size(27, 21);
            btnLinkFolder.TabIndex = 1;
            btnLinkFolder.Text = "...";
            btnLinkFolder.UseVisualStyleBackColor = true;
            btnLinkFolder.Click += btnLinkFolder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 21);
            label1.Name = "label1";
            label1.Size = new Size(170, 13);
            label1.TabIndex = 1;
            label1.Text = "Please select the link path to save";
            // 
            // txtLinkFolder
            // 
            txtLinkFolder.Location = new Point(5, 37);
            txtLinkFolder.Name = "txtLinkFolder";
            txtLinkFolder.Size = new Size(252, 21);
            txtLinkFolder.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTarget);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtTarget);
            groupBox2.Location = new Point(10, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 74);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Original File";
            // 
            // btnTarget
            // 
            btnTarget.Location = new Point(260, 36);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(27, 21);
            btnTarget.TabIndex = 1;
            btnTarget.Text = "...";
            btnTarget.UseVisualStyleBackColor = true;
            btnTarget.Click += btnTarget_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 20);
            label4.Name = "label4";
            label4.Size = new Size(206, 13);
            label4.TabIndex = 1;
            label4.Text = "Please choose the file you want to create";
            // 
            // txtTarget
            // 
            txtTarget.Location = new Point(5, 36);
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(252, 21);
            txtTarget.TabIndex = 0;
            // 
            // btnCreateShortcut
            // 
            btnCreateShortcut.Location = new Point(10, 166);
            btnCreateShortcut.Name = "btnCreateShortcut";
            btnCreateShortcut.Size = new Size(64, 21);
            btnCreateShortcut.TabIndex = 2;
            btnCreateShortcut.Text = "Create";
            btnCreateShortcut.UseVisualStyleBackColor = true;
            btnCreateShortcut.Click += btnCreateShortcut_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(80, 166);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(64, 21);
            btnExit.TabIndex = 3;
            btnExit.Text = "Cancel";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(314, 195);
            Controls.Add(btnExit);
            Controls.Add(btnCreateShortcut);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shrinkware";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtLinkFolder;
        private Button btnLinkFolder;
        private GroupBox groupBox2;
        private Button btnTarget;
        private Label label4;
        private TextBox txtTarget;
        private Button btnCreateShortcut;
        private Button btnExit;
        private OpenFileDialog target;
        private SaveFileDialog link;
    }
}