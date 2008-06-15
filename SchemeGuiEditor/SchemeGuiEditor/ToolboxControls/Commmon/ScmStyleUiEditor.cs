using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Design;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace SchemeGuiEditor.ToolboxControls
{
    public class ScmStyleUiEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService formsEditorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            if (formsEditorService == null)
                return null;

            if (value is ScmFrameStyle)
            {
                ScmFrameStyleEditorControl editorCtrl = new ScmFrameStyleEditorControl(value as ScmFrameStyle);
                formsEditorService.DropDownControl(editorCtrl);
                return editorCtrl.Style;
            }

            if (value is ScmButtonStyle)
            {
                ScmButtonStyleEditorControl editorCtrl = new ScmButtonStyleEditorControl(value as ScmButtonStyle);
                formsEditorService.DropDownControl(editorCtrl);
                return editorCtrl.Style;
            }

            if (value is ScmStyle)
            {
                ScmStyleEditorControl editorCtrl = new ScmStyleEditorControl(value as ScmStyle);
                formsEditorService.DropDownControl(editorCtrl);
                return editorCtrl.Style;
            }

            return null;
        }
    }

}
