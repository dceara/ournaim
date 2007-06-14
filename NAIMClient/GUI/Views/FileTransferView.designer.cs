using System.Windows.Forms;
namespace GUI
{
    public partial class FileTransferView : Form
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // FileTransferView
            // 
            this.ClientSize = new System.Drawing.Size(818, 580);
            this.Name = "FileTransferView";
            this.Text = "File Transfer Manager";
            this.ResumeLayout(false);

        }
        #endregion

        private SaveFileDialog saveFileDialog;

    }
}