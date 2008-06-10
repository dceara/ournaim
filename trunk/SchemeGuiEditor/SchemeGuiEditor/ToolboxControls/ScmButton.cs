using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SchemeGuiEditor.Utils;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmButton : Button, IScmControl
    {
        private ScmButtonProperties _scmProperties;

        public ScmButton()
        {
            this.Margin = new Padding(0);
            this.Height = 20;
            _scmProperties = new ScmButtonProperties(this);
        }

        public void RaiseStrechChanged(StrechDirection direction)
        {
            if (StrechChanged != null)
                StrechChanged(this, new DataEventArgs<StrechDirection>(direction));
        }

        public void RaiseContentSizeChanged()
        {
            if (ContentSizeChanged != null)
                ContentSizeChanged(this, EventArgs.Empty);
        }

        #region IScmControl Members

        public event EventHandler<DataEventArgs<StrechDirection>> StrechChanged;
        public event EventHandler ContentSizeChanged;

        public IScmControlProperties ScmPropertyObject
        {
            get { return _scmProperties; }
        }

        public void SetInitialProperties()
        {
        }

        #endregion

        protected override void OnTextChanged(EventArgs e)
        {
            RecomputeSizes();
        }

        public void RecomputeSizes()
        {
            SizeF textSize = this.CreateGraphics().MeasureString(this.Text, this.Font);
            Size s = new Size(Convert.ToInt32(textSize.Width) + 10, 20);
            this.MinimumSize = s;

            if (_scmProperties.AutosizeWidth)
                this.Width = s.Width;
            else
                this.Width = _scmProperties.MinWidth;

            if (_scmProperties.AutosizeHeight)
                this.Height = s.Height;
            else
                this.Height = _scmProperties.MinHeight;
        }
    }
}
