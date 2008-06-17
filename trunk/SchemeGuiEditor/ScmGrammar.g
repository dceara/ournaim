grammar ScmGrammar;

options {
	language=CSharp;
}

tokens {
	SEMI = ';';
	DEFINE = 'define';
	NEW = 'new';
	FRAME = 'frame%';
	BUTTON = 'button%';
	MESSAGE = 'message%';
	CHECKBOX = 'check-box%';
	HPANEL = 'horizontal-panel%';
	VPANEL = 'vertical-panel%';
	PARENT = 'parent';
	LABEL = 'label';
	WIDTH = 'width';
	HEIGHT = 'height';
	ENABLED = 'enabled';
	BORDER = 'border';
	SPACING = 'spacing';
	ALIGNMENT = 'alignment';
	MIN_WIDTH = 'min-width';
	MIN_HEIGHT = 'min-height';
	STRETCH_WIDTH = 'stretchable-width';
	STRETCH_HEIGHT = 'stretchable-height';
	VERT_MARGIN = 'vert-margin';
	HORIZ_MARGIN = 'horiz-margin';
	LP = '(';
	RP = ')';
	FALSE = '#f';
	TRUE = '#t';
	TOP = 'top';
	CENTER = 'center';
	BOTTOM = 'bottom';
	LEFT = 'left';
	RIGHT = 'right';
	NULL = 'null';
	NO_RESIZE_BORDER = 'no-resize-border';
	NO_CAPTION = 'no-caption';
	NO_SYSTEM_MENU ='no-system-menu';
	MDI_PARENT = 'mdi-parent';
	MDI_CHILD = 'mdi-child';
	FLOAT = 'float';
	STYLE = 'style';
	DELETED = 'deleted';
	
}

@lexer::namespace {
	SchemeGuiEditor.ParserComponents
}

@parser::namespace {
	SchemeGuiEditor.ParserComponents
}

@header{
using SchemeGuiEditor.ToolboxControls;
using System.Drawing;
using System.Collections.Generic;
}

@members{
List<object> _parsedData = new List<object>();
public List<object> ParsedData
{
	get
	{
		return _parsedData;
	}
}
}

main:	scmBlock+ EOF;

scmBlock
	:	frm = scmFrm {_parsedData.Add(frm);}
	|	btn = scmBtn {_parsedData.Add(btn);}
	|	msg = scmMsg {_parsedData.Add(msg);}
	|	cbx = scmCbx {_parsedData.Add(cbx);}
	|	hpnl = scmHpnl {_parsedData.Add(hpnl);}
	|	com = comment {_parsedData.Add(new ScmComment(com));}
	|	pe = parExpr {_parsedData.Add(new ScmBlock(pe));};

scmFrm returns [ScmFrameProperties frmProp]
@init
{
	ScmFrame frame = new ScmFrame();
	$frmProp = frame.ScmPropertyObject as ScmFrameProperties;
}
	:	LP DEFINE id = ID LP NEW FRAME scmFrmProp[$frmProp]+ RP RP {$frmProp.Name = $id.Text;} ;
	
scmBtn returns [ScmButtonProperties btnProp]
@init
{
	ScmButton btn = new ScmButton();
	$btnProp = btn.ScmPropertyObject as ScmButtonProperties;
}
	:	LP DEFINE id = ID LP NEW BUTTON scmBtnProp[$btnProp]+ RP RP {$btnProp.Name = $id.Text;};	
	
scmMsg returns [ScmMessageProperties msgProp]
@init
{
	ScmMessage msg = new ScmMessage();
	$msgProp = msg.ScmPropertyObject as ScmMessageProperties;
}
	:	LP DEFINE id = ID LP NEW MESSAGE scmMsgProp[$msgProp]+ RP RP {$msgProp.Name = $id.Text;};

scmCbx returns [ScmCheckBoxProperties cbxProp]
@init
{
	ScmCheckBox cbx = new ScmCheckBox();
	$cbxProp = cbx.ScmPropertyObject as ScmCheckBoxProperties;
}
	:	LP DEFINE id = ID LP NEW CHECKBOX scmCbxProp[$cbxProp]+ RP RP {$cbxProp.Name = $id.Text;};	

scmHpnl returns [ScmHorizontalPanelProperties hpnlProp]
@init
{
	ScmHorizontalPanel hpnl = new ScmHorizontalPanel();
	$hpnlProp = hpnl.ScmPropertyObject as ScmHorizontalPanelProperties;
}
	:	LP DEFINE id = ID LP NEW HPANEL scmHpnlProp[$hpnlProp]+ RP RP {$hpnlProp.Name = $id.Text;};	

