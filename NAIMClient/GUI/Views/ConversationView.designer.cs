using System.Windows.Forms;
using GUI.Controls;
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtMessageList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(443, 332);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(76, 53);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(6, 332);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(427, 53);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // txtMessageList
            // 
            this.txtMessageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageList.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessageList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessageList.Location = new System.Drawing.Point(6, 12);
            this.txtMessageList.Name = "txtMessageList";
            this.txtMessageList.ReadOnly = true;
            this.txtMessageList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMessageList.Size = new System.Drawing.Size(513, 314);
            this.txtMessageList.TabIndex = 2;
            this.txtMessageList.Text = "";
            // 
            // ConversationView
            // 
            this.AcceptButton = this.btnSend;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(525, 396);
            this.Controls.Add(this.txtMessageList);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "ConversationView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConversationView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Button btnSend;
        private TextBox txtMessage;
        private RichTextBox txtMessageList;

    }
}