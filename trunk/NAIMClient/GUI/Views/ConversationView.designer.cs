using System.Windows.Forms;
namespace GUI
{
    public partial class ConversationView : Form
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
            this.SuspendLayout();
            // 
            // ConversationView
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "ConversationView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConversationView_FormClosing);
            this.ResumeLayout(false);

        }
        #endregion

    }
}