/*scmVpnl returns [ScmVerticalPanelProperties vpnlProp]
@init
{
	ScmHorizontalPanel vpnl = new ScmHorizontalPanel();
	$vpnlProp = vpnl.ScmPropertyObject as ScmVerticalPanelProperties;
}
	:	LP DEFINE id = ID LP NEW VPANEL scmVpnlProp[$hpnlProp]+ RP RP {$hpnlProp.Name = $id.Text;};	*/
	
scmFrmProp [ScmFrameProperties frmProp]
	:	parent = scmParentProp {$frmProp.Parent = parent; $frmProp.AddParesedProperty(FramePropNames.Parent); }
	|	label = scmLabelProp {$frmProp.Label = label; $frmProp.AddParesedProperty(FramePropNames.Label); }
	|	width = scmWidthProp {if (width != "#f") { $frmProp.AutosizeWidth = false; $frmProp.Width = width; $frmProp.AddParesedProperty(FramePropNames.Width);}}
	|	height = scmHeightProp {if (height != "#f") {$frmProp.AutosizeHeight = false; $frmProp.Height = height; $frmProp.AddParesedProperty(FramePropNames.Height);}}
	|	enabled = scmEnabledProp {$frmProp.Enabled = enabled; $frmProp.AddParesedProperty(FramePropNames.Enabled);}
	|	border = scmBorderProp {$frmProp.Border = border; $frmProp.AddParesedProperty(FramePropNames.Border);}
	|	spacing = scmSpacingProp {$frmProp.Spacing = spacing; $frmProp.AddParesedProperty(FramePropNames.Spacing);}
	|	minWidth = scmMinWidthProp {$frmProp.MinWidth = minWidth; $frmProp.AddParesedProperty(FramePropNames.MinWidth);}
	|	minHeight = scmMinHeightProp {$frmProp.MinHeight = minHeight; $frmProp.AddParesedProperty(FramePropNames.MinHeight);}
	|	strechWidth = scmStretchWidthProp {$frmProp.StretchableWidth = strechWidth; $frmProp.AddParesedProperty(FramePropNames.StrechWidth);}
	|	strechHeight = scmStretchHeightProp {$frmProp.StretchableHeight = strechHeight; $frmProp.AddParesedProperty(FramePropNames.StrechHeight);}
	|	scmAlignmentProp[frmProp.Alignment] {$frmProp.AddParesedProperty(FramePropNames.Alignment);}
	|	scmFrmStyleProp[frmProp.Style] {$frmProp.AddParesedProperty(FramePropNames.Style);}
	|	xyProp = scmXYProp {$frmProp.SetXYProp(xyProp.name, xyProp.value);}
	|	comm = comment {$frmProp.SetScmComment(new ScmComment(comm)); }
	|	pe = parExpr {$frmProp.SetScmBlock(new ScmBlock(pe)); };
	
scmBtnProp [ScmButtonProperties btnProp]
	:	parent = scmParentProp {$btnProp.Parent = parent; $btnProp.AddParesedProperty(ButtonPropNames.Parent); }
	|	label = scmLabelProp {$btnProp.Label = label; $btnProp.AddParesedProperty(ButtonPropNames.Label); }
	|	enabled = scmEnabledProp {$btnProp.Enabled = enabled; $btnProp.AddParesedProperty(ButtonPropNames.Enabled);}
	|	minWidth = scmMinWidthProp {if (minWidth != 0) $btnProp.AutosizeWidth = false; $btnProp.MinWidth = minWidth; $btnProp.AddParesedProperty(ButtonPropNames.MinWidth);}
	|	minHeight = scmMinHeightProp {if (minHeight != 0) $btnProp.AutosizeHeight = false; $btnProp.MinHeight = minHeight; $btnProp.AddParesedProperty( ButtonPropNames.MinHeight);}
	|	strechWidth = scmStretchWidthProp {$btnProp.StretchableWidth = strechWidth; $btnProp.AddParesedProperty(ButtonPropNames.StrechWidth);}
	|	strechHeight = scmStretchHeightProp {$btnProp.StretchableHeight = strechHeight; $btnProp.AddParesedProperty(ButtonPropNames.StrechHeight);}
	|	vertMarg = scmVertMargin {$btnProp.VerticalMargin = vertMarg; $btnProp.AddParesedProperty(ButtonPropNames.VerticalMargin);}
	|	horizMarg = scmHorizMargin {$btnProp.HorizontalMargin = vertMarg; $btnProp.AddParesedProperty(ButtonPropNames.HorizontalMargin);}
	|	scmBtnStyleProp[btnProp.Style] {$btnProp.AddParesedProperty(ButtonPropNames.Style);}
	|	comm = comment {$btnProp.SetScmComment(new ScmComment(comm)); }
	|	pe = parExpr {$btnProp.SetScmBlock(new ScmBlock(pe)); };

