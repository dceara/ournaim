// $ANTLR 3.0.1 D:\\Projects\\AntlrTestApps\\ScmGrammar.g 2008-06-15 21:50:53
namespace 
	SchemeGuiEditor.ParserComponents

{

using SchemeGuiEditor.ToolboxControls;
using System.Drawing;
using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



public class ScmGrammarParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"SEMI", 
		"DEFINE", 
		"NEW", 
		"FRAME", 
		"BUTTON", 
		"MESSAGE", 
		"CHECKBOX", 
		"PARENT", 
		"LABEL", 
		"WIDTH", 
		"HEIGHT", 
		"ENABLED", 
		"BORDER", 
		"SPACING", 
		"ALIGNMENT", 
		"MIN_WIDTH", 
		"MIN_HEIGHT", 
		"STRETCH_WIDTH", 
		"STRETCH_HEIGHT", 
		"VERT_MARGIN", 
		"HORIZ_MARGIN", 
		"LP", 
		"RP", 
		"FALSE", 
		"TRUE", 
		"TOP", 
		"CENTER", 
		"BOTTOM", 
		"LEFT", 
		"RIGHT", 
		"NULL", 
		"NO_RESIZE_BORDER", 
		"NO_CAPTION", 
		"NO_SYSTEM_MENU", 
		"MDI_PARENT", 
		"MDI_CHILD", 
		"FLOAT", 
		"STYLE", 
		"DELETED", 
		"ID", 
		"NAME", 
		"NUMBER", 
		"QUOTE", 
		"PLUS", 
		"MINUS", 
		"STAR", 
		"SLASH", 
		"LT", 
		"GT", 
		"EQ", 
		"COMMENT", 
		"WS", 
		"CAR", 
		"DOT", 
		"DIGIT", 
		"LEAD_DIGIT", 
		"ZERO", 
		"NEWLINE"
    };

    public const int MDI_CHILD = 39;
    public const int LT = 51;
    public const int STAR = 49;
    public const int HORIZ_MARGIN = 24;
    public const int SPACING = 17;
    public const int STRETCH_WIDTH = 21;
    public const int RP = 26;
    public const int LEAD_DIGIT = 59;
    public const int STRETCH_HEIGHT = 22;
    public const int LP = 25;
    public const int NEW = 6;
    public const int BUTTON = 8;
    public const int FLOAT = 40;
    public const int ID = 43;
    public const int CAR = 56;
    public const int EOF = -1;
    public const int DEFINE = 5;
    public const int CENTER = 30;
    public const int ZERO = 60;
    public const int BORDER = 16;
    public const int MDI_PARENT = 38;
    public const int QUOTE = 46;
    public const int PARENT = 11;
    public const int MIN_HEIGHT = 20;
    public const int NAME = 44;
    public const int SLASH = 50;
    public const int ALIGNMENT = 18;
    public const int LEFT = 32;
    public const int ENABLED = 15;
    public const int MESSAGE = 9;
    public const int PLUS = 47;
    public const int DIGIT = 58;
    public const int EQ = 53;
    public const int DOT = 57;
    public const int COMMENT = 54;
    public const int NO_SYSTEM_MENU = 37;
    public const int NO_CAPTION = 36;
    public const int HEIGHT = 14;
    public const int NULL = 34;
    public const int CHECKBOX = 10;
    public const int NUMBER = 45;
    public const int RIGHT = 33;
    public const int MINUS = 48;
    public const int VERT_MARGIN = 23;
    public const int SEMI = 4;
    public const int TRUE = 28;
    public const int DELETED = 42;
    public const int NO_RESIZE_BORDER = 35;
    public const int WS = 55;
    public const int NEWLINE = 61;
    public const int LABEL = 12;
    public const int WIDTH = 13;
    public const int BOTTOM = 31;
    public const int STYLE = 41;
    public const int MIN_WIDTH = 19;
    public const int GT = 52;
    public const int FRAME = 7;
    public const int FALSE = 27;
    public const int TOP = 29;
    
    
        public ScmGrammarParser(ITokenStream input) 
    		: base(input)
    	{
    		InitializeCyclicDFAs();
        }
        

    override public string[] TokenNames
	{
		get { return tokenNames; }
	}

    override public string GrammarFileName
	{
		get { return "D:\\Projects\\AntlrTestApps\\ScmGrammar.g"; }
	}

    
    List<object> _parsedData = new List<object>();
    public List<object> ParsedData
    {
    	get
    	{
    		return _parsedData;
    	}
    }


    
    // $ANTLR start main
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:75:1: main : ( scmBlock )+ EOF ;
    public void main() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:75:5: ( ( scmBlock )+ EOF )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:75:7: ( scmBlock )+ EOF
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:75:7: ( scmBlock )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);
            	    
            	    if ( (LA1_0 == LP || (LA1_0 >= FALSE && LA1_0 <= TRUE) || LA1_0 == ID || (LA1_0 >= NUMBER && LA1_0 <= COMMENT)) )
            	    {
            	        alt1 = 1;
            	    }
            	    
            	
            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:75:7: scmBlock
            			    {
            			    	PushFollow(FOLLOW_scmBlock_in_main366);
            			    	scmBlock();
            			    	followingStackPointer_--;

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee =
            		                new EarlyExitException(1, input);
            		            throw eee;
            	    }
            	    cnt1++;
            	} while (true);
            	
            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements

            	Match(input,EOF,FOLLOW_EOF_in_main369); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end main

    
    // $ANTLR start scmBlock
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:77:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | com= comment | pe= parExpr );
    public void scmBlock() // throws RecognitionException [1]
    {   
        ScmFrameProperties frm = null;

        ScmButtonProperties btn = null;

        ScmMessageProperties msg = null;

        ScmCheckBoxProperties cbx = null;

        string com = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:78:2: (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | com= comment | pe= parExpr )
            int alt2 = 6;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                int LA2_1 = input.LA(2);
                
                if ( (LA2_1 == DEFINE) )
                {
                    int LA2_4 = input.LA(3);
                    
                    if ( (LA2_4 == ID) )
                    {
                        int LA2_5 = input.LA(4);
                        
                        if ( (LA2_5 == LP) )
                        {
                            int LA2_6 = input.LA(5);
                            
                            if ( (LA2_6 == NEW) )
                            {
                                switch ( input.LA(6) ) 
                                {
                                case BUTTON:
                                	{
                                    alt2 = 2;
                                    }
                                    break;
                                case FRAME:
                                	{
                                    alt2 = 1;
                                    }
                                    break;
                                case CHECKBOX:
                                	{
                                    alt2 = 4;
                                    }
                                    break;
                                case MESSAGE:
                                	{
                                    alt2 = 3;
                                    }
                                    break;
                                	default:
                                	    NoViableAltException nvae_d2s7 =
                                	        new NoViableAltException("77:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | com= comment | pe= parExpr );", 2, 7, input);
                                
                                	    throw nvae_d2s7;
                                }
                            
                            }
                            else 
                            {
                                NoViableAltException nvae_d2s6 =
                                    new NoViableAltException("77:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | com= comment | pe= parExpr );", 2, 6, input);
                            
                                throw nvae_d2s6;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d2s5 =
                                new NoViableAltException("77:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | com= comment | pe= parExpr );", 2, 5, input);
                        
                            throw nvae_d2s5;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d2s4 =
                            new NoViableAltException("77:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | com= comment | pe= parExpr );", 2, 4, input);
                    
                        throw nvae_d2s4;
                    }
                }
                else if ( (LA2_1 == LP || (LA2_1 >= FALSE && LA2_1 <= TRUE) || LA2_1 == ID || (LA2_1 >= NUMBER && LA2_1 <= EQ)) )
                {
                    alt2 = 6;
                }
                else 
                {
                    NoViableAltException nvae_d2s1 =
                        new NoViableAltException("77:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | com= comment | pe= parExpr );", 2, 1, input);
                
                    throw nvae_d2s1;
                }
                }
                break;
            case COMMENT:
            	{
                alt2 = 5;
                }
                break;
            case FALSE:
            case TRUE:
            case ID:
            case NUMBER:
            case QUOTE:
            case PLUS:
            case MINUS:
            case STAR:
            case SLASH:
            case LT:
            case GT:
            case EQ:
            	{
                alt2 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("77:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | com= comment | pe= parExpr );", 2, 0, input);
            
            	    throw nvae_d2s0;
            }
            
            switch (alt2) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:78:4: frm= scmFrm
                    {
                    	PushFollow(FOLLOW_scmFrm_in_scmBlock382);
                    	frm = scmFrm();
                    	followingStackPointer_--;

                    	_parsedData.Add(frm);
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:79:4: btn= scmBtn
                    {
                    	PushFollow(FOLLOW_scmBtn_in_scmBlock393);
                    	btn = scmBtn();
                    	followingStackPointer_--;

                    	_parsedData.Add(btn);
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:80:4: msg= scmMsg
                    {
                    	PushFollow(FOLLOW_scmMsg_in_scmBlock404);
                    	msg = scmMsg();
                    	followingStackPointer_--;

                    	_parsedData.Add(msg);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:81:4: cbx= scmCbx
                    {
                    	PushFollow(FOLLOW_scmCbx_in_scmBlock415);
                    	cbx = scmCbx();
                    	followingStackPointer_--;

                    	_parsedData.Add(cbx);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:82:4: com= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmBlock426);
                    	com = comment();
                    	followingStackPointer_--;

                    	_parsedData.Add(new ScmComment(com));
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:83:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmBlock437);
                    	pe = parExpr();
                    	followingStackPointer_--;

                    	_parsedData.Add(new ScmBlock(pe));
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmBlock

    
    // $ANTLR start scmFrm
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:85:1: scmFrm returns [ScmFrameProperties frmProp] : LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP ;
    public ScmFrameProperties scmFrm() // throws RecognitionException [1]
    {   

        ScmFrameProperties frmProp = null;
    
        IToken id = null;
    
        
        	ScmFrame frame = new ScmFrame();
        	frmProp =  frame.ScmPropertyObject as ScmFrameProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:91:2: ( LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:91:4: LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmFrm457); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmFrm459); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmFrm465); 
            	Match(input,LP,FOLLOW_LP_in_scmFrm467); 
            	Match(input,NEW,FOLLOW_NEW_in_scmFrm469); 
            	Match(input,FRAME,FOLLOW_FRAME_in_scmFrm471); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:91:35: ( scmFrmProp[$frmProp] )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);
            	    
            	    if ( (LA3_0 == LP || (LA3_0 >= FALSE && LA3_0 <= TRUE) || LA3_0 == ID || (LA3_0 >= NUMBER && LA3_0 <= COMMENT)) )
            	    {
            	        alt3 = 1;
            	    }
            	    
            	
            	    switch (alt3) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:91:35: scmFrmProp[$frmProp]
            			    {
            			    	PushFollow(FOLLOW_scmFrmProp_in_scmFrm473);
            			    	scmFrmProp(frmProp);
            			    	followingStackPointer_--;

            			    
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

            	Match(input,RP,FOLLOW_RP_in_scmFrm477); 
            	Match(input,RP,FOLLOW_RP_in_scmFrm479); 
            	frmProp.Name = id.Text;
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return frmProp;
    }
    // $ANTLR end scmFrm

    
    // $ANTLR start scmBtn
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:93:1: scmBtn returns [ScmButtonProperties btnProp] : LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP ;
    public ScmButtonProperties scmBtn() // throws RecognitionException [1]
    {   

        ScmButtonProperties btnProp = null;
    
        IToken id = null;
    
        
        	ScmButton btn = new ScmButton();
        	btnProp =  btn.ScmPropertyObject as ScmButtonProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:99:2: ( LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:99:4: LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBtn501); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmBtn503); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmBtn509); 
            	Match(input,LP,FOLLOW_LP_in_scmBtn511); 
            	Match(input,NEW,FOLLOW_NEW_in_scmBtn513); 
            	Match(input,BUTTON,FOLLOW_BUTTON_in_scmBtn515); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:99:36: ( scmBtnProp[$btnProp] )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);
            	    
            	    if ( (LA4_0 == LP || (LA4_0 >= FALSE && LA4_0 <= TRUE) || LA4_0 == ID || (LA4_0 >= NUMBER && LA4_0 <= COMMENT)) )
            	    {
            	        alt4 = 1;
            	    }
            	    
            	
            	    switch (alt4) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:99:36: scmBtnProp[$btnProp]
            			    {
            			    	PushFollow(FOLLOW_scmBtnProp_in_scmBtn517);
            			    	scmBtnProp(btnProp);
            			    	followingStackPointer_--;

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee =
            		                new EarlyExitException(4, input);
            		            throw eee;
            	    }
            	    cnt4++;
            	} while (true);
            	
            	loop4:
            		;	// Stops C# compiler whinging that label 'loop4' has no statements

            	Match(input,RP,FOLLOW_RP_in_scmBtn521); 
            	Match(input,RP,FOLLOW_RP_in_scmBtn523); 
            	btnProp.Name = id.Text;
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return btnProp;
    }
    // $ANTLR end scmBtn

    
    // $ANTLR start scmMsg
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:101:1: scmMsg returns [ScmMessageProperties msgProp] : LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP ;
    public ScmMessageProperties scmMsg() // throws RecognitionException [1]
    {   

        ScmMessageProperties msgProp = null;
    
        IToken id = null;
    
        
        	ScmMessage msg = new ScmMessage();
        	msgProp =  msg.ScmPropertyObject as ScmMessageProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:107:2: ( LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:107:4: LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMsg545); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmMsg547); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmMsg553); 
            	Match(input,LP,FOLLOW_LP_in_scmMsg555); 
            	Match(input,NEW,FOLLOW_NEW_in_scmMsg557); 
            	Match(input,MESSAGE,FOLLOW_MESSAGE_in_scmMsg559); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:107:37: ( scmMsgProp[$msgProp] )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);
            	    
            	    if ( (LA5_0 == LP || (LA5_0 >= FALSE && LA5_0 <= TRUE) || LA5_0 == ID || (LA5_0 >= NUMBER && LA5_0 <= COMMENT)) )
            	    {
            	        alt5 = 1;
            	    }
            	    
            	
            	    switch (alt5) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:107:37: scmMsgProp[$msgProp]
            			    {
            			    	PushFollow(FOLLOW_scmMsgProp_in_scmMsg561);
            			    	scmMsgProp(msgProp);
            			    	followingStackPointer_--;

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee =
            		                new EarlyExitException(5, input);
            		            throw eee;
            	    }
            	    cnt5++;
            	} while (true);
            	
            	loop5:
            		;	// Stops C# compiler whinging that label 'loop5' has no statements

            	Match(input,RP,FOLLOW_RP_in_scmMsg565); 
            	Match(input,RP,FOLLOW_RP_in_scmMsg567); 
            	msgProp.Name = id.Text;
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return msgProp;
    }
    // $ANTLR end scmMsg

    
    // $ANTLR start scmCbx
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:109:1: scmCbx returns [ScmCheckBoxProperties cbxProp] : LP DEFINE id= ID LP NEW CHECKBOX ( scmCbxProp[$cbxProp] )+ RP RP ;
    public ScmCheckBoxProperties scmCbx() // throws RecognitionException [1]
    {   

        ScmCheckBoxProperties cbxProp = null;
    
        IToken id = null;
    
        
        	ScmCheckBox msg = new ScmCheckBox();
        	cbxProp =  msg.ScmPropertyObject as ScmCheckBoxProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:115:2: ( LP DEFINE id= ID LP NEW CHECKBOX ( scmCbxProp[$cbxProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:115:4: LP DEFINE id= ID LP NEW CHECKBOX ( scmCbxProp[$cbxProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmCbx587); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmCbx589); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmCbx595); 
            	Match(input,LP,FOLLOW_LP_in_scmCbx597); 
            	Match(input,NEW,FOLLOW_NEW_in_scmCbx599); 
            	Match(input,CHECKBOX,FOLLOW_CHECKBOX_in_scmCbx601); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:115:38: ( scmCbxProp[$cbxProp] )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);
            	    
            	    if ( (LA6_0 == LP || (LA6_0 >= FALSE && LA6_0 <= TRUE) || LA6_0 == ID || (LA6_0 >= NUMBER && LA6_0 <= COMMENT)) )
            	    {
            	        alt6 = 1;
            	    }
            	    
            	
            	    switch (alt6) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:115:38: scmCbxProp[$cbxProp]
            			    {
            			    	PushFollow(FOLLOW_scmCbxProp_in_scmCbx603);
            			    	scmCbxProp(cbxProp);
            			    	followingStackPointer_--;

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee =
            		                new EarlyExitException(6, input);
            		            throw eee;
            	    }
            	    cnt6++;
            	} while (true);
            	
            	loop6:
            		;	// Stops C# compiler whinging that label 'loop6' has no statements

            	Match(input,RP,FOLLOW_RP_in_scmCbx607); 
            	Match(input,RP,FOLLOW_RP_in_scmCbx609); 
            	cbxProp.Name = id.Text;
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return cbxProp;
    }
    // $ANTLR end scmCbx

    
    // $ANTLR start scmFrmProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:117:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );
    public void scmFrmProp(ScmFrameProperties frmProp) // throws RecognitionException [1]
    {   
        string parent = null;

        string label = null;

        string width = null;

        string height = null;

        bool enabled = false;

        int border = 0;

        int spacing = 0;

        int minWidth = 0;

        int minHeight = 0;

        bool strechWidth = false;

        bool strechHeight = false;

        scmXYProp_return xyProp = null;

        string comm = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:118:2: (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr )
            int alt7 = 16;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case MIN_HEIGHT:
                	{
                    alt7 = 9;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt7 = 11;
                    }
                    break;
                case PARENT:
                	{
                    alt7 = 1;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt7 = 10;
                    }
                    break;
                case SPACING:
                	{
                    alt7 = 7;
                    }
                    break;
                case ID:
                	{
                    switch ( input.LA(3) ) 
                    {
                    case NUMBER:
                    	{
                        int LA7_18 = input.LA(4);
                        
                        if ( (LA7_18 == RP) )
                        {
                            alt7 = 14;
                        }
                        else if ( (LA7_18 == LP || (LA7_18 >= FALSE && LA7_18 <= TRUE) || LA7_18 == ID || (LA7_18 >= NUMBER && LA7_18 <= EQ)) )
                        {
                            alt7 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d7s18 =
                                new NoViableAltException("117:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 7, 18, input);
                        
                            throw nvae_d7s18;
                        }
                        }
                        break;
                    case LP:
                    case RP:
                    case TRUE:
                    case ID:
                    case QUOTE:
                    case PLUS:
                    case MINUS:
                    case STAR:
                    case SLASH:
                    case LT:
                    case GT:
                    case EQ:
                    	{
                        alt7 = 16;
                        }
                        break;
                    case FALSE:
                    	{
                        int LA7_19 = input.LA(4);
                        
                        if ( (LA7_19 == RP) )
                        {
                            alt7 = 14;
                        }
                        else if ( (LA7_19 == LP || (LA7_19 >= FALSE && LA7_19 <= TRUE) || LA7_19 == ID || (LA7_19 >= NUMBER && LA7_19 <= EQ)) )
                        {
                            alt7 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d7s19 =
                                new NoViableAltException("117:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 7, 19, input);
                        
                            throw nvae_d7s19;
                        }
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d7s9 =
                    	        new NoViableAltException("117:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 7, 9, input);
                    
                    	    throw nvae_d7s9;
                    }
                
                    }
                    break;
                case BORDER:
                	{
                    alt7 = 6;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt7 = 8;
                    }
                    break;
                case HEIGHT:
                	{
                    alt7 = 4;
                    }
                    break;
                case STYLE:
                	{
                    alt7 = 13;
                    }
                    break;
                case ENABLED:
                	{
                    alt7 = 5;
                    }
                    break;
                case ALIGNMENT:
                	{
                    alt7 = 12;
                    }
                    break;
                case LABEL:
                	{
                    alt7 = 2;
                    }
                    break;
                case WIDTH:
                	{
                    alt7 = 3;
                    }
                    break;
                case LP:
                case FALSE:
                case TRUE:
                case NUMBER:
                case QUOTE:
                case PLUS:
                case MINUS:
                case STAR:
                case SLASH:
                case LT:
                case GT:
                case EQ:
                	{
                    alt7 = 16;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d7s1 =
                	        new NoViableAltException("117:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 7, 1, input);
                
                	    throw nvae_d7s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt7 = 15;
                }
                break;
            case FALSE:
            case TRUE:
            case ID:
            case NUMBER:
            case QUOTE:
            case PLUS:
            case MINUS:
            case STAR:
            case SLASH:
            case LT:
            case GT:
            case EQ:
            	{
                alt7 = 16;
                }
                break;
            	default:
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("117:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 7, 0, input);
            
            	    throw nvae_d7s0;
            }
            
            switch (alt7) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:118:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmFrmProp627);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	frmProp.Parent = parent; frmProp.AddParesedProperty(FramePropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:119:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmFrmProp638);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	frmProp.Label = label; frmProp.AddParesedProperty(FramePropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:120:4: width= scmWidthProp
                    {
                    	PushFollow(FOLLOW_scmWidthProp_in_scmFrmProp649);
                    	width = scmWidthProp();
                    	followingStackPointer_--;

                    	if (width != "#f") { frmProp.AutosizeWidth = false; frmProp.Width = width; frmProp.AddParesedProperty(FramePropNames.Width);}
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:121:4: height= scmHeightProp
                    {
                    	PushFollow(FOLLOW_scmHeightProp_in_scmFrmProp660);
                    	height = scmHeightProp();
                    	followingStackPointer_--;

                    	if (height != "#f") {frmProp.AutosizeHeight = false; frmProp.Height = height; frmProp.AddParesedProperty(FramePropNames.Height);}
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:122:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmFrmProp671);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	frmProp.Enabled = enabled; frmProp.AddParesedProperty(FramePropNames.Enabled);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:123:4: border= scmBorderProp
                    {
                    	PushFollow(FOLLOW_scmBorderProp_in_scmFrmProp682);
                    	border = scmBorderProp();
                    	followingStackPointer_--;

                    	frmProp.Border = border; frmProp.AddParesedProperty(FramePropNames.Border);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:124:4: spacing= scmSpacingProp
                    {
                    	PushFollow(FOLLOW_scmSpacingProp_in_scmFrmProp693);
                    	spacing = scmSpacingProp();
                    	followingStackPointer_--;

                    	frmProp.Spacing = spacing; frmProp.AddParesedProperty(FramePropNames.Spacing);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:125:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmFrmProp704);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	frmProp.MinWidth = minWidth; frmProp.AddParesedProperty(FramePropNames.MinWidth);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:126:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmFrmProp715);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	frmProp.MinHeight = minHeight; frmProp.AddParesedProperty(FramePropNames.MinHeight);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:127:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmFrmProp726);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	frmProp.StretchableWidth = strechWidth; frmProp.AddParesedProperty(FramePropNames.StrechWidth);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:128:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmFrmProp737);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	frmProp.StretchableHeight = strechHeight; frmProp.AddParesedProperty(FramePropNames.StrechHeight);
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:129:4: scmAlignmentProp[frmProp.Alignment]
                    {
                    	PushFollow(FOLLOW_scmAlignmentProp_in_scmFrmProp744);
                    	scmAlignmentProp(frmProp.Alignment);
                    	followingStackPointer_--;

                    	frmProp.AddParesedProperty(FramePropNames.Alignment);
                    
                    }
                    break;
                case 13 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:130:4: scmFrmStyleProp[frmProp.Style]
                    {
                    	PushFollow(FOLLOW_scmFrmStyleProp_in_scmFrmProp752);
                    	scmFrmStyleProp(frmProp.Style);
                    	followingStackPointer_--;

                    	frmProp.AddParesedProperty(FramePropNames.Style);
                    
                    }
                    break;
                case 14 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:131:4: xyProp= scmXYProp
                    {
                    	PushFollow(FOLLOW_scmXYProp_in_scmFrmProp764);
                    	xyProp = scmXYProp();
                    	followingStackPointer_--;

                    	frmProp.SetXYProp(xyProp.name, xyProp.value);
                    
                    }
                    break;
                case 15 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:132:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmFrmProp775);
                    	comm = comment();
                    	followingStackPointer_--;

                    	frmProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 16 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:133:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmFrmProp786);
                    	pe = parExpr();
                    	followingStackPointer_--;

                    	frmProp.SetScmBlock(new ScmBlock(pe)); 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmFrmProp

    
    // $ANTLR start scmBtnProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:135:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );
    public void scmBtnProp(ScmButtonProperties btnProp) // throws RecognitionException [1]
    {   
        string parent = null;

        string label = null;

        bool enabled = false;

        int minWidth = 0;

        int minHeight = 0;

        bool strechWidth = false;

        bool strechHeight = false;

        int vertMarg = 0;

        int horizMarg = 0;

        string comm = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:136:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr )
            int alt8 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case STYLE:
                	{
                    alt8 = 10;
                    }
                    break;
                case ENABLED:
                	{
                    alt8 = 3;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt8 = 7;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt8 = 9;
                    }
                    break;
                case PARENT:
                	{
                    alt8 = 1;
                    }
                    break;
                case LABEL:
                	{
                    alt8 = 2;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt8 = 8;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt8 = 4;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt8 = 6;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt8 = 5;
                    }
                    break;
                case LP:
                case FALSE:
                case TRUE:
                case ID:
                case NUMBER:
                case QUOTE:
                case PLUS:
                case MINUS:
                case STAR:
                case SLASH:
                case LT:
                case GT:
                case EQ:
                	{
                    alt8 = 12;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d8s1 =
                	        new NoViableAltException("135:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );", 8, 1, input);
                
                	    throw nvae_d8s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt8 = 11;
                }
                break;
            case FALSE:
            case TRUE:
            case ID:
            case NUMBER:
            case QUOTE:
            case PLUS:
            case MINUS:
            case STAR:
            case SLASH:
            case LT:
            case GT:
            case EQ:
            	{
                alt8 = 12;
                }
                break;
            	default:
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("135:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );", 8, 0, input);
            
            	    throw nvae_d8s0;
            }
            
            switch (alt8) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:136:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmBtnProp804);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	btnProp.Parent = parent; btnProp.AddParesedProperty(ButtonPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:137:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmBtnProp815);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	btnProp.Label = label; btnProp.AddParesedProperty(ButtonPropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:138:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmBtnProp826);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	btnProp.Enabled = enabled; btnProp.AddParesedProperty(ButtonPropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:139:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmBtnProp837);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	btnProp.MinWidth = minWidth;if (minWidth == 0) btnProp.AutosizeWidth = true; btnProp.AddParesedProperty(ButtonPropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:140:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmBtnProp848);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	btnProp.MinHeight = minHeight; if (minHeight == 0) btnProp.AutosizeHeight = true; btnProp.AddParesedProperty( ButtonPropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:141:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmBtnProp859);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	btnProp.StretchableWidth = strechWidth; btnProp.AddParesedProperty(ButtonPropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:142:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmBtnProp870);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	btnProp.StretchableHeight = strechHeight; btnProp.AddParesedProperty(ButtonPropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:143:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmBtnProp881);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	btnProp.VerticalMargin = vertMarg; btnProp.AddParesedProperty(ButtonPropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:144:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmBtnProp892);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	btnProp.HorizontalMargin = vertMarg; btnProp.AddParesedProperty(ButtonPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:145:4: scmBtnStyleProp[btnProp.Style]
                    {
                    	PushFollow(FOLLOW_scmBtnStyleProp_in_scmBtnProp899);
                    	scmBtnStyleProp(btnProp.Style);
                    	followingStackPointer_--;

                    	btnProp.AddParesedProperty(ButtonPropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:146:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmBtnProp911);
                    	comm = comment();
                    	followingStackPointer_--;

                    	btnProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:147:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmBtnProp922);
                    	pe = parExpr();
                    	followingStackPointer_--;

                    	btnProp.SetScmBlock(new ScmBlock(pe)); 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmBtnProp

    
    // $ANTLR start scmMsgProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:149:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr );
    public void scmMsgProp(ScmMessageProperties msgProp) // throws RecognitionException [1]
    {   
        string parent = null;

        string label = null;

        bool enabled = false;

        int minWidth = 0;

        int minHeight = 0;

        bool strechWidth = false;

        bool strechHeight = false;

        int vertMarg = 0;

        int horizMarg = 0;

        string comm = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:150:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr )
            int alt9 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case LABEL:
                	{
                    alt9 = 2;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt9 = 7;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt9 = 9;
                    }
                    break;
                case PARENT:
                	{
                    alt9 = 1;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt9 = 6;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt9 = 8;
                    }
                    break;
                case STYLE:
                	{
                    alt9 = 10;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt9 = 5;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt9 = 4;
                    }
                    break;
                case ENABLED:
                	{
                    alt9 = 3;
                    }
                    break;
                case LP:
                case FALSE:
                case TRUE:
                case ID:
                case NUMBER:
                case QUOTE:
                case PLUS:
                case MINUS:
                case STAR:
                case SLASH:
                case LT:
                case GT:
                case EQ:
                	{
                    alt9 = 12;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d9s1 =
                	        new NoViableAltException("149:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr );", 9, 1, input);
                
                	    throw nvae_d9s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt9 = 11;
                }
                break;
            case FALSE:
            case TRUE:
            case ID:
            case NUMBER:
            case QUOTE:
            case PLUS:
            case MINUS:
            case STAR:
            case SLASH:
            case LT:
            case GT:
            case EQ:
            	{
                alt9 = 12;
                }
                break;
            	default:
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("149:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr );", 9, 0, input);
            
            	    throw nvae_d9s0;
            }
            
            switch (alt9) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:150:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmMsgProp939);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	msgProp.Parent = parent; msgProp.AddParesedProperty(MessagePropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:151:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmMsgProp950);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	msgProp.Label = label; msgProp.AddParesedProperty(MessagePropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:152:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmMsgProp961);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	msgProp.Enabled = enabled; msgProp.AddParesedProperty(MessagePropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:153:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmMsgProp972);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	msgProp.MinWidth = minWidth;if (minWidth == 0) msgProp.AutosizeWidth = true; msgProp.AddParesedProperty(MessagePropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:154:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmMsgProp983);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	msgProp.MinHeight = minHeight; if (minHeight == 0) msgProp.AutosizeHeight = true; msgProp.AddParesedProperty( MessagePropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:155:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmMsgProp994);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	msgProp.StretchableWidth = strechWidth; msgProp.AddParesedProperty(MessagePropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:156:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmMsgProp1005);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	msgProp.StretchableHeight = strechHeight; msgProp.AddParesedProperty(MessagePropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:157:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmMsgProp1016);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	msgProp.VerticalMargin = vertMarg; msgProp.AddParesedProperty(MessagePropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:158:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmMsgProp1027);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	msgProp.HorizontalMargin = vertMarg; msgProp.AddParesedProperty(MessagePropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:159:4: scmStyleProp[msgProp.Style]
                    {
                    	PushFollow(FOLLOW_scmStyleProp_in_scmMsgProp1034);
                    	scmStyleProp(msgProp.Style);
                    	followingStackPointer_--;

                    	msgProp.AddParesedProperty(MessagePropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:160:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmMsgProp1046);
                    	comm = comment();
                    	followingStackPointer_--;

                    	msgProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:161:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmMsgProp1057);
                    	pe = parExpr();
                    	followingStackPointer_--;

                    	msgProp.SetScmBlock(new ScmBlock(pe)); 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmMsgProp

    
    // $ANTLR start scmCbxProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:163:1: scmCbxProp[ScmCheckBoxProperties cbxProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr );
    public void scmCbxProp(ScmCheckBoxProperties cbxProp) // throws RecognitionException [1]
    {   
        string parent = null;

        string label = null;

        bool enabled = false;

        int minWidth = 0;

        int minHeight = 0;

        bool strechWidth = false;

        bool strechHeight = false;

        int vertMarg = 0;

        int horizMarg = 0;

        string comm = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:164:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr )
            int alt10 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case HORIZ_MARGIN:
                	{
                    alt10 = 9;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt10 = 6;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt10 = 8;
                    }
                    break;
                case STYLE:
                	{
                    alt10 = 10;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt10 = 4;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt10 = 5;
                    }
                    break;
                case ENABLED:
                	{
                    alt10 = 3;
                    }
                    break;
                case PARENT:
                	{
                    alt10 = 1;
                    }
                    break;
                case LABEL:
                	{
                    alt10 = 2;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt10 = 7;
                    }
                    break;
                case LP:
                case FALSE:
                case TRUE:
                case ID:
                case NUMBER:
                case QUOTE:
                case PLUS:
                case MINUS:
                case STAR:
                case SLASH:
                case LT:
                case GT:
                case EQ:
                	{
                    alt10 = 12;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d10s1 =
                	        new NoViableAltException("163:1: scmCbxProp[ScmCheckBoxProperties cbxProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr );", 10, 1, input);
                
                	    throw nvae_d10s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt10 = 11;
                }
                break;
            case FALSE:
            case TRUE:
            case ID:
            case NUMBER:
            case QUOTE:
            case PLUS:
            case MINUS:
            case STAR:
            case SLASH:
            case LT:
            case GT:
            case EQ:
            	{
                alt10 = 12;
                }
                break;
            	default:
            	    NoViableAltException nvae_d10s0 =
            	        new NoViableAltException("163:1: scmCbxProp[ScmCheckBoxProperties cbxProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr );", 10, 0, input);
            
            	    throw nvae_d10s0;
            }
            
            switch (alt10) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:164:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmCbxProp1075);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	cbxProp.Parent = parent; cbxProp.AddParesedProperty(CheckBoxPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:165:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmCbxProp1086);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	cbxProp.Label = label; cbxProp.AddParesedProperty(CheckBoxPropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:166:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmCbxProp1097);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	cbxProp.Enabled = enabled; cbxProp.AddParesedProperty(CheckBoxPropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:167:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmCbxProp1108);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	cbxProp.MinWidth = minWidth;if (minWidth == 0) cbxProp.AutosizeWidth = true; cbxProp.AddParesedProperty(CheckBoxPropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:168:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmCbxProp1119);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	cbxProp.MinHeight = minHeight; if (minHeight == 0) cbxProp.AutosizeHeight = true; cbxProp.AddParesedProperty( CheckBoxPropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:169:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmCbxProp1130);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	cbxProp.StretchableWidth = strechWidth; cbxProp.AddParesedProperty(CheckBoxPropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:170:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmCbxProp1141);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	cbxProp.StretchableHeight = strechHeight; cbxProp.AddParesedProperty(CheckBoxPropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:171:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmCbxProp1152);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	cbxProp.VerticalMargin = vertMarg; cbxProp.AddParesedProperty(CheckBoxPropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:172:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmCbxProp1163);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	cbxProp.HorizontalMargin = vertMarg; cbxProp.AddParesedProperty(CheckBoxPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:173:4: scmStyleProp[cbxProp.Style]
                    {
                    	PushFollow(FOLLOW_scmStyleProp_in_scmCbxProp1170);
                    	scmStyleProp(cbxProp.Style);
                    	followingStackPointer_--;

                    	cbxProp.AddParesedProperty(CheckBoxPropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:174:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmCbxProp1182);
                    	comm = comment();
                    	followingStackPointer_--;

                    	cbxProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:175:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmCbxProp1193);
                    	pe = parExpr();
                    	followingStackPointer_--;

                    	cbxProp.SetScmBlock(new ScmBlock(pe)); 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmCbxProp

    
    // $ANTLR start scmParentProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:177:1: scmParentProp returns [string parent] : LP PARENT par= ( ID | FALSE ) RP ;
    public string scmParentProp() // throws RecognitionException [1]
    {   

        string parent = null;
    
        IToken par = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:178:2: ( LP PARENT par= ( ID | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:178:4: LP PARENT par= ( ID | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmParentProp1209); 
            	Match(input,PARENT,FOLLOW_PARENT_in_scmParentProp1211); 
            	par = (IToken)input.LT(1);
            	if ( input.LA(1) == FALSE || input.LA(1) == ID ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmParentProp1216);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmParentProp1224); 
            	parent =  par.Text; 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return parent;
    }
    // $ANTLR end scmParentProp

    
    // $ANTLR start scmLabelProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:180:1: scmLabelProp returns [string label] : LP LABEL name= NAME RP ;
    public string scmLabelProp() // throws RecognitionException [1]
    {   

        string label = null;
    
        IToken name = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:181:2: ( LP LABEL name= NAME RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:181:4: LP LABEL name= NAME RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmLabelProp1240); 
            	Match(input,LABEL,FOLLOW_LABEL_in_scmLabelProp1242); 
            	name = (IToken)input.LT(1);
            	Match(input,NAME,FOLLOW_NAME_in_scmLabelProp1248); 
            	Match(input,RP,FOLLOW_RP_in_scmLabelProp1250); 
            	label =  name.Text.Trim('"'); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return label;
    }
    // $ANTLR end scmLabelProp

    
    // $ANTLR start scmWidthProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:183:1: scmWidthProp returns [string width] : LP WIDTH v= ( NUMBER | FALSE ) RP ;
    public string scmWidthProp() // throws RecognitionException [1]
    {   

        string width = null;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:184:2: ( LP WIDTH v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:184:4: LP WIDTH v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmWidthProp1266); 
            	Match(input,WIDTH,FOLLOW_WIDTH_in_scmWidthProp1268); 
            	v = (IToken)input.LT(1);
            	if ( input.LA(1) == FALSE || input.LA(1) == NUMBER ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmWidthProp1273);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmWidthProp1279); 
            	width =  v.Text; 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return width;
    }
    // $ANTLR end scmWidthProp

    
    // $ANTLR start scmHeightProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:186:1: scmHeightProp returns [string height] : LP HEIGHT v= ( NUMBER | FALSE ) RP ;
    public string scmHeightProp() // throws RecognitionException [1]
    {   

        string height = null;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:187:2: ( LP HEIGHT v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:187:4: LP HEIGHT v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHeightProp1294); 
            	Match(input,HEIGHT,FOLLOW_HEIGHT_in_scmHeightProp1296); 
            	v = (IToken)input.LT(1);
            	if ( input.LA(1) == FALSE || input.LA(1) == NUMBER ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmHeightProp1302);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmHeightProp1308); 
            	height =  v.Text; 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return height;
    }
    // $ANTLR end scmHeightProp

    public class scmXYProp_return : ParserRuleReturnScope 
    {
        public string name;
        public string value;
    };
    
    // $ANTLR start scmXYProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:189:1: scmXYProp returns [string name, string value] : LP n= ID v= ( NUMBER | FALSE ) RP ;
    public scmXYProp_return scmXYProp() // throws RecognitionException [1]
    {   
        scmXYProp_return retval = new scmXYProp_return();
        retval.start = input.LT(1);
    
        IToken n = null;
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:190:2: ( LP n= ID v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:190:4: LP n= ID v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmXYProp1324); 
            	n = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmXYProp1330); 
            	v = (IToken)input.LT(1);
            	if ( input.LA(1) == FALSE || input.LA(1) == NUMBER ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmXYProp1336);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmXYProp1342); 
            	retval.name =  n.Text; retval.value =  v.Text; 
            
            }
    
            retval.stop = input.LT(-1);
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end scmXYProp

    
    // $ANTLR start scmEnabledProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:192:1: scmEnabledProp returns [bool enabled] : LP ENABLED v= ( TRUE | FALSE ) RP ;
    public bool scmEnabledProp() // throws RecognitionException [1]
    {   

        bool enabled = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:193:2: ( LP ENABLED v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:193:4: LP ENABLED v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmEnabledProp1358); 
            	Match(input,ENABLED,FOLLOW_ENABLED_in_scmEnabledProp1360); 
            	v = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FALSE && input.LA(1) <= TRUE) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmEnabledProp1366);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmEnabledProp1372); 
            	if (v.Text == "#t") enabled =  true;
            								else enabled =  false; 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return enabled;
    }
    // $ANTLR end scmEnabledProp

    
    // $ANTLR start scmBorderProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:196:1: scmBorderProp returns [int border] : LP BORDER nr= NUMBER RP ;
    public int scmBorderProp() // throws RecognitionException [1]
    {   

        int border = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:197:2: ( LP BORDER nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:197:4: LP BORDER nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBorderProp1388); 
            	Match(input,BORDER,FOLLOW_BORDER_in_scmBorderProp1390); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmBorderProp1396); 
            	Match(input,RP,FOLLOW_RP_in_scmBorderProp1398); 
            	border =  ParserUtils.GetIntValue(nr.Text); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return border;
    }
    // $ANTLR end scmBorderProp

    
    // $ANTLR start scmSpacingProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:199:1: scmSpacingProp returns [int spacing] : LP SPACING nr= NUMBER RP ;
    public int scmSpacingProp() // throws RecognitionException [1]
    {   

        int spacing = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:200:2: ( LP SPACING nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:200:4: LP SPACING nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmSpacingProp1413); 
            	Match(input,SPACING,FOLLOW_SPACING_in_scmSpacingProp1415); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmSpacingProp1421); 
            	Match(input,RP,FOLLOW_RP_in_scmSpacingProp1423); 
            	spacing =  ParserUtils.GetIntValue(nr.Text); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return spacing;
    }
    // $ANTLR end scmSpacingProp

    
    // $ANTLR start scmMinWidthProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:202:1: scmMinWidthProp returns [int minWidth] : LP MIN_WIDTH nr= NUMBER RP ;
    public int scmMinWidthProp() // throws RecognitionException [1]
    {   

        int minWidth = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:203:2: ( LP MIN_WIDTH nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:203:4: LP MIN_WIDTH nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMinWidthProp1438); 
            	Match(input,MIN_WIDTH,FOLLOW_MIN_WIDTH_in_scmMinWidthProp1440); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmMinWidthProp1446); 
            	Match(input,RP,FOLLOW_RP_in_scmMinWidthProp1448); 
            	minWidth =  ParserUtils.GetIntValue(nr.Text); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return minWidth;
    }
    // $ANTLR end scmMinWidthProp

    
    // $ANTLR start scmMinHeightProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:205:1: scmMinHeightProp returns [int minHeight] : LP MIN_HEIGHT nr= NUMBER RP ;
    public int scmMinHeightProp() // throws RecognitionException [1]
    {   

        int minHeight = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:206:2: ( LP MIN_HEIGHT nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:206:4: LP MIN_HEIGHT nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMinHeightProp1463); 
            	Match(input,MIN_HEIGHT,FOLLOW_MIN_HEIGHT_in_scmMinHeightProp1465); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmMinHeightProp1471); 
            	Match(input,RP,FOLLOW_RP_in_scmMinHeightProp1473); 
            	minHeight =  ParserUtils.GetIntValue(nr.Text); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return minHeight;
    }
    // $ANTLR end scmMinHeightProp

    
    // $ANTLR start scmStretchWidthProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:208:1: scmStretchWidthProp returns [bool strechWidth] : LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP ;
    public bool scmStretchWidthProp() // throws RecognitionException [1]
    {   

        bool strechWidth = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:209:2: ( LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:209:4: LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmStretchWidthProp1488); 
            	Match(input,STRETCH_WIDTH,FOLLOW_STRETCH_WIDTH_in_scmStretchWidthProp1490); 
            	v = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FALSE && input.LA(1) <= TRUE) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmStretchWidthProp1496);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmStretchWidthProp1502); 
            	if (v.Text == "#t") strechWidth =  true;
            									else strechWidth =  false; 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return strechWidth;
    }
    // $ANTLR end scmStretchWidthProp

    
    // $ANTLR start scmStretchHeightProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:212:1: scmStretchHeightProp returns [bool strechHeigth] : LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP ;
    public bool scmStretchHeightProp() // throws RecognitionException [1]
    {   

        bool strechHeigth = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:213:2: ( LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:213:4: LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmStretchHeightProp1517); 
            	Match(input,STRETCH_HEIGHT,FOLLOW_STRETCH_HEIGHT_in_scmStretchHeightProp1519); 
            	v = (IToken)input.LT(1);
            	if ( (input.LA(1) >= FALSE && input.LA(1) <= TRUE) ) 
            	{
            	    input.Consume();
            	    errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse =
            	        new MismatchedSetException(null,input);
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmStretchHeightProp1525);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmStretchHeightProp1531); 
            	if (v.Text == "#t") strechHeigth =  true;
            									else strechHeigth =  false; 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return strechHeigth;
    }
    // $ANTLR end scmStretchHeightProp

    
    // $ANTLR start scmAlignmentProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:216:1: scmAlignmentProp[ContainerAlignment alignment] : LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP ;
    public void scmAlignmentProp(ContainerAlignment alignment) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:217:2: ( LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:217:4: LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmAlignmentProp1545); 
            	Match(input,ALIGNMENT,FOLLOW_ALIGNMENT_in_scmAlignmentProp1547); 
            	Match(input,QUOTE,FOLLOW_QUOTE_in_scmAlignmentProp1549); 
            	Match(input,LP,FOLLOW_LP_in_scmAlignmentProp1551); 
            	PushFollow(FOLLOW_scmHorizAlign_in_scmAlignmentProp1553);
            	scmHorizAlign(alignment);
            	followingStackPointer_--;

            	PushFollow(FOLLOW_scmVerticalAlign_in_scmAlignmentProp1556);
            	scmVerticalAlign(alignment);
            	followingStackPointer_--;

            	Match(input,RP,FOLLOW_RP_in_scmAlignmentProp1559); 
            	Match(input,RP,FOLLOW_RP_in_scmAlignmentProp1561); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmAlignmentProp

    
    // $ANTLR start scmFrmStyleProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:219:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmFrmStyleProp(ScmFrameStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:220:2: ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt11 = 2;
            int LA11_0 = input.LA(1);
            
            if ( (LA11_0 == LP) )
            {
                int LA11_1 = input.LA(2);
                
                if ( (LA11_1 == STYLE) )
                {
                    int LA11_2 = input.LA(3);
                    
                    if ( (LA11_2 == QUOTE) )
                    {
                        alt11 = 1;
                    }
                    else if ( (LA11_2 == NULL) )
                    {
                        alt11 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d11s2 =
                            new NoViableAltException("219:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 11, 2, input);
                    
                        throw nvae_d11s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d11s1 =
                        new NoViableAltException("219:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 11, 1, input);
                
                    throw nvae_d11s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("219:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 11, 0, input);
            
                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:220:4: LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1573); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmFrmStyleProp1575); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmFrmStyleProp1577); 
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1579); 
                    	PushFollow(FOLLOW_scmFrmStyleList_in_scmFrmStyleProp1581);
                    	scmFrmStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1584); 
                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1586); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:221:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1591); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmFrmStyleProp1593); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmFrmStyleProp1595); 
                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1597); 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmFrmStyleProp

    
    // $ANTLR start scmBtnStyleProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:223:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmBtnStyleProp(ScmButtonStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:224:2: ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt12 = 2;
            int LA12_0 = input.LA(1);
            
            if ( (LA12_0 == LP) )
            {
                int LA12_1 = input.LA(2);
                
                if ( (LA12_1 == STYLE) )
                {
                    int LA12_2 = input.LA(3);
                    
                    if ( (LA12_2 == NULL) )
                    {
                        alt12 = 2;
                    }
                    else if ( (LA12_2 == QUOTE) )
                    {
                        alt12 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d12s2 =
                            new NoViableAltException("223:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 12, 2, input);
                    
                        throw nvae_d12s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d12s1 =
                        new NoViableAltException("223:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 12, 1, input);
                
                    throw nvae_d12s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("223:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 12, 0, input);
            
                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:224:4: LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1609); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmBtnStyleProp1611); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmBtnStyleProp1613); 
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1615); 
                    	PushFollow(FOLLOW_scmBtnStyleList_in_scmBtnStyleProp1617);
                    	scmBtnStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1620); 
                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1622); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:225:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1627); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmBtnStyleProp1629); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmBtnStyleProp1631); 
                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1633); 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmBtnStyleProp

    
    // $ANTLR start scmStyleProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:227:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmStyleProp(ScmStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:228:2: ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt13 = 2;
            int LA13_0 = input.LA(1);
            
            if ( (LA13_0 == LP) )
            {
                int LA13_1 = input.LA(2);
                
                if ( (LA13_1 == STYLE) )
                {
                    int LA13_2 = input.LA(3);
                    
                    if ( (LA13_2 == QUOTE) )
                    {
                        alt13 = 1;
                    }
                    else if ( (LA13_2 == NULL) )
                    {
                        alt13 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s2 =
                            new NoViableAltException("227:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );", 13, 2, input);
                    
                        throw nvae_d13s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d13s1 =
                        new NoViableAltException("227:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );", 13, 1, input);
                
                    throw nvae_d13s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("227:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );", 13, 0, input);
            
                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:228:4: LP STYLE QUOTE LP scmStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmStyleProp1645); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmStyleProp1647); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmStyleProp1649); 
                    	Match(input,LP,FOLLOW_LP_in_scmStyleProp1651); 
                    	PushFollow(FOLLOW_scmStyleList_in_scmStyleProp1653);
                    	scmStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmStyleProp1656); 
                    	Match(input,RP,FOLLOW_RP_in_scmStyleProp1658); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:229:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmStyleProp1663); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmStyleProp1665); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmStyleProp1667); 
                    	Match(input,RP,FOLLOW_RP_in_scmStyleProp1669); 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmStyleProp

    
    // $ANTLR start scmVertMargin
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:231:1: scmVertMargin returns [int val] : LP VERT_MARGIN v= NUMBER RP ;
    public int scmVertMargin() // throws RecognitionException [1]
    {   

        int val = 0;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:232:2: ( LP VERT_MARGIN v= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:232:4: LP VERT_MARGIN v= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmVertMargin1682); 
            	Match(input,VERT_MARGIN,FOLLOW_VERT_MARGIN_in_scmVertMargin1684); 
            	v = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmVertMargin1690); 
            	Match(input,RP,FOLLOW_RP_in_scmVertMargin1692); 
            	val =  ParserUtils.GetIntValue(v.Text); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return val;
    }
    // $ANTLR end scmVertMargin

    
    // $ANTLR start scmHorizMargin
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:234:1: scmHorizMargin returns [int val] : LP HORIZ_MARGIN v= NUMBER RP ;
    public int scmHorizMargin() // throws RecognitionException [1]
    {   

        int val = 0;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:235:2: ( LP HORIZ_MARGIN v= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:235:4: LP HORIZ_MARGIN v= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHorizMargin1708); 
            	Match(input,HORIZ_MARGIN,FOLLOW_HORIZ_MARGIN_in_scmHorizMargin1710); 
            	v = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmHorizMargin1716); 
            	Match(input,RP,FOLLOW_RP_in_scmHorizMargin1718); 
            	val =  ParserUtils.GetIntValue(v.Text); 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return val;
    }
    // $ANTLR end scmHorizMargin

    
    // $ANTLR start scmVerticalAlign
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:237:1: scmVerticalAlign[ContainerAlignment align] : ( TOP | CENTER | BOTTOM );
    public void scmVerticalAlign(ContainerAlignment align) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:238:2: ( TOP | CENTER | BOTTOM )
            int alt14 = 3;
            switch ( input.LA(1) ) 
            {
            case TOP:
            	{
                alt14 = 1;
                }
                break;
            case CENTER:
            	{
                alt14 = 2;
                }
                break;
            case BOTTOM:
            	{
                alt14 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("237:1: scmVerticalAlign[ContainerAlignment align] : ( TOP | CENTER | BOTTOM );", 14, 0, input);
            
            	    throw nvae_d14s0;
            }
            
            switch (alt14) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:238:4: TOP
                    {
                    	Match(input,TOP,FOLLOW_TOP_in_scmVerticalAlign1731); 
                    	align.VerticalAlignment = VerticalAlign.Top; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:239:4: CENTER
                    {
                    	Match(input,CENTER,FOLLOW_CENTER_in_scmVerticalAlign1738); 
                    	align.VerticalAlignment = VerticalAlign.Center; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:240:4: BOTTOM
                    {
                    	Match(input,BOTTOM,FOLLOW_BOTTOM_in_scmVerticalAlign1745); 
                    	align.VerticalAlignment = VerticalAlign.Bottom; 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmVerticalAlign

    
    // $ANTLR start scmHorizAlign
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:242:1: scmHorizAlign[ContainerAlignment align] : ( LEFT | CENTER | RIGHT );
    public void scmHorizAlign(ContainerAlignment align) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:243:2: ( LEFT | CENTER | RIGHT )
            int alt15 = 3;
            switch ( input.LA(1) ) 
            {
            case LEFT:
            	{
                alt15 = 1;
                }
                break;
            case CENTER:
            	{
                alt15 = 2;
                }
                break;
            case RIGHT:
            	{
                alt15 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("242:1: scmHorizAlign[ContainerAlignment align] : ( LEFT | CENTER | RIGHT );", 15, 0, input);
            
            	    throw nvae_d15s0;
            }
            
            switch (alt15) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:243:4: LEFT
                    {
                    	Match(input,LEFT,FOLLOW_LEFT_in_scmHorizAlign1758); 
                    	align.HorizontalAlignment = HorizontalAlign.Left; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:244:4: CENTER
                    {
                    	Match(input,CENTER,FOLLOW_CENTER_in_scmHorizAlign1765); 
                    	align.HorizontalAlignment = HorizontalAlign.Center; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:245:4: RIGHT
                    {
                    	Match(input,RIGHT,FOLLOW_RIGHT_in_scmHorizAlign1772); 
                    	align.HorizontalAlignment = HorizontalAlign.Right; 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmHorizAlign

    
    // $ANTLR start scmFrmStyleList
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:247:1: scmFrmStyleList[ScmFrameStyle style] : ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )* ;
    public void scmFrmStyleList(ScmFrameStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:248:2: ( ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:248:4: ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:248:4: ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )*
            	do 
            	{
            	    int alt16 = 7;
            	    switch ( input.LA(1) ) 
            	    {
            	    case NO_RESIZE_BORDER:
            	    	{
            	        alt16 = 1;
            	        }
            	        break;
            	    case NO_CAPTION:
            	    	{
            	        alt16 = 2;
            	        }
            	        break;
            	    case NO_SYSTEM_MENU:
            	    	{
            	        alt16 = 3;
            	        }
            	        break;
            	    case MDI_PARENT:
            	    	{
            	        alt16 = 4;
            	        }
            	        break;
            	    case MDI_CHILD:
            	    	{
            	        alt16 = 5;
            	        }
            	        break;
            	    case FLOAT:
            	    	{
            	        alt16 = 6;
            	        }
            	        break;
            	    
            	    }
            	
            	    switch (alt16) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:248:5: NO_RESIZE_BORDER
            			    {
            			    	Match(input,NO_RESIZE_BORDER,FOLLOW_NO_RESIZE_BORDER_in_scmFrmStyleList1786); 
            			    	style.NoResizeBorder = true; 
            			    
            			    }
            			    break;
            			case 2 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:249:4: NO_CAPTION
            			    {
            			    	Match(input,NO_CAPTION,FOLLOW_NO_CAPTION_in_scmFrmStyleList1793); 
            			    	style.NoCaption = true; 
            			    
            			    }
            			    break;
            			case 3 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:250:4: NO_SYSTEM_MENU
            			    {
            			    	Match(input,NO_SYSTEM_MENU,FOLLOW_NO_SYSTEM_MENU_in_scmFrmStyleList1800); 
            			    	style.NoSystemMenu = true; 
            			    
            			    }
            			    break;
            			case 4 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:251:4: MDI_PARENT
            			    {
            			    	Match(input,MDI_PARENT,FOLLOW_MDI_PARENT_in_scmFrmStyleList1807); 
            			    	style.MdiParent = true; 
            			    
            			    }
            			    break;
            			case 5 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:252:4: MDI_CHILD
            			    {
            			    	Match(input,MDI_CHILD,FOLLOW_MDI_CHILD_in_scmFrmStyleList1814); 
            			    	style.MdiChild = true; 
            			    
            			    }
            			    break;
            			case 6 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:4: FLOAT
            			    {
            			    	Match(input,FLOAT,FOLLOW_FLOAT_in_scmFrmStyleList1821); 
            			    	style.Floating = true; 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop16;
            	    }
            	} while (true);
            	
            	loop16:
            		;	// Stops C# compiler whinging that label 'loop16' has no statements

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmFrmStyleList

    
    // $ANTLR start scmBtnStyleList
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:255:1: scmBtnStyleList[ScmButtonStyle style] : ( BORDER | DELETED )* ;
    public void scmBtnStyleList(ScmButtonStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:256:2: ( ( BORDER | DELETED )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:256:4: ( BORDER | DELETED )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:256:4: ( BORDER | DELETED )*
            	do 
            	{
            	    int alt17 = 3;
            	    int LA17_0 = input.LA(1);
            	    
            	    if ( (LA17_0 == BORDER) )
            	    {
            	        alt17 = 1;
            	    }
            	    else if ( (LA17_0 == DELETED) )
            	    {
            	        alt17 = 2;
            	    }
            	    
            	
            	    switch (alt17) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:256:5: BORDER
            			    {
            			    	Match(input,BORDER,FOLLOW_BORDER_in_scmBtnStyleList1836); 
            			    	style.Border = true; 
            			    
            			    }
            			    break;
            			case 2 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:257:5: DELETED
            			    {
            			    	Match(input,DELETED,FOLLOW_DELETED_in_scmBtnStyleList1844); 
            			    	style.Deleted = true; 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop17;
            	    }
            	} while (true);
            	
            	loop17:
            		;	// Stops C# compiler whinging that label 'loop17' has no statements

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmBtnStyleList

    
    // $ANTLR start scmStyleList
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:259:1: scmStyleList[ScmStyle style] : ( DELETED )* ;
    public void scmStyleList(ScmStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:260:2: ( ( DELETED )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:260:4: ( DELETED )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:260:4: ( DELETED )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);
            	    
            	    if ( (LA18_0 == DELETED) )
            	    {
            	        alt18 = 1;
            	    }
            	    
            	
            	    switch (alt18) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:260:5: DELETED
            			    {
            			    	Match(input,DELETED,FOLLOW_DELETED_in_scmStyleList1860); 
            			    	style.Deleted = true; 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop18;
            	    }
            	} while (true);
            	
            	loop18:
            		;	// Stops C# compiler whinging that label 'loop18' has no statements

            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end scmStyleList

    
    // $ANTLR start parExpr
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:262:1: parExpr returns [string expr] : ( LP (pe= parExpr )+ RP | op= operand | oa= opartors );
    public string parExpr() // throws RecognitionException [1]
    {   

        string expr = null;
    
        string pe = null;

        string op = null;

        string oa = null;
        
    
        
        expr =  string.Empty;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:266:2: ( LP (pe= parExpr )+ RP | op= operand | oa= opartors )
            int alt20 = 3;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                alt20 = 1;
                }
                break;
            case FALSE:
            case TRUE:
            case ID:
            case NUMBER:
            	{
                alt20 = 2;
                }
                break;
            case QUOTE:
            case PLUS:
            case MINUS:
            case STAR:
            case SLASH:
            case LT:
            case GT:
            case EQ:
            	{
                alt20 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d20s0 =
            	        new NoViableAltException("262:1: parExpr returns [string expr] : ( LP (pe= parExpr )+ RP | op= operand | oa= opartors );", 20, 0, input);
            
            	    throw nvae_d20s0;
            }
            
            switch (alt20) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:266:4: LP (pe= parExpr )+ RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_parExpr1881); 
                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:266:7: (pe= parExpr )+
                    	int cnt19 = 0;
                    	do 
                    	{
                    	    int alt19 = 2;
                    	    int LA19_0 = input.LA(1);
                    	    
                    	    if ( (LA19_0 == LP || (LA19_0 >= FALSE && LA19_0 <= TRUE) || LA19_0 == ID || (LA19_0 >= NUMBER && LA19_0 <= EQ)) )
                    	    {
                    	        alt19 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt19) 
                    		{
                    			case 1 :
                    			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:266:8: pe= parExpr
                    			    {
                    			    	PushFollow(FOLLOW_parExpr_in_parExpr1888);
                    			    	pe = parExpr();
                    			    	followingStackPointer_--;

                    			    	expr +=pe; 
                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    if ( cnt19 >= 1 ) goto loop19;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(19, input);
                    		            throw eee;
                    	    }
                    	    cnt19++;
                    	} while (true);
                    	
                    	loop19:
                    		;	// Stops C# compiler whinging that label 'loop19' has no statements

                    	Match(input,RP,FOLLOW_RP_in_parExpr1894); 
                    	expr =  "(" + expr + ")";
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:267:4: op= operand
                    {
                    	PushFollow(FOLLOW_operand_in_parExpr1906);
                    	op = operand();
                    	followingStackPointer_--;

                    	expr += op + " "; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:268:4: oa= opartors
                    {
                    	PushFollow(FOLLOW_opartors_in_parExpr1917);
                    	oa = opartors();
                    	followingStackPointer_--;

                    	expr += oa + " "; 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return expr;
    }
    // $ANTLR end parExpr

    
    // $ANTLR start operand
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:271:1: operand returns [string str] : (i= ID | i= NUMBER | i= TRUE | i= FALSE );
    public string operand() // throws RecognitionException [1]
    {   

        string str = null;
    
        IToken i = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:272:2: (i= ID | i= NUMBER | i= TRUE | i= FALSE )
            int alt21 = 4;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt21 = 1;
                }
                break;
            case NUMBER:
            	{
                alt21 = 2;
                }
                break;
            case TRUE:
            	{
                alt21 = 3;
                }
                break;
            case FALSE:
            	{
                alt21 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("271:1: operand returns [string str] : (i= ID | i= NUMBER | i= TRUE | i= FALSE );", 21, 0, input);
            
            	    throw nvae_d21s0;
            }
            
            switch (alt21) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:272:4: i= ID
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,ID,FOLLOW_ID_in_operand1938); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:273:4: i= NUMBER
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,NUMBER,FOLLOW_NUMBER_in_operand1949); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:274:4: i= TRUE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,TRUE,FOLLOW_TRUE_in_operand1960); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:275:4: i= FALSE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,FALSE,FOLLOW_FALSE_in_operand1971); 
                    	str =  i.Text; 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return str;
    }
    // $ANTLR end operand

    
    // $ANTLR start opartors
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:277:1: opartors returns [string str] : (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE );
    public string opartors() // throws RecognitionException [1]
    {   

        string str = null;
    
        IToken i = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:278:2: (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE )
            int alt22 = 8;
            switch ( input.LA(1) ) 
            {
            case PLUS:
            	{
                alt22 = 1;
                }
                break;
            case MINUS:
            	{
                alt22 = 2;
                }
                break;
            case STAR:
            	{
                alt22 = 3;
                }
                break;
            case SLASH:
            	{
                alt22 = 4;
                }
                break;
            case LT:
            	{
                alt22 = 5;
                }
                break;
            case GT:
            	{
                alt22 = 6;
                }
                break;
            case EQ:
            	{
                alt22 = 7;
                }
                break;
            case QUOTE:
            	{
                alt22 = 8;
                }
                break;
            	default:
            	    NoViableAltException nvae_d22s0 =
            	        new NoViableAltException("277:1: opartors returns [string str] : (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE );", 22, 0, input);
            
            	    throw nvae_d22s0;
            }
            
            switch (alt22) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:278:4: i= PLUS
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,PLUS,FOLLOW_PLUS_in_opartors1990); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:279:4: i= MINUS
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,MINUS,FOLLOW_MINUS_in_opartors2001); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:280:4: i= STAR
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,STAR,FOLLOW_STAR_in_opartors2012); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:281:4: i= SLASH
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,SLASH,FOLLOW_SLASH_in_opartors2023); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:282:4: i= LT
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,LT,FOLLOW_LT_in_opartors2034); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:4: i= GT
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,GT,FOLLOW_GT_in_opartors2045); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:284:4: i= EQ
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,EQ,FOLLOW_EQ_in_opartors2056); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:285:4: i= QUOTE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_opartors2067); 
                    	str =  i.Text; 
                    
                    }
                    break;
            
            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return str;
    }
    // $ANTLR end opartors

    
    // $ANTLR start comment
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:287:1: comment returns [string comm] : c= COMMENT ;
    public string comment() // throws RecognitionException [1]
    {   

        string comm = null;
    
        IToken c = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:288:2: (c= COMMENT )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:288:4: c= COMMENT
            {
            	c = (IToken)input.LT(1);
            	Match(input,COMMENT,FOLLOW_COMMENT_in_comment2086); 
            	comm =  c.Text; 
            
            }
    
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return comm;
    }
    // $ANTLR end comment


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_scmBlock_in_main366 = new BitSet(new ulong[]{0x007FE8001A000000UL});
    public static readonly BitSet FOLLOW_EOF_in_main369 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmFrm_in_scmBlock382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtn_in_scmBlock393 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMsg_in_scmBlock404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmCbx_in_scmBlock415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmBlock426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmBlock437 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrm457 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmFrm459 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmFrm465 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrm467 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmFrm469 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_FRAME_in_scmFrm471 = new BitSet(new ulong[]{0x007FE8001A000000UL});
    public static readonly BitSet FOLLOW_scmFrmProp_in_scmFrm473 = new BitSet(new ulong[]{0x007FE8001E000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrm477 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrm479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtn501 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmBtn503 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmBtn509 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtn511 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmBtn513 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_BUTTON_in_scmBtn515 = new BitSet(new ulong[]{0x007FE8001A000000UL});
    public static readonly BitSet FOLLOW_scmBtnProp_in_scmBtn517 = new BitSet(new ulong[]{0x007FE8001E000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtn521 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtn523 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsg545 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmMsg547 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmMsg553 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsg555 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmMsg557 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_MESSAGE_in_scmMsg559 = new BitSet(new ulong[]{0x007FE8001A000000UL});
    public static readonly BitSet FOLLOW_scmMsgProp_in_scmMsg561 = new BitSet(new ulong[]{0x007FE8001E000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsg565 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsg567 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmCbx587 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmCbx589 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmCbx595 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmCbx597 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmCbx599 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_CHECKBOX_in_scmCbx601 = new BitSet(new ulong[]{0x007FE8001A000000UL});
    public static readonly BitSet FOLLOW_scmCbxProp_in_scmCbx603 = new BitSet(new ulong[]{0x007FE8001E000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmCbx607 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmCbx609 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmFrmProp627 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmFrmProp638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmWidthProp_in_scmFrmProp649 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHeightProp_in_scmFrmProp660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmFrmProp671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBorderProp_in_scmFrmProp682 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmSpacingProp_in_scmFrmProp693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmFrmProp704 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmFrmProp715 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmFrmProp726 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmFrmProp737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmAlignmentProp_in_scmFrmProp744 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmFrmStyleProp_in_scmFrmProp752 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmXYProp_in_scmFrmProp764 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmFrmProp775 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmFrmProp786 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmBtnProp804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmBtnProp815 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmBtnProp826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmBtnProp837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmBtnProp848 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmBtnProp859 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmBtnProp870 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmBtnProp881 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmBtnProp892 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtnStyleProp_in_scmBtnProp899 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmBtnProp911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmBtnProp922 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmMsgProp939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmMsgProp950 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmMsgProp961 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmMsgProp972 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmMsgProp983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmMsgProp994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmMsgProp1005 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmMsgProp1016 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmMsgProp1027 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStyleProp_in_scmMsgProp1034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmMsgProp1046 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmMsgProp1057 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmCbxProp1075 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmCbxProp1086 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmCbxProp1097 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmCbxProp1108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmCbxProp1119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmCbxProp1130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmCbxProp1141 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmCbxProp1152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmCbxProp1163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStyleProp_in_scmCbxProp1170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmCbxProp1182 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmCbxProp1193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmParentProp1209 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_PARENT_in_scmParentProp1211 = new BitSet(new ulong[]{0x0000080008000000UL});
    public static readonly BitSet FOLLOW_set_in_scmParentProp1216 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmParentProp1224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmLabelProp1240 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_LABEL_in_scmLabelProp1242 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_NAME_in_scmLabelProp1248 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmLabelProp1250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmWidthProp1266 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_WIDTH_in_scmWidthProp1268 = new BitSet(new ulong[]{0x0000200008000000UL});
    public static readonly BitSet FOLLOW_set_in_scmWidthProp1273 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmWidthProp1279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHeightProp1294 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_HEIGHT_in_scmHeightProp1296 = new BitSet(new ulong[]{0x0000200008000000UL});
    public static readonly BitSet FOLLOW_set_in_scmHeightProp1302 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHeightProp1308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmXYProp1324 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmXYProp1330 = new BitSet(new ulong[]{0x0000200008000000UL});
    public static readonly BitSet FOLLOW_set_in_scmXYProp1336 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmXYProp1342 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmEnabledProp1358 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_ENABLED_in_scmEnabledProp1360 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_set_in_scmEnabledProp1366 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmEnabledProp1372 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBorderProp1388 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_BORDER_in_scmBorderProp1390 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmBorderProp1396 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBorderProp1398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmSpacingProp1413 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_SPACING_in_scmSpacingProp1415 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmSpacingProp1421 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmSpacingProp1423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMinWidthProp1438 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_MIN_WIDTH_in_scmMinWidthProp1440 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmMinWidthProp1446 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMinWidthProp1448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMinHeightProp1463 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_MIN_HEIGHT_in_scmMinHeightProp1465 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmMinHeightProp1471 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMinHeightProp1473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStretchWidthProp1488 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_STRETCH_WIDTH_in_scmStretchWidthProp1490 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_set_in_scmStretchWidthProp1496 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStretchWidthProp1502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStretchHeightProp1517 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_STRETCH_HEIGHT_in_scmStretchHeightProp1519 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_set_in_scmStretchHeightProp1525 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStretchHeightProp1531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmAlignmentProp1545 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_ALIGNMENT_in_scmAlignmentProp1547 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmAlignmentProp1549 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmAlignmentProp1551 = new BitSet(new ulong[]{0x0000000340000000UL});
    public static readonly BitSet FOLLOW_scmHorizAlign_in_scmAlignmentProp1553 = new BitSet(new ulong[]{0x00000000E0000000UL});
    public static readonly BitSet FOLLOW_scmVerticalAlign_in_scmAlignmentProp1556 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmAlignmentProp1559 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmAlignmentProp1561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1573 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmFrmStyleProp1575 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmFrmStyleProp1577 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1579 = new BitSet(new ulong[]{0x000001F804000000UL});
    public static readonly BitSet FOLLOW_scmFrmStyleList_in_scmFrmStyleProp1581 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1584 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1586 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1591 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmFrmStyleProp1593 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmFrmStyleProp1595 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1609 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmBtnStyleProp1611 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmBtnStyleProp1613 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1615 = new BitSet(new ulong[]{0x0000040004010000UL});
    public static readonly BitSet FOLLOW_scmBtnStyleList_in_scmBtnStyleProp1617 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1620 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1622 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1627 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmBtnStyleProp1629 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmBtnStyleProp1631 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1633 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStyleProp1645 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmStyleProp1647 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmStyleProp1649 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmStyleProp1651 = new BitSet(new ulong[]{0x0000040004000000UL});
    public static readonly BitSet FOLLOW_scmStyleList_in_scmStyleProp1653 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStyleProp1656 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStyleProp1658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStyleProp1663 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmStyleProp1665 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmStyleProp1667 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStyleProp1669 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmVertMargin1682 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_VERT_MARGIN_in_scmVertMargin1684 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmVertMargin1690 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmVertMargin1692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHorizMargin1708 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_HORIZ_MARGIN_in_scmHorizMargin1710 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmHorizMargin1716 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHorizMargin1718 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TOP_in_scmVerticalAlign1731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CENTER_in_scmVerticalAlign1738 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOTTOM_in_scmVerticalAlign1745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFT_in_scmHorizAlign1758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CENTER_in_scmHorizAlign1765 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RIGHT_in_scmHorizAlign1772 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NO_RESIZE_BORDER_in_scmFrmStyleList1786 = new BitSet(new ulong[]{0x000001F800000002UL});
    public static readonly BitSet FOLLOW_NO_CAPTION_in_scmFrmStyleList1793 = new BitSet(new ulong[]{0x000001F800000002UL});
    public static readonly BitSet FOLLOW_NO_SYSTEM_MENU_in_scmFrmStyleList1800 = new BitSet(new ulong[]{0x000001F800000002UL});
    public static readonly BitSet FOLLOW_MDI_PARENT_in_scmFrmStyleList1807 = new BitSet(new ulong[]{0x000001F800000002UL});
    public static readonly BitSet FOLLOW_MDI_CHILD_in_scmFrmStyleList1814 = new BitSet(new ulong[]{0x000001F800000002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_scmFrmStyleList1821 = new BitSet(new ulong[]{0x000001F800000002UL});
    public static readonly BitSet FOLLOW_BORDER_in_scmBtnStyleList1836 = new BitSet(new ulong[]{0x0000040000010002UL});
    public static readonly BitSet FOLLOW_DELETED_in_scmBtnStyleList1844 = new BitSet(new ulong[]{0x0000040000010002UL});
    public static readonly BitSet FOLLOW_DELETED_in_scmStyleList1860 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_LP_in_parExpr1881 = new BitSet(new ulong[]{0x003FE8001A000000UL});
    public static readonly BitSet FOLLOW_parExpr_in_parExpr1888 = new BitSet(new ulong[]{0x003FE8001E000000UL});
    public static readonly BitSet FOLLOW_RP_in_parExpr1894 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operand_in_parExpr1906 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_opartors_in_parExpr1917 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_operand1938 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_operand1949 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_operand1960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_operand1971 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_opartors1990 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_opartors2001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STAR_in_opartors2012 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SLASH_in_opartors2023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_opartors2034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GT_in_opartors2045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQ_in_opartors2056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOTE_in_opartors2067 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMENT_in_comment2086 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}