// $ANTLR 3.0.1 D:\\Projects\\AntlrTestApps\\ScmGrammar.g 2008-06-10 19:34:59
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
    public const int MDI_CHILD = 37;
    public const int LT = 49;
    public const int STAR = 47;
    public const int HORIZ_MARGIN = 22;
    public const int SPACING = 15;
    public const int STRETCH_WIDTH = 19;
    public const int RP = 24;
    public const int LEAD_DIGIT = 57;
    public const int STRETCH_HEIGHT = 20;
    public const int LP = 23;
    public const int NEW = 6;
    public const int BUTTON = 8;
    public const int FLOAT = 38;
    public const int ID = 41;
    public const int DEFINE = 5;
    public const int CAR = 54;
    public const int EOF = -1;
    public const int CENTER = 28;
    public const int ZERO = 58;
    public const int BORDER = 14;
    public const int MDI_PARENT = 36;
    public const int QUOTE = 44;
    public const int MIN_HEIGHT = 18;
    public const int PARENT = 9;
    public const int NAME = 42;
    public const int SLASH = 48;
    public const int ALIGNMENT = 16;
    public const int LEFT = 30;
    public const int ENABLED = 13;
    public const int PLUS = 45;
    public const int DIGIT = 56;
    public const int EQ = 51;
    public const int DOT = 55;
    public const int COMMENT = 52;
    public const int NO_SYSTEM_MENU = 35;
    public const int NO_CAPTION = 34;
    public const int HEIGHT = 12;
    public const int NULL = 32;
    public const int NUMBER = 43;
    public const int RIGHT = 31;
    public const int MINUS = 46;
    public const int Tokens = 60;
    public const int VERT_MARGIN = 21;
    public const int TRUE = 26;
    public const int SEMI = 4;
    public const int DELETED = 40;
    public const int NO_RESIZE_BORDER = 33;
    public const int WS = 53;
    public const int NEWLINE = 59;
    public const int LABEL = 10;
    public const int WIDTH = 11;
    public const int STYLE = 39;
    public const int BOTTOM = 29;
    public const int MIN_WIDTH = 17;
    public const int GT = 50;
    public const int FRAME = 7;
    public const int TOP = 27;
    public const int FALSE = 25;

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

    // $ANTLR start PARENT 
    public void mPARENT() // throws RecognitionException [2]
    {
        try 
    	{
            int _type = PARENT;
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:15:8: ( 'parent' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:15:10: 'parent'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:16:7: ( 'label' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:16:9: 'label'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:17:7: ( 'width' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:17:9: 'width'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:18:8: ( 'height' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:18:10: 'height'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:19:9: ( 'enabled' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:19:11: 'enabled'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:20:8: ( 'border' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:20:10: 'border'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:21:9: ( 'spacing' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:21:11: 'spacing'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:22:11: ( 'alignment' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:22:13: 'alignment'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:23:11: ( 'min-width' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:23:13: 'min-width'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:24:12: ( 'min-height' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:24:14: 'min-height'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:25:15: ( 'stretchable-width' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:25:17: 'stretchable-width'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:26:16: ( 'stretchable-height' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:26:18: 'stretchable-height'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:27:13: ( 'vert-margin' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:27:15: 'vert-margin'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:28:14: ( 'horiz-margin' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:28:16: 'horiz-margin'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:29:4: ( '(' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:29:6: '('
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:30:4: ( ')' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:30:6: ')'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:31:7: ( '#f' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:31:9: '#f'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:32:6: ( '#t' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:32:8: '#t'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:33:5: ( 'top' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:33:7: 'top'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:34:8: ( 'center' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:34:10: 'center'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:35:8: ( 'bottom' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:35:10: 'bottom'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:36:6: ( 'left' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:36:8: 'left'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:37:7: ( 'right' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:37:9: 'right'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:38:6: ( 'null' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:38:8: 'null'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:39:18: ( 'no-resize-border' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:39:20: 'no-resize-border'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:40:12: ( 'no-caption' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:40:14: 'no-caption'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:41:16: ( 'no-system-menu' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:41:18: 'no-system-menu'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:42:12: ( 'mdi-parent' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:42:14: 'mdi-parent'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:43:11: ( 'mdi-child' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:43:13: 'mdi-child'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:44:7: ( 'float' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:44:9: 'float'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:45:7: ( 'style' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:45:9: 'style'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:46:9: ( 'deleted' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:46:11: 'deleted'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:236:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:236:7: ( ' ' | '\\t' | '\\r' | '\\n' )
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:238:4: ( ( 'a' .. 'z' | 'A' .. 'Z' | CAR ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | CAR )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:238:6: ( 'a' .. 'z' | 'A' .. 'Z' | CAR ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | CAR )*
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

            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:238:34: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | CAR )*
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:241:2: ( '?' | '!' | ':' | '$' | '%' | '^' | '&' | '_' | '~' | '@' )
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:244:2: ( '0' .. '9' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:244:4: '0' .. '9'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:247:2: ( '1' .. '9' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:247:4: '1' .. '9'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:250:2: ( '0' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:250:4: '0'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:2: ( ZERO | LEAD_DIGIT ( DIGIT )* ( DOT ( DIGIT )+ )? )
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
                    new NoViableAltException("252:1: NUMBER : ( ZERO | LEAD_DIGIT ( DIGIT )* ( DOT ( DIGIT )+ )? );", 5, 0, input);
            
                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:4: ZERO
                    {
                    	mZERO(); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:11: LEAD_DIGIT ( DIGIT )* ( DOT ( DIGIT )+ )?
                    {
                    	mLEAD_DIGIT(); 
                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:22: ( DIGIT )*
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
                    			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:22: DIGIT
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

                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:29: ( DOT ( DIGIT )+ )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);
                    	
                    	if ( (LA4_0 == '.') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:30: DOT ( DIGIT )+
                    	        {
                    	        	mDOT(); 
                    	        	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:34: ( DIGIT )+
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
                    	        			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:34: DIGIT
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:255:5: ( '\"' ( . )* '\"' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:255:7: '\"' ( . )* '\"'
            {
            	Match('\"'); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:255:11: ( . )*
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:255:11: .
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:258:2: ( ( ( '\\r' )? '\\n' ) )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:258:4: ( ( '\\r' )? '\\n' )
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:258:4: ( ( '\\r' )? '\\n' )
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:258:5: ( '\\r' )? '\\n'
            	{
            		// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:258:5: ( '\\r' )?
            		int alt7 = 2;
            		int LA7_0 = input.LA(1);
            		
            		if ( (LA7_0 == '\r') )
            		{
            		    alt7 = 1;
            		}
            		switch (alt7) 
            		{
            		    case 1 :
            		        // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:258:5: '\\r'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:262:2: ( SEMI (~ ( '\\r' | '\\n' ) )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:262:4: SEMI (~ ( '\\r' | '\\n' ) )*
            {
            	mSEMI(); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:262:9: (~ ( '\\r' | '\\n' ) )*
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:262:10: ~ ( '\\r' | '\\n' )
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:264:7: ( '+' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:264:9: '+'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:266:8: ( '-' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:266:10: '-'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:268:7: ( '*' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:268:9: '*'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:270:8: ( '/' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:270:10: '/'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:272:6: ( '.' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:272:8: '.'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:274:5: ( '<' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:274:7: '<'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:276:5: ( '>' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:276:7: '>'
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:278:5: ( '=' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:278:7: '='
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:280:8: ( '\\'' )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:280:10: '\\''
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
        // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:8: ( SEMI | DEFINE | NEW | FRAME | BUTTON | PARENT | LABEL | WIDTH | HEIGHT | ENABLED | BORDER | SPACING | ALIGNMENT | MIN_WIDTH | MIN_HEIGHT | STRETCH_WIDTH | STRETCH_HEIGHT | VERT_MARGIN | HORIZ_MARGIN | LP | RP | FALSE | TRUE | TOP | CENTER | BOTTOM | LEFT | RIGHT | NULL | NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT | STYLE | DELETED | WS | ID | NUMBER | NAME | NEWLINE | COMMENT | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | QUOTE )
        int alt9 = 52;
        switch ( input.LA(1) ) 
        {
        case ';':
        	{
            int LA9_1 = input.LA(2);
            
            if ( ((LA9_1 >= '\u0000' && LA9_1 <= '\t') || (LA9_1 >= '\u000B' && LA9_1 <= '\f') || (LA9_1 >= '\u000E' && LA9_1 <= '\uFFFE')) )
            {
                alt9 = 43;
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
                    int LA9_65 = input.LA(4);
                    
                    if ( (LA9_65 == 'i') )
                    {
                        int LA9_92 = input.LA(5);
                        
                        if ( (LA9_92 == 'n') )
                        {
                            int LA9_121 = input.LA(6);
                            
                            if ( (LA9_121 == 'e') )
                            {
                                int LA9_150 = input.LA(7);
                                
                                if ( (LA9_150 == '!' || (LA9_150 >= '$' && LA9_150 <= '&') || (LA9_150 >= '*' && LA9_150 <= '+') || (LA9_150 >= '-' && LA9_150 <= ':') || (LA9_150 >= '<' && LA9_150 <= 'Z') || (LA9_150 >= '^' && LA9_150 <= '_') || (LA9_150 >= 'a' && LA9_150 <= 'z') || LA9_150 == '~') )
                                {
                                    alt9 = 39;
                                }
                                else 
                                {
                                    alt9 = 2;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                    }
                    break;
                case 'l':
                	{
                    int LA9_66 = input.LA(4);
                    
                    if ( (LA9_66 == 'e') )
                    {
                        int LA9_93 = input.LA(5);
                        
                        if ( (LA9_93 == 't') )
                        {
                            int LA9_122 = input.LA(6);
                            
                            if ( (LA9_122 == 'e') )
                            {
                                int LA9_151 = input.LA(7);
                                
                                if ( (LA9_151 == 'd') )
                                {
                                    int LA9_178 = input.LA(8);
                                    
                                    if ( (LA9_178 == '!' || (LA9_178 >= '$' && LA9_178 <= '&') || (LA9_178 >= '*' && LA9_178 <= '+') || (LA9_178 >= '-' && LA9_178 <= ':') || (LA9_178 >= '<' && LA9_178 <= 'Z') || (LA9_178 >= '^' && LA9_178 <= '_') || (LA9_178 >= 'a' && LA9_178 <= 'z') || LA9_178 == '~') )
                                    {
                                        alt9 = 39;
                                    }
                                    else 
                                    {
                                        alt9 = 37;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                    }
                    break;
                	default:
                    	alt9 = 39;
                    	break;}
            
            }
            else 
            {
                alt9 = 39;}
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
                    case 'r':
                    	{
                        int LA9_94 = input.LA(5);
                        
                        if ( (LA9_94 == 'e') )
                        {
                            int LA9_123 = input.LA(6);
                            
                            if ( (LA9_123 == 's') )
                            {
                                int LA9_152 = input.LA(7);
                                
                                if ( (LA9_152 == 'i') )
                                {
                                    int LA9_179 = input.LA(8);
                                    
                                    if ( (LA9_179 == 'z') )
                                    {
                                        int LA9_200 = input.LA(9);
                                        
                                        if ( (LA9_200 == 'e') )
                                        {
                                            int LA9_214 = input.LA(10);
                                            
                                            if ( (LA9_214 == '-') )
                                            {
                                                int LA9_225 = input.LA(11);
                                                
                                                if ( (LA9_225 == 'b') )
                                                {
                                                    int LA9_236 = input.LA(12);
                                                    
                                                    if ( (LA9_236 == 'o') )
                                                    {
                                                        int LA9_244 = input.LA(13);
                                                        
                                                        if ( (LA9_244 == 'r') )
                                                        {
                                                            int LA9_249 = input.LA(14);
                                                            
                                                            if ( (LA9_249 == 'd') )
                                                            {
                                                                int LA9_254 = input.LA(15);
                                                                
                                                                if ( (LA9_254 == 'e') )
                                                                {
                                                                    int LA9_258 = input.LA(16);
                                                                    
                                                                    if ( (LA9_258 == 'r') )
                                                                    {
                                                                        int LA9_262 = input.LA(17);
                                                                        
                                                                        if ( (LA9_262 == '!' || (LA9_262 >= '$' && LA9_262 <= '&') || (LA9_262 >= '*' && LA9_262 <= '+') || (LA9_262 >= '-' && LA9_262 <= ':') || (LA9_262 >= '<' && LA9_262 <= 'Z') || (LA9_262 >= '^' && LA9_262 <= '_') || (LA9_262 >= 'a' && LA9_262 <= 'z') || LA9_262 == '~') )
                                                                        {
                                                                            alt9 = 39;
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt9 = 30;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 39;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 39;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 39;}
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 39;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 39;}
                                                }
                                                else 
                                                {
                                                    alt9 = 39;}
                                            }
                                            else 
                                            {
                                                alt9 = 39;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                        }
                        break;
                    case 's':
                    	{
                        int LA9_95 = input.LA(5);
                        
                        if ( (LA9_95 == 'y') )
                        {
                            int LA9_124 = input.LA(6);
                            
                            if ( (LA9_124 == 's') )
                            {
                                int LA9_153 = input.LA(7);
                                
                                if ( (LA9_153 == 't') )
                                {
                                    int LA9_180 = input.LA(8);
                                    
                                    if ( (LA9_180 == 'e') )
                                    {
                                        int LA9_201 = input.LA(9);
                                        
                                        if ( (LA9_201 == 'm') )
                                        {
                                            int LA9_215 = input.LA(10);
                                            
                                            if ( (LA9_215 == '-') )
                                            {
                                                int LA9_226 = input.LA(11);
                                                
                                                if ( (LA9_226 == 'm') )
                                                {
                                                    int LA9_237 = input.LA(12);
                                                    
                                                    if ( (LA9_237 == 'e') )
                                                    {
                                                        int LA9_245 = input.LA(13);
                                                        
                                                        if ( (LA9_245 == 'n') )
                                                        {
                                                            int LA9_250 = input.LA(14);
                                                            
                                                            if ( (LA9_250 == 'u') )
                                                            {
                                                                int LA9_255 = input.LA(15);
                                                                
                                                                if ( (LA9_255 == '!' || (LA9_255 >= '$' && LA9_255 <= '&') || (LA9_255 >= '*' && LA9_255 <= '+') || (LA9_255 >= '-' && LA9_255 <= ':') || (LA9_255 >= '<' && LA9_255 <= 'Z') || (LA9_255 >= '^' && LA9_255 <= '_') || (LA9_255 >= 'a' && LA9_255 <= 'z') || LA9_255 == '~') )
                                                                {
                                                                    alt9 = 39;
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 32;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 39;}
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 39;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 39;}
                                                }
                                                else 
                                                {
                                                    alt9 = 39;}
                                            }
                                            else 
                                            {
                                                alt9 = 39;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                        }
                        break;
                    case 'c':
                    	{
                        int LA9_96 = input.LA(5);
                        
                        if ( (LA9_96 == 'a') )
                        {
                            int LA9_125 = input.LA(6);
                            
                            if ( (LA9_125 == 'p') )
                            {
                                int LA9_154 = input.LA(7);
                                
                                if ( (LA9_154 == 't') )
                                {
                                    int LA9_181 = input.LA(8);
                                    
                                    if ( (LA9_181 == 'i') )
                                    {
                                        int LA9_202 = input.LA(9);
                                        
                                        if ( (LA9_202 == 'o') )
                                        {
                                            int LA9_216 = input.LA(10);
                                            
                                            if ( (LA9_216 == 'n') )
                                            {
                                                int LA9_227 = input.LA(11);
                                                
                                                if ( (LA9_227 == '!' || (LA9_227 >= '$' && LA9_227 <= '&') || (LA9_227 >= '*' && LA9_227 <= '+') || (LA9_227 >= '-' && LA9_227 <= ':') || (LA9_227 >= '<' && LA9_227 <= 'Z') || (LA9_227 >= '^' && LA9_227 <= '_') || (LA9_227 >= 'a' && LA9_227 <= 'z') || LA9_227 == '~') )
                                                {
                                                    alt9 = 39;
                                                }
                                                else 
                                                {
                                                    alt9 = 31;}
                                            }
                                            else 
                                            {
                                                alt9 = 39;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                        }
                        break;
                    	default:
                        	alt9 = 39;
                        	break;}
                
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            case 'e':
            	{
                int LA9_40 = input.LA(3);
                
                if ( (LA9_40 == 'w') )
                {
                    int LA9_68 = input.LA(4);
                    
                    if ( (LA9_68 == '!' || (LA9_68 >= '$' && LA9_68 <= '&') || (LA9_68 >= '*' && LA9_68 <= '+') || (LA9_68 >= '-' && LA9_68 <= ':') || (LA9_68 >= '<' && LA9_68 <= 'Z') || (LA9_68 >= '^' && LA9_68 <= '_') || (LA9_68 >= 'a' && LA9_68 <= 'z') || LA9_68 == '~') )
                    {
                        alt9 = 39;
                    }
                    else 
                    {
                        alt9 = 3;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            case 'u':
            	{
                int LA9_41 = input.LA(3);
                
                if ( (LA9_41 == 'l') )
                {
                    int LA9_69 = input.LA(4);
                    
                    if ( (LA9_69 == 'l') )
                    {
                        int LA9_98 = input.LA(5);
                        
                        if ( (LA9_98 == '!' || (LA9_98 >= '$' && LA9_98 <= '&') || (LA9_98 >= '*' && LA9_98 <= '+') || (LA9_98 >= '-' && LA9_98 <= ':') || (LA9_98 >= '<' && LA9_98 <= 'Z') || (LA9_98 >= '^' && LA9_98 <= '_') || (LA9_98 >= 'a' && LA9_98 <= 'z') || LA9_98 == '~') )
                        {
                            alt9 = 39;
                        }
                        else 
                        {
                            alt9 = 29;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            	default:
                	alt9 = 39;
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
                    int LA9_70 = input.LA(4);
                    
                    if ( (LA9_70 == 'a') )
                    {
                        int LA9_99 = input.LA(5);
                        
                        if ( (LA9_99 == 't') )
                        {
                            int LA9_127 = input.LA(6);
                            
                            if ( (LA9_127 == '!' || (LA9_127 >= '$' && LA9_127 <= '&') || (LA9_127 >= '*' && LA9_127 <= '+') || (LA9_127 >= '-' && LA9_127 <= ':') || (LA9_127 >= '<' && LA9_127 <= 'Z') || (LA9_127 >= '^' && LA9_127 <= '_') || (LA9_127 >= 'a' && LA9_127 <= 'z') || LA9_127 == '~') )
                            {
                                alt9 = 39;
                            }
                            else 
                            {
                                alt9 = 35;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            case 'r':
            	{
                int LA9_43 = input.LA(3);
                
                if ( (LA9_43 == 'a') )
                {
                    int LA9_71 = input.LA(4);
                    
                    if ( (LA9_71 == 'm') )
                    {
                        int LA9_100 = input.LA(5);
                        
                        if ( (LA9_100 == 'e') )
                        {
                            int LA9_128 = input.LA(6);
                            
                            if ( (LA9_128 == '%') )
                            {
                                int LA9_156 = input.LA(7);
                                
                                if ( (LA9_156 == '!' || (LA9_156 >= '$' && LA9_156 <= '&') || (LA9_156 >= '*' && LA9_156 <= '+') || (LA9_156 >= '-' && LA9_156 <= ':') || (LA9_156 >= '<' && LA9_156 <= 'Z') || (LA9_156 >= '^' && LA9_156 <= '_') || (LA9_156 >= 'a' && LA9_156 <= 'z') || LA9_156 == '~') )
                                {
                                    alt9 = 39;
                                }
                                else 
                                {
                                    alt9 = 4;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            	default:
                	alt9 = 39;
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
                    int LA9_72 = input.LA(4);
                    
                    if ( (LA9_72 == 't') )
                    {
                        int LA9_101 = input.LA(5);
                        
                        if ( (LA9_101 == 'o') )
                        {
                            int LA9_129 = input.LA(6);
                            
                            if ( (LA9_129 == 'n') )
                            {
                                int LA9_157 = input.LA(7);
                                
                                if ( (LA9_157 == '%') )
                                {
                                    int LA9_183 = input.LA(8);
                                    
                                    if ( (LA9_183 == '!' || (LA9_183 >= '$' && LA9_183 <= '&') || (LA9_183 >= '*' && LA9_183 <= '+') || (LA9_183 >= '-' && LA9_183 <= ':') || (LA9_183 >= '<' && LA9_183 <= 'Z') || (LA9_183 >= '^' && LA9_183 <= '_') || (LA9_183 >= 'a' && LA9_183 <= 'z') || LA9_183 == '~') )
                                    {
                                        alt9 = 39;
                                    }
                                    else 
                                    {
                                        alt9 = 5;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            case 'o':
            	{
                switch ( input.LA(3) ) 
                {
                case 'r':
                	{
                    int LA9_73 = input.LA(4);
                    
                    if ( (LA9_73 == 'd') )
                    {
                        int LA9_102 = input.LA(5);
                        
                        if ( (LA9_102 == 'e') )
                        {
                            int LA9_130 = input.LA(6);
                            
                            if ( (LA9_130 == 'r') )
                            {
                                int LA9_158 = input.LA(7);
                                
                                if ( (LA9_158 == '!' || (LA9_158 >= '$' && LA9_158 <= '&') || (LA9_158 >= '*' && LA9_158 <= '+') || (LA9_158 >= '-' && LA9_158 <= ':') || (LA9_158 >= '<' && LA9_158 <= 'Z') || (LA9_158 >= '^' && LA9_158 <= '_') || (LA9_158 >= 'a' && LA9_158 <= 'z') || LA9_158 == '~') )
                                {
                                    alt9 = 39;
                                }
                                else 
                                {
                                    alt9 = 11;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                    }
                    break;
                case 't':
                	{
                    int LA9_74 = input.LA(4);
                    
                    if ( (LA9_74 == 't') )
                    {
                        int LA9_103 = input.LA(5);
                        
                        if ( (LA9_103 == 'o') )
                        {
                            int LA9_131 = input.LA(6);
                            
                            if ( (LA9_131 == 'm') )
                            {
                                int LA9_159 = input.LA(7);
                                
                                if ( (LA9_159 == '!' || (LA9_159 >= '$' && LA9_159 <= '&') || (LA9_159 >= '*' && LA9_159 <= '+') || (LA9_159 >= '-' && LA9_159 <= ':') || (LA9_159 >= '<' && LA9_159 <= 'Z') || (LA9_159 >= '^' && LA9_159 <= '_') || (LA9_159 >= 'a' && LA9_159 <= 'z') || LA9_159 == '~') )
                                {
                                    alt9 = 39;
                                }
                                else 
                                {
                                    alt9 = 26;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                    }
                    break;
                	default:
                    	alt9 = 39;
                    	break;}
            
                }
                break;
            	default:
                	alt9 = 39;
                	break;}
        
            }
            break;
        case 'p':
        	{
            int LA9_6 = input.LA(2);
            
            if ( (LA9_6 == 'a') )
            {
                int LA9_46 = input.LA(3);
                
                if ( (LA9_46 == 'r') )
                {
                    int LA9_75 = input.LA(4);
                    
                    if ( (LA9_75 == 'e') )
                    {
                        int LA9_104 = input.LA(5);
                        
                        if ( (LA9_104 == 'n') )
                        {
                            int LA9_132 = input.LA(6);
                            
                            if ( (LA9_132 == 't') )
                            {
                                int LA9_160 = input.LA(7);
                                
                                if ( (LA9_160 == '!' || (LA9_160 >= '$' && LA9_160 <= '&') || (LA9_160 >= '*' && LA9_160 <= '+') || (LA9_160 >= '-' && LA9_160 <= ':') || (LA9_160 >= '<' && LA9_160 <= 'Z') || (LA9_160 >= '^' && LA9_160 <= '_') || (LA9_160 >= 'a' && LA9_160 <= 'z') || LA9_160 == '~') )
                                {
                                    alt9 = 39;
                                }
                                else 
                                {
                                    alt9 = 6;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
            }
            else 
            {
                alt9 = 39;}
            }
            break;
        case 'l':
        	{
            switch ( input.LA(2) ) 
            {
            case 'a':
            	{
                int LA9_47 = input.LA(3);
                
                if ( (LA9_47 == 'b') )
                {
                    int LA9_76 = input.LA(4);
                    
                    if ( (LA9_76 == 'e') )
                    {
                        int LA9_105 = input.LA(5);
                        
                        if ( (LA9_105 == 'l') )
                        {
                            int LA9_133 = input.LA(6);
                            
                            if ( (LA9_133 == '!' || (LA9_133 >= '$' && LA9_133 <= '&') || (LA9_133 >= '*' && LA9_133 <= '+') || (LA9_133 >= '-' && LA9_133 <= ':') || (LA9_133 >= '<' && LA9_133 <= 'Z') || (LA9_133 >= '^' && LA9_133 <= '_') || (LA9_133 >= 'a' && LA9_133 <= 'z') || LA9_133 == '~') )
                            {
                                alt9 = 39;
                            }
                            else 
                            {
                                alt9 = 7;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            case 'e':
            	{
                int LA9_48 = input.LA(3);
                
                if ( (LA9_48 == 'f') )
                {
                    int LA9_77 = input.LA(4);
                    
                    if ( (LA9_77 == 't') )
                    {
                        int LA9_106 = input.LA(5);
                        
                        if ( (LA9_106 == '!' || (LA9_106 >= '$' && LA9_106 <= '&') || (LA9_106 >= '*' && LA9_106 <= '+') || (LA9_106 >= '-' && LA9_106 <= ':') || (LA9_106 >= '<' && LA9_106 <= 'Z') || (LA9_106 >= '^' && LA9_106 <= '_') || (LA9_106 >= 'a' && LA9_106 <= 'z') || LA9_106 == '~') )
                        {
                            alt9 = 39;
                        }
                        else 
                        {
                            alt9 = 27;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            	default:
                	alt9 = 39;
                	break;}
        
            }
            break;
        case 'w':
        	{
            int LA9_8 = input.LA(2);
            
            if ( (LA9_8 == 'i') )
            {
                int LA9_49 = input.LA(3);
                
                if ( (LA9_49 == 'd') )
                {
                    int LA9_78 = input.LA(4);
                    
                    if ( (LA9_78 == 't') )
                    {
                        int LA9_107 = input.LA(5);
                        
                        if ( (LA9_107 == 'h') )
                        {
                            int LA9_135 = input.LA(6);
                            
                            if ( (LA9_135 == '!' || (LA9_135 >= '$' && LA9_135 <= '&') || (LA9_135 >= '*' && LA9_135 <= '+') || (LA9_135 >= '-' && LA9_135 <= ':') || (LA9_135 >= '<' && LA9_135 <= 'Z') || (LA9_135 >= '^' && LA9_135 <= '_') || (LA9_135 >= 'a' && LA9_135 <= 'z') || LA9_135 == '~') )
                            {
                                alt9 = 39;
                            }
                            else 
                            {
                                alt9 = 8;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
            }
            else 
            {
                alt9 = 39;}
            }
            break;
        case 'h':
        	{
            switch ( input.LA(2) ) 
            {
            case 'e':
            	{
                int LA9_50 = input.LA(3);
                
                if ( (LA9_50 == 'i') )
                {
                    int LA9_79 = input.LA(4);
                    
                    if ( (LA9_79 == 'g') )
                    {
                        int LA9_108 = input.LA(5);
                        
                        if ( (LA9_108 == 'h') )
                        {
                            int LA9_136 = input.LA(6);
                            
                            if ( (LA9_136 == 't') )
                            {
                                int LA9_163 = input.LA(7);
                                
                                if ( (LA9_163 == '!' || (LA9_163 >= '$' && LA9_163 <= '&') || (LA9_163 >= '*' && LA9_163 <= '+') || (LA9_163 >= '-' && LA9_163 <= ':') || (LA9_163 >= '<' && LA9_163 <= 'Z') || (LA9_163 >= '^' && LA9_163 <= '_') || (LA9_163 >= 'a' && LA9_163 <= 'z') || LA9_163 == '~') )
                                {
                                    alt9 = 39;
                                }
                                else 
                                {
                                    alt9 = 9;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            case 'o':
            	{
                int LA9_51 = input.LA(3);
                
                if ( (LA9_51 == 'r') )
                {
                    int LA9_80 = input.LA(4);
                    
                    if ( (LA9_80 == 'i') )
                    {
                        int LA9_109 = input.LA(5);
                        
                        if ( (LA9_109 == 'z') )
                        {
                            int LA9_137 = input.LA(6);
                            
                            if ( (LA9_137 == '-') )
                            {
                                int LA9_164 = input.LA(7);
                                
                                if ( (LA9_164 == 'm') )
                                {
                                    int LA9_188 = input.LA(8);
                                    
                                    if ( (LA9_188 == 'a') )
                                    {
                                        int LA9_204 = input.LA(9);
                                        
                                        if ( (LA9_204 == 'r') )
                                        {
                                            int LA9_217 = input.LA(10);
                                            
                                            if ( (LA9_217 == 'g') )
                                            {
                                                int LA9_228 = input.LA(11);
                                                
                                                if ( (LA9_228 == 'i') )
                                                {
                                                    int LA9_239 = input.LA(12);
                                                    
                                                    if ( (LA9_239 == 'n') )
                                                    {
                                                        int LA9_246 = input.LA(13);
                                                        
                                                        if ( (LA9_246 == '!' || (LA9_246 >= '$' && LA9_246 <= '&') || (LA9_246 >= '*' && LA9_246 <= '+') || (LA9_246 >= '-' && LA9_246 <= ':') || (LA9_246 >= '<' && LA9_246 <= 'Z') || (LA9_246 >= '^' && LA9_246 <= '_') || (LA9_246 >= 'a' && LA9_246 <= 'z') || LA9_246 == '~') )
                                                        {
                                                            alt9 = 39;
                                                        }
                                                        else 
                                                        {
                                                            alt9 = 19;}
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 39;}
                                                }
                                                else 
                                                {
                                                    alt9 = 39;}
                                            }
                                            else 
                                            {
                                                alt9 = 39;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            	default:
                	alt9 = 39;
                	break;}
        
            }
            break;
        case 'e':
        	{
            int LA9_10 = input.LA(2);
            
            if ( (LA9_10 == 'n') )
            {
                int LA9_52 = input.LA(3);
                
                if ( (LA9_52 == 'a') )
                {
                    int LA9_81 = input.LA(4);
                    
                    if ( (LA9_81 == 'b') )
                    {
                        int LA9_110 = input.LA(5);
                        
                        if ( (LA9_110 == 'l') )
                        {
                            int LA9_138 = input.LA(6);
                            
                            if ( (LA9_138 == 'e') )
                            {
                                int LA9_165 = input.LA(7);
                                
                                if ( (LA9_165 == 'd') )
                                {
                                    int LA9_189 = input.LA(8);
                                    
                                    if ( (LA9_189 == '!' || (LA9_189 >= '$' && LA9_189 <= '&') || (LA9_189 >= '*' && LA9_189 <= '+') || (LA9_189 >= '-' && LA9_189 <= ':') || (LA9_189 >= '<' && LA9_189 <= 'Z') || (LA9_189 >= '^' && LA9_189 <= '_') || (LA9_189 >= 'a' && LA9_189 <= 'z') || LA9_189 == '~') )
                                    {
                                        alt9 = 39;
                                    }
                                    else 
                                    {
                                        alt9 = 10;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
            }
            else 
            {
                alt9 = 39;}
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
                case 'y':
                	{
                    int LA9_82 = input.LA(4);
                    
                    if ( (LA9_82 == 'l') )
                    {
                        int LA9_111 = input.LA(5);
                        
                        if ( (LA9_111 == 'e') )
                        {
                            int LA9_139 = input.LA(6);
                            
                            if ( (LA9_139 == '!' || (LA9_139 >= '$' && LA9_139 <= '&') || (LA9_139 >= '*' && LA9_139 <= '+') || (LA9_139 >= '-' && LA9_139 <= ':') || (LA9_139 >= '<' && LA9_139 <= 'Z') || (LA9_139 >= '^' && LA9_139 <= '_') || (LA9_139 >= 'a' && LA9_139 <= 'z') || LA9_139 == '~') )
                            {
                                alt9 = 39;
                            }
                            else 
                            {
                                alt9 = 36;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                    }
                    break;
                case 'r':
                	{
                    int LA9_83 = input.LA(4);
                    
                    if ( (LA9_83 == 'e') )
                    {
                        int LA9_112 = input.LA(5);
                        
                        if ( (LA9_112 == 't') )
                        {
                            int LA9_140 = input.LA(6);
                            
                            if ( (LA9_140 == 'c') )
                            {
                                int LA9_167 = input.LA(7);
                                
                                if ( (LA9_167 == 'h') )
                                {
                                    int LA9_190 = input.LA(8);
                                    
                                    if ( (LA9_190 == 'a') )
                                    {
                                        int LA9_206 = input.LA(9);
                                        
                                        if ( (LA9_206 == 'b') )
                                        {
                                            int LA9_218 = input.LA(10);
                                            
                                            if ( (LA9_218 == 'l') )
                                            {
                                                int LA9_229 = input.LA(11);
                                                
                                                if ( (LA9_229 == 'e') )
                                                {
                                                    int LA9_240 = input.LA(12);
                                                    
                                                    if ( (LA9_240 == '-') )
                                                    {
                                                        switch ( input.LA(13) ) 
                                                        {
                                                        case 'w':
                                                        	{
                                                            int LA9_252 = input.LA(14);
                                                            
                                                            if ( (LA9_252 == 'i') )
                                                            {
                                                                int LA9_256 = input.LA(15);
                                                                
                                                                if ( (LA9_256 == 'd') )
                                                                {
                                                                    int LA9_260 = input.LA(16);
                                                                    
                                                                    if ( (LA9_260 == 't') )
                                                                    {
                                                                        int LA9_263 = input.LA(17);
                                                                        
                                                                        if ( (LA9_263 == 'h') )
                                                                        {
                                                                            int LA9_266 = input.LA(18);
                                                                            
                                                                            if ( (LA9_266 == '!' || (LA9_266 >= '$' && LA9_266 <= '&') || (LA9_266 >= '*' && LA9_266 <= '+') || (LA9_266 >= '-' && LA9_266 <= ':') || (LA9_266 >= '<' && LA9_266 <= 'Z') || (LA9_266 >= '^' && LA9_266 <= '_') || (LA9_266 >= 'a' && LA9_266 <= 'z') || LA9_266 == '~') )
                                                                            {
                                                                                alt9 = 39;
                                                                            }
                                                                            else 
                                                                            {
                                                                                alt9 = 16;}
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt9 = 39;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 39;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 39;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 39;}
                                                            }
                                                            break;
                                                        case 'h':
                                                        	{
                                                            int LA9_253 = input.LA(14);
                                                            
                                                            if ( (LA9_253 == 'e') )
                                                            {
                                                                int LA9_257 = input.LA(15);
                                                                
                                                                if ( (LA9_257 == 'i') )
                                                                {
                                                                    int LA9_261 = input.LA(16);
                                                                    
                                                                    if ( (LA9_261 == 'g') )
                                                                    {
                                                                        int LA9_264 = input.LA(17);
                                                                        
                                                                        if ( (LA9_264 == 'h') )
                                                                        {
                                                                            int LA9_267 = input.LA(18);
                                                                            
                                                                            if ( (LA9_267 == 't') )
                                                                            {
                                                                                int LA9_269 = input.LA(19);
                                                                                
                                                                                if ( (LA9_269 == '!' || (LA9_269 >= '$' && LA9_269 <= '&') || (LA9_269 >= '*' && LA9_269 <= '+') || (LA9_269 >= '-' && LA9_269 <= ':') || (LA9_269 >= '<' && LA9_269 <= 'Z') || (LA9_269 >= '^' && LA9_269 <= '_') || (LA9_269 >= 'a' && LA9_269 <= 'z') || LA9_269 == '~') )
                                                                                {
                                                                                    alt9 = 39;
                                                                                }
                                                                                else 
                                                                                {
                                                                                    alt9 = 17;}
                                                                            }
                                                                            else 
                                                                            {
                                                                                alt9 = 39;}
                                                                        }
                                                                        else 
                                                                        {
                                                                            alt9 = 39;}
                                                                    }
                                                                    else 
                                                                    {
                                                                        alt9 = 39;}
                                                                }
                                                                else 
                                                                {
                                                                    alt9 = 39;}
                                                            }
                                                            else 
                                                            {
                                                                alt9 = 39;}
                                                            }
                                                            break;
                                                        	default:
                                                            	alt9 = 39;
                                                            	break;}
                                                    
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 39;}
                                                }
                                                else 
                                                {
                                                    alt9 = 39;}
                                            }
                                            else 
                                            {
                                                alt9 = 39;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                    }
                    break;
                	default:
                    	alt9 = 39;
                    	break;}
            
                }
                break;
            case 'p':
            	{
                int LA9_54 = input.LA(3);
                
                if ( (LA9_54 == 'a') )
                {
                    int LA9_84 = input.LA(4);
                    
                    if ( (LA9_84 == 'c') )
                    {
                        int LA9_113 = input.LA(5);
                        
                        if ( (LA9_113 == 'i') )
                        {
                            int LA9_141 = input.LA(6);
                            
                            if ( (LA9_141 == 'n') )
                            {
                                int LA9_168 = input.LA(7);
                                
                                if ( (LA9_168 == 'g') )
                                {
                                    int LA9_191 = input.LA(8);
                                    
                                    if ( (LA9_191 == '!' || (LA9_191 >= '$' && LA9_191 <= '&') || (LA9_191 >= '*' && LA9_191 <= '+') || (LA9_191 >= '-' && LA9_191 <= ':') || (LA9_191 >= '<' && LA9_191 <= 'Z') || (LA9_191 >= '^' && LA9_191 <= '_') || (LA9_191 >= 'a' && LA9_191 <= 'z') || LA9_191 == '~') )
                                    {
                                        alt9 = 39;
                                    }
                                    else 
                                    {
                                        alt9 = 12;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            	default:
                	alt9 = 39;
                	break;}
        
            }
            break;
        case 'a':
        	{
            int LA9_12 = input.LA(2);
            
            if ( (LA9_12 == 'l') )
            {
                int LA9_55 = input.LA(3);
                
                if ( (LA9_55 == 'i') )
                {
                    int LA9_85 = input.LA(4);
                    
                    if ( (LA9_85 == 'g') )
                    {
                        int LA9_114 = input.LA(5);
                        
                        if ( (LA9_114 == 'n') )
                        {
                            int LA9_142 = input.LA(6);
                            
                            if ( (LA9_142 == 'm') )
                            {
                                int LA9_169 = input.LA(7);
                                
                                if ( (LA9_169 == 'e') )
                                {
                                    int LA9_192 = input.LA(8);
                                    
                                    if ( (LA9_192 == 'n') )
                                    {
                                        int LA9_208 = input.LA(9);
                                        
                                        if ( (LA9_208 == 't') )
                                        {
                                            int LA9_219 = input.LA(10);
                                            
                                            if ( (LA9_219 == '!' || (LA9_219 >= '$' && LA9_219 <= '&') || (LA9_219 >= '*' && LA9_219 <= '+') || (LA9_219 >= '-' && LA9_219 <= ':') || (LA9_219 >= '<' && LA9_219 <= 'Z') || (LA9_219 >= '^' && LA9_219 <= '_') || (LA9_219 >= 'a' && LA9_219 <= 'z') || LA9_219 == '~') )
                                            {
                                                alt9 = 39;
                                            }
                                            else 
                                            {
                                                alt9 = 13;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
            }
            else 
            {
                alt9 = 39;}
            }
            break;
        case 'm':
        	{
            switch ( input.LA(2) ) 
            {
            case 'd':
            	{
                int LA9_56 = input.LA(3);
                
                if ( (LA9_56 == 'i') )
                {
                    int LA9_86 = input.LA(4);
                    
                    if ( (LA9_86 == '-') )
                    {
                        switch ( input.LA(5) ) 
                        {
                        case 'p':
                        	{
                            int LA9_143 = input.LA(6);
                            
                            if ( (LA9_143 == 'a') )
                            {
                                int LA9_170 = input.LA(7);
                                
                                if ( (LA9_170 == 'r') )
                                {
                                    int LA9_193 = input.LA(8);
                                    
                                    if ( (LA9_193 == 'e') )
                                    {
                                        int LA9_209 = input.LA(9);
                                        
                                        if ( (LA9_209 == 'n') )
                                        {
                                            int LA9_220 = input.LA(10);
                                            
                                            if ( (LA9_220 == 't') )
                                            {
                                                int LA9_231 = input.LA(11);
                                                
                                                if ( (LA9_231 == '!' || (LA9_231 >= '$' && LA9_231 <= '&') || (LA9_231 >= '*' && LA9_231 <= '+') || (LA9_231 >= '-' && LA9_231 <= ':') || (LA9_231 >= '<' && LA9_231 <= 'Z') || (LA9_231 >= '^' && LA9_231 <= '_') || (LA9_231 >= 'a' && LA9_231 <= 'z') || LA9_231 == '~') )
                                                {
                                                    alt9 = 39;
                                                }
                                                else 
                                                {
                                                    alt9 = 33;}
                                            }
                                            else 
                                            {
                                                alt9 = 39;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                            }
                            break;
                        case 'c':
                        	{
                            int LA9_144 = input.LA(6);
                            
                            if ( (LA9_144 == 'h') )
                            {
                                int LA9_171 = input.LA(7);
                                
                                if ( (LA9_171 == 'i') )
                                {
                                    int LA9_194 = input.LA(8);
                                    
                                    if ( (LA9_194 == 'l') )
                                    {
                                        int LA9_210 = input.LA(9);
                                        
                                        if ( (LA9_210 == 'd') )
                                        {
                                            int LA9_221 = input.LA(10);
                                            
                                            if ( (LA9_221 == '!' || (LA9_221 >= '$' && LA9_221 <= '&') || (LA9_221 >= '*' && LA9_221 <= '+') || (LA9_221 >= '-' && LA9_221 <= ':') || (LA9_221 >= '<' && LA9_221 <= 'Z') || (LA9_221 >= '^' && LA9_221 <= '_') || (LA9_221 >= 'a' && LA9_221 <= 'z') || LA9_221 == '~') )
                                            {
                                                alt9 = 39;
                                            }
                                            else 
                                            {
                                                alt9 = 34;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                            }
                            break;
                        	default:
                            	alt9 = 39;
                            	break;}
                    
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            case 'i':
            	{
                int LA9_57 = input.LA(3);
                
                if ( (LA9_57 == 'n') )
                {
                    int LA9_87 = input.LA(4);
                    
                    if ( (LA9_87 == '-') )
                    {
                        switch ( input.LA(5) ) 
                        {
                        case 'h':
                        	{
                            int LA9_145 = input.LA(6);
                            
                            if ( (LA9_145 == 'e') )
                            {
                                int LA9_172 = input.LA(7);
                                
                                if ( (LA9_172 == 'i') )
                                {
                                    int LA9_195 = input.LA(8);
                                    
                                    if ( (LA9_195 == 'g') )
                                    {
                                        int LA9_211 = input.LA(9);
                                        
                                        if ( (LA9_211 == 'h') )
                                        {
                                            int LA9_222 = input.LA(10);
                                            
                                            if ( (LA9_222 == 't') )
                                            {
                                                int LA9_233 = input.LA(11);
                                                
                                                if ( (LA9_233 == '!' || (LA9_233 >= '$' && LA9_233 <= '&') || (LA9_233 >= '*' && LA9_233 <= '+') || (LA9_233 >= '-' && LA9_233 <= ':') || (LA9_233 >= '<' && LA9_233 <= 'Z') || (LA9_233 >= '^' && LA9_233 <= '_') || (LA9_233 >= 'a' && LA9_233 <= 'z') || LA9_233 == '~') )
                                                {
                                                    alt9 = 39;
                                                }
                                                else 
                                                {
                                                    alt9 = 15;}
                                            }
                                            else 
                                            {
                                                alt9 = 39;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                            }
                            break;
                        case 'w':
                        	{
                            int LA9_146 = input.LA(6);
                            
                            if ( (LA9_146 == 'i') )
                            {
                                int LA9_173 = input.LA(7);
                                
                                if ( (LA9_173 == 'd') )
                                {
                                    int LA9_196 = input.LA(8);
                                    
                                    if ( (LA9_196 == 't') )
                                    {
                                        int LA9_212 = input.LA(9);
                                        
                                        if ( (LA9_212 == 'h') )
                                        {
                                            int LA9_223 = input.LA(10);
                                            
                                            if ( (LA9_223 == '!' || (LA9_223 >= '$' && LA9_223 <= '&') || (LA9_223 >= '*' && LA9_223 <= '+') || (LA9_223 >= '-' && LA9_223 <= ':') || (LA9_223 >= '<' && LA9_223 <= 'Z') || (LA9_223 >= '^' && LA9_223 <= '_') || (LA9_223 >= 'a' && LA9_223 <= 'z') || LA9_223 == '~') )
                                            {
                                                alt9 = 39;
                                            }
                                            else 
                                            {
                                                alt9 = 14;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                            }
                            break;
                        	default:
                            	alt9 = 39;
                            	break;}
                    
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
                }
                break;
            	default:
                	alt9 = 39;
                	break;}
        
            }
            break;
        case 'v':
        	{
            int LA9_14 = input.LA(2);
            
            if ( (LA9_14 == 'e') )
            {
                int LA9_58 = input.LA(3);
                
                if ( (LA9_58 == 'r') )
                {
                    int LA9_88 = input.LA(4);
                    
                    if ( (LA9_88 == 't') )
                    {
                        int LA9_117 = input.LA(5);
                        
                        if ( (LA9_117 == '-') )
                        {
                            int LA9_147 = input.LA(6);
                            
                            if ( (LA9_147 == 'm') )
                            {
                                int LA9_174 = input.LA(7);
                                
                                if ( (LA9_174 == 'a') )
                                {
                                    int LA9_197 = input.LA(8);
                                    
                                    if ( (LA9_197 == 'r') )
                                    {
                                        int LA9_213 = input.LA(9);
                                        
                                        if ( (LA9_213 == 'g') )
                                        {
                                            int LA9_224 = input.LA(10);
                                            
                                            if ( (LA9_224 == 'i') )
                                            {
                                                int LA9_235 = input.LA(11);
                                                
                                                if ( (LA9_235 == 'n') )
                                                {
                                                    int LA9_243 = input.LA(12);
                                                    
                                                    if ( (LA9_243 == '!' || (LA9_243 >= '$' && LA9_243 <= '&') || (LA9_243 >= '*' && LA9_243 <= '+') || (LA9_243 >= '-' && LA9_243 <= ':') || (LA9_243 >= '<' && LA9_243 <= 'Z') || (LA9_243 >= '^' && LA9_243 <= '_') || (LA9_243 >= 'a' && LA9_243 <= 'z') || LA9_243 == '~') )
                                                    {
                                                        alt9 = 39;
                                                    }
                                                    else 
                                                    {
                                                        alt9 = 18;}
                                                }
                                                else 
                                                {
                                                    alt9 = 39;}
                                            }
                                            else 
                                            {
                                                alt9 = 39;}
                                        }
                                        else 
                                        {
                                            alt9 = 39;}
                                    }
                                    else 
                                    {
                                        alt9 = 39;}
                                }
                                else 
                                {
                                    alt9 = 39;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
            }
            else 
            {
                alt9 = 39;}
            }
            break;
        case '(':
        	{
            alt9 = 20;
            }
            break;
        case ')':
        	{
            alt9 = 21;
            }
            break;
        case '#':
        	{
            int LA9_17 = input.LA(2);
            
            if ( (LA9_17 == 't') )
            {
                alt9 = 23;
            }
            else if ( (LA9_17 == 'f') )
            {
                alt9 = 22;
            }
            else 
            {
                NoViableAltException nvae_d9s17 =
                    new NoViableAltException("1:1: Tokens : ( SEMI | DEFINE | NEW | FRAME | BUTTON | PARENT | LABEL | WIDTH | HEIGHT | ENABLED | BORDER | SPACING | ALIGNMENT | MIN_WIDTH | MIN_HEIGHT | STRETCH_WIDTH | STRETCH_HEIGHT | VERT_MARGIN | HORIZ_MARGIN | LP | RP | FALSE | TRUE | TOP | CENTER | BOTTOM | LEFT | RIGHT | NULL | NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT | STYLE | DELETED | WS | ID | NUMBER | NAME | NEWLINE | COMMENT | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | QUOTE );", 9, 17, input);
            
                throw nvae_d9s17;
            }
            }
            break;
        case 't':
        	{
            int LA9_18 = input.LA(2);
            
            if ( (LA9_18 == 'o') )
            {
                int LA9_61 = input.LA(3);
                
                if ( (LA9_61 == 'p') )
                {
                    int LA9_89 = input.LA(4);
                    
                    if ( (LA9_89 == '!' || (LA9_89 >= '$' && LA9_89 <= '&') || (LA9_89 >= '*' && LA9_89 <= '+') || (LA9_89 >= '-' && LA9_89 <= ':') || (LA9_89 >= '<' && LA9_89 <= 'Z') || (LA9_89 >= '^' && LA9_89 <= '_') || (LA9_89 >= 'a' && LA9_89 <= 'z') || LA9_89 == '~') )
                    {
                        alt9 = 39;
                    }
                    else 
                    {
                        alt9 = 24;}
                }
                else 
                {
                    alt9 = 39;}
            }
            else 
            {
                alt9 = 39;}
            }
            break;
        case 'c':
        	{
            int LA9_19 = input.LA(2);
            
            if ( (LA9_19 == 'e') )
            {
                int LA9_62 = input.LA(3);
                
                if ( (LA9_62 == 'n') )
                {
                    int LA9_90 = input.LA(4);
                    
                    if ( (LA9_90 == 't') )
                    {
                        int LA9_119 = input.LA(5);
                        
                        if ( (LA9_119 == 'e') )
                        {
                            int LA9_148 = input.LA(6);
                            
                            if ( (LA9_148 == 'r') )
                            {
                                int LA9_175 = input.LA(7);
                                
                                if ( (LA9_175 == '!' || (LA9_175 >= '$' && LA9_175 <= '&') || (LA9_175 >= '*' && LA9_175 <= '+') || (LA9_175 >= '-' && LA9_175 <= ':') || (LA9_175 >= '<' && LA9_175 <= 'Z') || (LA9_175 >= '^' && LA9_175 <= '_') || (LA9_175 >= 'a' && LA9_175 <= 'z') || LA9_175 == '~') )
                                {
                                    alt9 = 39;
                                }
                                else 
                                {
                                    alt9 = 25;}
                            }
                            else 
                            {
                                alt9 = 39;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
            }
            else 
            {
                alt9 = 39;}
            }
            break;
        case 'r':
        	{
            int LA9_20 = input.LA(2);
            
            if ( (LA9_20 == 'i') )
            {
                int LA9_63 = input.LA(3);
                
                if ( (LA9_63 == 'g') )
                {
                    int LA9_91 = input.LA(4);
                    
                    if ( (LA9_91 == 'h') )
                    {
                        int LA9_120 = input.LA(5);
                        
                        if ( (LA9_120 == 't') )
                        {
                            int LA9_149 = input.LA(6);
                            
                            if ( (LA9_149 == '!' || (LA9_149 >= '$' && LA9_149 <= '&') || (LA9_149 >= '*' && LA9_149 <= '+') || (LA9_149 >= '-' && LA9_149 <= ':') || (LA9_149 >= '<' && LA9_149 <= 'Z') || (LA9_149 >= '^' && LA9_149 <= '_') || (LA9_149 >= 'a' && LA9_149 <= 'z') || LA9_149 == '~') )
                            {
                                alt9 = 39;
                            }
                            else 
                            {
                                alt9 = 28;}
                        }
                        else 
                        {
                            alt9 = 39;}
                    }
                    else 
                    {
                        alt9 = 39;}
                }
                else 
                {
                    alt9 = 39;}
            }
            else 
            {
                alt9 = 39;}
            }
            break;
        case '\r':
        	{
            int LA9_21 = input.LA(2);
            
            if ( (LA9_21 == '\n') )
            {
                alt9 = 42;
            }
            else 
            {
                alt9 = 38;}
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
            alt9 = 39;
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
            alt9 = 40;
            }
            break;
        case '\"':
        	{
            alt9 = 41;
            }
            break;
        case '\n':
        	{
            alt9 = 38;
            }
            break;
        case '\t':
        case ' ':
        	{
            alt9 = 38;
            }
            break;
        case '+':
        	{
            alt9 = 44;
            }
            break;
        case '-':
        	{
            alt9 = 45;
            }
            break;
        case '*':
        	{
            alt9 = 46;
            }
            break;
        case '/':
        	{
            alt9 = 47;
            }
            break;
        case '.':
        	{
            alt9 = 48;
            }
            break;
        case '<':
        	{
            alt9 = 49;
            }
            break;
        case '>':
        	{
            alt9 = 50;
            }
            break;
        case '=':
        	{
            alt9 = 51;
            }
            break;
        case '\'':
        	{
            alt9 = 52;
            }
            break;
        	default:
        	    NoViableAltException nvae_d9s0 =
        	        new NoViableAltException("1:1: Tokens : ( SEMI | DEFINE | NEW | FRAME | BUTTON | PARENT | LABEL | WIDTH | HEIGHT | ENABLED | BORDER | SPACING | ALIGNMENT | MIN_WIDTH | MIN_HEIGHT | STRETCH_WIDTH | STRETCH_HEIGHT | VERT_MARGIN | HORIZ_MARGIN | LP | RP | FALSE | TRUE | TOP | CENTER | BOTTOM | LEFT | RIGHT | NULL | NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT | STYLE | DELETED | WS | ID | NUMBER | NAME | NEWLINE | COMMENT | PLUS | MINUS | STAR | SLASH | DOT | LT | GT | EQ | QUOTE );", 9, 0, input);
        
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
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:39: PARENT
                {
                	mPARENT(); 
                
                }
                break;
            case 7 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:46: LABEL
                {
                	mLABEL(); 
                
                }
                break;
            case 8 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:52: WIDTH
                {
                	mWIDTH(); 
                
                }
                break;
            case 9 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:58: HEIGHT
                {
                	mHEIGHT(); 
                
                }
                break;
            case 10 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:65: ENABLED
                {
                	mENABLED(); 
                
                }
                break;
            case 11 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:73: BORDER
                {
                	mBORDER(); 
                
                }
                break;
            case 12 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:80: SPACING
                {
                	mSPACING(); 
                
                }
                break;
            case 13 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:88: ALIGNMENT
                {
                	mALIGNMENT(); 
                
                }
                break;
            case 14 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:98: MIN_WIDTH
                {
                	mMIN_WIDTH(); 
                
                }
                break;
            case 15 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:108: MIN_HEIGHT
                {
                	mMIN_HEIGHT(); 
                
                }
                break;
            case 16 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:119: STRETCH_WIDTH
                {
                	mSTRETCH_WIDTH(); 
                
                }
                break;
            case 17 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:133: STRETCH_HEIGHT
                {
                	mSTRETCH_HEIGHT(); 
                
                }
                break;
            case 18 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:148: VERT_MARGIN
                {
                	mVERT_MARGIN(); 
                
                }
                break;
            case 19 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:160: HORIZ_MARGIN
                {
                	mHORIZ_MARGIN(); 
                
                }
                break;
            case 20 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:173: LP
                {
                	mLP(); 
                
                }
                break;
            case 21 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:176: RP
                {
                	mRP(); 
                
                }
                break;
            case 22 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:179: FALSE
                {
                	mFALSE(); 
                
                }
                break;
            case 23 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:185: TRUE
                {
                	mTRUE(); 
                
                }
                break;
            case 24 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:190: TOP
                {
                	mTOP(); 
                
                }
                break;
            case 25 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:194: CENTER
                {
                	mCENTER(); 
                
                }
                break;
            case 26 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:201: BOTTOM
                {
                	mBOTTOM(); 
                
                }
                break;
            case 27 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:208: LEFT
                {
                	mLEFT(); 
                
                }
                break;
            case 28 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:213: RIGHT
                {
                	mRIGHT(); 
                
                }
                break;
            case 29 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:219: NULL
                {
                	mNULL(); 
                
                }
                break;
            case 30 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:224: NO_RESIZE_BORDER
                {
                	mNO_RESIZE_BORDER(); 
                
                }
                break;
            case 31 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:241: NO_CAPTION
                {
                	mNO_CAPTION(); 
                
                }
                break;
            case 32 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:252: NO_SYSTEM_MENU
                {
                	mNO_SYSTEM_MENU(); 
                
                }
                break;
            case 33 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:267: MDI_PARENT
                {
                	mMDI_PARENT(); 
                
                }
                break;
            case 34 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:278: MDI_CHILD
                {
                	mMDI_CHILD(); 
                
                }
                break;
            case 35 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:288: FLOAT
                {
                	mFLOAT(); 
                
                }
                break;
            case 36 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:294: STYLE
                {
                	mSTYLE(); 
                
                }
                break;
            case 37 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:300: DELETED
                {
                	mDELETED(); 
                
                }
                break;
            case 38 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:308: WS
                {
                	mWS(); 
                
                }
                break;
            case 39 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:311: ID
                {
                	mID(); 
                
                }
                break;
            case 40 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:314: NUMBER
                {
                	mNUMBER(); 
                
                }
                break;
            case 41 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:321: NAME
                {
                	mNAME(); 
                
                }
                break;
            case 42 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:326: NEWLINE
                {
                	mNEWLINE(); 
                
                }
                break;
            case 43 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:334: COMMENT
                {
                	mCOMMENT(); 
                
                }
                break;
            case 44 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:342: PLUS
                {
                	mPLUS(); 
                
                }
                break;
            case 45 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:347: MINUS
                {
                	mMINUS(); 
                
                }
                break;
            case 46 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:353: STAR
                {
                	mSTAR(); 
                
                }
                break;
            case 47 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:358: SLASH
                {
                	mSLASH(); 
                
                }
                break;
            case 48 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:364: DOT
                {
                	mDOT(); 
                
                }
                break;
            case 49 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:368: LT
                {
                	mLT(); 
                
                }
                break;
            case 50 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:371: GT
                {
                	mGT(); 
                
                }
                break;
            case 51 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:374: EQ
                {
                	mEQ(); 
                
                }
                break;
            case 52 :
                // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:1:377: QUOTE
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