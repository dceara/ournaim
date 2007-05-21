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
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(6, 127);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(330, 74);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(342, 127);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 74);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtMessageList
            // 
            this.txtMessageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessageList.Location = new System.Drawing.Point(6, 12);
            this.txtMessageList.Multiline = true;
            this.txtMessageList.Name = "txtMessageList";
            this.txtMessageList.ReadOnly = true;
            this.txtMessageList.Size = new System.Drawing.Size(406, 107);
            this.txtMessageList.TabIndex = 2;
            // 
            // ConversationView
            // 
            this.ClientSize = new System.Drawing.Size(419, 209);
            this.Controls.Add(this.txtMessageList);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Name = "ConversationView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConversationView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private RichTextBox txtMessage;
        private Button btnSend;
        private TextBox txtMessageList;

    }
}