// $ANTLR 3.0.1 D:\\Projects\\AntlrTestApps\\ScmGrammar.g 2008-06-17 18:02:56
namespace 
	SchemeGuiEditor.ParserComponents

{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class ScmGrammarLexer : Lexer 
{
    public const int MDI_CHILD = 41;
    public const int LT = 53;
    public const int STAR = 51;
    public const int HORIZ_MARGIN = 26;
    public const int STRETCH_WIDTH = 23;
    public const int SPACING = 19;
    public const int RP = 28;
    public const int LEAD_DIGIT = 61;
    public const int STRETCH_HEIGHT = 24;
    public const int LP = 27;
    public const int NEW = 6;
    public const int BUTTON = 8;
    public const int FLOAT = 42;
    public const int ID = 45;
    public const int DEFINE = 5;
    public const int CAR = 58;
    public const int EOF = -1;
    public const int CENTER = 32;
    public const int ZERO = 62;
    public const int BORDER = 18;
    public const int MDI_PARENT = 40;
    public const int QUOTE = 48;
    public const int PARENT = 13;
    public const int MIN_HEIGHT = 22;
    public const int NAME = 46;
    public const int SLASH = 52;
    public const int VPANEL = 12;
    public const int ALIGNMENT = 20;
    public const int LEFT = 34;
    public const int HPANEL = 11;
    public const int ENABLED = 17;
    public const int MESSAGE = 9;
    public const int PLUS = 49;
    public const int DIGIT = 60;
    public const int EQ = 55;
    public const int DOT = 59;
    public const int COMMENT = 56;
    public const int NO_SYSTEM_MENU = 39;
    public const int NO_CAPTION = 38;
    public const int HEIGHT = 16;
    public const int NULL = 36;
    public const int CHECKBOX = 10;
    public const int NUMBER = 47;
    public const int RIGHT = 35;
    public const int MINUS = 50;
    public const int Tokens = 64;
    public const int VERT_MARGIN = 25;
    public const int TRUE = 30;
    public const int SEMI = 4;
    public const int DELETED = 44;
    public const int NO_RESIZE_BORDER = 37;
    public const int WS = 57;
    public const int NEWLINE = 63;
    public const int LABEL = 14;
    public const int WIDTH = 15;
    public const int STYLE = 43;
    public const int BOTTOM = 33;
    public const int MIN_WIDTH = 21;
    public const int GT = 54;
    public const int FRAME = 7;
    public const int TOP = 31;
    public const int FALSE = 29;

    public ScmGrammarLexer() 
    {
		InitializeCyclicDFAs();
    }
    public ScmGrammarLexer(ICharStream input) 
		: base(input)
	{
		InitializeCyclicDFAs();
    }
    
    override public string GrammarFileName
    {
    	get { return "D:\\Projects\\AntlrTestApps\\ScmGrammar.g";} 
    }

    // $ANTLR start SEMI 
    public void mSEMI() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = SEMI;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:10:6: ( ';' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:10:8: ';'
            {
            	Match(';'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end SEMI

    // $ANTLR start DEFINE 
    public void mDEFINE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DEFINE;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:11:8: ( 'define' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:11:10: 'define'
            {
            	Match("define"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DEFINE

    // $ANTLR start NEW 
    public void mNEW() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NEW;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:12:5: ( 'new' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:12:7: 'new'
            {
            	Match("new"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NEW

    // $ANTLR start FRAME 
    public void mFRAME() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = FRAME;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:13:7: ( 'frame%' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:13:9: 'frame%'
            {
            	Match("frame%"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end FRAME

    // $ANTLR start BUTTON 
    public void mBUTTON() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = BUTTON;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:14:8: ( 'button%' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:14:10: 'button%'
            {
            	Match("button%"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end BUTTON

    // $ANTLR start MESSAGE 
    public void mMESSAGE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MESSAGE;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:15:9: ( 'message%' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:15:11: 'message%'
            {
            	Match("message%"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MESSAGE

    // $ANTLR start CHECKBOX 
    public void mCHECKBOX() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CHECKBOX;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:16:10: ( 'check-box%' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:16:12: 'check-box%'
            {
            	Match("check-box%"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CHECKBOX

    // $ANTLR start HPANEL 
    public void mHPANEL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = HPANEL;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:17:8: ( 'horizontal-panel%' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:17:10: 'horizontal-panel%'
            {
            	Match("horizontal-panel%"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end HPANEL

    // $ANTLR start VPANEL 
    public void mVPANEL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = VPANEL;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:18:8: ( 'vertical-panel%' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:18:10: 'vertical-panel%'
            {
            	Match("vertical-panel%"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end VPANEL

    // $ANTLR start PARENT 
    public void mPARENT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = PARENT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:19:8: ( 'parent' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:19:10: 'parent'
            {
            	Match("parent"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end PARENT

    // $ANTLR start LABEL 
    public void mLABEL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LABEL;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:20:7: ( 'label' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:20:9: 'label'
            {
            	Match("label"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LABEL

    // $ANTLR start WIDTH 
    public void mWIDTH() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WIDTH;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:21:7: ( 'width' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:21:9: 'width'
            {
            	Match("width"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WIDTH

    // $ANTLR start HEIGHT 
    public void mHEIGHT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = HEIGHT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:22:8: ( 'height' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:22:10: 'height'
            {
            	Match("height"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end HEIGHT

    // $ANTLR start ENABLED 
    public void mENABLED() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ENABLED;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:23:9: ( 'enabled' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:23:11: 'enabled'
            {
            	Match("enabled"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ENABLED

    // $ANTLR start BORDER 
    public void mBORDER() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = BORDER;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:24:8: ( 'border' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:24:10: 'border'
            {
            	Match("border"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end BORDER

    // $ANTLR start SPACING 
    public void mSPACING() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = SPACING;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:25:9: ( 'spacing' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:25:11: 'spacing'
            {
            	Match("spacing"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end SPACING

    // $ANTLR start ALIGNMENT 
    public void mALIGNMENT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ALIGNMENT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:26:11: ( 'alignment' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:26:13: 'alignment'
            {
            	Match("alignment"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ALIGNMENT

    // $ANTLR start MIN_WIDTH 
    public void mMIN_WIDTH() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MIN_WIDTH;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:27:11: ( 'min-width' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:27:13: 'min-width'
            {
            	Match("min-width"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MIN_WIDTH

    // $ANTLR start MIN_HEIGHT 
    public void mMIN_HEIGHT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MIN_HEIGHT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:28:12: ( 'min-height' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:28:14: 'min-height'
            {
            	Match("min-height"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MIN_HEIGHT

    // $ANTLR start STRETCH_WIDTH 
    public void mSTRETCH_WIDTH() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = STRETCH_WIDTH;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:29:15: ( 'stretchable-width' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:29:17: 'stretchable-width'
            {
            	Match("stretchable-width"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end STRETCH_WIDTH

    // $ANTLR start STRETCH_HEIGHT 
    public void mSTRETCH_HEIGHT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = STRETCH_HEIGHT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:30:16: ( 'stretchable-height' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:30:18: 'stretchable-height'
            {
            	Match("stretchable-height"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end STRETCH_HEIGHT

    // $ANTLR start VERT_MARGIN 
    public void mVERT_MARGIN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = VERT_MARGIN;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:31:13: ( 'vert-margin' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:31:15: 'vert-margin'
            {
            	Match("vert-margin"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end VERT_MARGIN

    // $ANTLR start HORIZ_MARGIN 
    public void mHORIZ_MARGIN() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = HORIZ_MARGIN;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:32:14: ( 'horiz-margin' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:32:16: 'horiz-margin'
            {
            	Match("horiz-margin"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end HORIZ_MARGIN

    // $ANTLR start LP 
    public void mLP() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LP;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:33:4: ( '(' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:33:6: '('
            {
            	Match('('); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LP

    // $ANTLR start RP 
    public void mRP() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = RP;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:34:4: ( ')' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:34:6: ')'
            {
            	Match(')'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end RP

    // $ANTLR start FALSE 
    public void mFALSE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = FALSE;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:35:7: ( '#f' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:35:9: '#f'
            {
            	Match("#f"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end FALSE

    // $ANTLR start TRUE 
    public void mTRUE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = TRUE;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:36:6: ( '#t' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:36:8: '#t'
            {
            	Match("#t"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end TRUE

    // $ANTLR start TOP 
    public void mTOP() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = TOP;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:37:5: ( 'top' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:37:7: 'top'
            {
            	Match("top"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end TOP

    // $ANTLR start CENTER 
    public void mCENTER() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = CENTER;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:38:8: ( 'center' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:38:10: 'center'
            {
            	Match("center"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end CENTER

    // $ANTLR start BOTTOM 
    public void mBOTTOM() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = BOTTOM;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:39:8: ( 'bottom' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:39:10: 'bottom'
            {
            	Match("bottom"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end BOTTOM

    // $ANTLR start LEFT 
    public void mLEFT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LEFT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:40:6: ( 'left' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:40:8: 'left'
            {
            	Match("left"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LEFT

    // $ANTLR start RIGHT 
    public void mRIGHT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = RIGHT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:41:7: ( 'right' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:41:9: 'right'
            {
            	Match("right"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end RIGHT

    // $ANTLR start NULL 
    public void mNULL() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NULL;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:42:6: ( 'null' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:42:8: 'null'
            {
            	Match("null"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NULL

    // $ANTLR start NO_RESIZE_BORDER 
    public void mNO_RESIZE_BORDER() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NO_RESIZE_BORDER;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:43:18: ( 'no-resize-border' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:43:20: 'no-resize-border'
            {
            	Match("no-resize-border"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NO_RESIZE_BORDER

    // $ANTLR start NO_CAPTION 
    public void mNO_CAPTION() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NO_CAPTION;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:44:12: ( 'no-caption' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:44:14: 'no-caption'
            {
            	Match("no-caption"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NO_CAPTION

    // $ANTLR start NO_SYSTEM_MENU 
    public void mNO_SYSTEM_MENU() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NO_SYSTEM_MENU;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:45:16: ( 'no-system-menu' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:45:18: 'no-system-menu'
            {
            	Match("no-system-menu"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NO_SYSTEM_MENU

    // $ANTLR start MDI_PARENT 
    public void mMDI_PARENT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MDI_PARENT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:46:12: ( 'mdi-parent' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:46:14: 'mdi-parent'
            {
            	Match("mdi-parent"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MDI_PARENT

    // $ANTLR start MDI_CHILD 
    public void mMDI_CHILD() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MDI_CHILD;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:47:11: ( 'mdi-child' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:47:13: 'mdi-child'
            {
            	Match("mdi-child"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MDI_CHILD

    // $ANTLR start FLOAT 
    public void mFLOAT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = FLOAT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:48:7: ( 'float' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:48:9: 'float'
            {
            	Match("float"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end FLOAT

    // $ANTLR start STYLE 
    public void mSTYLE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = STYLE;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:49:7: ( 'style' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:49:9: 'style'
            {
            	Match("style"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end STYLE

    // $ANTLR start DELETED 
    public void mDELETED() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DELETED;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:50:9: ( 'deleted' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:50:11: 'deleted'
            {
            	Match("deleted"); 

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DELETED

    // $ANTLR start WS 
    public void mWS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = WS;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:342:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:342:7: ( ' ' | '\\t' | '\\r' | '\\n' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();
            	
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    Recover(mse);    throw mse;
            	}

            	Skip();
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end WS

    // $ANTLR start ID 
    public void mID() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = ID;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:344:4: ( ( 'a' .. 'z' | 'A' .. 'Z' | CAR ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | CAR )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:344:6: ( 'a' .. 'z' | 'A' .. 'Z' | CAR ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | CAR )*
            {
            	if ( input.LA(1) == '!' || (input.LA(1) >= '$' && input.LA(1) <= '&') || input.LA(1) == ':' || (input.LA(1) >= '?' && input.LA(1) <= 'Z') || (input.LA(1) >= '^' && input.LA(1) <= '_') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || input.LA(1) == '~' ) 
            	{
            	    input.Consume();
            	
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    Recover(mse);    throw mse;
            	}

            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:344:34: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | CAR )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);
            	    
            	    if ( (LA1_0 == '!' || (LA1_0 >= '$' && LA1_0 <= '&') || (LA1_0 >= '*' && LA1_0 <= '+') || (LA1_0 >= '-' && LA1_0 <= ':') || (LA1_0 >= '<' && LA1_0 <= 'Z') || (LA1_0 >= '^' && LA1_0 <= '_') || (LA1_0 >= 'a' && LA1_0 <= 'z') || LA1_0 == '~') )
            	    {
            	        alt1 = 1;
            	    }
            	    
            	
            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:
            			    {
            			    	if ( input.LA(1) == '!' || (input.LA(1) >= '$' && input.LA(1) <= '&') || (input.LA(1) >= '*' && input.LA(1) <= '+') || (input.LA(1) >= '-' && input.LA(1) <= ':') || (input.LA(1) >= '<' && input.LA(1) <= 'Z') || (input.LA(1) >= '^' && input.LA(1) <= '_') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || input.LA(1) == '~' ) 
            			    	{
            			    	    input.Consume();
            			    	
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop1;
            	    }
            	} while (true);
            	
            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end ID

    // $ANTLR start CAR 
    public void mCAR() // throws RecognitionException [2]
    {
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:347:2: ( '?' | '!' | ':' | '$' | '%' | '^' | '&' | '_' | '~' | '@' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:
            {
            	if ( input.LA(1) == '!' || (input.LA(1) >= '$' && input.LA(1) <= '&') || input.LA(1) == ':' || (input.LA(1) >= '?' && input.LA(1) <= '@') || (input.LA(1) >= '^' && input.LA(1) <= '_') || input.LA(1) == '~' ) 
            	{
            	    input.Consume();
            	
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    Recover(mse);    throw mse;
            	}

            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end CAR

    // $ANTLR start DIGIT 
    public void mDIGIT() // throws RecognitionException [2]
    {
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:350:2: ( '0' .. '9' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:350:4: '0' .. '9'
            {
            	MatchRange('0','9'); 
            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end DIGIT

    // $ANTLR start LEAD_DIGIT 
    public void mLEAD_DIGIT() // throws RecognitionException [2]
    {
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:353:2: ( '1' .. '9' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:353:4: '1' .. '9'
            {
            	MatchRange('1','9'); 
            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end LEAD_DIGIT

    // $ANTLR start ZERO 
    public void mZERO() // throws RecognitionException [2]
    {
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:356:2: ( '0' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:356:4: '0'
            {
            	Match('0'); 
            
            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end ZERO

    // $ANTLR start NUMBER 
    public void mNUMBER() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NUMBER;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:359:2: ( ZERO | LEAD_DIGIT ( DIGIT )* ( DOT ( DIGIT )+ )? )
            int alt5 = 2;
            int LA5_0 = input.LA(1);
            
            if ( (LA5_0 == '0') )
            {
                alt5 = 1;
            }
            else if ( ((LA5_0 >= '1' && LA5_0 <= '9')) )
            {
                alt5 = 2;
            }
            else 
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("358:1: NUMBER : ( ZERO | LEAD_DIGIT ( DIGIT )* ( DOT ( DIGIT )+ )? );", 5, 0, input);
            
                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:359:4: ZERO
                    {
                    	mZERO(); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:359:11: LEAD_DIGIT ( DIGIT )* ( DOT ( DIGIT )+ )?
                    {
                    	mLEAD_DIGIT(); 
                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:359:22: ( DIGIT )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);
                    	    
                    	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
                    	    {
                    	        alt2 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:359:22: DIGIT
                    			    {
                    			    	mDIGIT(); 
                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    goto loop2;
                    	    }
                    	} while (true);
                    	
                    	loop2:
                    		;	// Stops C# compiler whinging that label 'loop2' has no statements

                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:359:29: ( DOT ( DIGIT )+ )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);
                    	
                    	if ( (LA4_0 == '.') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:359:30: DOT ( DIGIT )+
                    	        {
                    	        	mDOT(); 
                    	        	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:359:34: ( DIGIT )+
                    	        	int cnt3 = 0;
                    	        	do 
                    	        	{
                    	        	    int alt3 = 2;
                    	        	    int LA3_0 = input.LA(1);
                    	        	    
                    	        	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    	        	    {
                    	        	        alt3 = 1;
                    	        	    }
                    	        	    
                    	        	
                    	        	    switch (alt3) 
                    	        		{
                    	        			case 1 :
                    	        			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:359:34: DIGIT
                    	        			    {
                    	        			    	mDIGIT(); 
                    	        			    
                    	        			    }
                    	        			    break;
                    	        	
                    	        			default:
                    	        			    if ( cnt3 >= 1 ) goto loop3;
                    	        		            EarlyExitException eee =
                    	        		                new EarlyExitException(3, input);
                    	        		            throw eee;
                    	        	    }
                    	        	    cnt3++;
                    	        	} while (true);
                    	        	
                    	        	loop3:
                    	        		;	// Stops C# compiler whinging that label 'loop3' has no statements

                    	        
                    	        }
                    	        break;
                    	
                    	}

                    
                    }
                    break;
            
            }
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NUMBER

    // $ANTLR start NAME 
    public void mNAME() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NAME;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:361:5: ( '\"' ( . )* '\"' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:361:7: '\"' ( . )* '\"'
            {
            	Match('\"'); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:361:11: ( . )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);
            	    
            	    if ( (LA6_0 == '\"') )
            	    {
            	        alt6 = 2;
            	    }
            	    else if ( ((LA6_0 >= '\u0000' && LA6_0 <= '!') || (LA6_0 >= '#' && LA6_0 <= '\uFFFE')) )
            	    {
            	        alt6 = 1;
            	    }
            	    
            	
            	    switch (alt6) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:361:11: .
            			    {
            			    	MatchAny(); 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop6;
            	    }
            	} while (true);
            	
            	loop6:
            		;	// Stops C# compiler whinging that label 'loop6' has no statements

            	Match('\"'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NAME

    // $ANTLR start NEWLINE 
    public void mNEWLINE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = NEWLINE;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:364:2: ( ( ( '\\r' )? '\\n' ) )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:364:4: ( ( '\\r' )? '\\n' )
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:364:4: ( ( '\\r' )? '\\n' )
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:364:5: ( '\\r' )? '\\n'
            	{
            		// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:364:5: ( '\\r' )?
            		int alt7 = 2;
            		int LA7_0 = input.LA(1);
            		
            		if ( (LA7_0 == '\r') )
            		{
            		    alt7 = 1;
            		}
            		switch (alt7) 
            		{
            		    case 1 :
            		        // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:364:5: '\\r'
            		        {
            		        	Match('\r'); 
            		        
            		        }
            		        break;
            		
            		}

            		Match('\n'); 
            	
            	}

            	Skip();
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end NEWLINE

    // $ANTLR start COMMENT 
    public void mCOMMENT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = COMMENT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:368:2: ( SEMI (~ ( '\\r' | '\\n' ) )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:368:4: SEMI (~ ( '\\r' | '\\n' ) )*
            {
            	mSEMI(); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:368:9: (~ ( '\\r' | '\\n' ) )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);
            	    
            	    if ( ((LA8_0 >= '\u0000' && LA8_0 <= '\t') || (LA8_0 >= '\u000B' && LA8_0 <= '\f') || (LA8_0 >= '\u000E' && LA8_0 <= '\uFFFE')) )
            	    {
            	        alt8 = 1;
            	    }
            	    
            	
            	    switch (alt8) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:368:10: ~ ( '\\r' | '\\n' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFE') ) 
            			    	{
            			    	    input.Consume();
            			    	
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    Recover(mse);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop8;
            	    }
            	} while (true);
            	
            	loop8:
            		;	// Stops C# compiler whinging that label 'loop8' has no statements

            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end COMMENT

    // $ANTLR start PLUS 
    public void mPLUS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = PLUS;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:370:7: ( '+' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:370:9: '+'
            {
            	Match('+'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end PLUS

    // $ANTLR start MINUS 
    public void mMINUS() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = MINUS;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:372:8: ( '-' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:372:10: '-'
            {
            	Match('-'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end MINUS

    // $ANTLR start STAR 
    public void mSTAR() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = STAR;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:374:7: ( '*' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:374:9: '*'
            {
            	Match('*'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end STAR

    // $ANTLR start SLASH 
    public void mSLASH() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = SLASH;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:376:8: ( '/' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:376:10: '/'
            {
            	Match('/'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end SLASH

    // $ANTLR start DOT 
    public void mDOT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = DOT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:378:6: ( '.' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:378:8: '.'
            {
            	Match('.'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end DOT

    // $ANTLR start LT 
    public void mLT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = LT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:380:5: ( '<' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:380:7: '<'
            {
            	Match('<'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end LT

    // $ANTLR start GT 
    public void mGT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = GT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:382:5: ( '>' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:382:7: '>'
            {
            	Match('>'); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end GT

    // $ANTLR start EQ 
    public void mEQ() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = EQ;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:384:5: ( '=' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:384:7: '='
            {
            	Match('='); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end EQ

    // $ANTLR start QUOTE 
    public void mQUOTE() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = QUOTE;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:386:8: ( '\\'' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:386:10: '\\''
            {
            	Match('\''); 
            
            }
    
            this.type = _type;
        }
        finally 
    	{
        }
    }
    // $ANTLR end QUOTE

    override public void mTokens() // throws RecognitionException 
    {
        // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:8: ( SEMI | DEFINE | NEW | FRAME | BUTTON | MESSAGE | CHECKBOX | HPANEL | VPANEL | PARENT | LABEL | WIDTH | HEIGHT | ENABLED | BORDER | SPACING | ALIGNMENT | MIN_WIDTH | MIN_HEIGHT | STRETCH_WIDTH | STRETCH_HEIGHT | VERT_MARGIN | HORIZ_MARGIN | LP | RP | FALSE | TRUE | TOP | CENTER | BOTTOM | LEFT | RIGHT | NULL | NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT | STYLE | DELETED | WS | ID | NUMBER | NAME | NEWLINE | COMMENT | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | QUOTE )
        int alt9 = 56;
        switch ( input.LA(1) ) 
        {
        case ';':
        	{
            int LA9_1 = input.LA(2);
            
            if ( ((LA9_1 >= '\u0000' && LA9_1 <= '\t') || (LA9_1 >= '\u000B' && LA9_1 <= '\f') || (LA9_1 >= '\u000E' && LA9_1 <= '\uFFFE')) )
            {
                alt9 = 47;
            }
            else 
            {
                alt9 = 1;}
            }
            break;
        case 'd':
        	{
            int LA9_2 = input.LA(2);
            
            if ( (LA9_2 == 'e') )
            {
                switch ( input.LA(3) ) 
                {
                case 'f':
                	{
                    int LA9_67 = input.LA(4);
                    
                    if ( (LA9_67 == 'i') )
                    {
                        int LA9_96 = input.LA(5);
                        
                        if ( (LA9_96 == 'n') )
                        {
                            int LA9_127 = input.LA(6);
                            
                            if ( (LA9_127 == 'e') )
                            {
                                int LA9_159 = input.LA(7);
                                
                                if ( (LA9_159 == '!' || (LA9_159 >= '$' && LA9_159 <= '&') || (LA9_159 >= '*' && LA9_159 <= '+') || (LA9_159 >= '-' && LA9_159 <= ':') || (LA9_159 >= '<' && LA9_159 <= 'Z') || (LA9_159 >= '^' && LA9_159 <= '_') || (LA9_159 >= 'a' && LA9_159 <= 'z') || LA9_159 == '~') )
                                {
                                    alt9 = 43;
                                }
                                else 
                                {
                                    alt9 = 2;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                    }
                    break;
                case 'l':
                	{
                    int LA9_68 = input.LA(4);
                    
                    if ( (LA9_68 == 'e') )
                    {
                        int LA9_97 = input.LA(5);
                        
                        if ( (LA9_97 == 't') )
                        {
                            int LA9_128 = input.LA(6);
                            
                            if ( (LA9_128 == 'e') )
                            {
                                int LA9_160 = input.LA(7);
                                
                                if ( (LA9_160 == 'd') )
                                {
                                    int LA9_191 = input.LA(8);
                                    
                                    if ( (LA9_191 == '!' || (LA9_191 >= '$' && LA9_191 <= '&') || (LA9_191 >= '*' && LA9_191 <= '+') || (LA9_191 >= '-' && LA9_191 <= ':') || (LA9_191 >= '<' && LA9_191 <= 'Z') || (LA9_191 >= '^' && LA9_191 <= '_') || (LA9_191 >= 'a' && LA9_191 <= 'z') || LA9_191 == '~') )
                                    {
                                        alt9 = 43;
                                    }
                                    else 
                                    {
                                        alt9 = 41;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                    }
                    break;
                	default:
                    	alt9 = 43;
                    	break;}
            
            }
            else 
            {
                alt9 = 43;}
            }
            break;
        case 'n':
        	{
            switch ( input.LA(2) ) 
            {
            case 'u':
            	{
                int LA9_39 = input.LA(3);
                
                if ( (LA9_39 == 'l') )
                {
                    int LA9_69 = input.LA(4);
                    
                    if ( (LA9_69 == 'l') )
                    {
                        int LA9_98 = input.LA(5);
                        
                        if ( (LA9_98 == '!' || (LA9_98 >= '$' && LA9_98 <= '&') || (LA9_98 >= '*' && LA9_98 <= '+') || (LA9_98 >= '-' && LA9_98 <= ':') || (LA9_98 >= '<' && LA9_98 <= 'Z') || (LA9_98 >= '^' && LA9_98 <= '_') || (LA9_98 >= 'a' && LA9_98 <= 'z') || LA9_98 == '~') )
                        {
                            alt9 = 43;
                        }
                        else 
                        {
                            alt9 = 33;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            case 'o':
            	{
                int LA9_40 = input.LA(3);
                
                if ( (LA9_40 == '-') )
                {
                    switch ( input.LA(4) ) 
                    {
                    case 'r':
                    	{
                        int LA9_99 = input.LA(5);
                        
                        if ( (LA9_99 == 'e') )
                        {
                            int LA9_130 = input.LA(6);
                            
                            if ( (LA9_130 == 's') )
                            {
                                int LA9_161 = input.LA(7);
                                
                                if ( (LA9_161 == 'i') )
                                {
                                    int LA9_192 = input.LA(8);
                                    
                                    if ( (LA9_192 == 'z') )
                                    {
                                        int LA9_217 = input.LA(9);
                                        
                                        if ( (LA9_217 == 'e') )
                                        {
                                            int LA9_235 = input.LA(10);
                                            
                                            if ( (LA9_235 == '-') )
                                            {
                                                int LA9_250 = input.LA(11);
                                                
                                                if ( (LA9_250 == 'b') )
                                                {
                                                    int LA9_264 = input.LA(12);
                                                    
                                                    if ( (LA9_264 == 'o') )
                                                    {
                                                        int LA9_275 = input.LA(13);
                                                        
                                                        if ( (LA9_275 == 'r') )
                                                        {
                                                            int LA9_282 = input.LA(14);
                                                            
                                                            if ( (LA9_282 == 'd') )
                                                            {
                                                                int LA9_289 = input.LA(15);
                                                                
                                                                if ( (LA9_289 == 'e') )
                                                                {
                                                                    int LA9_295 = input.LA(16);
                                                                    
                                                                    if ( (LA9_295 == 'r') )
                                                                    {
                                                                        int LA9_301 = input.LA(17);
                                                                        
                                                                        if ( (LA9_301 == '!' || (LA9_301 >= '$' && LA9_301 <= '&') || (LA9_301 >= '*' && LA9_301 <= '+') || (LA9_301 >= '-' && LA9_301 <= ':') || (LA9_301 >= '<' && LA9_301 <= 'Z') || (LA9_301 >= '^' && LA9_301 <= '_') || (LA9_301 >= 'a' && LA9_301 <= 'z') || LA9_301 == '~') )
                                                                        {
                                                                            alt9 = 43;
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt9 = 34;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 43;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 43;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 43;}
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 43;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 43;}
                                                }
                                                else 
                                                {
                                                    alt9 = 43;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                        }
                        break;
                    case 's':
                    	{
                        int LA9_100 = input.LA(5);
                        
                        if ( (LA9_100 == 'y') )
                        {
                            int LA9_131 = input.LA(6);
                            
                            if ( (LA9_131 == 's') )
                            {
                                int LA9_162 = input.LA(7);
                                
                                if ( (LA9_162 == 't') )
                                {
                                    int LA9_193 = input.LA(8);
                                    
                                    if ( (LA9_193 == 'e') )
                                    {
                                        int LA9_218 = input.LA(9);
                                        
                                        if ( (LA9_218 == 'm') )
                                        {
                                            int LA9_236 = input.LA(10);
                                            
                                            if ( (LA9_236 == '-') )
                                            {
                                                int LA9_251 = input.LA(11);
                                                
                                                if ( (LA9_251 == 'm') )
                                                {
                                                    int LA9_265 = input.LA(12);
                                                    
                                                    if ( (LA9_265 == 'e') )
                                                    {
                                                        int LA9_276 = input.LA(13);
                                                        
                                                        if ( (LA9_276 == 'n') )
                                                        {
                                                            int LA9_283 = input.LA(14);
                                                            
                                                            if ( (LA9_283 == 'u') )
                                                            {
                                                                int LA9_290 = input.LA(15);
                                                                
                                                                if ( (LA9_290 == '!' || (LA9_290 >= '$' && LA9_290 <= '&') || (LA9_290 >= '*' && LA9_290 <= '+') || (LA9_290 >= '-' && LA9_290 <= ':') || (LA9_290 >= '<' && LA9_290 <= 'Z') || (LA9_290 >= '^' && LA9_290 <= '_') || (LA9_290 >= 'a' && LA9_290 <= 'z') || LA9_290 == '~') )
                                                                {
                                                                    alt9 = 43;
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 36;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 43;}
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 43;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 43;}
                                                }
                                                else 
                                                {
                                                    alt9 = 43;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                        }
                        break;
                    case 'c':
                    	{
                        int LA9_101 = input.LA(5);
                        
                        if ( (LA9_101 == 'a') )
                        {
                            int LA9_132 = input.LA(6);
                            
                            if ( (LA9_132 == 'p') )
                            {
                                int LA9_163 = input.LA(7);
                                
                                if ( (LA9_163 == 't') )
                                {
                                    int LA9_194 = input.LA(8);
                                    
                                    if ( (LA9_194 == 'i') )
                                    {
                                        int LA9_219 = input.LA(9);
                                        
                                        if ( (LA9_219 == 'o') )
                                        {
                                            int LA9_237 = input.LA(10);
                                            
                                            if ( (LA9_237 == 'n') )
                                            {
                                                int LA9_252 = input.LA(11);
                                                
                                                if ( (LA9_252 == '!' || (LA9_252 >= '$' && LA9_252 <= '&') || (LA9_252 >= '*' && LA9_252 <= '+') || (LA9_252 >= '-' && LA9_252 <= ':') || (LA9_252 >= '<' && LA9_252 <= 'Z') || (LA9_252 >= '^' && LA9_252 <= '_') || (LA9_252 >= 'a' && LA9_252 <= 'z') || LA9_252 == '~') )
                                                {
                                                    alt9 = 43;
                                                }
                                                else 
                                                {
                                                    alt9 = 35;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                        }
                        break;
                    	default:
                        	alt9 = 43;
                        	break;}
                
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            case 'e':
            	{
                int LA9_41 = input.LA(3);
                
                if ( (LA9_41 == 'w') )
                {
                    int LA9_71 = input.LA(4);
                    
                    if ( (LA9_71 == '!' || (LA9_71 >= '$' && LA9_71 <= '&') || (LA9_71 >= '*' && LA9_71 <= '+') || (LA9_71 >= '-' && LA9_71 <= ':') || (LA9_71 >= '<' && LA9_71 <= 'Z') || (LA9_71 >= '^' && LA9_71 <= '_') || (LA9_71 >= 'a' && LA9_71 <= 'z') || LA9_71 == '~') )
                    {
                        alt9 = 43;
                    }
                    else 
                    {
                        alt9 = 3;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            	default:
                	alt9 = 43;
                	break;}
        
            }
            break;
        case 'f':
        	{
            switch ( input.LA(2) ) 
            {
            case 'l':
            	{
                int LA9_42 = input.LA(3);
                
                if ( (LA9_42 == 'o') )
                {
                    int LA9_72 = input.LA(4);
                    
                    if ( (LA9_72 == 'a') )
                    {
                        int LA9_103 = input.LA(5);
                        
                        if ( (LA9_103 == 't') )
                        {
                            int LA9_133 = input.LA(6);
                            
                            if ( (LA9_133 == '!' || (LA9_133 >= '$' && LA9_133 <= '&') || (LA9_133 >= '*' && LA9_133 <= '+') || (LA9_133 >= '-' && LA9_133 <= ':') || (LA9_133 >= '<' && LA9_133 <= 'Z') || (LA9_133 >= '^' && LA9_133 <= '_') || (LA9_133 >= 'a' && LA9_133 <= 'z') || LA9_133 == '~') )
                            {
                                alt9 = 43;
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            case 'r':
            	{
                int LA9_43 = input.LA(3);
                
                if ( (LA9_43 == 'a') )
                {
                    int LA9_73 = input.LA(4);
                    
                    if ( (LA9_73 == 'm') )
                    {
                        int LA9_104 = input.LA(5);
                        
                        if ( (LA9_104 == 'e') )
                        {
                            int LA9_134 = input.LA(6);
                            
                            if ( (LA9_134 == '%') )
                            {
                                int LA9_165 = input.LA(7);
                                
                                if ( (LA9_165 == '!' || (LA9_165 >= '$' && LA9_165 <= '&') || (LA9_165 >= '*' && LA9_165 <= '+') || (LA9_165 >= '-' && LA9_165 <= ':') || (LA9_165 >= '<' && LA9_165 <= 'Z') || (LA9_165 >= '^' && LA9_165 <= '_') || (LA9_165 >= 'a' && LA9_165 <= 'z') || LA9_165 == '~') )
                                {
                                    alt9 = 43;
                                }
                                else 
                                {
                                    alt9 = 4;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            	default:
                	alt9 = 43;
                	break;}
        
            }
            break;
        case 'b':
        	{
            switch ( input.LA(2) ) 
            {
            case 'o':
            	{
                switch ( input.LA(3) ) 
                {
                case 'r':
                	{
                    int LA9_74 = input.LA(4);
                    
                    if ( (LA9_74 == 'd') )
                    {
                        int LA9_105 = input.LA(5);
                        
                        if ( (LA9_105 == 'e') )
                        {
                            int LA9_135 = input.LA(6);
                            
                            if ( (LA9_135 == 'r') )
                            {
                                int LA9_166 = input.LA(7);
                                
                                if ( (LA9_166 == '!' || (LA9_166 >= '$' && LA9_166 <= '&') || (LA9_166 >= '*' && LA9_166 <= '+') || (LA9_166 >= '-' && LA9_166 <= ':') || (LA9_166 >= '<' && LA9_166 <= 'Z') || (LA9_166 >= '^' && LA9_166 <= '_') || (LA9_166 >= 'a' && LA9_166 <= 'z') || LA9_166 == '~') )
                                {
                                    alt9 = 43;
                                }
                                else 
                                {
                                    alt9 = 15;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                    }
                    break;
                case 't':
                	{
                    int LA9_75 = input.LA(4);
                    
                    if ( (LA9_75 == 't') )
                    {
                        int LA9_106 = input.LA(5);
                        
                        if ( (LA9_106 == 'o') )
                        {
                            int LA9_136 = input.LA(6);
                            
                            if ( (LA9_136 == 'm') )
                            {
                                int LA9_167 = input.LA(7);
                                
                                if ( (LA9_167 == '!' || (LA9_167 >= '$' && LA9_167 <= '&') || (LA9_167 >= '*' && LA9_167 <= '+') || (LA9_167 >= '-' && LA9_167 <= ':') || (LA9_167 >= '<' && LA9_167 <= 'Z') || (LA9_167 >= '^' && LA9_167 <= '_') || (LA9_167 >= 'a' && LA9_167 <= 'z') || LA9_167 == '~') )
                                {
                                    alt9 = 43;
                                }
                                else 
                                {
                                    alt9 = 30;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                    }
                    break;
                	default:
                    	alt9 = 43;
                    	break;}
            
                }
                break;
            case 'u':
            	{
                int LA9_45 = input.LA(3);
                
                if ( (LA9_45 == 't') )
                {
                    int LA9_76 = input.LA(4);
                    
                    if ( (LA9_76 == 't') )
                    {
                        int LA9_107 = input.LA(5);
                        
                        if ( (LA9_107 == 'o') )
                        {
                            int LA9_137 = input.LA(6);
                            
                            if ( (LA9_137 == 'n') )
                            {
                                int LA9_168 = input.LA(7);
                                
                                if ( (LA9_168 == '%') )
                                {
                                    int LA9_198 = input.LA(8);
                                    
                                    if ( (LA9_198 == '!' || (LA9_198 >= '$' && LA9_198 <= '&') || (LA9_198 >= '*' && LA9_198 <= '+') || (LA9_198 >= '-' && LA9_198 <= ':') || (LA9_198 >= '<' && LA9_198 <= 'Z') || (LA9_198 >= '^' && LA9_198 <= '_') || (LA9_198 >= 'a' && LA9_198 <= 'z') || LA9_198 == '~') )
                                    {
                                        alt9 = 43;
                                    }
                                    else 
                                    {
                                        alt9 = 5;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            	default:
                	alt9 = 43;
                	break;}
        
            }
            break;
        case 'm':
        	{
            switch ( input.LA(2) ) 
            {
            case 'd':
            	{
                int LA9_46 = input.LA(3);
                
                if ( (LA9_46 == 'i') )
                {
                    int LA9_77 = input.LA(4);
                    
                    if ( (LA9_77 == '-') )
                    {
                        switch ( input.LA(5) ) 
                        {
                        case 'p':
                        	{
                            int LA9_138 = input.LA(6);
                            
                            if ( (LA9_138 == 'a') )
                            {
                                int LA9_169 = input.LA(7);
                                
                                if ( (LA9_169 == 'r') )
                                {
                                    int LA9_199 = input.LA(8);
                                    
                                    if ( (LA9_199 == 'e') )
                                    {
                                        int LA9_221 = input.LA(9);
                                        
                                        if ( (LA9_221 == 'n') )
                                        {
                                            int LA9_238 = input.LA(10);
                                            
                                            if ( (LA9_238 == 't') )
                                            {
                                                int LA9_253 = input.LA(11);
                                                
                                                if ( (LA9_253 == '!' || (LA9_253 >= '$' && LA9_253 <= '&') || (LA9_253 >= '*' && LA9_253 <= '+') || (LA9_253 >= '-' && LA9_253 <= ':') || (LA9_253 >= '<' && LA9_253 <= 'Z') || (LA9_253 >= '^' && LA9_253 <= '_') || (LA9_253 >= 'a' && LA9_253 <= 'z') || LA9_253 == '~') )
                                                {
                                                    alt9 = 43;
                                                }
                                                else 
                                                {
                                                    alt9 = 37;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                            }
                            break;
                        case 'c':
                        	{
                            int LA9_139 = input.LA(6);
                            
                            if ( (LA9_139 == 'h') )
                            {
                                int LA9_170 = input.LA(7);
                                
                                if ( (LA9_170 == 'i') )
                                {
                                    int LA9_200 = input.LA(8);
                                    
                                    if ( (LA9_200 == 'l') )
                                    {
                                        int LA9_222 = input.LA(9);
                                        
                                        if ( (LA9_222 == 'd') )
                                        {
                                            int LA9_239 = input.LA(10);
                                            
                                            if ( (LA9_239 == '!' || (LA9_239 >= '$' && LA9_239 <= '&') || (LA9_239 >= '*' && LA9_239 <= '+') || (LA9_239 >= '-' && LA9_239 <= ':') || (LA9_239 >= '<' && LA9_239 <= 'Z') || (LA9_239 >= '^' && LA9_239 <= '_') || (LA9_239 >= 'a' && LA9_239 <= 'z') || LA9_239 == '~') )
                                            {
                                                alt9 = 43;
                                            }
                                            else 
                                            {
                                                alt9 = 38;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                            }
                            break;
                        	default:
                            	alt9 = 43;
                            	break;}
                    
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            case 'e':
            	{
                int LA9_47 = input.LA(3);
                
                if ( (LA9_47 == 's') )
                {
                    int LA9_78 = input.LA(4);
                    
                    if ( (LA9_78 == 's') )
                    {
                        int LA9_109 = input.LA(5);
                        
                        if ( (LA9_109 == 'a') )
                        {
                            int LA9_140 = input.LA(6);
                            
                            if ( (LA9_140 == 'g') )
                            {
                                int LA9_171 = input.LA(7);
                                
                                if ( (LA9_171 == 'e') )
                                {
                                    int LA9_201 = input.LA(8);
                                    
                                    if ( (LA9_201 == '%') )
                                    {
                                        int LA9_223 = input.LA(9);
                                        
                                        if ( (LA9_223 == '!' || (LA9_223 >= '$' && LA9_223 <= '&') || (LA9_223 >= '*' && LA9_223 <= '+') || (LA9_223 >= '-' && LA9_223 <= ':') || (LA9_223 >= '<' && LA9_223 <= 'Z') || (LA9_223 >= '^' && LA9_223 <= '_') || (LA9_223 >= 'a' && LA9_223 <= 'z') || LA9_223 == '~') )
                                        {
                                            alt9 = 43;
                                        }
                                        else 
                                        {
                                            alt9 = 6;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            case 'i':
            	{
                int LA9_48 = input.LA(3);
                
                if ( (LA9_48 == 'n') )
                {
                    int LA9_79 = input.LA(4);
                    
                    if ( (LA9_79 == '-') )
                    {
                        switch ( input.LA(5) ) 
                        {
                        case 'h':
                        	{
                            int LA9_141 = input.LA(6);
                            
                            if ( (LA9_141 == 'e') )
                            {
                                int LA9_172 = input.LA(7);
                                
                                if ( (LA9_172 == 'i') )
                                {
                                    int LA9_202 = input.LA(8);
                                    
                                    if ( (LA9_202 == 'g') )
                                    {
                                        int LA9_224 = input.LA(9);
                                        
                                        if ( (LA9_224 == 'h') )
                                        {
                                            int LA9_241 = input.LA(10);
                                            
                                            if ( (LA9_241 == 't') )
                                            {
                                                int LA9_255 = input.LA(11);
                                                
                                                if ( (LA9_255 == '!' || (LA9_255 >= '$' && LA9_255 <= '&') || (LA9_255 >= '*' && LA9_255 <= '+') || (LA9_255 >= '-' && LA9_255 <= ':') || (LA9_255 >= '<' && LA9_255 <= 'Z') || (LA9_255 >= '^' && LA9_255 <= '_') || (LA9_255 >= 'a' && LA9_255 <= 'z') || LA9_255 == '~') )
                                                {
                                                    alt9 = 43;
                                                }
                                                else 
                                                {
                                                    alt9 = 19;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                            }
                            break;
                        case 'w':
                        	{
                            int LA9_142 = input.LA(6);
                            
                            if ( (LA9_142 == 'i') )
                            {
                                int LA9_173 = input.LA(7);
                                
                                if ( (LA9_173 == 'd') )
                                {
                                    int LA9_203 = input.LA(8);
                                    
                                    if ( (LA9_203 == 't') )
                                    {
                                        int LA9_225 = input.LA(9);
                                        
                                        if ( (LA9_225 == 'h') )
                                        {
                                            int LA9_242 = input.LA(10);
                                            
                                            if ( (LA9_242 == '!' || (LA9_242 >= '$' && LA9_242 <= '&') || (LA9_242 >= '*' && LA9_242 <= '+') || (LA9_242 >= '-' && LA9_242 <= ':') || (LA9_242 >= '<' && LA9_242 <= 'Z') || (LA9_242 >= '^' && LA9_242 <= '_') || (LA9_242 >= 'a' && LA9_242 <= 'z') || LA9_242 == '~') )
                                            {
                                                alt9 = 43;
                                            }
                                            else 
                                            {
                                                alt9 = 18;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                            }
                            break;
                        	default:
                            	alt9 = 43;
                            	break;}
                    
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            	default:
                	alt9 = 43;
                	break;}
        
            }
            break;
        case 'c':
        	{
            switch ( input.LA(2) ) 
            {
            case 'e':
            	{
                int LA9_49 = input.LA(3);
                
                if ( (LA9_49 == 'n') )
                {
                    int LA9_80 = input.LA(4);
                    
                    if ( (LA9_80 == 't') )
                    {
                        int LA9_111 = input.LA(5);
                        
                        if ( (LA9_111 == 'e') )
                        {
                            int LA9_143 = input.LA(6);
                            
                            if ( (LA9_143 == 'r') )
                            {
                                int LA9_174 = input.LA(7);
                                
                                if ( (LA9_174 == '!' || (LA9_174 >= '$' && LA9_174 <= '&') || (LA9_174 >= '*' && LA9_174 <= '+') || (LA9_174 >= '-' && LA9_174 <= ':') || (LA9_174 >= '<' && LA9_174 <= 'Z') || (LA9_174 >= '^' && LA9_174 <= '_') || (LA9_174 >= 'a' && LA9_174 <= 'z') || LA9_174 == '~') )
                                {
                                    alt9 = 43;
                                }
                                else 
                                {
                                    alt9 = 29;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            case 'h':
            	{
                int LA9_50 = input.LA(3);
                
                if ( (LA9_50 == 'e') )
                {
                    int LA9_81 = input.LA(4);
                    
                    if ( (LA9_81 == 'c') )
                    {
                        int LA9_112 = input.LA(5);
                        
                        if ( (LA9_112 == 'k') )
                        {
                            int LA9_144 = input.LA(6);
                            
                            if ( (LA9_144 == '-') )
                            {
                                int LA9_175 = input.LA(7);
                                
                                if ( (LA9_175 == 'b') )
                                {
                                    int LA9_205 = input.LA(8);
                                    
                                    if ( (LA9_205 == 'o') )
                                    {
                                        int LA9_226 = input.LA(9);
                                        
                                        if ( (LA9_226 == 'x') )
                                        {
                                            int LA9_243 = input.LA(10);
                                            
                                            if ( (LA9_243 == '%') )
                                            {
                                                int LA9_257 = input.LA(11);
                                                
                                                if ( (LA9_257 == '!' || (LA9_257 >= '$' && LA9_257 <= '&') || (LA9_257 >= '*' && LA9_257 <= '+') || (LA9_257 >= '-' && LA9_257 <= ':') || (LA9_257 >= '<' && LA9_257 <= 'Z') || (LA9_257 >= '^' && LA9_257 <= '_') || (LA9_257 >= 'a' && LA9_257 <= 'z') || LA9_257 == '~') )
                                                {
                                                    alt9 = 43;
                                                }
                                                else 
                                                {
                                                    alt9 = 7;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            	default:
                	alt9 = 43;
                	break;}
        
            }
            break;
        case 'h':
        	{
            switch ( input.LA(2) ) 
            {
            case 'o':
            	{
                int LA9_51 = input.LA(3);
                
                if ( (LA9_51 == 'r') )
                {
                    int LA9_82 = input.LA(4);
                    
                    if ( (LA9_82 == 'i') )
                    {
                        int LA9_113 = input.LA(5);
                        
                        if ( (LA9_113 == 'z') )
                        {
                            switch ( input.LA(6) ) 
                            {
                            case 'o':
                            	{
                                int LA9_176 = input.LA(7);
                                
                                if ( (LA9_176 == 'n') )
                                {
                                    int LA9_206 = input.LA(8);
                                    
                                    if ( (LA9_206 == 't') )
                                    {
                                        int LA9_227 = input.LA(9);
                                        
                                        if ( (LA9_227 == 'a') )
                                        {
                                            int LA9_244 = input.LA(10);
                                            
                                            if ( (LA9_244 == 'l') )
                                            {
                                                int LA9_258 = input.LA(11);
                                                
                                                if ( (LA9_258 == '-') )
                                                {
                                                    int LA9_270 = input.LA(12);
                                                    
                                                    if ( (LA9_270 == 'p') )
                                                    {
                                                        int LA9_277 = input.LA(13);
                                                        
                                                        if ( (LA9_277 == 'a') )
                                                        {
                                                            int LA9_284 = input.LA(14);
                                                            
                                                            if ( (LA9_284 == 'n') )
                                                            {
                                                                int LA9_291 = input.LA(15);
                                                                
                                                                if ( (LA9_291 == 'e') )
                                                                {
                                                                    int LA9_297 = input.LA(16);
                                                                    
                                                                    if ( (LA9_297 == 'l') )
                                                                    {
                                                                        int LA9_302 = input.LA(17);
                                                                        
                                                                        if ( (LA9_302 == '%') )
                                                                        {
                                                                            int LA9_307 = input.LA(18);
                                                                            
                                                                            if ( (LA9_307 == '!' || (LA9_307 >= '$' && LA9_307 <= '&') || (LA9_307 >= '*' && LA9_307 <= '+') || (LA9_307 >= '-' && LA9_307 <= ':') || (LA9_307 >= '<' && LA9_307 <= 'Z') || (LA9_307 >= '^' && LA9_307 <= '_') || (LA9_307 >= 'a' && LA9_307 <= 'z') || LA9_307 == '~') )
                                                                            {
                                                                                alt9 = 43;
                                                                            }
                                                                            else 
                                                                            {
                                                                                alt9 = 8;}
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt9 = 43;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 43;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 43;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 43;}
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 43;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 43;}
                                                }
                                                else 
                                                {
                                                    alt9 = 43;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                                }
                                break;
                            case '-':
                            	{
                                int LA9_177 = input.LA(7);
                                
                                if ( (LA9_177 == 'm') )
                                {
                                    int LA9_207 = input.LA(8);
                                    
                                    if ( (LA9_207 == 'a') )
                                    {
                                        int LA9_228 = input.LA(9);
                                        
                                        if ( (LA9_228 == 'r') )
                                        {
                                            int LA9_245 = input.LA(10);
                                            
                                            if ( (LA9_245 == 'g') )
                                            {
                                                int LA9_259 = input.LA(11);
                                                
                                                if ( (LA9_259 == 'i') )
                                                {
                                                    int LA9_271 = input.LA(12);
                                                    
                                                    if ( (LA9_271 == 'n') )
                                                    {
                                                        int LA9_278 = input.LA(13);
                                                        
                                                        if ( (LA9_278 == '!' || (LA9_278 >= '$' && LA9_278 <= '&') || (LA9_278 >= '*' && LA9_278 <= '+') || (LA9_278 >= '-' && LA9_278 <= ':') || (LA9_278 >= '<' && LA9_278 <= 'Z') || (LA9_278 >= '^' && LA9_278 <= '_') || (LA9_278 >= 'a' && LA9_278 <= 'z') || LA9_278 == '~') )
                                                        {
                                                            alt9 = 43;
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 23;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 43;}
                                                }
                                                else 
                                                {
                                                    alt9 = 43;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                                }
                                break;
                            	default:
                                	alt9 = 43;
                                	break;}
                        
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            case 'e':
            	{
                int LA9_52 = input.LA(3);
                
                if ( (LA9_52 == 'i') )
                {
                    int LA9_83 = input.LA(4);
                    
                    if ( (LA9_83 == 'g') )
                    {
                        int LA9_114 = input.LA(5);
                        
                        if ( (LA9_114 == 'h') )
                        {
                            int LA9_146 = input.LA(6);
                            
                            if ( (LA9_146 == 't') )
                            {
                                int LA9_178 = input.LA(7);
                                
                                if ( (LA9_178 == '!' || (LA9_178 >= '$' && LA9_178 <= '&') || (LA9_178 >= '*' && LA9_178 <= '+') || (LA9_178 >= '-' && LA9_178 <= ':') || (LA9_178 >= '<' && LA9_178 <= 'Z') || (LA9_178 >= '^' && LA9_178 <= '_') || (LA9_178 >= 'a' && LA9_178 <= 'z') || LA9_178 == '~') )
                                {
                                    alt9 = 43;
                                }
                                else 
                                {
                                    alt9 = 13;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            	default:
                	alt9 = 43;
                	break;}
        
            }
            break;
        case 'v':
        	{
            int LA9_9 = input.LA(2);
            
            if ( (LA9_9 == 'e') )
            {
                int LA9_53 = input.LA(3);
                
                if ( (LA9_53 == 'r') )
                {
                    int LA9_84 = input.LA(4);
                    
                    if ( (LA9_84 == 't') )
                    {
                        switch ( input.LA(5) ) 
                        {
                        case '-':
                        	{
                            int LA9_147 = input.LA(6);
                            
                            if ( (LA9_147 == 'm') )
                            {
                                int LA9_179 = input.LA(7);
                                
                                if ( (LA9_179 == 'a') )
                                {
                                    int LA9_209 = input.LA(8);
                                    
                                    if ( (LA9_209 == 'r') )
                                    {
                                        int LA9_229 = input.LA(9);
                                        
                                        if ( (LA9_229 == 'g') )
                                        {
                                            int LA9_246 = input.LA(10);
                                            
                                            if ( (LA9_246 == 'i') )
                                            {
                                                int LA9_260 = input.LA(11);
                                                
                                                if ( (LA9_260 == 'n') )
                                                {
                                                    int LA9_272 = input.LA(12);
                                                    
                                                    if ( (LA9_272 == '!' || (LA9_272 >= '$' && LA9_272 <= '&') || (LA9_272 >= '*' && LA9_272 <= '+') || (LA9_272 >= '-' && LA9_272 <= ':') || (LA9_272 >= '<' && LA9_272 <= 'Z') || (LA9_272 >= '^' && LA9_272 <= '_') || (LA9_272 >= 'a' && LA9_272 <= 'z') || LA9_272 == '~') )
                                                    {
                                                        alt9 = 43;
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 22;}
                                                }
                                                else 
                                                {
                                                    alt9 = 43;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                            }
                            break;
                        case 'i':
                        	{
                            int LA9_148 = input.LA(6);
                            
                            if ( (LA9_148 == 'c') )
                            {
                                int LA9_180 = input.LA(7);
                                
                                if ( (LA9_180 == 'a') )
                                {
                                    int LA9_210 = input.LA(8);
                                    
                                    if ( (LA9_210 == 'l') )
                                    {
                                        int LA9_230 = input.LA(9);
                                        
                                        if ( (LA9_230 == '-') )
                                        {
                                            int LA9_247 = input.LA(10);
                                            
                                            if ( (LA9_247 == 'p') )
                                            {
                                                int LA9_261 = input.LA(11);
                                                
                                                if ( (LA9_261 == 'a') )
                                                {
                                                    int LA9_273 = input.LA(12);
                                                    
                                                    if ( (LA9_273 == 'n') )
                                                    {
                                                        int LA9_280 = input.LA(13);
                                                        
                                                        if ( (LA9_280 == 'e') )
                                                        {
                                                            int LA9_286 = input.LA(14);
                                                            
                                                            if ( (LA9_286 == 'l') )
                                                            {
                                                                int LA9_292 = input.LA(15);
                                                                
                                                                if ( (LA9_292 == '%') )
                                                                {
                                                                    int LA9_298 = input.LA(16);
                                                                    
                                                                    if ( (LA9_298 == '!' || (LA9_298 >= '$' && LA9_298 <= '&') || (LA9_298 >= '*' && LA9_298 <= '+') || (LA9_298 >= '-' && LA9_298 <= ':') || (LA9_298 >= '<' && LA9_298 <= 'Z') || (LA9_298 >= '^' && LA9_298 <= '_') || (LA9_298 >= 'a' && LA9_298 <= 'z') || LA9_298 == '~') )
                                                                    {
                                                                        alt9 = 43;
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 9;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 43;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 43;}
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 43;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 43;}
                                                }
                                                else 
                                                {
                                                    alt9 = 43;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                            }
                            break;
                        	default:
                            	alt9 = 43;
                            	break;}
                    
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
            }
            else 
            {
                alt9 = 43;}
            }
            break;
        case 'p':
        	{
            int LA9_10 = input.LA(2);
            
            if ( (LA9_10 == 'a') )
            {
                int LA9_54 = input.LA(3);
                
                if ( (LA9_54 == 'r') )
                {
                    int LA9_85 = input.LA(4);
                    
                    if ( (LA9_85 == 'e') )
                    {
                        int LA9_116 = input.LA(5);
                        
                        if ( (LA9_116 == 'n') )
                        {
                            int LA9_149 = input.LA(6);
                            
                            if ( (LA9_149 == 't') )
                            {
                                int LA9_181 = input.LA(7);
                                
                                if ( (LA9_181 == '!' || (LA9_181 >= '$' && LA9_181 <= '&') || (LA9_181 >= '*' && LA9_181 <= '+') || (LA9_181 >= '-' && LA9_181 <= ':') || (LA9_181 >= '<' && LA9_181 <= 'Z') || (LA9_181 >= '^' && LA9_181 <= '_') || (LA9_181 >= 'a' && LA9_181 <= 'z') || LA9_181 == '~') )
                                {
                                    alt9 = 43;
                                }
                                else 
                                {
                                    alt9 = 10;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
            }
            else 
            {
                alt9 = 43;}
            }
            break;
        case 'l':
        	{
            switch ( input.LA(2) ) 
            {
            case 'e':
            	{
                int LA9_55 = input.LA(3);
                
                if ( (LA9_55 == 'f') )
                {
                    int LA9_86 = input.LA(4);
                    
                    if ( (LA9_86 == 't') )
                    {
                        int LA9_117 = input.LA(5);
                        
                        if ( (LA9_117 == '!' || (LA9_117 >= '$' && LA9_117 <= '&') || (LA9_117 >= '*' && LA9_117 <= '+') || (LA9_117 >= '-' && LA9_117 <= ':') || (LA9_117 >= '<' && LA9_117 <= 'Z') || (LA9_117 >= '^' && LA9_117 <= '_') || (LA9_117 >= 'a' && LA9_117 <= 'z') || LA9_117 == '~') )
                        {
                            alt9 = 43;
                        }
                        else 
                        {
                            alt9 = 31;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            case 'a':
            	{
                int LA9_56 = input.LA(3);
                
                if ( (LA9_56 == 'b') )
                {
                    int LA9_87 = input.LA(4);
                    
                    if ( (LA9_87 == 'e') )
                    {
                        int LA9_118 = input.LA(5);
                        
                        if ( (LA9_118 == 'l') )
                        {
                            int LA9_151 = input.LA(6);
                            
                            if ( (LA9_151 == '!' || (LA9_151 >= '$' && LA9_151 <= '&') || (LA9_151 >= '*' && LA9_151 <= '+') || (LA9_151 >= '-' && LA9_151 <= ':') || (LA9_151 >= '<' && LA9_151 <= 'Z') || (LA9_151 >= '^' && LA9_151 <= '_') || (LA9_151 >= 'a' && LA9_151 <= 'z') || LA9_151 == '~') )
                            {
                                alt9 = 43;
                            }
                            else 
                            {
                                alt9 = 11;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            	default:
                	alt9 = 43;
                	break;}
        
            }
            break;
        case 'w':
        	{
            int LA9_12 = input.LA(2);
            
            if ( (LA9_12 == 'i') )
            {
                int LA9_57 = input.LA(3);
                
                if ( (LA9_57 == 'd') )
                {
                    int LA9_88 = input.LA(4);
                    
                    if ( (LA9_88 == 't') )
                    {
                        int LA9_119 = input.LA(5);
                        
                        if ( (LA9_119 == 'h') )
                        {
                            int LA9_152 = input.LA(6);
                            
                            if ( (LA9_152 == '!' || (LA9_152 >= '$' && LA9_152 <= '&') || (LA9_152 >= '*' && LA9_152 <= '+') || (LA9_152 >= '-' && LA9_152 <= ':') || (LA9_152 >= '<' && LA9_152 <= 'Z') || (LA9_152 >= '^' && LA9_152 <= '_') || (LA9_152 >= 'a' && LA9_152 <= 'z') || LA9_152 == '~') )
                            {
                                alt9 = 43;
                            }
                            else 
                            {
                                alt9 = 12;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
            }
            else 
            {
                alt9 = 43;}
            }
            break;
        case 'e':
        	{
            int LA9_13 = input.LA(2);
            
            if ( (LA9_13 == 'n') )
            {
                int LA9_58 = input.LA(3);
                
                if ( (LA9_58 == 'a') )
                {
                    int LA9_89 = input.LA(4);
                    
                    if ( (LA9_89 == 'b') )
                    {
                        int LA9_120 = input.LA(5);
                        
                        if ( (LA9_120 == 'l') )
                        {
                            int LA9_153 = input.LA(6);
                            
                            if ( (LA9_153 == 'e') )
                            {
                                int LA9_184 = input.LA(7);
                                
                                if ( (LA9_184 == 'd') )
                                {
                                    int LA9_212 = input.LA(8);
                                    
                                    if ( (LA9_212 == '!' || (LA9_212 >= '$' && LA9_212 <= '&') || (LA9_212 >= '*' && LA9_212 <= '+') || (LA9_212 >= '-' && LA9_212 <= ':') || (LA9_212 >= '<' && LA9_212 <= 'Z') || (LA9_212 >= '^' && LA9_212 <= '_') || (LA9_212 >= 'a' && LA9_212 <= 'z') || LA9_212 == '~') )
                                    {
                                        alt9 = 43;
                                    }
                                    else 
                                    {
                                        alt9 = 14;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
            }
            else 
            {
                alt9 = 43;}
            }
            break;
        case 's':
        	{
            switch ( input.LA(2) ) 
            {
            case 't':
            	{
                switch ( input.LA(3) ) 
                {
                case 'r':
                	{
                    int LA9_90 = input.LA(4);
                    
                    if ( (LA9_90 == 'e') )
                    {
                        int LA9_121 = input.LA(5);
                        
                        if ( (LA9_121 == 't') )
                        {
                            int LA9_154 = input.LA(6);
                            
                            if ( (LA9_154 == 'c') )
                            {
                                int LA9_185 = input.LA(7);
                                
                                if ( (LA9_185 == 'h') )
                                {
                                    int LA9_213 = input.LA(8);
                                    
                                    if ( (LA9_213 == 'a') )
                                    {
                                        int LA9_232 = input.LA(9);
                                        
                                        if ( (LA9_232 == 'b') )
                                        {
                                            int LA9_248 = input.LA(10);
                                            
                                            if ( (LA9_248 == 'l') )
                                            {
                                                int LA9_262 = input.LA(11);
                                                
                                                if ( (LA9_262 == 'e') )
                                                {
                                                    int LA9_274 = input.LA(12);
                                                    
                                                    if ( (LA9_274 == '-') )
                                                    {
                                                        switch ( input.LA(13) ) 
                                                        {
                                                        case 'w':
                                                        	{
                                                            int LA9_287 = input.LA(14);
                                                            
                                                            if ( (LA9_287 == 'i') )
                                                            {
                                                                int LA9_293 = input.LA(15);
                                                                
                                                                if ( (LA9_293 == 'd') )
                                                                {
                                                                    int LA9_299 = input.LA(16);
                                                                    
                                                                    if ( (LA9_299 == 't') )
                                                                    {
                                                                        int LA9_304 = input.LA(17);
                                                                        
                                                                        if ( (LA9_304 == 'h') )
                                                                        {
                                                                            int LA9_308 = input.LA(18);
                                                                            
                                                                            if ( (LA9_308 == '!' || (LA9_308 >= '$' && LA9_308 <= '&') || (LA9_308 >= '*' && LA9_308 <= '+') || (LA9_308 >= '-' && LA9_308 <= ':') || (LA9_308 >= '<' && LA9_308 <= 'Z') || (LA9_308 >= '^' && LA9_308 <= '_') || (LA9_308 >= 'a' && LA9_308 <= 'z') || LA9_308 == '~') )
                                                                            {
                                                                                alt9 = 43;
                                                                            }
                                                                            else 
                                                                            {
                                                                                alt9 = 20;}
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt9 = 43;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 43;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 43;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 43;}
                                                            }
                                                            break;
                                                        case 'h':
                                                        	{
                                                            int LA9_288 = input.LA(14);
                                                            
                                                            if ( (LA9_288 == 'e') )
                                                            {
                                                                int LA9_294 = input.LA(15);
                                                                
                                                                if ( (LA9_294 == 'i') )
                                                                {
                                                                    int LA9_300 = input.LA(16);
                                                                    
                                                                    if ( (LA9_300 == 'g') )
                                                                    {
                                                                        int LA9_305 = input.LA(17);
                                                                        
                                                                        if ( (LA9_305 == 'h') )
                                                                        {
                                                                            int LA9_309 = input.LA(18);
                                                                            
                                                                            if ( (LA9_309 == 't') )
                                                                            {
                                                                                int LA9_312 = input.LA(19);
                                                                                
                                                                                if ( (LA9_312 == '!' || (LA9_312 >= '$' && LA9_312 <= '&') || (LA9_312 >= '*' && LA9_312 <= '+') || (LA9_312 >= '-' && LA9_312 <= ':') || (LA9_312 >= '<' && LA9_312 <= 'Z') || (LA9_312 >= '^' && LA9_312 <= '_') || (LA9_312 >= 'a' && LA9_312 <= 'z') || LA9_312 == '~') )
                                                                                {
                                                                                    alt9 = 43;
                                                                                }
                                                                                else 
                                                                                {
                                                                                    alt9 = 21;}
                                                                            }
                                                                            else 
                                                                            {
                                                                                alt9 = 43;}
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt9 = 43;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 43;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 43;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 43;}
                                                            }
                                                            break;
                                                        	default:
                                                            	alt9 = 43;
                                                            	break;}
                                                    
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 43;}
                                                }
                                                else 
                                                {
                                                    alt9 = 43;}
                                            }
                                            else 
                                            {
                                                alt9 = 43;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                    }
                    break;
                case 'y':
                	{
                    int LA9_91 = input.LA(4);
                    
                    if ( (LA9_91 == 'l') )
                    {
                        int LA9_122 = input.LA(5);
                        
                        if ( (LA9_122 == 'e') )
                        {
                            int LA9_155 = input.LA(6);
                            
                            if ( (LA9_155 == '!' || (LA9_155 >= '$' && LA9_155 <= '&') || (LA9_155 >= '*' && LA9_155 <= '+') || (LA9_155 >= '-' && LA9_155 <= ':') || (LA9_155 >= '<' && LA9_155 <= 'Z') || (LA9_155 >= '^' && LA9_155 <= '_') || (LA9_155 >= 'a' && LA9_155 <= 'z') || LA9_155 == '~') )
                            {
                                alt9 = 43;
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                    }
                    break;
                	default:
                    	alt9 = 43;
                    	break;}
            
                }
                break;
            case 'p':
            	{
                int LA9_60 = input.LA(3);
                
                if ( (LA9_60 == 'a') )
                {
                    int LA9_92 = input.LA(4);
                    
                    if ( (LA9_92 == 'c') )
                    {
                        int LA9_123 = input.LA(5);
                        
                        if ( (LA9_123 == 'i') )
                        {
                            int LA9_156 = input.LA(6);
                            
                            if ( (LA9_156 == 'n') )
                            {
                                int LA9_187 = input.LA(7);
                                
                                if ( (LA9_187 == 'g') )
                                {
                                    int LA9_214 = input.LA(8);
                                    
                                    if ( (LA9_214 == '!' || (LA9_214 >= '$' && LA9_214 <= '&') || (LA9_214 >= '*' && LA9_214 <= '+') || (LA9_214 >= '-' && LA9_214 <= ':') || (LA9_214 >= '<' && LA9_214 <= 'Z') || (LA9_214 >= '^' && LA9_214 <= '_') || (LA9_214 >= 'a' && LA9_214 <= 'z') || LA9_214 == '~') )
                                    {
                                        alt9 = 43;
                                    }
                                    else 
                                    {
                                        alt9 = 16;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
                }
                break;
            	default:
                	alt9 = 43;
                	break;}
        
            }
            break;
        case 'a':
        	{
            int LA9_15 = input.LA(2);
            
            if ( (LA9_15 == 'l') )
            {
                int LA9_61 = input.LA(3);
                
                if ( (LA9_61 == 'i') )
                {
                    int LA9_93 = input.LA(4);
                    
                    if ( (LA9_93 == 'g') )
                    {
                        int LA9_124 = input.LA(5);
                        
                        if ( (LA9_124 == 'n') )
                        {
                            int LA9_157 = input.LA(6);
                            
                            if ( (LA9_157 == 'm') )
                            {
                                int LA9_188 = input.LA(7);
                                
                                if ( (LA9_188 == 'e') )
                                {
                                    int LA9_215 = input.LA(8);
                                    
                                    if ( (LA9_215 == 'n') )
                                    {
                                        int LA9_234 = input.LA(9);
                                        
                                        if ( (LA9_234 == 't') )
                                        {
                                            int LA9_249 = input.LA(10);
                                            
                                            if ( (LA9_249 == '!' || (LA9_249 >= '$' && LA9_249 <= '&') || (LA9_249 >= '*' && LA9_249 <= '+') || (LA9_249 >= '-' && LA9_249 <= ':') || (LA9_249 >= '<' && LA9_249 <= 'Z') || (LA9_249 >= '^' && LA9_249 <= '_') || (LA9_249 >= 'a' && LA9_249 <= 'z') || LA9_249 == '~') )
                                            {
                                                alt9 = 43;
                                            }
                                            else 
                                            {
                                                alt9 = 17;}
                                        }
                                        else 
                                        {
                                            alt9 = 43;}
                                    }
                                    else 
                                    {
                                        alt9 = 43;}
                                }
                                else 
                                {
                                    alt9 = 43;}
                            }
                            else 
                            {
                                alt9 = 43;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
            }
            else 
            {
                alt9 = 43;}
            }
            break;
        case '(':
        	{
            alt9 = 24;
            }
            break;
        case ')':
        	{
            alt9 = 25;
            }
            break;
        case '#':
        	{
            int LA9_18 = input.LA(2);
            
            if ( (LA9_18 == 'f') )
            {
                alt9 = 26;
            }
            else if ( (LA9_18 == 't') )
            {
                alt9 = 27;
            }
            else 
            {
                NoViableAltException nvae_d9s18 =
                    new NoViableAltException("1:1: Tokens : ( SEMI | DEFINE | NEW | FRAME | BUTTON | MESSAGE | CHECKBOX | HPANEL | VPANEL | PARENT | LABEL | WIDTH | HEIGHT | ENABLED | BORDER | SPACING | ALIGNMENT | MIN_WIDTH | MIN_HEIGHT | STRETCH_WIDTH | STRETCH_HEIGHT | VERT_MARGIN | HORIZ_MARGIN | LP | RP | FALSE | TRUE | TOP | CENTER | BOTTOM | LEFT | RIGHT | NULL | NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT | STYLE | DELETED | WS | ID | NUMBER | NAME | NEWLINE | COMMENT | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | QUOTE );", 9, 18, input);
            
                throw nvae_d9s18;
            }
            }
            break;
        case 't':
        	{
            int LA9_19 = input.LA(2);
            
            if ( (LA9_19 == 'o') )
            {
                int LA9_64 = input.LA(3);
                
                if ( (LA9_64 == 'p') )
                {
                    int LA9_94 = input.LA(4);
                    
                    if ( (LA9_94 == '!' || (LA9_94 >= '$' && LA9_94 <= '&') || (LA9_94 >= '*' && LA9_94 <= '+') || (LA9_94 >= '-' && LA9_94 <= ':') || (LA9_94 >= '<' && LA9_94 <= 'Z') || (LA9_94 >= '^' && LA9_94 <= '_') || (LA9_94 >= 'a' && LA9_94 <= 'z') || LA9_94 == '~') )
                    {
                        alt9 = 43;
                    }
                    else 
                    {
                        alt9 = 28;}
                }
                else 
                {
                    alt9 = 43;}
            }
            else 
            {
                alt9 = 43;}
            }
            break;
        case 'r':
        	{
            int LA9_20 = input.LA(2);
            
            if ( (LA9_20 == 'i') )
            {
                int LA9_65 = input.LA(3);
                
                if ( (LA9_65 == 'g') )
                {
                    int LA9_95 = input.LA(4);
                    
                    if ( (LA9_95 == 'h') )
                    {
                        int LA9_126 = input.LA(5);
                        
                        if ( (LA9_126 == 't') )
                        {
                            int LA9_158 = input.LA(6);
                            
                            if ( (LA9_158 == '!' || (LA9_158 >= '$' && LA9_158 <= '&') || (LA9_158 >= '*' && LA9_158 <= '+') || (LA9_158 >= '-' && LA9_158 <= ':') || (LA9_158 >= '<' && LA9_158 <= 'Z') || (LA9_158 >= '^' && LA9_158 <= '_') || (LA9_158 >= 'a' && LA9_158 <= 'z') || LA9_158 == '~') )
                            {
                                alt9 = 43;
                            }
                            else 
                            {
                                alt9 = 32;}
                        }
                        else 
                        {
                            alt9 = 43;}
                    }
                    else 
                    {
                        alt9 = 43;}
                }
                else 
                {
                    alt9 = 43;}
            }
            else 
            {
                alt9 = 43;}
            }
            break;
        case '\r':
        	{
            int LA9_21 = input.LA(2);
            
            if ( (LA9_21 == '\n') )
            {
                alt9 = 46;
            }
            else 
            {
                alt9 = 42;}
            }
            break;
        case '!':
        case '$':
        case '%':
        case '&':
        case ':':
        case '?':
        case '@':
        case 'A':
        case 'B':
        case 'C':
        case 'D':
        case 'E':
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'L':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        case '^':
        case '_':
        case 'g':
        case 'i':
        case 'j':
        case 'k':
        case 'o':
        case 'q':
        case 'u':
        case 'x':
        case 'y':
        case 'z':
        case '~':
        	{
            alt9 = 43;
            }
            break;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
        	{
            alt9 = 44;
            }
            break;
        case '\"':
        	{
            alt9 = 45;
            }
            break;
        case '\n':
        	{
            alt9 = 42;
            }
            break;
        case '\t':
        case ' ':
        	{
            alt9 = 42;
            }
            break;
        case '+':
        	{
            alt9 = 48;
            }
            break;
        case '-':
        	{
            alt9 = 49;
            }
            break;
        case '*':
        	{
            alt9 = 50;
            }
            break;
        case '/':
        	{
            alt9 = 51;
            }
            break;
        case '.':
        	{
            alt9 = 52;
            }
            break;
        case '<':
        	{
            alt9 = 53;
            }
            break;
        case '>':
        	{
            alt9 = 54;
            }
            break;
        case '=':
        	{
            alt9 = 55;
            }
            break;
        case '\'':
        	{
            alt9 = 56;
            }
            break;
        	default:
        	    NoViableAltException nvae_d9s0 =
        	        new NoViableAltException("1:1: Tokens : ( SEMI | DEFINE | NEW | FRAME | BUTTON | MESSAGE | CHECKBOX | HPANEL | VPANEL | PARENT | LABEL | WIDTH | HEIGHT | ENABLED | BORDER | SPACING | ALIGNMENT | MIN_WIDTH | MIN_HEIGHT | STRETCH_WIDTH | STRETCH_HEIGHT | VERT_MARGIN | HORIZ_MARGIN | LP | RP | FALSE | TRUE | TOP | CENTER | BOTTOM | LEFT | RIGHT | NULL | NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT | STYLE | DELETED | WS | ID | NUMBER | NAME | NEWLINE | COMMENT | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | QUOTE );", 9, 0, input);
        
        	    throw nvae_d9s0;
        }
        
        switch (alt9) 
        {
            case 1 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:10: SEMI
                {
                	mSEMI(); 
                
                }
                break;
            case 2 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:15: DEFINE
                {
                	mDEFINE(); 
                
                }
                break;
            case 3 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:22: NEW
                {
                	mNEW(); 
                
                }
                break;
            case 4 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:26: FRAME
                {
                	mFRAME(); 
                
                }
                break;
            case 5 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:32: BUTTON
                {
                	mBUTTON(); 
                
                }
                break;
            case 6 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:39: MESSAGE
                {
                	mMESSAGE(); 
                
                }
                break;
            case 7 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:47: CHECKBOX
                {
                	mCHECKBOX(); 
                
                }
                break;
            case 8 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:56: HPANEL
                {
                	mHPANEL(); 
                
                }
                break;
            case 9 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:63: VPANEL
                {
                	mVPANEL(); 
                
                }
                break;
            case 10 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:70: PARENT
                {
                	mPARENT(); 
                
                }
                break;
            case 11 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:77: LABEL
                {
                	mLABEL(); 
                
                }
                break;
            case 12 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:83: WIDTH
                {
                	mWIDTH(); 
                
                }
                break;
            case 13 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:89: HEIGHT
                {
                	mHEIGHT(); 
                
                }
                break;
            case 14 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:96: ENABLED
                {
                	mENABLED(); 
                
                }
                break;
            case 15 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:104: BORDER
                {
                	mBORDER(); 
                
                }
                break;
            case 16 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:111: SPACING
                {
                	mSPACING(); 
                
                }
                break;
            case 17 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:119: ALIGNMENT
                {
                	mALIGNMENT(); 
                
                }
                break;
            case 18 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:129: MIN_WIDTH
                {
                	mMIN_WIDTH(); 
                
                }
                break;
            case 19 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:139: MIN_HEIGHT
                {
                	mMIN_HEIGHT(); 
                
                }
                break;
            case 20 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:150: STRETCH_WIDTH
                {
                	mSTRETCH_WIDTH(); 
                
                }
                break;
            case 21 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:164: STRETCH_HEIGHT
                {
                	mSTRETCH_HEIGHT(); 
                
                }
                break;
            case 22 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:179: VERT_MARGIN
                {
                	mVERT_MARGIN(); 
                
                }
                break;
            case 23 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:191: HORIZ_MARGIN
                {
                	mHORIZ_MARGIN(); 
                
                }
                break;
            case 24 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:204: LP
                {
                	mLP(); 
                
                }
                break;
            case 25 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:207: RP
                {
                	mRP(); 
                
                }
                break;
            case 26 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:210: FALSE
                {
                	mFALSE(); 
                
                }
                break;
            case 27 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:216: TRUE
                {
                	mTRUE(); 
                
                }
                break;
            case 28 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:221: TOP
                {
                	mTOP(); 
                
                }
                break;
            case 29 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:225: CENTER
                {
                	mCENTER(); 
                
                }
                break;
            case 30 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:232: BOTTOM
                {
                	mBOTTOM(); 
                
                }
                break;
            case 31 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:239: LEFT
                {
                	mLEFT(); 
                
                }
                break;
            case 32 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:244: RIGHT
                {
                	mRIGHT(); 
                
                }
                break;
            case 33 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:250: NULL
                {
                	mNULL(); 
                
                }
                break;
            case 34 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:255: NO_RESIZE_BORDER
                {
                	mNO_RESIZE_BORDER(); 
                
                }
                break;
            case 35 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:272: NO_CAPTION
                {
                	mNO_CAPTION(); 
                
                }
                break;
            case 36 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:283: NO_SYSTEM_MENU
                {
                	mNO_SYSTEM_MENU(); 
                
                }
                break;
            case 37 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:298: MDI_PARENT
                {
                	mMDI_PARENT(); 
                
                }
                break;
            case 38 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:309: MDI_CHILD
                {
                	mMDI_CHILD(); 
                
                }
                break;
            case 39 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:319: FLOAT
                {
                	mFLOAT(); 
                
                }
                break;
            case 40 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:325: STYLE
                {
                	mSTYLE(); 
                
                }
                break;
            case 41 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:331: DELETED
                {
                	mDELETED(); 
                
                }
                break;
            case 42 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:339: WS
                {
                	mWS(); 
                
                }
                break;
            case 43 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:342: ID
                {
                	mID(); 
                
                }
                break;
            case 44 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:345: NUMBER
                {
                	mNUMBER(); 
                
                }
                break;
            case 45 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:352: NAME
                {
                	mNAME(); 
                
                }
                break;
            case 46 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:357: NEWLINE
                {
                	mNEWLINE(); 
                
                }
                break;
            case 47 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:365: COMMENT
                {
                	mCOMMENT(); 
                
                }
                break;
            case 48 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:373: PLUS
                {
                	mPLUS(); 
                
                }
                break;
            case 49 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:378: MINUS
                {
                	mMINUS(); 
                
                }
                break;
            case 50 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:384: STAR
                {
                	mSTAR(); 
                
                }
                break;
            case 51 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:389: SLASH
                {
                	mSLASH(); 
                
                }
                break;
            case 52 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:395: DOT
                {
                	mDOT(); 
                
                }
                break;
            case 53 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:399: LT
                {
                	mLT(); 
                
                }
                break;
            case 54 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:402: GT
                {
                	mGT(); 
                
                }
                break;
            case 55 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:405: EQ
                {
                	mEQ(); 
                
                }
                break;
            case 56 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:408: QUOTE
                {
                	mQUOTE(); 
                
                }
                break;
        
        }
    
    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
}