scmMsgProp [ScmMessageProperties msgProp]
	:	parent = scmParentProp {$msgProp.Parent = parent; $msgProp.AddParesedProperty(MessagePropNames.Parent); }
	|	label = scmLabelProp {$msgProp.Label = label; $msgProp.AddParesedProperty(MessagePropNames.Label); }
	|	enabled = scmEnabledProp {$msgProp.Enabled = enabled; $msgProp.AddParesedProperty(MessagePropNames.Enabled);}
	|	minWidth = scmMinWidthProp {if (minWidth != 0) msgProp.AutosizeWidth = false; $msgProp.MinWidth = minWidth; $msgProp.AddParesedProperty(MessagePropNames.MinWidth);}
	|	minHeight = scmMinHeightProp {if (minHeight != 0) $msgProp.AutosizeHeight = false; $msgProp.MinHeight = minHeight; $msgProp.AddParesedProperty( MessagePropNames.MinHeight);}
	|	strechWidth = scmStretchWidthProp {$msgProp.StretchableWidth = strechWidth; $msgProp.AddParesedProperty(MessagePropNames.StrechWidth);}
	|	strechHeight = scmStretchHeightProp {$msgProp.StretchableHeight = strechHeight; $msgProp.AddParesedProperty(MessagePropNames.StrechHeight);}
	|	vertMarg = scmVertMargin {$msgProp.VerticalMargin = vertMarg; $msgProp.AddParesedProperty(MessagePropNames.VerticalMargin);}
	|	horizMarg = scmHorizMargin {$msgProp.HorizontalMargin = vertMarg; $msgProp.AddParesedProperty(MessagePropNames.HorizontalMargin);}
	|	scmStyleProp[msgProp.Style] {$msgProp.AddParesedProperty(MessagePropNames.Style);}
	|	comm = comment {$msgProp.SetScmComment(new ScmComment(comm)); }
	|	pe = parExpr {$msgProp.SetScmBlock(new ScmBlock(pe)); };
	
scmCbxProp [ScmCheckBoxProperties cbxProp]
	:	parent = scmParentProp {$cbxProp.Parent = parent; $cbxProp.AddParesedProperty(CheckBoxPropNames.Parent); }
	|	label = scmLabelProp {$cbxProp.Label = label; $cbxProp.AddParesedProperty(CheckBoxPropNames.Label); }
	|	enabled = scmEnabledProp {$cbxProp.Enabled = enabled; $cbxProp.AddParesedProperty(CheckBoxPropNames.Enabled);}
	|	minWidth = scmMinWidthProp {if (minWidth != 0) cbxProp.AutosizeWidth = false; $cbxProp.MinWidth = minWidth; $cbxProp.AddParesedProperty(CheckBoxPropNames.MinWidth);}
	|	minHeight = scmMinHeightProp {if (minHeight != 0) $cbxProp.AutosizeHeight = false; $cbxProp.MinHeight = minHeight; $cbxProp.AddParesedProperty( CheckBoxPropNames.MinHeight);}
	|	strechWidth = scmStretchWidthProp {$cbxProp.StretchableWidth = strechWidth; $cbxProp.AddParesedProperty(CheckBoxPropNames.StrechWidth);}
	|	strechHeight = scmStretchHeightProp {$cbxProp.StretchableHeight = strechHeight; $cbxProp.AddParesedProperty(CheckBoxPropNames.StrechHeight);}
	|	vertMarg = scmVertMargin {$cbxProp.VerticalMargin = vertMarg; $cbxProp.AddParesedProperty(CheckBoxPropNames.VerticalMargin);}
	|	horizMarg = scmHorizMargin {$cbxProp.HorizontalMargin = vertMarg; $cbxProp.AddParesedProperty(CheckBoxPropNames.HorizontalMargin);}
	|	scmStyleProp[cbxProp.Style] {$cbxProp.AddParesedProperty(CheckBoxPropNames.Style);}
	|	comm = comment {$cbxProp.SetScmComment(new ScmComment(comm)); }
	|	pe = parExpr {$cbxProp.SetScmBlock(new ScmBlock(pe)); };
	
