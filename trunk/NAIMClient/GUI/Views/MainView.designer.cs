using System.Windows.Forms;
namespace GUI
{
    public partial class MainView : Form
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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnAddConversation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Location = new System.Drawing.Point(177, 231);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(103, 23);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnAddConversation
            // 
            this.btnAddConversation.Location = new System.Drawing.Point(105, 81);
            this.btnAddConversation.Name = "btnAddConversation";
            this.btnAddConversation.Size = new System.Drawing.Size(154, 24);
            this.btnAddConversation.TabIndex = 1;
            this.btnAddConversation.Text = "Add Conversation View";
            this.btnAddConversation.UseVisualStyleBackColor = true;
            this.btnAddConversation.Click += new System.EventHandler(this.btnAddConversation_Click);
            // 
            // MainView
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnAddConversation);
            this.Controls.Add(this.btnSignOut);
            this.Name = "MainView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.ResumeLayout(false);

        }
        #endregion

        private Button btnAddConversation;
    }
}