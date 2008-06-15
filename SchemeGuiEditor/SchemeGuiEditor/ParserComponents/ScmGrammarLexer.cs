// $ANTLR 3.0.1 D:\\Projects\\AntlrTestApps\\ScmGrammar.g 2008-06-15 16:55:10
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
    public const int MDI_CHILD = 38;
    public const int LT = 50;
    public const int STAR = 48;
    public const int HORIZ_MARGIN = 23;
    public const int STRETCH_WIDTH = 20;
    public const int SPACING = 16;
    public const int RP = 25;
    public const int LEAD_DIGIT = 58;
    public const int STRETCH_HEIGHT = 21;
    public const int LP = 24;
    public const int NEW = 6;
    public const int BUTTON = 8;
    public const int FLOAT = 39;
    public const int ID = 42;
    public const int DEFINE = 5;
    public const int CAR = 55;
    public const int EOF = -1;
    public const int CENTER = 29;
    public const int ZERO = 59;
    public const int BORDER = 15;
    public const int MDI_PARENT = 37;
    public const int QUOTE = 45;
    public const int MIN_HEIGHT = 19;
    public const int PARENT = 10;
    public const int NAME = 43;
    public const int SLASH = 49;
    public const int ALIGNMENT = 17;
    public const int LEFT = 31;
    public const int ENABLED = 14;
    public const int MESSAGE = 9;
    public const int PLUS = 46;
    public const int DIGIT = 57;
    public const int EQ = 52;
    public const int DOT = 56;
    public const int COMMENT = 53;
    public const int NO_SYSTEM_MENU = 36;
    public const int NO_CAPTION = 35;
    public const int HEIGHT = 13;
    public const int NULL = 33;
    public const int NUMBER = 44;
    public const int RIGHT = 32;
    public const int MINUS = 47;
    public const int Tokens = 61;
    public const int VERT_MARGIN = 22;
    public const int TRUE = 27;
    public const int SEMI = 4;
    public const int DELETED = 41;
    public const int NO_RESIZE_BORDER = 34;
    public const int WS = 54;
    public const int NEWLINE = 60;
    public const int LABEL = 11;
    public const int WIDTH = 12;
    public const int STYLE = 40;
    public const int BOTTOM = 30;
    public const int MIN_WIDTH = 18;
    public const int GT = 51;
    public const int FRAME = 7;
    public const int TOP = 28;
    public const int FALSE = 26;

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

    // $ANTLR start PARENT 
    public void mPARENT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = PARENT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:16:8: ( 'parent' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:16:10: 'parent'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:17:7: ( 'label' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:17:9: 'label'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:18:7: ( 'width' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:18:9: 'width'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:19:8: ( 'height' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:19:10: 'height'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:20:9: ( 'enabled' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:20:11: 'enabled'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:21:8: ( 'border' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:21:10: 'border'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:22:9: ( 'spacing' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:22:11: 'spacing'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:23:11: ( 'alignment' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:23:13: 'alignment'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:24:11: ( 'min-width' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:24:13: 'min-width'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:25:12: ( 'min-height' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:25:14: 'min-height'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:26:15: ( 'stretchable-width' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:26:17: 'stretchable-width'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:27:16: ( 'stretchable-height' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:27:18: 'stretchable-height'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:28:13: ( 'vert-margin' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:28:15: 'vert-margin'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:29:14: ( 'horiz-margin' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:29:16: 'horiz-margin'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:30:4: ( '(' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:30:6: '('
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:31:4: ( ')' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:31:6: ')'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:32:7: ( '#f' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:32:9: '#f'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:33:6: ( '#t' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:33:8: '#t'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:34:5: ( 'top' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:34:7: 'top'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:35:8: ( 'center' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:35:10: 'center'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:36:8: ( 'bottom' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:36:10: 'bottom'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:37:6: ( 'left' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:37:8: 'left'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:38:7: ( 'right' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:38:9: 'right'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:39:6: ( 'null' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:39:8: 'null'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:40:18: ( 'no-resize-border' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:40:20: 'no-resize-border'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:41:12: ( 'no-caption' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:41:14: 'no-caption'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:42:16: ( 'no-system-menu' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:42:18: 'no-system-menu'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:43:12: ( 'mdi-parent' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:43:14: 'mdi-parent'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:44:11: ( 'mdi-child' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:44:13: 'mdi-child'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:45:7: ( 'float' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:45:9: 'float'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:46:7: ( 'style' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:46:9: 'style'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:47:9: ( 'deleted' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:47:11: 'deleted'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:266:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:266:7: ( ' ' | '\\t' | '\\r' | '\\n' )
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:268:4: ( ( 'a' .. 'z' | 'A' .. 'Z' | CAR ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | CAR )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:268:6: ( 'a' .. 'z' | 'A' .. 'Z' | CAR ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | CAR )*
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

            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:268:34: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | CAR )*
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:271:2: ( '?' | '!' | ':' | '$' | '%' | '^' | '&' | '_' | '~' | '@' )
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:274:2: ( '0' .. '9' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:274:4: '0' .. '9'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:277:2: ( '1' .. '9' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:277:4: '1' .. '9'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:280:2: ( '0' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:280:4: '0'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:2: ( ZERO | LEAD_DIGIT ( DIGIT )* ( DOT ( DIGIT )+ )? )
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
                    new NoViableAltException("282:1: NUMBER : ( ZERO | LEAD_DIGIT ( DIGIT )* ( DOT ( DIGIT )+ )? );", 5, 0, input);
            
                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:4: ZERO
                    {
                    	mZERO(); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:11: LEAD_DIGIT ( DIGIT )* ( DOT ( DIGIT )+ )?
                    {
                    	mLEAD_DIGIT(); 
                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:22: ( DIGIT )*
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
                    			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:22: DIGIT
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

                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:29: ( DOT ( DIGIT )+ )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);
                    	
                    	if ( (LA4_0 == '.') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:30: DOT ( DIGIT )+
                    	        {
                    	        	mDOT(); 
                    	        	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:34: ( DIGIT )+
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
                    	        			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:34: DIGIT
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:285:5: ( '\"' ( . )* '\"' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:285:7: '\"' ( . )* '\"'
            {
            	Match('\"'); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:285:11: ( . )*
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:285:11: .
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:288:2: ( ( ( '\\r' )? '\\n' ) )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:288:4: ( ( '\\r' )? '\\n' )
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:288:4: ( ( '\\r' )? '\\n' )
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:288:5: ( '\\r' )? '\\n'
            	{
            		// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:288:5: ( '\\r' )?
            		int alt7 = 2;
            		int LA7_0 = input.LA(1);
            		
            		if ( (LA7_0 == '\r') )
            		{
            		    alt7 = 1;
            		}
            		switch (alt7) 
            		{
            		    case 1 :
            		        // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:288:5: '\\r'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:292:2: ( SEMI (~ ( '\\r' | '\\n' ) )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:292:4: SEMI (~ ( '\\r' | '\\n' ) )*
            {
            	mSEMI(); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:292:9: (~ ( '\\r' | '\\n' ) )*
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:292:10: ~ ( '\\r' | '\\n' )
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:294:7: ( '+' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:294:9: '+'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:296:8: ( '-' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:296:10: '-'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:298:7: ( '*' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:298:9: '*'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:300:8: ( '/' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:300:10: '/'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:302:6: ( '.' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:302:8: '.'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:304:5: ( '<' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:304:7: '<'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:306:5: ( '>' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:306:7: '>'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:308:5: ( '=' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:308:7: '='
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:310:8: ( '\\'' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:310:10: '\\''
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
        // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:8: ( SEMI | DEFINE | NEW | FRAME | BUTTON | MESSAGE | PARENT | LABEL | WIDTH | HEIGHT | ENABLED | BORDER | SPACING | ALIGNMENT | MIN_WIDTH | MIN_HEIGHT | STRETCH_WIDTH | STRETCH_HEIGHT | VERT_MARGIN | HORIZ_MARGIN | LP | RP | FALSE | TRUE | TOP | CENTER | BOTTOM | LEFT | RIGHT | NULL | NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT | STYLE | DELETED | WS | ID | NUMBER | NAME | NEWLINE | COMMENT | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | QUOTE )
        int alt9 = 53;
        switch ( input.LA(1) ) 
        {
        case ';':
        	{
            int LA9_1 = input.LA(2);
            
            if ( ((LA9_1 >= '\u0000' && LA9_1 <= '\t') || (LA9_1 >= '\u000B' && LA9_1 <= '\f') || (LA9_1 >= '\u000E' && LA9_1 <= '\uFFFE')) )
            {
                alt9 = 44;
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
                case 'l':
                	{
                    int LA9_66 = input.LA(4);
                    
                    if ( (LA9_66 == 'e') )
                    {
                        int LA9_94 = input.LA(5);
                        
                        if ( (LA9_94 == 't') )
                        {
                            int LA9_124 = input.LA(6);
                            
                            if ( (LA9_124 == 'e') )
                            {
                                int LA9_154 = input.LA(7);
                                
                                if ( (LA9_154 == 'd') )
                                {
                                    int LA9_182 = input.LA(8);
                                    
                                    if ( (LA9_182 == '!' || (LA9_182 >= '$' && LA9_182 <= '&') || (LA9_182 >= '*' && LA9_182 <= '+') || (LA9_182 >= '-' && LA9_182 <= ':') || (LA9_182 >= '<' && LA9_182 <= 'Z') || (LA9_182 >= '^' && LA9_182 <= '_') || (LA9_182 >= 'a' && LA9_182 <= 'z') || LA9_182 == '~') )
                                    {
                                        alt9 = 40;
                                    }
                                    else 
                                    {
                                        alt9 = 38;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                    }
                    break;
                case 'f':
                	{
                    int LA9_67 = input.LA(4);
                    
                    if ( (LA9_67 == 'i') )
                    {
                        int LA9_95 = input.LA(5);
                        
                        if ( (LA9_95 == 'n') )
                        {
                            int LA9_125 = input.LA(6);
                            
                            if ( (LA9_125 == 'e') )
                            {
                                int LA9_155 = input.LA(7);
                                
                                if ( (LA9_155 == '!' || (LA9_155 >= '$' && LA9_155 <= '&') || (LA9_155 >= '*' && LA9_155 <= '+') || (LA9_155 >= '-' && LA9_155 <= ':') || (LA9_155 >= '<' && LA9_155 <= 'Z') || (LA9_155 >= '^' && LA9_155 <= '_') || (LA9_155 >= 'a' && LA9_155 <= 'z') || LA9_155 == '~') )
                                {
                                    alt9 = 40;
                                }
                                else 
                                {
                                    alt9 = 2;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                    }
                    break;
                	default:
                    	alt9 = 40;
                    	break;}
            
            }
            else 
            {
                alt9 = 40;}
            }
            break;
        case 'n':
        	{
            switch ( input.LA(2) ) 
            {
            case 'o':
            	{
                int LA9_39 = input.LA(3);
                
                if ( (LA9_39 == '-') )
                {
                    switch ( input.LA(4) ) 
                    {
                    case 'c':
                    	{
                        int LA9_96 = input.LA(5);
                        
                        if ( (LA9_96 == 'a') )
                        {
                            int LA9_126 = input.LA(6);
                            
                            if ( (LA9_126 == 'p') )
                            {
                                int LA9_156 = input.LA(7);
                                
                                if ( (LA9_156 == 't') )
                                {
                                    int LA9_184 = input.LA(8);
                                    
                                    if ( (LA9_184 == 'i') )
                                    {
                                        int LA9_206 = input.LA(9);
                                        
                                        if ( (LA9_206 == 'o') )
                                        {
                                            int LA9_221 = input.LA(10);
                                            
                                            if ( (LA9_221 == 'n') )
                                            {
                                                int LA9_233 = input.LA(11);
                                                
                                                if ( (LA9_233 == '!' || (LA9_233 >= '$' && LA9_233 <= '&') || (LA9_233 >= '*' && LA9_233 <= '+') || (LA9_233 >= '-' && LA9_233 <= ':') || (LA9_233 >= '<' && LA9_233 <= 'Z') || (LA9_233 >= '^' && LA9_233 <= '_') || (LA9_233 >= 'a' && LA9_233 <= 'z') || LA9_233 == '~') )
                                                {
                                                    alt9 = 40;
                                                }
                                                else 
                                                {
                                                    alt9 = 32;}
                                            }
                                            else 
                                            {
                                                alt9 = 40;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                        }
                        break;
                    case 's':
                    	{
                        int LA9_97 = input.LA(5);
                        
                        if ( (LA9_97 == 'y') )
                        {
                            int LA9_127 = input.LA(6);
                            
                            if ( (LA9_127 == 's') )
                            {
                                int LA9_157 = input.LA(7);
                                
                                if ( (LA9_157 == 't') )
                                {
                                    int LA9_185 = input.LA(8);
                                    
                                    if ( (LA9_185 == 'e') )
                                    {
                                        int LA9_207 = input.LA(9);
                                        
                                        if ( (LA9_207 == 'm') )
                                        {
                                            int LA9_222 = input.LA(10);
                                            
                                            if ( (LA9_222 == '-') )
                                            {
                                                int LA9_234 = input.LA(11);
                                                
                                                if ( (LA9_234 == 'm') )
                                                {
                                                    int LA9_245 = input.LA(12);
                                                    
                                                    if ( (LA9_245 == 'e') )
                                                    {
                                                        int LA9_252 = input.LA(13);
                                                        
                                                        if ( (LA9_252 == 'n') )
                                                        {
                                                            int LA9_257 = input.LA(14);
                                                            
                                                            if ( (LA9_257 == 'u') )
                                                            {
                                                                int LA9_262 = input.LA(15);
                                                                
                                                                if ( (LA9_262 == '!' || (LA9_262 >= '$' && LA9_262 <= '&') || (LA9_262 >= '*' && LA9_262 <= '+') || (LA9_262 >= '-' && LA9_262 <= ':') || (LA9_262 >= '<' && LA9_262 <= 'Z') || (LA9_262 >= '^' && LA9_262 <= '_') || (LA9_262 >= 'a' && LA9_262 <= 'z') || LA9_262 == '~') )
                                                                {
                                                                    alt9 = 40;
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 33;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 40;}
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 40;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 40;}
                                                }
                                                else 
                                                {
                                                    alt9 = 40;}
                                            }
                                            else 
                                            {
                                                alt9 = 40;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                        }
                        break;
                    case 'r':
                    	{
                        int LA9_98 = input.LA(5);
                        
                        if ( (LA9_98 == 'e') )
                        {
                            int LA9_128 = input.LA(6);
                            
                            if ( (LA9_128 == 's') )
                            {
                                int LA9_158 = input.LA(7);
                                
                                if ( (LA9_158 == 'i') )
                                {
                                    int LA9_186 = input.LA(8);
                                    
                                    if ( (LA9_186 == 'z') )
                                    {
                                        int LA9_208 = input.LA(9);
                                        
                                        if ( (LA9_208 == 'e') )
                                        {
                                            int LA9_223 = input.LA(10);
                                            
                                            if ( (LA9_223 == '-') )
                                            {
                                                int LA9_235 = input.LA(11);
                                                
                                                if ( (LA9_235 == 'b') )
                                                {
                                                    int LA9_246 = input.LA(12);
                                                    
                                                    if ( (LA9_246 == 'o') )
                                                    {
                                                        int LA9_253 = input.LA(13);
                                                        
                                                        if ( (LA9_253 == 'r') )
                                                        {
                                                            int LA9_258 = input.LA(14);
                                                            
                                                            if ( (LA9_258 == 'd') )
                                                            {
                                                                int LA9_263 = input.LA(15);
                                                                
                                                                if ( (LA9_263 == 'e') )
                                                                {
                                                                    int LA9_267 = input.LA(16);
                                                                    
                                                                    if ( (LA9_267 == 'r') )
                                                                    {
                                                                        int LA9_270 = input.LA(17);
                                                                        
                                                                        if ( (LA9_270 == '!' || (LA9_270 >= '$' && LA9_270 <= '&') || (LA9_270 >= '*' && LA9_270 <= '+') || (LA9_270 >= '-' && LA9_270 <= ':') || (LA9_270 >= '<' && LA9_270 <= 'Z') || (LA9_270 >= '^' && LA9_270 <= '_') || (LA9_270 >= 'a' && LA9_270 <= 'z') || LA9_270 == '~') )
                                                                        {
                                                                            alt9 = 40;
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt9 = 31;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 40;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 40;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 40;}
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 40;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 40;}
                                                }
                                                else 
                                                {
                                                    alt9 = 40;}
                                            }
                                            else 
                                            {
                                                alt9 = 40;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                        }
                        break;
                    	default:
                        	alt9 = 40;
                        	break;}
                
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            case 'e':
            	{
                int LA9_40 = input.LA(3);
                
                if ( (LA9_40 == 'w') )
                {
                    int LA9_69 = input.LA(4);
                    
                    if ( (LA9_69 == '!' || (LA9_69 >= '$' && LA9_69 <= '&') || (LA9_69 >= '*' && LA9_69 <= '+') || (LA9_69 >= '-' && LA9_69 <= ':') || (LA9_69 >= '<' && LA9_69 <= 'Z') || (LA9_69 >= '^' && LA9_69 <= '_') || (LA9_69 >= 'a' && LA9_69 <= 'z') || LA9_69 == '~') )
                    {
                        alt9 = 40;
                    }
                    else 
                    {
                        alt9 = 3;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            case 'u':
            	{
                int LA9_41 = input.LA(3);
                
                if ( (LA9_41 == 'l') )
                {
                    int LA9_70 = input.LA(4);
                    
                    if ( (LA9_70 == 'l') )
                    {
                        int LA9_100 = input.LA(5);
                        
                        if ( (LA9_100 == '!' || (LA9_100 >= '$' && LA9_100 <= '&') || (LA9_100 >= '*' && LA9_100 <= '+') || (LA9_100 >= '-' && LA9_100 <= ':') || (LA9_100 >= '<' && LA9_100 <= 'Z') || (LA9_100 >= '^' && LA9_100 <= '_') || (LA9_100 >= 'a' && LA9_100 <= 'z') || LA9_100 == '~') )
                        {
                            alt9 = 40;
                        }
                        else 
                        {
                            alt9 = 30;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            	default:
                	alt9 = 40;
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
                    int LA9_71 = input.LA(4);
                    
                    if ( (LA9_71 == 'a') )
                    {
                        int LA9_101 = input.LA(5);
                        
                        if ( (LA9_101 == 't') )
                        {
                            int LA9_130 = input.LA(6);
                            
                            if ( (LA9_130 == '!' || (LA9_130 >= '$' && LA9_130 <= '&') || (LA9_130 >= '*' && LA9_130 <= '+') || (LA9_130 >= '-' && LA9_130 <= ':') || (LA9_130 >= '<' && LA9_130 <= 'Z') || (LA9_130 >= '^' && LA9_130 <= '_') || (LA9_130 >= 'a' && LA9_130 <= 'z') || LA9_130 == '~') )
                            {
                                alt9 = 40;
                            }
                            else 
                            {
                                alt9 = 36;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            case 'r':
            	{
                int LA9_43 = input.LA(3);
                
                if ( (LA9_43 == 'a') )
                {
                    int LA9_72 = input.LA(4);
                    
                    if ( (LA9_72 == 'm') )
                    {
                        int LA9_102 = input.LA(5);
                        
                        if ( (LA9_102 == 'e') )
                        {
                            int LA9_131 = input.LA(6);
                            
                            if ( (LA9_131 == '%') )
                            {
                                int LA9_160 = input.LA(7);
                                
                                if ( (LA9_160 == '!' || (LA9_160 >= '$' && LA9_160 <= '&') || (LA9_160 >= '*' && LA9_160 <= '+') || (LA9_160 >= '-' && LA9_160 <= ':') || (LA9_160 >= '<' && LA9_160 <= 'Z') || (LA9_160 >= '^' && LA9_160 <= '_') || (LA9_160 >= 'a' && LA9_160 <= 'z') || LA9_160 == '~') )
                                {
                                    alt9 = 40;
                                }
                                else 
                                {
                                    alt9 = 4;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            	default:
                	alt9 = 40;
                	break;}
        
            }
            break;
        case 'b':
        	{
            switch ( input.LA(2) ) 
            {
            case 'u':
            	{
                int LA9_44 = input.LA(3);
                
                if ( (LA9_44 == 't') )
                {
                    int LA9_73 = input.LA(4);
                    
                    if ( (LA9_73 == 't') )
                    {
                        int LA9_103 = input.LA(5);
                        
                        if ( (LA9_103 == 'o') )
                        {
                            int LA9_132 = input.LA(6);
                            
                            if ( (LA9_132 == 'n') )
                            {
                                int LA9_161 = input.LA(7);
                                
                                if ( (LA9_161 == '%') )
                                {
                                    int LA9_188 = input.LA(8);
                                    
                                    if ( (LA9_188 == '!' || (LA9_188 >= '$' && LA9_188 <= '&') || (LA9_188 >= '*' && LA9_188 <= '+') || (LA9_188 >= '-' && LA9_188 <= ':') || (LA9_188 >= '<' && LA9_188 <= 'Z') || (LA9_188 >= '^' && LA9_188 <= '_') || (LA9_188 >= 'a' && LA9_188 <= 'z') || LA9_188 == '~') )
                                    {
                                        alt9 = 40;
                                    }
                                    else 
                                    {
                                        alt9 = 5;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            case 'o':
            	{
                switch ( input.LA(3) ) 
                {
                case 't':
                	{
                    int LA9_74 = input.LA(4);
                    
                    if ( (LA9_74 == 't') )
                    {
                        int LA9_104 = input.LA(5);
                        
                        if ( (LA9_104 == 'o') )
                        {
                            int LA9_133 = input.LA(6);
                            
                            if ( (LA9_133 == 'm') )
                            {
                                int LA9_162 = input.LA(7);
                                
                                if ( (LA9_162 == '!' || (LA9_162 >= '$' && LA9_162 <= '&') || (LA9_162 >= '*' && LA9_162 <= '+') || (LA9_162 >= '-' && LA9_162 <= ':') || (LA9_162 >= '<' && LA9_162 <= 'Z') || (LA9_162 >= '^' && LA9_162 <= '_') || (LA9_162 >= 'a' && LA9_162 <= 'z') || LA9_162 == '~') )
                                {
                                    alt9 = 40;
                                }
                                else 
                                {
                                    alt9 = 27;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                    }
                    break;
                case 'r':
                	{
                    int LA9_75 = input.LA(4);
                    
                    if ( (LA9_75 == 'd') )
                    {
                        int LA9_105 = input.LA(5);
                        
                        if ( (LA9_105 == 'e') )
                        {
                            int LA9_134 = input.LA(6);
                            
                            if ( (LA9_134 == 'r') )
                            {
                                int LA9_163 = input.LA(7);
                                
                                if ( (LA9_163 == '!' || (LA9_163 >= '$' && LA9_163 <= '&') || (LA9_163 >= '*' && LA9_163 <= '+') || (LA9_163 >= '-' && LA9_163 <= ':') || (LA9_163 >= '<' && LA9_163 <= 'Z') || (LA9_163 >= '^' && LA9_163 <= '_') || (LA9_163 >= 'a' && LA9_163 <= 'z') || LA9_163 == '~') )
                                {
                                    alt9 = 40;
                                }
                                else 
                                {
                                    alt9 = 12;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                    }
                    break;
                	default:
                    	alt9 = 40;
                    	break;}
            
                }
                break;
            	default:
                	alt9 = 40;
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
                    int LA9_76 = input.LA(4);
                    
                    if ( (LA9_76 == '-') )
                    {
                        switch ( input.LA(5) ) 
                        {
                        case 'c':
                        	{
                            int LA9_135 = input.LA(6);
                            
                            if ( (LA9_135 == 'h') )
                            {
                                int LA9_164 = input.LA(7);
                                
                                if ( (LA9_164 == 'i') )
                                {
                                    int LA9_191 = input.LA(8);
                                    
                                    if ( (LA9_191 == 'l') )
                                    {
                                        int LA9_210 = input.LA(9);
                                        
                                        if ( (LA9_210 == 'd') )
                                        {
                                            int LA9_224 = input.LA(10);
                                            
                                            if ( (LA9_224 == '!' || (LA9_224 >= '$' && LA9_224 <= '&') || (LA9_224 >= '*' && LA9_224 <= '+') || (LA9_224 >= '-' && LA9_224 <= ':') || (LA9_224 >= '<' && LA9_224 <= 'Z') || (LA9_224 >= '^' && LA9_224 <= '_') || (LA9_224 >= 'a' && LA9_224 <= 'z') || LA9_224 == '~') )
                                            {
                                                alt9 = 40;
                                            }
                                            else 
                                            {
                                                alt9 = 35;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                            }
                            break;
                        case 'p':
                        	{
                            int LA9_136 = input.LA(6);
                            
                            if ( (LA9_136 == 'a') )
                            {
                                int LA9_165 = input.LA(7);
                                
                                if ( (LA9_165 == 'r') )
                                {
                                    int LA9_192 = input.LA(8);
                                    
                                    if ( (LA9_192 == 'e') )
                                    {
                                        int LA9_211 = input.LA(9);
                                        
                                        if ( (LA9_211 == 'n') )
                                        {
                                            int LA9_225 = input.LA(10);
                                            
                                            if ( (LA9_225 == 't') )
                                            {
                                                int LA9_237 = input.LA(11);
                                                
                                                if ( (LA9_237 == '!' || (LA9_237 >= '$' && LA9_237 <= '&') || (LA9_237 >= '*' && LA9_237 <= '+') || (LA9_237 >= '-' && LA9_237 <= ':') || (LA9_237 >= '<' && LA9_237 <= 'Z') || (LA9_237 >= '^' && LA9_237 <= '_') || (LA9_237 >= 'a' && LA9_237 <= 'z') || LA9_237 == '~') )
                                                {
                                                    alt9 = 40;
                                                }
                                                else 
                                                {
                                                    alt9 = 34;}
                                            }
                                            else 
                                            {
                                                alt9 = 40;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                            }
                            break;
                        	default:
                            	alt9 = 40;
                            	break;}
                    
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            case 'e':
            	{
                int LA9_47 = input.LA(3);
                
                if ( (LA9_47 == 's') )
                {
                    int LA9_77 = input.LA(4);
                    
                    if ( (LA9_77 == 's') )
                    {
                        int LA9_107 = input.LA(5);
                        
                        if ( (LA9_107 == 'a') )
                        {
                            int LA9_137 = input.LA(6);
                            
                            if ( (LA9_137 == 'g') )
                            {
                                int LA9_166 = input.LA(7);
                                
                                if ( (LA9_166 == 'e') )
                                {
                                    int LA9_193 = input.LA(8);
                                    
                                    if ( (LA9_193 == '%') )
                                    {
                                        int LA9_212 = input.LA(9);
                                        
                                        if ( (LA9_212 == '!' || (LA9_212 >= '$' && LA9_212 <= '&') || (LA9_212 >= '*' && LA9_212 <= '+') || (LA9_212 >= '-' && LA9_212 <= ':') || (LA9_212 >= '<' && LA9_212 <= 'Z') || (LA9_212 >= '^' && LA9_212 <= '_') || (LA9_212 >= 'a' && LA9_212 <= 'z') || LA9_212 == '~') )
                                        {
                                            alt9 = 40;
                                        }
                                        else 
                                        {
                                            alt9 = 6;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            case 'i':
            	{
                int LA9_48 = input.LA(3);
                
                if ( (LA9_48 == 'n') )
                {
                    int LA9_78 = input.LA(4);
                    
                    if ( (LA9_78 == '-') )
                    {
                        switch ( input.LA(5) ) 
                        {
                        case 'w':
                        	{
                            int LA9_138 = input.LA(6);
                            
                            if ( (LA9_138 == 'i') )
                            {
                                int LA9_167 = input.LA(7);
                                
                                if ( (LA9_167 == 'd') )
                                {
                                    int LA9_194 = input.LA(8);
                                    
                                    if ( (LA9_194 == 't') )
                                    {
                                        int LA9_213 = input.LA(9);
                                        
                                        if ( (LA9_213 == 'h') )
                                        {
                                            int LA9_227 = input.LA(10);
                                            
                                            if ( (LA9_227 == '!' || (LA9_227 >= '$' && LA9_227 <= '&') || (LA9_227 >= '*' && LA9_227 <= '+') || (LA9_227 >= '-' && LA9_227 <= ':') || (LA9_227 >= '<' && LA9_227 <= 'Z') || (LA9_227 >= '^' && LA9_227 <= '_') || (LA9_227 >= 'a' && LA9_227 <= 'z') || LA9_227 == '~') )
                                            {
                                                alt9 = 40;
                                            }
                                            else 
                                            {
                                                alt9 = 15;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                            }
                            break;
                        case 'h':
                        	{
                            int LA9_139 = input.LA(6);
                            
                            if ( (LA9_139 == 'e') )
                            {
                                int LA9_168 = input.LA(7);
                                
                                if ( (LA9_168 == 'i') )
                                {
                                    int LA9_195 = input.LA(8);
                                    
                                    if ( (LA9_195 == 'g') )
                                    {
                                        int LA9_214 = input.LA(9);
                                        
                                        if ( (LA9_214 == 'h') )
                                        {
                                            int LA9_228 = input.LA(10);
                                            
                                            if ( (LA9_228 == 't') )
                                            {
                                                int LA9_239 = input.LA(11);
                                                
                                                if ( (LA9_239 == '!' || (LA9_239 >= '$' && LA9_239 <= '&') || (LA9_239 >= '*' && LA9_239 <= '+') || (LA9_239 >= '-' && LA9_239 <= ':') || (LA9_239 >= '<' && LA9_239 <= 'Z') || (LA9_239 >= '^' && LA9_239 <= '_') || (LA9_239 >= 'a' && LA9_239 <= 'z') || LA9_239 == '~') )
                                                {
                                                    alt9 = 40;
                                                }
                                                else 
                                                {
                                                    alt9 = 16;}
                                            }
                                            else 
                                            {
                                                alt9 = 40;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                            }
                            break;
                        	default:
                            	alt9 = 40;
                            	break;}
                    
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            	default:
                	alt9 = 40;
                	break;}
        
            }
            break;
        case 'p':
        	{
            int LA9_7 = input.LA(2);
            
            if ( (LA9_7 == 'a') )
            {
                int LA9_49 = input.LA(3);
                
                if ( (LA9_49 == 'r') )
                {
                    int LA9_79 = input.LA(4);
                    
                    if ( (LA9_79 == 'e') )
                    {
                        int LA9_109 = input.LA(5);
                        
                        if ( (LA9_109 == 'n') )
                        {
                            int LA9_140 = input.LA(6);
                            
                            if ( (LA9_140 == 't') )
                            {
                                int LA9_169 = input.LA(7);
                                
                                if ( (LA9_169 == '!' || (LA9_169 >= '$' && LA9_169 <= '&') || (LA9_169 >= '*' && LA9_169 <= '+') || (LA9_169 >= '-' && LA9_169 <= ':') || (LA9_169 >= '<' && LA9_169 <= 'Z') || (LA9_169 >= '^' && LA9_169 <= '_') || (LA9_169 >= 'a' && LA9_169 <= 'z') || LA9_169 == '~') )
                                {
                                    alt9 = 40;
                                }
                                else 
                                {
                                    alt9 = 7;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
            }
            else 
            {
                alt9 = 40;}
            }
            break;
        case 'l':
        	{
            switch ( input.LA(2) ) 
            {
            case 'a':
            	{
                int LA9_50 = input.LA(3);
                
                if ( (LA9_50 == 'b') )
                {
                    int LA9_80 = input.LA(4);
                    
                    if ( (LA9_80 == 'e') )
                    {
                        int LA9_110 = input.LA(5);
                        
                        if ( (LA9_110 == 'l') )
                        {
                            int LA9_141 = input.LA(6);
                            
                            if ( (LA9_141 == '!' || (LA9_141 >= '$' && LA9_141 <= '&') || (LA9_141 >= '*' && LA9_141 <= '+') || (LA9_141 >= '-' && LA9_141 <= ':') || (LA9_141 >= '<' && LA9_141 <= 'Z') || (LA9_141 >= '^' && LA9_141 <= '_') || (LA9_141 >= 'a' && LA9_141 <= 'z') || LA9_141 == '~') )
                            {
                                alt9 = 40;
                            }
                            else 
                            {
                                alt9 = 8;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            case 'e':
            	{
                int LA9_51 = input.LA(3);
                
                if ( (LA9_51 == 'f') )
                {
                    int LA9_81 = input.LA(4);
                    
                    if ( (LA9_81 == 't') )
                    {
                        int LA9_111 = input.LA(5);
                        
                        if ( (LA9_111 == '!' || (LA9_111 >= '$' && LA9_111 <= '&') || (LA9_111 >= '*' && LA9_111 <= '+') || (LA9_111 >= '-' && LA9_111 <= ':') || (LA9_111 >= '<' && LA9_111 <= 'Z') || (LA9_111 >= '^' && LA9_111 <= '_') || (LA9_111 >= 'a' && LA9_111 <= 'z') || LA9_111 == '~') )
                        {
                            alt9 = 40;
                        }
                        else 
                        {
                            alt9 = 28;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            	default:
                	alt9 = 40;
                	break;}
        
            }
            break;
        case 'w':
        	{
            int LA9_9 = input.LA(2);
            
            if ( (LA9_9 == 'i') )
            {
                int LA9_52 = input.LA(3);
                
                if ( (LA9_52 == 'd') )
                {
                    int LA9_82 = input.LA(4);
                    
                    if ( (LA9_82 == 't') )
                    {
                        int LA9_112 = input.LA(5);
                        
                        if ( (LA9_112 == 'h') )
                        {
                            int LA9_143 = input.LA(6);
                            
                            if ( (LA9_143 == '!' || (LA9_143 >= '$' && LA9_143 <= '&') || (LA9_143 >= '*' && LA9_143 <= '+') || (LA9_143 >= '-' && LA9_143 <= ':') || (LA9_143 >= '<' && LA9_143 <= 'Z') || (LA9_143 >= '^' && LA9_143 <= '_') || (LA9_143 >= 'a' && LA9_143 <= 'z') || LA9_143 == '~') )
                            {
                                alt9 = 40;
                            }
                            else 
                            {
                                alt9 = 9;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
            }
            else 
            {
                alt9 = 40;}
            }
            break;
        case 'h':
        	{
            switch ( input.LA(2) ) 
            {
            case 'e':
            	{
                int LA9_53 = input.LA(3);
                
                if ( (LA9_53 == 'i') )
                {
                    int LA9_83 = input.LA(4);
                    
                    if ( (LA9_83 == 'g') )
                    {
                        int LA9_113 = input.LA(5);
                        
                        if ( (LA9_113 == 'h') )
                        {
                            int LA9_144 = input.LA(6);
                            
                            if ( (LA9_144 == 't') )
                            {
                                int LA9_172 = input.LA(7);
                                
                                if ( (LA9_172 == '!' || (LA9_172 >= '$' && LA9_172 <= '&') || (LA9_172 >= '*' && LA9_172 <= '+') || (LA9_172 >= '-' && LA9_172 <= ':') || (LA9_172 >= '<' && LA9_172 <= 'Z') || (LA9_172 >= '^' && LA9_172 <= '_') || (LA9_172 >= 'a' && LA9_172 <= 'z') || LA9_172 == '~') )
                                {
                                    alt9 = 40;
                                }
                                else 
                                {
                                    alt9 = 10;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            case 'o':
            	{
                int LA9_54 = input.LA(3);
                
                if ( (LA9_54 == 'r') )
                {
                    int LA9_84 = input.LA(4);
                    
                    if ( (LA9_84 == 'i') )
                    {
                        int LA9_114 = input.LA(5);
                        
                        if ( (LA9_114 == 'z') )
                        {
                            int LA9_145 = input.LA(6);
                            
                            if ( (LA9_145 == '-') )
                            {
                                int LA9_173 = input.LA(7);
                                
                                if ( (LA9_173 == 'm') )
                                {
                                    int LA9_198 = input.LA(8);
                                    
                                    if ( (LA9_198 == 'a') )
                                    {
                                        int LA9_215 = input.LA(9);
                                        
                                        if ( (LA9_215 == 'r') )
                                        {
                                            int LA9_229 = input.LA(10);
                                            
                                            if ( (LA9_229 == 'g') )
                                            {
                                                int LA9_240 = input.LA(11);
                                                
                                                if ( (LA9_240 == 'i') )
                                                {
                                                    int LA9_249 = input.LA(12);
                                                    
                                                    if ( (LA9_249 == 'n') )
                                                    {
                                                        int LA9_254 = input.LA(13);
                                                        
                                                        if ( (LA9_254 == '!' || (LA9_254 >= '$' && LA9_254 <= '&') || (LA9_254 >= '*' && LA9_254 <= '+') || (LA9_254 >= '-' && LA9_254 <= ':') || (LA9_254 >= '<' && LA9_254 <= 'Z') || (LA9_254 >= '^' && LA9_254 <= '_') || (LA9_254 >= 'a' && LA9_254 <= 'z') || LA9_254 == '~') )
                                                        {
                                                            alt9 = 40;
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 20;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 40;}
                                                }
                                                else 
                                                {
                                                    alt9 = 40;}
                                            }
                                            else 
                                            {
                                                alt9 = 40;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            	default:
                	alt9 = 40;
                	break;}
        
            }
            break;
        case 'e':
        	{
            int LA9_11 = input.LA(2);
            
            if ( (LA9_11 == 'n') )
            {
                int LA9_55 = input.LA(3);
                
                if ( (LA9_55 == 'a') )
                {
                    int LA9_85 = input.LA(4);
                    
                    if ( (LA9_85 == 'b') )
                    {
                        int LA9_115 = input.LA(5);
                        
                        if ( (LA9_115 == 'l') )
                        {
                            int LA9_146 = input.LA(6);
                            
                            if ( (LA9_146 == 'e') )
                            {
                                int LA9_174 = input.LA(7);
                                
                                if ( (LA9_174 == 'd') )
                                {
                                    int LA9_199 = input.LA(8);
                                    
                                    if ( (LA9_199 == '!' || (LA9_199 >= '$' && LA9_199 <= '&') || (LA9_199 >= '*' && LA9_199 <= '+') || (LA9_199 >= '-' && LA9_199 <= ':') || (LA9_199 >= '<' && LA9_199 <= 'Z') || (LA9_199 >= '^' && LA9_199 <= '_') || (LA9_199 >= 'a' && LA9_199 <= 'z') || LA9_199 == '~') )
                                    {
                                        alt9 = 40;
                                    }
                                    else 
                                    {
                                        alt9 = 11;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
            }
            else 
            {
                alt9 = 40;}
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
                    int LA9_86 = input.LA(4);
                    
                    if ( (LA9_86 == 'e') )
                    {
                        int LA9_116 = input.LA(5);
                        
                        if ( (LA9_116 == 't') )
                        {
                            int LA9_147 = input.LA(6);
                            
                            if ( (LA9_147 == 'c') )
                            {
                                int LA9_175 = input.LA(7);
                                
                                if ( (LA9_175 == 'h') )
                                {
                                    int LA9_200 = input.LA(8);
                                    
                                    if ( (LA9_200 == 'a') )
                                    {
                                        int LA9_217 = input.LA(9);
                                        
                                        if ( (LA9_217 == 'b') )
                                        {
                                            int LA9_230 = input.LA(10);
                                            
                                            if ( (LA9_230 == 'l') )
                                            {
                                                int LA9_241 = input.LA(11);
                                                
                                                if ( (LA9_241 == 'e') )
                                                {
                                                    int LA9_250 = input.LA(12);
                                                    
                                                    if ( (LA9_250 == '-') )
                                                    {
                                                        switch ( input.LA(13) ) 
                                                        {
                                                        case 'w':
                                                        	{
                                                            int LA9_260 = input.LA(14);
                                                            
                                                            if ( (LA9_260 == 'i') )
                                                            {
                                                                int LA9_264 = input.LA(15);
                                                                
                                                                if ( (LA9_264 == 'd') )
                                                                {
                                                                    int LA9_268 = input.LA(16);
                                                                    
                                                                    if ( (LA9_268 == 't') )
                                                                    {
                                                                        int LA9_271 = input.LA(17);
                                                                        
                                                                        if ( (LA9_271 == 'h') )
                                                                        {
                                                                            int LA9_274 = input.LA(18);
                                                                            
                                                                            if ( (LA9_274 == '!' || (LA9_274 >= '$' && LA9_274 <= '&') || (LA9_274 >= '*' && LA9_274 <= '+') || (LA9_274 >= '-' && LA9_274 <= ':') || (LA9_274 >= '<' && LA9_274 <= 'Z') || (LA9_274 >= '^' && LA9_274 <= '_') || (LA9_274 >= 'a' && LA9_274 <= 'z') || LA9_274 == '~') )
                                                                            {
                                                                                alt9 = 40;
                                                                            }
                                                                            else 
                                                                            {
                                                                                alt9 = 17;}
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt9 = 40;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 40;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 40;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 40;}
                                                            }
                                                            break;
                                                        case 'h':
                                                        	{
                                                            int LA9_261 = input.LA(14);
                                                            
                                                            if ( (LA9_261 == 'e') )
                                                            {
                                                                int LA9_265 = input.LA(15);
                                                                
                                                                if ( (LA9_265 == 'i') )
                                                                {
                                                                    int LA9_269 = input.LA(16);
                                                                    
                                                                    if ( (LA9_269 == 'g') )
                                                                    {
                                                                        int LA9_272 = input.LA(17);
                                                                        
                                                                        if ( (LA9_272 == 'h') )
                                                                        {
                                                                            int LA9_275 = input.LA(18);
                                                                            
                                                                            if ( (LA9_275 == 't') )
                                                                            {
                                                                                int LA9_277 = input.LA(19);
                                                                                
                                                                                if ( (LA9_277 == '!' || (LA9_277 >= '$' && LA9_277 <= '&') || (LA9_277 >= '*' && LA9_277 <= '+') || (LA9_277 >= '-' && LA9_277 <= ':') || (LA9_277 >= '<' && LA9_277 <= 'Z') || (LA9_277 >= '^' && LA9_277 <= '_') || (LA9_277 >= 'a' && LA9_277 <= 'z') || LA9_277 == '~') )
                                                                                {
                                                                                    alt9 = 40;
                                                                                }
                                                                                else 
                                                                                {
                                                                                    alt9 = 18;}
                                                                            }
                                                                            else 
                                                                            {
                                                                                alt9 = 40;}
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt9 = 40;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 40;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 40;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 40;}
                                                            }
                                                            break;
                                                        	default:
                                                            	alt9 = 40;
                                                            	break;}
                                                    
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 40;}
                                                }
                                                else 
                                                {
                                                    alt9 = 40;}
                                            }
                                            else 
                                            {
                                                alt9 = 40;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                    }
                    break;
                case 'y':
                	{
                    int LA9_87 = input.LA(4);
                    
                    if ( (LA9_87 == 'l') )
                    {
                        int LA9_117 = input.LA(5);
                        
                        if ( (LA9_117 == 'e') )
                        {
                            int LA9_148 = input.LA(6);
                            
                            if ( (LA9_148 == '!' || (LA9_148 >= '$' && LA9_148 <= '&') || (LA9_148 >= '*' && LA9_148 <= '+') || (LA9_148 >= '-' && LA9_148 <= ':') || (LA9_148 >= '<' && LA9_148 <= 'Z') || (LA9_148 >= '^' && LA9_148 <= '_') || (LA9_148 >= 'a' && LA9_148 <= 'z') || LA9_148 == '~') )
                            {
                                alt9 = 40;
                            }
                            else 
                            {
                                alt9 = 37;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                    }
                    break;
                	default:
                    	alt9 = 40;
                    	break;}
            
                }
                break;
            case 'p':
            	{
                int LA9_57 = input.LA(3);
                
                if ( (LA9_57 == 'a') )
                {
                    int LA9_88 = input.LA(4);
                    
                    if ( (LA9_88 == 'c') )
                    {
                        int LA9_118 = input.LA(5);
                        
                        if ( (LA9_118 == 'i') )
                        {
                            int LA9_149 = input.LA(6);
                            
                            if ( (LA9_149 == 'n') )
                            {
                                int LA9_177 = input.LA(7);
                                
                                if ( (LA9_177 == 'g') )
                                {
                                    int LA9_201 = input.LA(8);
                                    
                                    if ( (LA9_201 == '!' || (LA9_201 >= '$' && LA9_201 <= '&') || (LA9_201 >= '*' && LA9_201 <= '+') || (LA9_201 >= '-' && LA9_201 <= ':') || (LA9_201 >= '<' && LA9_201 <= 'Z') || (LA9_201 >= '^' && LA9_201 <= '_') || (LA9_201 >= 'a' && LA9_201 <= 'z') || LA9_201 == '~') )
                                    {
                                        alt9 = 40;
                                    }
                                    else 
                                    {
                                        alt9 = 13;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
                }
                break;
            	default:
                	alt9 = 40;
                	break;}
        
            }
            break;
        case 'a':
        	{
            int LA9_13 = input.LA(2);
            
            if ( (LA9_13 == 'l') )
            {
                int LA9_58 = input.LA(3);
                
                if ( (LA9_58 == 'i') )
                {
                    int LA9_89 = input.LA(4);
                    
                    if ( (LA9_89 == 'g') )
                    {
                        int LA9_119 = input.LA(5);
                        
                        if ( (LA9_119 == 'n') )
                        {
                            int LA9_150 = input.LA(6);
                            
                            if ( (LA9_150 == 'm') )
                            {
                                int LA9_178 = input.LA(7);
                                
                                if ( (LA9_178 == 'e') )
                                {
                                    int LA9_202 = input.LA(8);
                                    
                                    if ( (LA9_202 == 'n') )
                                    {
                                        int LA9_219 = input.LA(9);
                                        
                                        if ( (LA9_219 == 't') )
                                        {
                                            int LA9_231 = input.LA(10);
                                            
                                            if ( (LA9_231 == '!' || (LA9_231 >= '$' && LA9_231 <= '&') || (LA9_231 >= '*' && LA9_231 <= '+') || (LA9_231 >= '-' && LA9_231 <= ':') || (LA9_231 >= '<' && LA9_231 <= 'Z') || (LA9_231 >= '^' && LA9_231 <= '_') || (LA9_231 >= 'a' && LA9_231 <= 'z') || LA9_231 == '~') )
                                            {
                                                alt9 = 40;
                                            }
                                            else 
                                            {
                                                alt9 = 14;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
            }
            else 
            {
                alt9 = 40;}
            }
            break;
        case 'v':
        	{
            int LA9_14 = input.LA(2);
            
            if ( (LA9_14 == 'e') )
            {
                int LA9_59 = input.LA(3);
                
                if ( (LA9_59 == 'r') )
                {
                    int LA9_90 = input.LA(4);
                    
                    if ( (LA9_90 == 't') )
                    {
                        int LA9_120 = input.LA(5);
                        
                        if ( (LA9_120 == '-') )
                        {
                            int LA9_151 = input.LA(6);
                            
                            if ( (LA9_151 == 'm') )
                            {
                                int LA9_179 = input.LA(7);
                                
                                if ( (LA9_179 == 'a') )
                                {
                                    int LA9_203 = input.LA(8);
                                    
                                    if ( (LA9_203 == 'r') )
                                    {
                                        int LA9_220 = input.LA(9);
                                        
                                        if ( (LA9_220 == 'g') )
                                        {
                                            int LA9_232 = input.LA(10);
                                            
                                            if ( (LA9_232 == 'i') )
                                            {
                                                int LA9_243 = input.LA(11);
                                                
                                                if ( (LA9_243 == 'n') )
                                                {
                                                    int LA9_251 = input.LA(12);
                                                    
                                                    if ( (LA9_251 == '!' || (LA9_251 >= '$' && LA9_251 <= '&') || (LA9_251 >= '*' && LA9_251 <= '+') || (LA9_251 >= '-' && LA9_251 <= ':') || (LA9_251 >= '<' && LA9_251 <= 'Z') || (LA9_251 >= '^' && LA9_251 <= '_') || (LA9_251 >= 'a' && LA9_251 <= 'z') || LA9_251 == '~') )
                                                    {
                                                        alt9 = 40;
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 19;}
                                                }
                                                else 
                                                {
                                                    alt9 = 40;}
                                            }
                                            else 
                                            {
                                                alt9 = 40;}
                                        }
                                        else 
                                        {
                                            alt9 = 40;}
                                    }
                                    else 
                                    {
                                        alt9 = 40;}
                                }
                                else 
                                {
                                    alt9 = 40;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
            }
            else 
            {
                alt9 = 40;}
            }
            break;
        case '(':
        	{
            alt9 = 21;
            }
            break;
        case ')':
        	{
            alt9 = 22;
            }
            break;
        case '#':
        	{
            int LA9_17 = input.LA(2);
            
            if ( (LA9_17 == 'f') )
            {
                alt9 = 23;
            }
            else if ( (LA9_17 == 't') )
            {
                alt9 = 24;
            }
            else 
            {
                NoViableAltException nvae_d9s17 =
                    new NoViableAltException("1:1: Tokens : ( SEMI | DEFINE | NEW | FRAME | BUTTON | MESSAGE | PARENT | LABEL | WIDTH | HEIGHT | ENABLED | BORDER | SPACING | ALIGNMENT | MIN_WIDTH | MIN_HEIGHT | STRETCH_WIDTH | STRETCH_HEIGHT | VERT_MARGIN | HORIZ_MARGIN | LP | RP | FALSE | TRUE | TOP | CENTER | BOTTOM | LEFT | RIGHT | NULL | NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT | STYLE | DELETED | WS | ID | NUMBER | NAME | NEWLINE | COMMENT | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | QUOTE );", 9, 17, input);
            
                throw nvae_d9s17;
            }
            }
            break;
        case 't':
        	{
            int LA9_18 = input.LA(2);
            
            if ( (LA9_18 == 'o') )
            {
                int LA9_62 = input.LA(3);
                
                if ( (LA9_62 == 'p') )
                {
                    int LA9_91 = input.LA(4);
                    
                    if ( (LA9_91 == '!' || (LA9_91 >= '$' && LA9_91 <= '&') || (LA9_91 >= '*' && LA9_91 <= '+') || (LA9_91 >= '-' && LA9_91 <= ':') || (LA9_91 >= '<' && LA9_91 <= 'Z') || (LA9_91 >= '^' && LA9_91 <= '_') || (LA9_91 >= 'a' && LA9_91 <= 'z') || LA9_91 == '~') )
                    {
                        alt9 = 40;
                    }
                    else 
                    {
                        alt9 = 25;}
                }
                else 
                {
                    alt9 = 40;}
            }
            else 
            {
                alt9 = 40;}
            }
            break;
        case 'c':
        	{
            int LA9_19 = input.LA(2);
            
            if ( (LA9_19 == 'e') )
            {
                int LA9_63 = input.LA(3);
                
                if ( (LA9_63 == 'n') )
                {
                    int LA9_92 = input.LA(4);
                    
                    if ( (LA9_92 == 't') )
                    {
                        int LA9_122 = input.LA(5);
                        
                        if ( (LA9_122 == 'e') )
                        {
                            int LA9_152 = input.LA(6);
                            
                            if ( (LA9_152 == 'r') )
                            {
                                int LA9_180 = input.LA(7);
                                
                                if ( (LA9_180 == '!' || (LA9_180 >= '$' && LA9_180 <= '&') || (LA9_180 >= '*' && LA9_180 <= '+') || (LA9_180 >= '-' && LA9_180 <= ':') || (LA9_180 >= '<' && LA9_180 <= 'Z') || (LA9_180 >= '^' && LA9_180 <= '_') || (LA9_180 >= 'a' && LA9_180 <= 'z') || LA9_180 == '~') )
                                {
                                    alt9 = 40;
                                }
                                else 
                                {
                                    alt9 = 26;}
                            }
                            else 
                            {
                                alt9 = 40;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
            }
            else 
            {
                alt9 = 40;}
            }
            break;
        case 'r':
        	{
            int LA9_20 = input.LA(2);
            
            if ( (LA9_20 == 'i') )
            {
                int LA9_64 = input.LA(3);
                
                if ( (LA9_64 == 'g') )
                {
                    int LA9_93 = input.LA(4);
                    
                    if ( (LA9_93 == 'h') )
                    {
                        int LA9_123 = input.LA(5);
                        
                        if ( (LA9_123 == 't') )
                        {
                            int LA9_153 = input.LA(6);
                            
                            if ( (LA9_153 == '!' || (LA9_153 >= '$' && LA9_153 <= '&') || (LA9_153 >= '*' && LA9_153 <= '+') || (LA9_153 >= '-' && LA9_153 <= ':') || (LA9_153 >= '<' && LA9_153 <= 'Z') || (LA9_153 >= '^' && LA9_153 <= '_') || (LA9_153 >= 'a' && LA9_153 <= 'z') || LA9_153 == '~') )
                            {
                                alt9 = 40;
                            }
                            else 
                            {
                                alt9 = 29;}
                        }
                        else 
                        {
                            alt9 = 40;}
                    }
                    else 
                    {
                        alt9 = 40;}
                }
                else 
                {
                    alt9 = 40;}
            }
            else 
            {
                alt9 = 40;}
            }
            break;
        case '\r':
        	{
            int LA9_21 = input.LA(2);
            
            if ( (LA9_21 == '\n') )
            {
                alt9 = 43;
            }
            else 
            {
                alt9 = 39;}
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
            alt9 = 40;
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
            alt9 = 41;
            }
            break;
        case '\"':
        	{
            alt9 = 42;
            }
            break;
        case '\n':
        	{
            alt9 = 39;
            }
            break;
        case '\t':
        case ' ':
        	{
            alt9 = 39;
            }
            break;
        case '+':
        	{
            alt9 = 45;
            }
            break;
        case '-':
        	{
            alt9 = 46;
            }
            break;
        case '*':
        	{
            alt9 = 47;
            }
            break;
        case '/':
        	{
            alt9 = 48;
            }
            break;
        case '.':
        	{
            alt9 = 49;
            }
            break;
        case '<':
        	{
            alt9 = 50;
            }
            break;
        case '>':
        	{
            alt9 = 51;
            }
            break;
        case '=':
        	{
            alt9 = 52;
            }
            break;
        case '\'':
        	{
            alt9 = 53;
            }
            break;
        	default:
        	    NoViableAltException nvae_d9s0 =
        	        new NoViableAltException("1:1: Tokens : ( SEMI | DEFINE | NEW | FRAME | BUTTON | MESSAGE | PARENT | LABEL | WIDTH | HEIGHT | ENABLED | BORDER | SPACING | ALIGNMENT | MIN_WIDTH | MIN_HEIGHT | STRETCH_WIDTH | STRETCH_HEIGHT | VERT_MARGIN | HORIZ_MARGIN | LP | RP | FALSE | TRUE | TOP | CENTER | BOTTOM | LEFT | RIGHT | NULL | NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT | STYLE | DELETED | WS | ID | NUMBER | NAME | NEWLINE | COMMENT | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | QUOTE );", 9, 0, input);
        
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
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:47: PARENT
                {
                	mPARENT(); 
                
                }
                break;
            case 8 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:54: LABEL
                {
                	mLABEL(); 
                
                }
                break;
            case 9 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:60: WIDTH
                {
                	mWIDTH(); 
                
                }
                break;
            case 10 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:66: HEIGHT
                {
                	mHEIGHT(); 
                
                }
                break;
            case 11 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:73: ENABLED
                {
                	mENABLED(); 
                
                }
                break;
            case 12 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:81: BORDER
                {
                	mBORDER(); 
                
                }
                break;
            case 13 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:88: SPACING
                {
                	mSPACING(); 
                
                }
                break;
            case 14 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:96: ALIGNMENT
                {
                	mALIGNMENT(); 
                
                }
                break;
            case 15 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:106: MIN_WIDTH
                {
                	mMIN_WIDTH(); 
                
                }
                break;
            case 16 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:116: MIN_HEIGHT
                {
                	mMIN_HEIGHT(); 
                
                }
                break;
            case 17 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:127: STRETCH_WIDTH
                {
                	mSTRETCH_WIDTH(); 
                
                }
                break;
            case 18 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:141: STRETCH_HEIGHT
                {
                	mSTRETCH_HEIGHT(); 
                
                }
                break;
            case 19 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:156: VERT_MARGIN
                {
                	mVERT_MARGIN(); 
                
                }
                break;
            case 20 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:168: HORIZ_MARGIN
                {
                	mHORIZ_MARGIN(); 
                
                }
                break;
            case 21 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:181: LP
                {
                	mLP(); 
                
                }
                break;
            case 22 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:184: RP
                {
                	mRP(); 
                
                }
                break;
            case 23 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:187: FALSE
                {
                	mFALSE(); 
                
                }
                break;
            case 24 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:193: TRUE
                {
                	mTRUE(); 
                
                }
                break;
            case 25 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:198: TOP
                {
                	mTOP(); 
                
                }
                break;
            case 26 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:202: CENTER
                {
                	mCENTER(); 
                
                }
                break;
            case 27 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:209: BOTTOM
                {
                	mBOTTOM(); 
                
                }
                break;
            case 28 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:216: LEFT
                {
                	mLEFT(); 
                
                }
                break;
            case 29 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:221: RIGHT
                {
                	mRIGHT(); 
                
                }
                break;
            case 30 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:227: NULL
                {
                	mNULL(); 
                
                }
                break;
            case 31 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:232: NO_RESIZE_BORDER
                {
                	mNO_RESIZE_BORDER(); 
                
                }
                break;
            case 32 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:249: NO_CAPTION
                {
                	mNO_CAPTION(); 
                
                }
                break;
            case 33 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:260: NO_SYSTEM_MENU
                {
                	mNO_SYSTEM_MENU(); 
                
                }
                break;
            case 34 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:275: MDI_PARENT
                {
                	mMDI_PARENT(); 
                
                }
                break;
            case 35 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:286: MDI_CHILD
                {
                	mMDI_CHILD(); 
                
                }
                break;
            case 36 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:296: FLOAT
                {
                	mFLOAT(); 
                
                }
                break;
            case 37 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:302: STYLE
                {
                	mSTYLE(); 
                
                }
                break;
            case 38 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:308: DELETED
                {
                	mDELETED(); 
                
                }
                break;
            case 39 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:316: WS
                {
                	mWS(); 
                
                }
                break;
            case 40 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:319: ID
                {
                	mID(); 
                
                }
                break;
            case 41 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:322: NUMBER
                {
                	mNUMBER(); 
                
                }
                break;
            case 42 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:329: NAME
                {
                	mNAME(); 
                
                }
                break;
            case 43 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:334: NEWLINE
                {
                	mNEWLINE(); 
                
                }
                break;
            case 44 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:342: COMMENT
                {
                	mCOMMENT(); 
                
                }
                break;
            case 45 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:350: PLUS
                {
                	mPLUS(); 
                
                }
                break;
            case 46 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:355: MINUS
                {
                	mMINUS(); 
                
                }
                break;
            case 47 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:361: STAR
                {
                	mSTAR(); 
                
                }
                break;
            case 48 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:366: SLASH
                {
                	mSLASH(); 
                
                }
                break;
            case 49 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:372: DOT
                {
                	mDOT(); 
                
                }
                break;
            case 50 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:376: LT
                {
                	mLT(); 
                
                }
                break;
            case 51 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:379: GT
                {
                	mGT(); 
                
                }
                break;
            case 52 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:382: EQ
                {
                	mEQ(); 
                
                }
                break;
            case 53 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:385: QUOTE
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