scmHpnlProp [ScmHorizontalPanelProperties hpnlProp]
	:	parent = scmParentProp {$hpnlProp.Parent = parent; $hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Parent); }
	|	enabled = scmEnabledProp {$hpnlProp.Enabled = enabled; $hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Enabled);}
	|	minWidth = scmMinWidthProp {if (minWidth != 0) hpnlProp.AutosizeWidth = false; $hpnlProp.MinWidth = minWidth; $hpnlProp.AddParesedProperty(HorizontalPanelPropNames.MinWidth);}
	|	minHeight = scmMinHeightProp {if (minHeight != 0) $hpnlProp.AutosizeHeight = false; $hpnlProp.MinHeight = minHeight; $hpnlProp.AddParesedProperty( HorizontalPanelPropNames.MinHeight);}
	|	strechWidth = scmStretchWidthProp {$hpnlProp.StretchableWidth = strechWidth; $hpnlProp.AddParesedProperty(HorizontalPanelPropNames.StrechWidth);}
	|	strechHeight = scmStretchHeightProp {$hpnlProp.StretchableHeight = strechHeight; $hpnlProp.AddParesedProperty(HorizontalPanelPropNames.StrechHeight);}
	|	vertMarg = scmVertMargin {$hpnlProp.VerticalMargin = vertMarg; $hpnlProp.AddParesedProperty(HorizontalPanelPropNames.VerticalMargin);}
	|	horizMarg = scmHorizMargin {$hpnlProp.HorizontalMargin = vertMarg; $hpnlProp.AddParesedProperty(HorizontalPanelPropNames.HorizontalMargin);}
	|	border = scmBorderProp {$hpnlProp.Border = border; $hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Border);}
	|	spacing = scmSpacingProp {$hpnlProp.Spacing = spacing; $hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Spacing);}
	|	scmBtnStyleProp[hpnlProp.Style] {$hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Style);}
	|	scmAlignmentProp[hpnlProp.Alignment] {$hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Alignment);}
	|	comm = comment {$hpnlProp.SetScmComment(new ScmComment(comm)); }
	|	pe = parExpr {$hpnlProp.SetScmBlock(new ScmBlock(pe)); };
	
scmParentProp returns [string parent]
	:	LP PARENT par =(ID | FALSE) RP {$parent = $par.Text; };
	
scmLabelProp returns [string label]
	:	LP LABEL name = NAME RP {$label = $name.Text.Trim('"'); };
	
scmWidthProp returns [string width]
	:	LP WIDTH v =(NUMBER|FALSE) RP {$width = $v.Text; };

scmHeightProp returns [string height]
	:	LP HEIGHT v = (NUMBER|FALSE) RP {$height = $v.Text; };
	
scmXYProp returns [string name, string value]
	:	LP n = ID v = (NUMBER|FALSE) RP {$name = $n.Text; $value = $v.Text; };
	
scmEnabledProp returns [bool enabled]
	:	LP ENABLED v = (TRUE|FALSE) RP {if ($v.Text == "#t") $enabled = true;
							else $enabled = false; } ;

scmBorderProp returns [int border]
	:	LP BORDER nr = NUMBER RP {$border = ParserUtils.GetIntValue($nr.Text); };

scmSpacingProp returns [int spacing]
	:	LP SPACING nr = NUMBER RP {$spacing = ParserUtils.GetIntValue($nr.Text); };

scmMinWidthProp returns [int minWidth]
	:	LP MIN_WIDTH nr = NUMBER RP {$minWidth = ParserUtils.GetIntValue($nr.Text); };

scmMinHeightProp returns [int minHeight]
	:	LP MIN_HEIGHT nr = NUMBER RP {$minHeight = ParserUtils.GetIntValue($nr.Text); };

scmStretchWidthProp returns [bool strechWidth]
	:	LP STRETCH_WIDTH v = (TRUE|FALSE) RP {if ($v.Text == "#t") $strechWidth = true;
								else $strechWidth = false; };

scmStretchHeightProp returns [bool strechHeigth]
	:	LP STRETCH_HEIGHT v = (TRUE|FALSE) RP {if ($v.Text == "#t") $strechHeigth = true;
								else $strechHeigth = false; };
	
scmAlignmentProp [ContainerAlignment alignment]
	:	LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP;
	
scmFrmStyleProp [ScmFrameStyle style]
	:	LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP
	|	LP STYLE NULL RP;
	
scmBtnStyleProp [ScmButtonStyle style]
	:	LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP
	|	LP STYLE NULL RP;
	
scmStyleProp [ScmStyle style]
	:	LP STYLE QUOTE LP scmStyleList[$style] RP RP
	|	LP STYLE NULL RP;

scmVertMargin returns [int val]
	:	LP VERT_MARGIN v = NUMBER RP {$val = ParserUtils.GetIntValue($v.Text); };
	
scmHorizMargin returns [int val]
	:	LP HORIZ_MARGIN v = NUMBER RP {$val = ParserUtils.GetIntValue($v.Text); };

scmVerticalAlign [ContainerAlignment align]
	:	TOP {$align.VerticalAlignment = VerticalAlign.Top; }
	|	CENTER {$align.VerticalAlignment = VerticalAlign.Center; }
	|	BOTTOM {$align.VerticalAlignment = VerticalAlign.Bottom; };

scmHorizAlign [ContainerAlignment align]
	:	LEFT {$align.HorizontalAlignment = HorizontalAlign.Left; }
	|	CENTER {$align.HorizontalAlignment = HorizontalAlign.Center; }
	|	RIGHT {$align.HorizontalAlignment = HorizontalAlign.Right; };
	
scmFrmStyleList[ScmFrameStyle style]
	:	(NO_RESIZE_BORDER {$style.NoResizeBorder = true; }
	|	NO_CAPTION {$style.NoCaption = true; }
	|	NO_SYSTEM_MENU {$style.NoSystemMenu = true; }
	|	MDI_PARENT {$style.MdiParent = true; }
	|	MDI_CHILD {$style.MdiChild = true; }
	|	FLOAT {$style.Floating = true; })*;

scmBtnStyleList[ScmButtonStyle style]
	:	(BORDER {$style.Border = true; }
	| 	DELETED {$style.Deleted = true; })*;
	
scmStyleList[ScmStyle style]
	:	(DELETED {$style.Deleted = true; })*;

parExpr returns [string expr]
@init{
$expr = string.Empty;
}
	:	LP (pe = parExpr {$expr +=pe; })+ RP {$expr = "(" + $expr + ")";} 
	|	op = operand {$expr += op + " "; }
	|	oa = opartors {$expr += oa + " "; };
	

operand returns [string str]
	:	i = ID {$str = i.Text; }
	|	i = NUMBER {$str = i.Text; }
	|	i = TRUE {$str = i.Text; }
	|	i = FALSE {$str = i.Text; };

opartors returns [string str]
	:	i = PLUS {$str = i.Text; }
	|	i = MINUS {$str = i.Text; }
	|	i = STAR {$str = i.Text; }
	|	i = SLASH {$str = i.Text; }
	|	i = LT {$str = i.Text; }
	|	i = GT {$str = i.Text; }
	|	i = EQ {$str = i.Text; }
	|	i = QUOTE {$str = i.Text; };

comment returns [string comm]
	:	c = COMMENT {$comm = $c.Text; };
	
WS 	:	(' ' | '\t' | '\r' | '\n') {Skip();};

ID	:	('a'..'z' | 'A'..'Z' | CAR) ('a'..'z' | 'A'..'Z' | '0'..'9' | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | CAR)*; 

fragment CAR
	:	'?' | '!' | ':' | '$' | '%' | '^' | '&' | '_' | '~' | '@';

fragment DIGIT
	:	'0'..'9';
	
fragment LEAD_DIGIT
	:	'1'..'9';

fragment ZERO
	:	'0';

NUMBER
	:	ZERO | LEAD_DIGIT DIGIT* (DOT DIGIT+)?;
	
NAME:	'"' .* '"';

NEWLINE
	:	('\r'? '\n') {Skip();} 
;

COMMENT 
	:	SEMI (~('\r' | '\n'))*;
	
PLUS 	:	'+';

MINUS 	:	'-';

STAR 	:	'*';

SLASH 	:	'/';

DOT 	:	'.';

LT 	:	'<';

GT 	:	'>';

EQ 	:	'=';

QUOTE 	:	'\'';



