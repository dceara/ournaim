// $ANTLR 3.0.1 D:\\Projects\\AntlrTestApps\\ScmGrammar.g 2008-06-17 18:02:56
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
		"HPANEL", 
		"VPANEL", 
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

    public const int MDI_CHILD = 41;
    public const int LT = 53;
    public const int STAR = 51;
    public const int HORIZ_MARGIN = 26;
    public const int SPACING = 19;
    public const int STRETCH_WIDTH = 23;
    public const int RP = 28;
    public const int LEAD_DIGIT = 61;
    public const int STRETCH_HEIGHT = 24;
    public const int LP = 27;
    public const int NEW = 6;
    public const int BUTTON = 8;
    public const int FLOAT = 42;
    public const int ID = 45;
    public const int CAR = 58;
    public const int EOF = -1;
    public const int DEFINE = 5;
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
    public const int VERT_MARGIN = 25;
    public const int SEMI = 4;
    public const int TRUE = 30;
    public const int DELETED = 44;
    public const int NO_RESIZE_BORDER = 37;
    public const int WS = 57;
    public const int NEWLINE = 63;
    public const int LABEL = 14;
    public const int WIDTH = 15;
    public const int BOTTOM = 33;
    public const int STYLE = 43;
    public const int MIN_WIDTH = 21;
    public const int GT = 54;
    public const int FRAME = 7;
    public const int FALSE = 29;
    public const int TOP = 31;
    
    
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:77:1: main : ( scmBlock )+ EOF ;
    public void main() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:77:5: ( ( scmBlock )+ EOF )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:77:7: ( scmBlock )+ EOF
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:77:7: ( scmBlock )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:77:7: scmBlock
            			    {
            			    	PushFollow(FOLLOW_scmBlock_in_main382);
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

            	Match(input,EOF,FOLLOW_EOF_in_main385); 
            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | vpnl= scmVpnl | com= comment | pe= parExpr );
    public void scmBlock() // throws RecognitionException [1]
    {   
        ScmFrameProperties frm = null;

        ScmButtonProperties btn = null;

        ScmMessageProperties msg = null;

        ScmCheckBoxProperties cbx = null;

        ScmHorizontalPanelProperties hpnl = null;

        ScmVerticalPanelProperties vpnl = null;

        string com = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:80:2: (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | vpnl= scmVpnl | com= comment | pe= parExpr )
            int alt2 = 8;
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
                                case CHECKBOX:
                                	{
                                    alt2 = 4;
                                    }
                                    break;
                                case BUTTON:
                                	{
                                    alt2 = 2;
                                    }
                                    break;
                                case MESSAGE:
                                	{
                                    alt2 = 3;
                                    }
                                    break;
                                case VPANEL:
                                	{
                                    alt2 = 6;
                                    }
                                    break;
                                case HPANEL:
                                	{
                                    alt2 = 5;
                                    }
                                    break;
                                case FRAME:
                                	{
                                    alt2 = 1;
                                    }
                                    break;
                                	default:
                                	    NoViableAltException nvae_d2s7 =
                                	        new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | vpnl= scmVpnl | com= comment | pe= parExpr );", 2, 7, input);
                                
                                	    throw nvae_d2s7;
                                }
                            
                            }
                            else 
                            {
                                NoViableAltException nvae_d2s6 =
                                    new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | vpnl= scmVpnl | com= comment | pe= parExpr );", 2, 6, input);
                            
                                throw nvae_d2s6;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d2s5 =
                                new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | vpnl= scmVpnl | com= comment | pe= parExpr );", 2, 5, input);
                        
                            throw nvae_d2s5;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d2s4 =
                            new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | vpnl= scmVpnl | com= comment | pe= parExpr );", 2, 4, input);
                    
                        throw nvae_d2s4;
                    }
                }
                else if ( (LA2_1 == LP || (LA2_1 >= FALSE && LA2_1 <= TRUE) || LA2_1 == ID || (LA2_1 >= NUMBER && LA2_1 <= EQ)) )
                {
                    alt2 = 8;
                }
                else 
                {
                    NoViableAltException nvae_d2s1 =
                        new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | vpnl= scmVpnl | com= comment | pe= parExpr );", 2, 1, input);
                
                    throw nvae_d2s1;
                }
                }
                break;
            case COMMENT:
            	{
                alt2 = 7;
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
                alt2 = 8;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | vpnl= scmVpnl | com= comment | pe= parExpr );", 2, 0, input);
            
            	    throw nvae_d2s0;
            }
            
            switch (alt2) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:80:4: frm= scmFrm
                    {
                    	PushFollow(FOLLOW_scmFrm_in_scmBlock398);
                    	frm = scmFrm();
                    	followingStackPointer_--;

                    	_parsedData.Add(frm);
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:81:4: btn= scmBtn
                    {
                    	PushFollow(FOLLOW_scmBtn_in_scmBlock409);
                    	btn = scmBtn();
                    	followingStackPointer_--;

                    	_parsedData.Add(btn);
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:82:4: msg= scmMsg
                    {
                    	PushFollow(FOLLOW_scmMsg_in_scmBlock420);
                    	msg = scmMsg();
                    	followingStackPointer_--;

                    	_parsedData.Add(msg);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:83:4: cbx= scmCbx
                    {
                    	PushFollow(FOLLOW_scmCbx_in_scmBlock431);
                    	cbx = scmCbx();
                    	followingStackPointer_--;

                    	_parsedData.Add(cbx);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:84:4: hpnl= scmHpnl
                    {
                    	PushFollow(FOLLOW_scmHpnl_in_scmBlock442);
                    	hpnl = scmHpnl();
                    	followingStackPointer_--;

                    	_parsedData.Add(hpnl);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:85:4: vpnl= scmVpnl
                    {
                    	PushFollow(FOLLOW_scmVpnl_in_scmBlock453);
                    	vpnl = scmVpnl();
                    	followingStackPointer_--;

                    	_parsedData.Add(vpnl);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:86:4: com= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmBlock464);
                    	com = comment();
                    	followingStackPointer_--;

                    	_parsedData.Add(new ScmComment(com));
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:87:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmBlock475);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:89:1: scmFrm returns [ScmFrameProperties frmProp] : LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP ;
    public ScmFrameProperties scmFrm() // throws RecognitionException [1]
    {   

        ScmFrameProperties frmProp = null;
    
        IToken id = null;
    
        
        	ScmFrame frame = new ScmFrame();
        	frmProp =  frame.ScmPropertyObject as ScmFrameProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:95:2: ( LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:95:4: LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmFrm495); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmFrm497); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmFrm503); 
            	Match(input,LP,FOLLOW_LP_in_scmFrm505); 
            	Match(input,NEW,FOLLOW_NEW_in_scmFrm507); 
            	Match(input,FRAME,FOLLOW_FRAME_in_scmFrm509); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:95:35: ( scmFrmProp[$frmProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:95:35: scmFrmProp[$frmProp]
            			    {
            			    	PushFollow(FOLLOW_scmFrmProp_in_scmFrm511);
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

            	Match(input,RP,FOLLOW_RP_in_scmFrm515); 
            	Match(input,RP,FOLLOW_RP_in_scmFrm517); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:97:1: scmBtn returns [ScmButtonProperties btnProp] : LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP ;
    public ScmButtonProperties scmBtn() // throws RecognitionException [1]
    {   

        ScmButtonProperties btnProp = null;
    
        IToken id = null;
    
        
        	ScmButton btn = new ScmButton();
        	btnProp =  btn.ScmPropertyObject as ScmButtonProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:103:2: ( LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:103:4: LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBtn539); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmBtn541); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmBtn547); 
            	Match(input,LP,FOLLOW_LP_in_scmBtn549); 
            	Match(input,NEW,FOLLOW_NEW_in_scmBtn551); 
            	Match(input,BUTTON,FOLLOW_BUTTON_in_scmBtn553); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:103:36: ( scmBtnProp[$btnProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:103:36: scmBtnProp[$btnProp]
            			    {
            			    	PushFollow(FOLLOW_scmBtnProp_in_scmBtn555);
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

            	Match(input,RP,FOLLOW_RP_in_scmBtn559); 
            	Match(input,RP,FOLLOW_RP_in_scmBtn561); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:105:1: scmMsg returns [ScmMessageProperties msgProp] : LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP ;
    public ScmMessageProperties scmMsg() // throws RecognitionException [1]
    {   

        ScmMessageProperties msgProp = null;
    
        IToken id = null;
    
        
        	ScmMessage msg = new ScmMessage();
        	msgProp =  msg.ScmPropertyObject as ScmMessageProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:111:2: ( LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:111:4: LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMsg583); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmMsg585); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmMsg591); 
            	Match(input,LP,FOLLOW_LP_in_scmMsg593); 
            	Match(input,NEW,FOLLOW_NEW_in_scmMsg595); 
            	Match(input,MESSAGE,FOLLOW_MESSAGE_in_scmMsg597); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:111:37: ( scmMsgProp[$msgProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:111:37: scmMsgProp[$msgProp]
            			    {
            			    	PushFollow(FOLLOW_scmMsgProp_in_scmMsg599);
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

            	Match(input,RP,FOLLOW_RP_in_scmMsg603); 
            	Match(input,RP,FOLLOW_RP_in_scmMsg605); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:113:1: scmCbx returns [ScmCheckBoxProperties cbxProp] : LP DEFINE id= ID LP NEW CHECKBOX ( scmCbxProp[$cbxProp] )+ RP RP ;
    public ScmCheckBoxProperties scmCbx() // throws RecognitionException [1]
    {   

        ScmCheckBoxProperties cbxProp = null;
    
        IToken id = null;
    
        
        	ScmCheckBox cbx = new ScmCheckBox();
        	cbxProp =  cbx.ScmPropertyObject as ScmCheckBoxProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:119:2: ( LP DEFINE id= ID LP NEW CHECKBOX ( scmCbxProp[$cbxProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:119:4: LP DEFINE id= ID LP NEW CHECKBOX ( scmCbxProp[$cbxProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmCbx625); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmCbx627); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmCbx633); 
            	Match(input,LP,FOLLOW_LP_in_scmCbx635); 
            	Match(input,NEW,FOLLOW_NEW_in_scmCbx637); 
            	Match(input,CHECKBOX,FOLLOW_CHECKBOX_in_scmCbx639); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:119:38: ( scmCbxProp[$cbxProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:119:38: scmCbxProp[$cbxProp]
            			    {
            			    	PushFollow(FOLLOW_scmCbxProp_in_scmCbx641);
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

            	Match(input,RP,FOLLOW_RP_in_scmCbx645); 
            	Match(input,RP,FOLLOW_RP_in_scmCbx647); 
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

    
    // $ANTLR start scmHpnl
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:121:1: scmHpnl returns [ScmHorizontalPanelProperties hpnlProp] : LP DEFINE id= ID LP NEW HPANEL ( scmHpnlProp[$hpnlProp] )+ RP RP ;
    public ScmHorizontalPanelProperties scmHpnl() // throws RecognitionException [1]
    {   

        ScmHorizontalPanelProperties hpnlProp = null;
    
        IToken id = null;
    
        
        	ScmHorizontalPanel hpnl = new ScmHorizontalPanel();
        	hpnlProp =  hpnl.ScmPropertyObject as ScmHorizontalPanelProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:127:2: ( LP DEFINE id= ID LP NEW HPANEL ( scmHpnlProp[$hpnlProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:127:4: LP DEFINE id= ID LP NEW HPANEL ( scmHpnlProp[$hpnlProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHpnl668); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmHpnl670); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmHpnl676); 
            	Match(input,LP,FOLLOW_LP_in_scmHpnl678); 
            	Match(input,NEW,FOLLOW_NEW_in_scmHpnl680); 
            	Match(input,HPANEL,FOLLOW_HPANEL_in_scmHpnl682); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:127:36: ( scmHpnlProp[$hpnlProp] )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);
            	    
            	    if ( (LA7_0 == LP || (LA7_0 >= FALSE && LA7_0 <= TRUE) || LA7_0 == ID || (LA7_0 >= NUMBER && LA7_0 <= COMMENT)) )
            	    {
            	        alt7 = 1;
            	    }
            	    
            	
            	    switch (alt7) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:127:36: scmHpnlProp[$hpnlProp]
            			    {
            			    	PushFollow(FOLLOW_scmHpnlProp_in_scmHpnl684);
            			    	scmHpnlProp(hpnlProp);
            			    	followingStackPointer_--;

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee =
            		                new EarlyExitException(7, input);
            		            throw eee;
            	    }
            	    cnt7++;
            	} while (true);
            	
            	loop7:
            		;	// Stops C# compiler whinging that label 'loop7' has no statements

            	Match(input,RP,FOLLOW_RP_in_scmHpnl688); 
            	Match(input,RP,FOLLOW_RP_in_scmHpnl690); 
            	hpnlProp.Name = id.Text;
            
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
        return hpnlProp;
    }
    // $ANTLR end scmHpnl

    
    // $ANTLR start scmVpnl
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:129:1: scmVpnl returns [ScmVerticalPanelProperties vpnlProp] : LP DEFINE id= ID LP NEW VPANEL ( scmVpnlProp[$vpnlProp] )+ RP RP ;
    public ScmVerticalPanelProperties scmVpnl() // throws RecognitionException [1]
    {   

        ScmVerticalPanelProperties vpnlProp = null;
    
        IToken id = null;
    
        
        	ScmHorizontalPanel vpnl = new ScmHorizontalPanel();
        	vpnlProp =  vpnl.ScmPropertyObject as ScmVerticalPanelProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:135:2: ( LP DEFINE id= ID LP NEW VPANEL ( scmVpnlProp[$vpnlProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:135:4: LP DEFINE id= ID LP NEW VPANEL ( scmVpnlProp[$vpnlProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmVpnl711); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmVpnl713); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmVpnl719); 
            	Match(input,LP,FOLLOW_LP_in_scmVpnl721); 
            	Match(input,NEW,FOLLOW_NEW_in_scmVpnl723); 
            	Match(input,VPANEL,FOLLOW_VPANEL_in_scmVpnl725); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:135:36: ( scmVpnlProp[$vpnlProp] )+
            	int cnt8 = 0;
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);
            	    
            	    if ( (LA8_0 == LP || (LA8_0 >= FALSE && LA8_0 <= TRUE) || LA8_0 == ID || (LA8_0 >= NUMBER && LA8_0 <= COMMENT)) )
            	    {
            	        alt8 = 1;
            	    }
            	    
            	
            	    switch (alt8) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:135:36: scmVpnlProp[$vpnlProp]
            			    {
            			    	PushFollow(FOLLOW_scmVpnlProp_in_scmVpnl727);
            			    	scmVpnlProp(vpnlProp);
            			    	followingStackPointer_--;

            			    
            			    }
            			    break;
            	
            			default:
            			    if ( cnt8 >= 1 ) goto loop8;
            		            EarlyExitException eee =
            		                new EarlyExitException(8, input);
            		            throw eee;
            	    }
            	    cnt8++;
            	} while (true);
            	
            	loop8:
            		;	// Stops C# compiler whinging that label 'loop8' has no statements

            	Match(input,RP,FOLLOW_RP_in_scmVpnl731); 
            	Match(input,RP,FOLLOW_RP_in_scmVpnl733); 
            	vpnlProp.Name = id.Text;
            
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
        return vpnlProp;
    }
    // $ANTLR end scmVpnl

    
    // $ANTLR start scmFrmProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:137:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:138:2: (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr )
            int alt9 = 16;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case ALIGNMENT:
                	{
                    alt9 = 12;
                    }
                    break;
                case WIDTH:
                	{
                    alt9 = 3;
                    }
                    break;
                case PARENT:
                	{
                    alt9 = 1;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt9 = 11;
                    }
                    break;
                case LABEL:
                	{
                    alt9 = 2;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt9 = 10;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt9 = 9;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt9 = 8;
                    }
                    break;
                case SPACING:
                	{
                    alt9 = 7;
                    }
                    break;
                case BORDER:
                	{
                    alt9 = 6;
                    }
                    break;
                case ID:
                	{
                    switch ( input.LA(3) ) 
                    {
                    case NUMBER:
                    	{
                        int LA9_18 = input.LA(4);
                        
                        if ( (LA9_18 == RP) )
                        {
                            alt9 = 14;
                        }
                        else if ( (LA9_18 == LP || (LA9_18 >= FALSE && LA9_18 <= TRUE) || LA9_18 == ID || (LA9_18 >= NUMBER && LA9_18 <= EQ)) )
                        {
                            alt9 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d9s18 =
                                new NoViableAltException("137:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 9, 18, input);
                        
                            throw nvae_d9s18;
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
                        alt9 = 16;
                        }
                        break;
                    case FALSE:
                    	{
                        int LA9_19 = input.LA(4);
                        
                        if ( (LA9_19 == RP) )
                        {
                            alt9 = 14;
                        }
                        else if ( (LA9_19 == LP || (LA9_19 >= FALSE && LA9_19 <= TRUE) || LA9_19 == ID || (LA9_19 >= NUMBER && LA9_19 <= EQ)) )
                        {
                            alt9 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d9s19 =
                                new NoViableAltException("137:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 9, 19, input);
                        
                            throw nvae_d9s19;
                        }
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d9s14 =
                    	        new NoViableAltException("137:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 9, 14, input);
                    
                    	    throw nvae_d9s14;
                    }
                
                    }
                    break;
                case STYLE:
                	{
                    alt9 = 13;
                    }
                    break;
                case ENABLED:
                	{
                    alt9 = 5;
                    }
                    break;
                case HEIGHT:
                	{
                    alt9 = 4;
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
                    alt9 = 16;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d9s1 =
                	        new NoViableAltException("137:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 9, 1, input);
                
                	    throw nvae_d9s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt9 = 15;
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
                alt9 = 16;
                }
                break;
            	default:
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("137:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 9, 0, input);
            
            	    throw nvae_d9s0;
            }
            
            switch (alt9) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:138:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmFrmProp751);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	frmProp.Parent = parent; frmProp.AddParesedProperty(FramePropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:139:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmFrmProp762);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	frmProp.Label = label; frmProp.AddParesedProperty(FramePropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:140:4: width= scmWidthProp
                    {
                    	PushFollow(FOLLOW_scmWidthProp_in_scmFrmProp773);
                    	width = scmWidthProp();
                    	followingStackPointer_--;

                    	if (width != "#f") { frmProp.AutosizeWidth = false; frmProp.Width = width; frmProp.AddParesedProperty(FramePropNames.Width);}
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:141:4: height= scmHeightProp
                    {
                    	PushFollow(FOLLOW_scmHeightProp_in_scmFrmProp784);
                    	height = scmHeightProp();
                    	followingStackPointer_--;

                    	if (height != "#f") {frmProp.AutosizeHeight = false; frmProp.Height = height; frmProp.AddParesedProperty(FramePropNames.Height);}
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:142:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmFrmProp795);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	frmProp.Enabled = enabled; frmProp.AddParesedProperty(FramePropNames.Enabled);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:143:4: border= scmBorderProp
                    {
                    	PushFollow(FOLLOW_scmBorderProp_in_scmFrmProp806);
                    	border = scmBorderProp();
                    	followingStackPointer_--;

                    	frmProp.Border = border; frmProp.AddParesedProperty(FramePropNames.Border);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:144:4: spacing= scmSpacingProp
                    {
                    	PushFollow(FOLLOW_scmSpacingProp_in_scmFrmProp817);
                    	spacing = scmSpacingProp();
                    	followingStackPointer_--;

                    	frmProp.Spacing = spacing; frmProp.AddParesedProperty(FramePropNames.Spacing);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:145:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmFrmProp828);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	frmProp.MinWidth = minWidth; frmProp.AddParesedProperty(FramePropNames.MinWidth);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:146:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmFrmProp839);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	frmProp.MinHeight = minHeight; frmProp.AddParesedProperty(FramePropNames.MinHeight);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:147:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmFrmProp850);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	frmProp.StretchableWidth = strechWidth; frmProp.AddParesedProperty(FramePropNames.StrechWidth);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:148:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmFrmProp861);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	frmProp.StretchableHeight = strechHeight; frmProp.AddParesedProperty(FramePropNames.StrechHeight);
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:149:4: scmAlignmentProp[frmProp.Alignment]
                    {
                    	PushFollow(FOLLOW_scmAlignmentProp_in_scmFrmProp868);
                    	scmAlignmentProp(frmProp.Alignment);
                    	followingStackPointer_--;

                    	frmProp.AddParesedProperty(FramePropNames.Alignment);
                    
                    }
                    break;
                case 13 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:150:4: scmFrmStyleProp[frmProp.Style]
                    {
                    	PushFollow(FOLLOW_scmFrmStyleProp_in_scmFrmProp876);
                    	scmFrmStyleProp(frmProp.Style);
                    	followingStackPointer_--;

                    	frmProp.AddParesedProperty(FramePropNames.Style);
                    
                    }
                    break;
                case 14 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:151:4: xyProp= scmXYProp
                    {
                    	PushFollow(FOLLOW_scmXYProp_in_scmFrmProp888);
                    	xyProp = scmXYProp();
                    	followingStackPointer_--;

                    	frmProp.SetXYProp(xyProp.name, xyProp.value);
                    
                    }
                    break;
                case 15 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:152:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmFrmProp899);
                    	comm = comment();
                    	followingStackPointer_--;

                    	frmProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 16 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:153:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmFrmProp910);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:155:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:156:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr )
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
                case MIN_HEIGHT:
                	{
                    alt10 = 5;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt10 = 4;
                    }
                    break;
                case ENABLED:
                	{
                    alt10 = 3;
                    }
                    break;
                case STYLE:
                	{
                    alt10 = 10;
                    }
                    break;
                case LABEL:
                	{
                    alt10 = 2;
                    }
                    break;
                case PARENT:
                	{
                    alt10 = 1;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt10 = 7;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt10 = 8;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt10 = 6;
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
                	        new NoViableAltException("155:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );", 10, 1, input);
                
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
            	        new NoViableAltException("155:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );", 10, 0, input);
            
            	    throw nvae_d10s0;
            }
            
            switch (alt10) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:156:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmBtnProp928);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	btnProp.Parent = parent; btnProp.AddParesedProperty(ButtonPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:157:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmBtnProp939);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	btnProp.Label = label; btnProp.AddParesedProperty(ButtonPropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:158:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmBtnProp950);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	btnProp.Enabled = enabled; btnProp.AddParesedProperty(ButtonPropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:159:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmBtnProp961);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	if (minWidth != 0) btnProp.AutosizeWidth = false; btnProp.MinWidth = minWidth; btnProp.AddParesedProperty(ButtonPropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:160:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmBtnProp972);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	if (minHeight != 0) btnProp.AutosizeHeight = false; btnProp.MinHeight = minHeight; btnProp.AddParesedProperty( ButtonPropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:161:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmBtnProp983);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	btnProp.StretchableWidth = strechWidth; btnProp.AddParesedProperty(ButtonPropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:162:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmBtnProp994);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	btnProp.StretchableHeight = strechHeight; btnProp.AddParesedProperty(ButtonPropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:163:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmBtnProp1005);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	btnProp.VerticalMargin = vertMarg; btnProp.AddParesedProperty(ButtonPropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:164:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmBtnProp1016);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	btnProp.HorizontalMargin = vertMarg; btnProp.AddParesedProperty(ButtonPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:165:4: scmBtnStyleProp[btnProp.Style]
                    {
                    	PushFollow(FOLLOW_scmBtnStyleProp_in_scmBtnProp1023);
                    	scmBtnStyleProp(btnProp.Style);
                    	followingStackPointer_--;

                    	btnProp.AddParesedProperty(ButtonPropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:166:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmBtnProp1035);
                    	comm = comment();
                    	followingStackPointer_--;

                    	btnProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:167:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmBtnProp1046);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:169:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:170:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr )
            int alt11 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case ENABLED:
                	{
                    alt11 = 3;
                    }
                    break;
                case STYLE:
                	{
                    alt11 = 10;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt11 = 8;
                    }
                    break;
                case LABEL:
                	{
                    alt11 = 2;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt11 = 9;
                    }
                    break;
                case PARENT:
                	{
                    alt11 = 1;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt11 = 7;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt11 = 6;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt11 = 5;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt11 = 4;
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
                    alt11 = 12;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d11s1 =
                	        new NoViableAltException("169:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr );", 11, 1, input);
                
                	    throw nvae_d11s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt11 = 11;
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
                alt11 = 12;
                }
                break;
            	default:
            	    NoViableAltException nvae_d11s0 =
            	        new NoViableAltException("169:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr );", 11, 0, input);
            
            	    throw nvae_d11s0;
            }
            
            switch (alt11) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:170:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmMsgProp1063);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	msgProp.Parent = parent; msgProp.AddParesedProperty(MessagePropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:171:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmMsgProp1074);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	msgProp.Label = label; msgProp.AddParesedProperty(MessagePropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:172:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmMsgProp1085);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	msgProp.Enabled = enabled; msgProp.AddParesedProperty(MessagePropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:173:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmMsgProp1096);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	if (minWidth != 0) msgProp.AutosizeWidth = false; msgProp.MinWidth = minWidth; msgProp.AddParesedProperty(MessagePropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:174:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmMsgProp1107);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	if (minHeight != 0) msgProp.AutosizeHeight = false; msgProp.MinHeight = minHeight; msgProp.AddParesedProperty( MessagePropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:175:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmMsgProp1118);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	msgProp.StretchableWidth = strechWidth; msgProp.AddParesedProperty(MessagePropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:176:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmMsgProp1129);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	msgProp.StretchableHeight = strechHeight; msgProp.AddParesedProperty(MessagePropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:177:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmMsgProp1140);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	msgProp.VerticalMargin = vertMarg; msgProp.AddParesedProperty(MessagePropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:178:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmMsgProp1151);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	msgProp.HorizontalMargin = vertMarg; msgProp.AddParesedProperty(MessagePropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:179:4: scmStyleProp[msgProp.Style]
                    {
                    	PushFollow(FOLLOW_scmStyleProp_in_scmMsgProp1158);
                    	scmStyleProp(msgProp.Style);
                    	followingStackPointer_--;

                    	msgProp.AddParesedProperty(MessagePropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:180:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmMsgProp1170);
                    	comm = comment();
                    	followingStackPointer_--;

                    	msgProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:181:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmMsgProp1181);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:183:1: scmCbxProp[ScmCheckBoxProperties cbxProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:184:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr )
            int alt12 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case PARENT:
                	{
                    alt12 = 1;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt12 = 4;
                    }
                    break;
                case STYLE:
                	{
                    alt12 = 10;
                    }
                    break;
                case ENABLED:
                	{
                    alt12 = 3;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt12 = 8;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt12 = 5;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt12 = 7;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt12 = 9;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt12 = 6;
                    }
                    break;
                case LABEL:
                	{
                    alt12 = 2;
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
                    alt12 = 12;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d12s1 =
                	        new NoViableAltException("183:1: scmCbxProp[ScmCheckBoxProperties cbxProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr );", 12, 1, input);
                
                	    throw nvae_d12s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt12 = 11;
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
                alt12 = 12;
                }
                break;
            	default:
            	    NoViableAltException nvae_d12s0 =
            	        new NoViableAltException("183:1: scmCbxProp[ScmCheckBoxProperties cbxProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr );", 12, 0, input);
            
            	    throw nvae_d12s0;
            }
            
            switch (alt12) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:184:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmCbxProp1199);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	cbxProp.Parent = parent; cbxProp.AddParesedProperty(CheckBoxPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:185:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmCbxProp1210);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	cbxProp.Label = label; cbxProp.AddParesedProperty(CheckBoxPropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:186:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmCbxProp1221);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	cbxProp.Enabled = enabled; cbxProp.AddParesedProperty(CheckBoxPropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:187:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmCbxProp1232);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	if (minWidth != 0) cbxProp.AutosizeWidth = false; cbxProp.MinWidth = minWidth; cbxProp.AddParesedProperty(CheckBoxPropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:188:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmCbxProp1243);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	if (minHeight != 0) cbxProp.AutosizeHeight = false; cbxProp.MinHeight = minHeight; cbxProp.AddParesedProperty( CheckBoxPropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:189:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmCbxProp1254);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	cbxProp.StretchableWidth = strechWidth; cbxProp.AddParesedProperty(CheckBoxPropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:190:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmCbxProp1265);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	cbxProp.StretchableHeight = strechHeight; cbxProp.AddParesedProperty(CheckBoxPropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:191:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmCbxProp1276);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	cbxProp.VerticalMargin = vertMarg; cbxProp.AddParesedProperty(CheckBoxPropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:192:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmCbxProp1287);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	cbxProp.HorizontalMargin = vertMarg; cbxProp.AddParesedProperty(CheckBoxPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:193:4: scmStyleProp[cbxProp.Style]
                    {
                    	PushFollow(FOLLOW_scmStyleProp_in_scmCbxProp1294);
                    	scmStyleProp(cbxProp.Style);
                    	followingStackPointer_--;

                    	cbxProp.AddParesedProperty(CheckBoxPropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:194:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmCbxProp1306);
                    	comm = comment();
                    	followingStackPointer_--;

                    	cbxProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:195:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmCbxProp1317);
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

    
    // $ANTLR start scmHpnlProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:197:1: scmHpnlProp[ScmHorizontalPanelProperties hpnlProp] : (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[hpnlProp.Style] | scmAlignmentProp[hpnlProp.Alignment] | comm= comment | pe= parExpr );
    public void scmHpnlProp(ScmHorizontalPanelProperties hpnlProp) // throws RecognitionException [1]
    {   
        string parent = null;

        bool enabled = false;

        int minWidth = 0;

        int minHeight = 0;

        bool strechWidth = false;

        bool strechHeight = false;

        int vertMarg = 0;

        int horizMarg = 0;

        int border = 0;

        int spacing = 0;

        string comm = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:198:2: (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[hpnlProp.Style] | scmAlignmentProp[hpnlProp.Alignment] | comm= comment | pe= parExpr )
            int alt13 = 14;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case VERT_MARGIN:
                	{
                    alt13 = 7;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt13 = 5;
                    }
                    break;
                case SPACING:
                	{
                    alt13 = 10;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt13 = 4;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt13 = 6;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt13 = 8;
                    }
                    break;
                case ALIGNMENT:
                	{
                    alt13 = 12;
                    }
                    break;
                case PARENT:
                	{
                    alt13 = 1;
                    }
                    break;
                case ENABLED:
                	{
                    alt13 = 2;
                    }
                    break;
                case STYLE:
                	{
                    alt13 = 11;
                    }
                    break;
                case BORDER:
                	{
                    alt13 = 9;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt13 = 3;
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
                    alt13 = 14;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d13s1 =
                	        new NoViableAltException("197:1: scmHpnlProp[ScmHorizontalPanelProperties hpnlProp] : (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[hpnlProp.Style] | scmAlignmentProp[hpnlProp.Alignment] | comm= comment | pe= parExpr );", 13, 1, input);
                
                	    throw nvae_d13s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt13 = 13;
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
                alt13 = 14;
                }
                break;
            	default:
            	    NoViableAltException nvae_d13s0 =
            	        new NoViableAltException("197:1: scmHpnlProp[ScmHorizontalPanelProperties hpnlProp] : (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[hpnlProp.Style] | scmAlignmentProp[hpnlProp.Alignment] | comm= comment | pe= parExpr );", 13, 0, input);
            
            	    throw nvae_d13s0;
            }
            
            switch (alt13) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:198:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmHpnlProp1335);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	hpnlProp.Parent = parent; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:199:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmHpnlProp1346);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	hpnlProp.Enabled = enabled; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Enabled);
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:200:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmHpnlProp1357);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	if (minWidth != 0) hpnlProp.AutosizeWidth = false; hpnlProp.MinWidth = minWidth; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.MinWidth);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:201:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmHpnlProp1368);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	if (minHeight != 0) hpnlProp.AutosizeHeight = false; hpnlProp.MinHeight = minHeight; hpnlProp.AddParesedProperty( HorizontalPanelPropNames.MinHeight);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:202:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmHpnlProp1379);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	hpnlProp.StretchableWidth = strechWidth; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.StrechWidth);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:203:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmHpnlProp1390);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	hpnlProp.StretchableHeight = strechHeight; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.StrechHeight);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:204:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmHpnlProp1401);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	hpnlProp.VerticalMargin = vertMarg; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.VerticalMargin);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:205:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmHpnlProp1412);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	hpnlProp.HorizontalMargin = vertMarg; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:206:4: border= scmBorderProp
                    {
                    	PushFollow(FOLLOW_scmBorderProp_in_scmHpnlProp1423);
                    	border = scmBorderProp();
                    	followingStackPointer_--;

                    	hpnlProp.Border = border; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Border);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:207:4: spacing= scmSpacingProp
                    {
                    	PushFollow(FOLLOW_scmSpacingProp_in_scmHpnlProp1434);
                    	spacing = scmSpacingProp();
                    	followingStackPointer_--;

                    	hpnlProp.Spacing = spacing; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Spacing);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:208:4: scmBtnStyleProp[hpnlProp.Style]
                    {
                    	PushFollow(FOLLOW_scmBtnStyleProp_in_scmHpnlProp1441);
                    	scmBtnStyleProp(hpnlProp.Style);
                    	followingStackPointer_--;

                    	hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Style);
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:209:4: scmAlignmentProp[hpnlProp.Alignment]
                    {
                    	PushFollow(FOLLOW_scmAlignmentProp_in_scmHpnlProp1449);
                    	scmAlignmentProp(hpnlProp.Alignment);
                    	followingStackPointer_--;

                    	hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Alignment);
                    
                    }
                    break;
                case 13 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:210:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmHpnlProp1461);
                    	comm = comment();
                    	followingStackPointer_--;

                    	hpnlProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 14 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:211:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmHpnlProp1472);
                    	pe = parExpr();
                    	followingStackPointer_--;

                    	hpnlProp.SetScmBlock(new ScmBlock(pe)); 
                    
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
    // $ANTLR end scmHpnlProp

    
    // $ANTLR start scmVpnlProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:213:1: scmVpnlProp[ScmVerticalPanelProperties vpnlProp] : (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[vpnlProp.Style] | scmAlignmentProp[vpnlProp.Alignment] | comm= comment | pe= parExpr );
    public void scmVpnlProp(ScmVerticalPanelProperties vpnlProp) // throws RecognitionException [1]
    {   
        string parent = null;

        bool enabled = false;

        int minWidth = 0;

        int minHeight = 0;

        bool strechWidth = false;

        bool strechHeight = false;

        int vertMarg = 0;

        int horizMarg = 0;

        int border = 0;

        int spacing = 0;

        string comm = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:214:2: (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[vpnlProp.Style] | scmAlignmentProp[vpnlProp.Alignment] | comm= comment | pe= parExpr )
            int alt14 = 14;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case ENABLED:
                	{
                    alt14 = 2;
                    }
                    break;
                case STYLE:
                	{
                    alt14 = 11;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt14 = 3;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt14 = 4;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt14 = 7;
                    }
                    break;
                case BORDER:
                	{
                    alt14 = 9;
                    }
                    break;
                case SPACING:
                	{
                    alt14 = 10;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt14 = 5;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt14 = 8;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt14 = 6;
                    }
                    break;
                case PARENT:
                	{
                    alt14 = 1;
                    }
                    break;
                case ALIGNMENT:
                	{
                    alt14 = 12;
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
                    alt14 = 14;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d14s1 =
                	        new NoViableAltException("213:1: scmVpnlProp[ScmVerticalPanelProperties vpnlProp] : (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[vpnlProp.Style] | scmAlignmentProp[vpnlProp.Alignment] | comm= comment | pe= parExpr );", 14, 1, input);
                
                	    throw nvae_d14s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt14 = 13;
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
                alt14 = 14;
                }
                break;
            	default:
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("213:1: scmVpnlProp[ScmVerticalPanelProperties vpnlProp] : (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[vpnlProp.Style] | scmAlignmentProp[vpnlProp.Alignment] | comm= comment | pe= parExpr );", 14, 0, input);
            
            	    throw nvae_d14s0;
            }
            
            switch (alt14) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:214:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmVpnlProp1490);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	vpnlProp.Parent = parent; vpnlProp.AddParesedProperty(VerticalPanelPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:215:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmVpnlProp1501);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	vpnlProp.Enabled = enabled; vpnlProp.AddParesedProperty(VerticalPanelPropNames.Enabled);
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:216:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmVpnlProp1512);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	if (minWidth != 0) vpnlProp.AutosizeWidth = false; vpnlProp.MinWidth = minWidth; vpnlProp.AddParesedProperty(VerticalPanelPropNames.MinWidth);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:217:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmVpnlProp1523);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	if (minHeight != 0) vpnlProp.AutosizeHeight = false; vpnlProp.MinHeight = minHeight; vpnlProp.AddParesedProperty( VerticalPanelPropNames.MinHeight);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:218:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmVpnlProp1534);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	vpnlProp.StretchableWidth = strechWidth; vpnlProp.AddParesedProperty(VerticalPanelPropNames.StrechWidth);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:219:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmVpnlProp1545);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	vpnlProp.StretchableHeight = strechHeight; vpnlProp.AddParesedProperty(VerticalPanelPropNames.StrechHeight);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:220:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmVpnlProp1556);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	vpnlProp.VerticalMargin = vertMarg; vpnlProp.AddParesedProperty(VerticalPanelPropNames.VerticalMargin);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:221:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmVpnlProp1567);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	vpnlProp.HorizontalMargin = vertMarg; vpnlProp.AddParesedProperty(VerticalPanelPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:222:4: border= scmBorderProp
                    {
                    	PushFollow(FOLLOW_scmBorderProp_in_scmVpnlProp1578);
                    	border = scmBorderProp();
                    	followingStackPointer_--;

                    	vpnlProp.Border = border; vpnlProp.AddParesedProperty(VerticalPanelPropNames.Border);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:223:4: spacing= scmSpacingProp
                    {
                    	PushFollow(FOLLOW_scmSpacingProp_in_scmVpnlProp1589);
                    	spacing = scmSpacingProp();
                    	followingStackPointer_--;

                    	vpnlProp.Spacing = spacing; vpnlProp.AddParesedProperty(VerticalPanelPropNames.Spacing);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:224:4: scmBtnStyleProp[vpnlProp.Style]
                    {
                    	PushFollow(FOLLOW_scmBtnStyleProp_in_scmVpnlProp1596);
                    	scmBtnStyleProp(vpnlProp.Style);
                    	followingStackPointer_--;

                    	vpnlProp.AddParesedProperty(VerticalPanelPropNames.Style);
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:225:4: scmAlignmentProp[vpnlProp.Alignment]
                    {
                    	PushFollow(FOLLOW_scmAlignmentProp_in_scmVpnlProp1604);
                    	scmAlignmentProp(vpnlProp.Alignment);
                    	followingStackPointer_--;

                    	vpnlProp.AddParesedProperty(VerticalPanelPropNames.Alignment);
                    
                    }
                    break;
                case 13 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:226:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmVpnlProp1616);
                    	comm = comment();
                    	followingStackPointer_--;

                    	vpnlProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 14 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:227:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmVpnlProp1627);
                    	pe = parExpr();
                    	followingStackPointer_--;

                    	vpnlProp.SetScmBlock(new ScmBlock(pe)); 
                    
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
    // $ANTLR end scmVpnlProp

    
    // $ANTLR start scmParentProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:229:1: scmParentProp returns [string parent] : LP PARENT par= ( ID | FALSE ) RP ;
    public string scmParentProp() // throws RecognitionException [1]
    {   

        string parent = null;
    
        IToken par = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:230:2: ( LP PARENT par= ( ID | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:230:4: LP PARENT par= ( ID | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmParentProp1643); 
            	Match(input,PARENT,FOLLOW_PARENT_in_scmParentProp1645); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmParentProp1650);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmParentProp1658); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:232:1: scmLabelProp returns [string label] : LP LABEL name= NAME RP ;
    public string scmLabelProp() // throws RecognitionException [1]
    {   

        string label = null;
    
        IToken name = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:233:2: ( LP LABEL name= NAME RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:233:4: LP LABEL name= NAME RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmLabelProp1674); 
            	Match(input,LABEL,FOLLOW_LABEL_in_scmLabelProp1676); 
            	name = (IToken)input.LT(1);
            	Match(input,NAME,FOLLOW_NAME_in_scmLabelProp1682); 
            	Match(input,RP,FOLLOW_RP_in_scmLabelProp1684); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:235:1: scmWidthProp returns [string width] : LP WIDTH v= ( NUMBER | FALSE ) RP ;
    public string scmWidthProp() // throws RecognitionException [1]
    {   

        string width = null;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:236:2: ( LP WIDTH v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:236:4: LP WIDTH v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmWidthProp1700); 
            	Match(input,WIDTH,FOLLOW_WIDTH_in_scmWidthProp1702); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmWidthProp1707);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmWidthProp1713); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:238:1: scmHeightProp returns [string height] : LP HEIGHT v= ( NUMBER | FALSE ) RP ;
    public string scmHeightProp() // throws RecognitionException [1]
    {   

        string height = null;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:239:2: ( LP HEIGHT v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:239:4: LP HEIGHT v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHeightProp1728); 
            	Match(input,HEIGHT,FOLLOW_HEIGHT_in_scmHeightProp1730); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmHeightProp1736);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmHeightProp1742); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:241:1: scmXYProp returns [string name, string value] : LP n= ID v= ( NUMBER | FALSE ) RP ;
    public scmXYProp_return scmXYProp() // throws RecognitionException [1]
    {   
        scmXYProp_return retval = new scmXYProp_return();
        retval.start = input.LT(1);
    
        IToken n = null;
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:242:2: ( LP n= ID v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:242:4: LP n= ID v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmXYProp1758); 
            	n = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmXYProp1764); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmXYProp1770);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmXYProp1776); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:244:1: scmEnabledProp returns [bool enabled] : LP ENABLED v= ( TRUE | FALSE ) RP ;
    public bool scmEnabledProp() // throws RecognitionException [1]
    {   

        bool enabled = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:245:2: ( LP ENABLED v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:245:4: LP ENABLED v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmEnabledProp1792); 
            	Match(input,ENABLED,FOLLOW_ENABLED_in_scmEnabledProp1794); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmEnabledProp1800);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmEnabledProp1806); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:248:1: scmBorderProp returns [int border] : LP BORDER nr= NUMBER RP ;
    public int scmBorderProp() // throws RecognitionException [1]
    {   

        int border = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:249:2: ( LP BORDER nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:249:4: LP BORDER nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBorderProp1822); 
            	Match(input,BORDER,FOLLOW_BORDER_in_scmBorderProp1824); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmBorderProp1830); 
            	Match(input,RP,FOLLOW_RP_in_scmBorderProp1832); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:251:1: scmSpacingProp returns [int spacing] : LP SPACING nr= NUMBER RP ;
    public int scmSpacingProp() // throws RecognitionException [1]
    {   

        int spacing = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:252:2: ( LP SPACING nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:252:4: LP SPACING nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmSpacingProp1847); 
            	Match(input,SPACING,FOLLOW_SPACING_in_scmSpacingProp1849); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmSpacingProp1855); 
            	Match(input,RP,FOLLOW_RP_in_scmSpacingProp1857); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:254:1: scmMinWidthProp returns [int minWidth] : LP MIN_WIDTH nr= NUMBER RP ;
    public int scmMinWidthProp() // throws RecognitionException [1]
    {   

        int minWidth = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:255:2: ( LP MIN_WIDTH nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:255:4: LP MIN_WIDTH nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMinWidthProp1872); 
            	Match(input,MIN_WIDTH,FOLLOW_MIN_WIDTH_in_scmMinWidthProp1874); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmMinWidthProp1880); 
            	Match(input,RP,FOLLOW_RP_in_scmMinWidthProp1882); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:257:1: scmMinHeightProp returns [int minHeight] : LP MIN_HEIGHT nr= NUMBER RP ;
    public int scmMinHeightProp() // throws RecognitionException [1]
    {   

        int minHeight = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:258:2: ( LP MIN_HEIGHT nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:258:4: LP MIN_HEIGHT nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMinHeightProp1897); 
            	Match(input,MIN_HEIGHT,FOLLOW_MIN_HEIGHT_in_scmMinHeightProp1899); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmMinHeightProp1905); 
            	Match(input,RP,FOLLOW_RP_in_scmMinHeightProp1907); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:260:1: scmStretchWidthProp returns [bool strechWidth] : LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP ;
    public bool scmStretchWidthProp() // throws RecognitionException [1]
    {   

        bool strechWidth = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:261:2: ( LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:261:4: LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmStretchWidthProp1922); 
            	Match(input,STRETCH_WIDTH,FOLLOW_STRETCH_WIDTH_in_scmStretchWidthProp1924); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmStretchWidthProp1930);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmStretchWidthProp1936); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:264:1: scmStretchHeightProp returns [bool strechHeigth] : LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP ;
    public bool scmStretchHeightProp() // throws RecognitionException [1]
    {   

        bool strechHeigth = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:265:2: ( LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:265:4: LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmStretchHeightProp1951); 
            	Match(input,STRETCH_HEIGHT,FOLLOW_STRETCH_HEIGHT_in_scmStretchHeightProp1953); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmStretchHeightProp1959);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmStretchHeightProp1965); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:268:1: scmAlignmentProp[ContainerAlignment alignment] : LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP ;
    public void scmAlignmentProp(ContainerAlignment alignment) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:269:2: ( LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:269:4: LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmAlignmentProp1979); 
            	Match(input,ALIGNMENT,FOLLOW_ALIGNMENT_in_scmAlignmentProp1981); 
            	Match(input,QUOTE,FOLLOW_QUOTE_in_scmAlignmentProp1983); 
            	Match(input,LP,FOLLOW_LP_in_scmAlignmentProp1985); 
            	PushFollow(FOLLOW_scmHorizAlign_in_scmAlignmentProp1987);
            	scmHorizAlign(alignment);
            	followingStackPointer_--;

            	PushFollow(FOLLOW_scmVerticalAlign_in_scmAlignmentProp1990);
            	scmVerticalAlign(alignment);
            	followingStackPointer_--;

            	Match(input,RP,FOLLOW_RP_in_scmAlignmentProp1993); 
            	Match(input,RP,FOLLOW_RP_in_scmAlignmentProp1995); 
            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:271:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmFrmStyleProp(ScmFrameStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:272:2: ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt15 = 2;
            int LA15_0 = input.LA(1);
            
            if ( (LA15_0 == LP) )
            {
                int LA15_1 = input.LA(2);
                
                if ( (LA15_1 == STYLE) )
                {
                    int LA15_2 = input.LA(3);
                    
                    if ( (LA15_2 == QUOTE) )
                    {
                        alt15 = 1;
                    }
                    else if ( (LA15_2 == NULL) )
                    {
                        alt15 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d15s2 =
                            new NoViableAltException("271:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 15, 2, input);
                    
                        throw nvae_d15s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d15s1 =
                        new NoViableAltException("271:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 15, 1, input);
                
                    throw nvae_d15s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d15s0 =
                    new NoViableAltException("271:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 15, 0, input);
            
                throw nvae_d15s0;
            }
            switch (alt15) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:272:4: LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp2007); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmFrmStyleProp2009); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmFrmStyleProp2011); 
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp2013); 
                    	PushFollow(FOLLOW_scmFrmStyleList_in_scmFrmStyleProp2015);
                    	scmFrmStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp2018); 
                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp2020); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:273:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp2025); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmFrmStyleProp2027); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmFrmStyleProp2029); 
                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp2031); 
                    
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:275:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmBtnStyleProp(ScmButtonStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:276:2: ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt16 = 2;
            int LA16_0 = input.LA(1);
            
            if ( (LA16_0 == LP) )
            {
                int LA16_1 = input.LA(2);
                
                if ( (LA16_1 == STYLE) )
                {
                    int LA16_2 = input.LA(3);
                    
                    if ( (LA16_2 == QUOTE) )
                    {
                        alt16 = 1;
                    }
                    else if ( (LA16_2 == NULL) )
                    {
                        alt16 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d16s2 =
                            new NoViableAltException("275:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 16, 2, input);
                    
                        throw nvae_d16s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d16s1 =
                        new NoViableAltException("275:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 16, 1, input);
                
                    throw nvae_d16s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("275:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 16, 0, input);
            
                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:276:4: LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp2043); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmBtnStyleProp2045); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmBtnStyleProp2047); 
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp2049); 
                    	PushFollow(FOLLOW_scmBtnStyleList_in_scmBtnStyleProp2051);
                    	scmBtnStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp2054); 
                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp2056); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:277:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp2061); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmBtnStyleProp2063); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmBtnStyleProp2065); 
                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp2067); 
                    
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:279:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmStyleProp(ScmStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:280:2: ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt17 = 2;
            int LA17_0 = input.LA(1);
            
            if ( (LA17_0 == LP) )
            {
                int LA17_1 = input.LA(2);
                
                if ( (LA17_1 == STYLE) )
                {
                    int LA17_2 = input.LA(3);
                    
                    if ( (LA17_2 == NULL) )
                    {
                        alt17 = 2;
                    }
                    else if ( (LA17_2 == QUOTE) )
                    {
                        alt17 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d17s2 =
                            new NoViableAltException("279:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );", 17, 2, input);
                    
                        throw nvae_d17s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d17s1 =
                        new NoViableAltException("279:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );", 17, 1, input);
                
                    throw nvae_d17s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("279:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );", 17, 0, input);
            
                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:280:4: LP STYLE QUOTE LP scmStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmStyleProp2079); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmStyleProp2081); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmStyleProp2083); 
                    	Match(input,LP,FOLLOW_LP_in_scmStyleProp2085); 
                    	PushFollow(FOLLOW_scmStyleList_in_scmStyleProp2087);
                    	scmStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmStyleProp2090); 
                    	Match(input,RP,FOLLOW_RP_in_scmStyleProp2092); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:281:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmStyleProp2097); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmStyleProp2099); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmStyleProp2101); 
                    	Match(input,RP,FOLLOW_RP_in_scmStyleProp2103); 
                    
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:1: scmVertMargin returns [int val] : LP VERT_MARGIN v= NUMBER RP ;
    public int scmVertMargin() // throws RecognitionException [1]
    {   

        int val = 0;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:284:2: ( LP VERT_MARGIN v= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:284:4: LP VERT_MARGIN v= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmVertMargin2116); 
            	Match(input,VERT_MARGIN,FOLLOW_VERT_MARGIN_in_scmVertMargin2118); 
            	v = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmVertMargin2124); 
            	Match(input,RP,FOLLOW_RP_in_scmVertMargin2126); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:286:1: scmHorizMargin returns [int val] : LP HORIZ_MARGIN v= NUMBER RP ;
    public int scmHorizMargin() // throws RecognitionException [1]
    {   

        int val = 0;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:287:2: ( LP HORIZ_MARGIN v= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:287:4: LP HORIZ_MARGIN v= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHorizMargin2142); 
            	Match(input,HORIZ_MARGIN,FOLLOW_HORIZ_MARGIN_in_scmHorizMargin2144); 
            	v = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmHorizMargin2150); 
            	Match(input,RP,FOLLOW_RP_in_scmHorizMargin2152); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:289:1: scmVerticalAlign[ContainerAlignment align] : ( TOP | CENTER | BOTTOM );
    public void scmVerticalAlign(ContainerAlignment align) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:290:2: ( TOP | CENTER | BOTTOM )
            int alt18 = 3;
            switch ( input.LA(1) ) 
            {
            case TOP:
            	{
                alt18 = 1;
                }
                break;
            case CENTER:
            	{
                alt18 = 2;
                }
                break;
            case BOTTOM:
            	{
                alt18 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d18s0 =
            	        new NoViableAltException("289:1: scmVerticalAlign[ContainerAlignment align] : ( TOP | CENTER | BOTTOM );", 18, 0, input);
            
            	    throw nvae_d18s0;
            }
            
            switch (alt18) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:290:4: TOP
                    {
                    	Match(input,TOP,FOLLOW_TOP_in_scmVerticalAlign2165); 
                    	align.VerticalAlignment = VerticalAlign.Top; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:291:4: CENTER
                    {
                    	Match(input,CENTER,FOLLOW_CENTER_in_scmVerticalAlign2172); 
                    	align.VerticalAlignment = VerticalAlign.Center; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:292:4: BOTTOM
                    {
                    	Match(input,BOTTOM,FOLLOW_BOTTOM_in_scmVerticalAlign2179); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:294:1: scmHorizAlign[ContainerAlignment align] : ( LEFT | CENTER | RIGHT );
    public void scmHorizAlign(ContainerAlignment align) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:295:2: ( LEFT | CENTER | RIGHT )
            int alt19 = 3;
            switch ( input.LA(1) ) 
            {
            case LEFT:
            	{
                alt19 = 1;
                }
                break;
            case CENTER:
            	{
                alt19 = 2;
                }
                break;
            case RIGHT:
            	{
                alt19 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("294:1: scmHorizAlign[ContainerAlignment align] : ( LEFT | CENTER | RIGHT );", 19, 0, input);
            
            	    throw nvae_d19s0;
            }
            
            switch (alt19) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:295:4: LEFT
                    {
                    	Match(input,LEFT,FOLLOW_LEFT_in_scmHorizAlign2192); 
                    	align.HorizontalAlignment = HorizontalAlign.Left; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:296:4: CENTER
                    {
                    	Match(input,CENTER,FOLLOW_CENTER_in_scmHorizAlign2199); 
                    	align.HorizontalAlignment = HorizontalAlign.Center; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:297:4: RIGHT
                    {
                    	Match(input,RIGHT,FOLLOW_RIGHT_in_scmHorizAlign2206); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:299:1: scmFrmStyleList[ScmFrameStyle style] : ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )* ;
    public void scmFrmStyleList(ScmFrameStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:300:2: ( ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:300:4: ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:300:4: ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )*
            	do 
            	{
            	    int alt20 = 7;
            	    switch ( input.LA(1) ) 
            	    {
            	    case NO_RESIZE_BORDER:
            	    	{
            	        alt20 = 1;
            	        }
            	        break;
            	    case NO_CAPTION:
            	    	{
            	        alt20 = 2;
            	        }
            	        break;
            	    case NO_SYSTEM_MENU:
            	    	{
            	        alt20 = 3;
            	        }
            	        break;
            	    case MDI_PARENT:
            	    	{
            	        alt20 = 4;
            	        }
            	        break;
            	    case MDI_CHILD:
            	    	{
            	        alt20 = 5;
            	        }
            	        break;
            	    case FLOAT:
            	    	{
            	        alt20 = 6;
            	        }
            	        break;
            	    
            	    }
            	
            	    switch (alt20) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:300:5: NO_RESIZE_BORDER
            			    {
            			    	Match(input,NO_RESIZE_BORDER,FOLLOW_NO_RESIZE_BORDER_in_scmFrmStyleList2220); 
            			    	style.NoResizeBorder = true; 
            			    
            			    }
            			    break;
            			case 2 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:301:4: NO_CAPTION
            			    {
            			    	Match(input,NO_CAPTION,FOLLOW_NO_CAPTION_in_scmFrmStyleList2227); 
            			    	style.NoCaption = true; 
            			    
            			    }
            			    break;
            			case 3 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:302:4: NO_SYSTEM_MENU
            			    {
            			    	Match(input,NO_SYSTEM_MENU,FOLLOW_NO_SYSTEM_MENU_in_scmFrmStyleList2234); 
            			    	style.NoSystemMenu = true; 
            			    
            			    }
            			    break;
            			case 4 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:303:4: MDI_PARENT
            			    {
            			    	Match(input,MDI_PARENT,FOLLOW_MDI_PARENT_in_scmFrmStyleList2241); 
            			    	style.MdiParent = true; 
            			    
            			    }
            			    break;
            			case 5 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:304:4: MDI_CHILD
            			    {
            			    	Match(input,MDI_CHILD,FOLLOW_MDI_CHILD_in_scmFrmStyleList2248); 
            			    	style.MdiChild = true; 
            			    
            			    }
            			    break;
            			case 6 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:305:4: FLOAT
            			    {
            			    	Match(input,FLOAT,FOLLOW_FLOAT_in_scmFrmStyleList2255); 
            			    	style.Floating = true; 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop20;
            	    }
            	} while (true);
            	
            	loop20:
            		;	// Stops C# compiler whinging that label 'loop20' has no statements

            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:307:1: scmBtnStyleList[ScmButtonStyle style] : ( BORDER | DELETED )* ;
    public void scmBtnStyleList(ScmButtonStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:308:2: ( ( BORDER | DELETED )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:308:4: ( BORDER | DELETED )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:308:4: ( BORDER | DELETED )*
            	do 
            	{
            	    int alt21 = 3;
            	    int LA21_0 = input.LA(1);
            	    
            	    if ( (LA21_0 == BORDER) )
            	    {
            	        alt21 = 1;
            	    }
            	    else if ( (LA21_0 == DELETED) )
            	    {
            	        alt21 = 2;
            	    }
            	    
            	
            	    switch (alt21) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:308:5: BORDER
            			    {
            			    	Match(input,BORDER,FOLLOW_BORDER_in_scmBtnStyleList2270); 
            			    	style.Border = true; 
            			    
            			    }
            			    break;
            			case 2 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:309:5: DELETED
            			    {
            			    	Match(input,DELETED,FOLLOW_DELETED_in_scmBtnStyleList2278); 
            			    	style.Deleted = true; 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop21;
            	    }
            	} while (true);
            	
            	loop21:
            		;	// Stops C# compiler whinging that label 'loop21' has no statements

            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:311:1: scmStyleList[ScmStyle style] : ( DELETED )* ;
    public void scmStyleList(ScmStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:312:2: ( ( DELETED )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:312:4: ( DELETED )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:312:4: ( DELETED )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);
            	    
            	    if ( (LA22_0 == DELETED) )
            	    {
            	        alt22 = 1;
            	    }
            	    
            	
            	    switch (alt22) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:312:5: DELETED
            			    {
            			    	Match(input,DELETED,FOLLOW_DELETED_in_scmStyleList2294); 
            			    	style.Deleted = true; 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop22;
            	    }
            	} while (true);
            	
            	loop22:
            		;	// Stops C# compiler whinging that label 'loop22' has no statements

            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:314:1: parExpr returns [string expr] : ( LP (pe= parExpr )+ RP | op= operand | oa= opartors );
    public string parExpr() // throws RecognitionException [1]
    {   

        string expr = null;
    
        string pe = null;

        string op = null;

        string oa = null;
        
    
        
        expr =  string.Empty;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:318:2: ( LP (pe= parExpr )+ RP | op= operand | oa= opartors )
            int alt24 = 3;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                alt24 = 1;
                }
                break;
            case FALSE:
            case TRUE:
            case ID:
            case NUMBER:
            	{
                alt24 = 2;
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
                alt24 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d24s0 =
            	        new NoViableAltException("314:1: parExpr returns [string expr] : ( LP (pe= parExpr )+ RP | op= operand | oa= opartors );", 24, 0, input);
            
            	    throw nvae_d24s0;
            }
            
            switch (alt24) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:318:4: LP (pe= parExpr )+ RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_parExpr2315); 
                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:318:7: (pe= parExpr )+
                    	int cnt23 = 0;
                    	do 
                    	{
                    	    int alt23 = 2;
                    	    int LA23_0 = input.LA(1);
                    	    
                    	    if ( (LA23_0 == LP || (LA23_0 >= FALSE && LA23_0 <= TRUE) || LA23_0 == ID || (LA23_0 >= NUMBER && LA23_0 <= EQ)) )
                    	    {
                    	        alt23 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt23) 
                    		{
                    			case 1 :
                    			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:318:8: pe= parExpr
                    			    {
                    			    	PushFollow(FOLLOW_parExpr_in_parExpr2322);
                    			    	pe = parExpr();
                    			    	followingStackPointer_--;

                    			    	expr +=pe; 
                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    if ( cnt23 >= 1 ) goto loop23;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(23, input);
                    		            throw eee;
                    	    }
                    	    cnt23++;
                    	} while (true);
                    	
                    	loop23:
                    		;	// Stops C# compiler whinging that label 'loop23' has no statements

                    	Match(input,RP,FOLLOW_RP_in_parExpr2328); 
                    	expr =  "(" + expr + ")";
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:319:4: op= operand
                    {
                    	PushFollow(FOLLOW_operand_in_parExpr2340);
                    	op = operand();
                    	followingStackPointer_--;

                    	expr += op + " "; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:320:4: oa= opartors
                    {
                    	PushFollow(FOLLOW_opartors_in_parExpr2351);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:323:1: operand returns [string str] : (i= ID | i= NUMBER | i= TRUE | i= FALSE );
    public string operand() // throws RecognitionException [1]
    {   

        string str = null;
    
        IToken i = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:324:2: (i= ID | i= NUMBER | i= TRUE | i= FALSE )
            int alt25 = 4;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt25 = 1;
                }
                break;
            case NUMBER:
            	{
                alt25 = 2;
                }
                break;
            case TRUE:
            	{
                alt25 = 3;
                }
                break;
            case FALSE:
            	{
                alt25 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d25s0 =
            	        new NoViableAltException("323:1: operand returns [string str] : (i= ID | i= NUMBER | i= TRUE | i= FALSE );", 25, 0, input);
            
            	    throw nvae_d25s0;
            }
            
            switch (alt25) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:324:4: i= ID
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,ID,FOLLOW_ID_in_operand2372); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:325:4: i= NUMBER
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,NUMBER,FOLLOW_NUMBER_in_operand2383); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:326:4: i= TRUE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,TRUE,FOLLOW_TRUE_in_operand2394); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:327:4: i= FALSE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,FALSE,FOLLOW_FALSE_in_operand2405); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:329:1: opartors returns [string str] : (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE );
    public string opartors() // throws RecognitionException [1]
    {   

        string str = null;
    
        IToken i = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:330:2: (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE )
            int alt26 = 8;
            switch ( input.LA(1) ) 
            {
            case PLUS:
            	{
                alt26 = 1;
                }
                break;
            case MINUS:
            	{
                alt26 = 2;
                }
                break;
            case STAR:
            	{
                alt26 = 3;
                }
                break;
            case SLASH:
            	{
                alt26 = 4;
                }
                break;
            case LT:
            	{
                alt26 = 5;
                }
                break;
            case GT:
            	{
                alt26 = 6;
                }
                break;
            case EQ:
            	{
                alt26 = 7;
                }
                break;
            case QUOTE:
            	{
                alt26 = 8;
                }
                break;
            	default:
            	    NoViableAltException nvae_d26s0 =
            	        new NoViableAltException("329:1: opartors returns [string str] : (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE );", 26, 0, input);
            
            	    throw nvae_d26s0;
            }
            
            switch (alt26) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:330:4: i= PLUS
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,PLUS,FOLLOW_PLUS_in_opartors2424); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:331:4: i= MINUS
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,MINUS,FOLLOW_MINUS_in_opartors2435); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:332:4: i= STAR
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,STAR,FOLLOW_STAR_in_opartors2446); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:333:4: i= SLASH
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,SLASH,FOLLOW_SLASH_in_opartors2457); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:334:4: i= LT
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,LT,FOLLOW_LT_in_opartors2468); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:335:4: i= GT
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,GT,FOLLOW_GT_in_opartors2479); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:336:4: i= EQ
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,EQ,FOLLOW_EQ_in_opartors2490); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:337:4: i= QUOTE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_opartors2501); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:339:1: comment returns [string comm] : c= COMMENT ;
    public string comment() // throws RecognitionException [1]
    {   

        string comm = null;
    
        IToken c = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:340:2: (c= COMMENT )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:340:4: c= COMMENT
            {
            	c = (IToken)input.LT(1);
            	Match(input,COMMENT,FOLLOW_COMMENT_in_comment2520); 
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

 

    public static readonly BitSet FOLLOW_scmBlock_in_main382 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_EOF_in_main385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmFrm_in_scmBlock398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtn_in_scmBlock409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMsg_in_scmBlock420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmCbx_in_scmBlock431 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHpnl_in_scmBlock442 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVpnl_in_scmBlock453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmBlock464 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmBlock475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrm495 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmFrm497 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmFrm503 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrm505 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmFrm507 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_FRAME_in_scmFrm509 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmFrmProp_in_scmFrm511 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrm515 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrm517 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtn539 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmBtn541 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmBtn547 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtn549 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmBtn551 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_BUTTON_in_scmBtn553 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmBtnProp_in_scmBtn555 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtn559 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtn561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsg583 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmMsg585 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmMsg591 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsg593 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmMsg595 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_MESSAGE_in_scmMsg597 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmMsgProp_in_scmMsg599 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsg603 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsg605 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmCbx625 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmCbx627 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmCbx633 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmCbx635 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmCbx637 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_CHECKBOX_in_scmCbx639 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmCbxProp_in_scmCbx641 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmCbx645 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmCbx647 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHpnl668 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmHpnl670 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmHpnl676 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmHpnl678 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmHpnl680 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_HPANEL_in_scmHpnl682 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmHpnlProp_in_scmHpnl684 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHpnl688 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHpnl690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmVpnl711 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmVpnl713 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmVpnl719 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmVpnl721 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmVpnl723 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_VPANEL_in_scmVpnl725 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmVpnlProp_in_scmVpnl727 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmVpnl731 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmVpnl733 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmFrmProp751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmFrmProp762 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmWidthProp_in_scmFrmProp773 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHeightProp_in_scmFrmProp784 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmFrmProp795 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBorderProp_in_scmFrmProp806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmSpacingProp_in_scmFrmProp817 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmFrmProp828 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmFrmProp839 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmFrmProp850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmFrmProp861 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmAlignmentProp_in_scmFrmProp868 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmFrmStyleProp_in_scmFrmProp876 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmXYProp_in_scmFrmProp888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmFrmProp899 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmFrmProp910 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmBtnProp928 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmBtnProp939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmBtnProp950 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmBtnProp961 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmBtnProp972 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmBtnProp983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmBtnProp994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmBtnProp1005 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmBtnProp1016 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtnStyleProp_in_scmBtnProp1023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmBtnProp1035 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmBtnProp1046 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmMsgProp1063 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmMsgProp1074 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmMsgProp1085 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmMsgProp1096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmMsgProp1107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmMsgProp1118 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmMsgProp1129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmMsgProp1140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmMsgProp1151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStyleProp_in_scmMsgProp1158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmMsgProp1170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmMsgProp1181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmCbxProp1199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmCbxProp1210 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmCbxProp1221 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmCbxProp1232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmCbxProp1243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmCbxProp1254 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmCbxProp1265 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmCbxProp1276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmCbxProp1287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStyleProp_in_scmCbxProp1294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmCbxProp1306 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmCbxProp1317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmHpnlProp1335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmHpnlProp1346 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmHpnlProp1357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmHpnlProp1368 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmHpnlProp1379 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmHpnlProp1390 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmHpnlProp1401 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmHpnlProp1412 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBorderProp_in_scmHpnlProp1423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmSpacingProp_in_scmHpnlProp1434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtnStyleProp_in_scmHpnlProp1441 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmAlignmentProp_in_scmHpnlProp1449 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmHpnlProp1461 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmHpnlProp1472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmVpnlProp1490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmVpnlProp1501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmVpnlProp1512 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmVpnlProp1523 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmVpnlProp1534 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmVpnlProp1545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmVpnlProp1556 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmVpnlProp1567 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBorderProp_in_scmVpnlProp1578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmSpacingProp_in_scmVpnlProp1589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtnStyleProp_in_scmVpnlProp1596 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmAlignmentProp_in_scmVpnlProp1604 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmVpnlProp1616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmVpnlProp1627 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmParentProp1643 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_PARENT_in_scmParentProp1645 = new BitSet(new ulong[]{0x0000200020000000UL});
    public static readonly BitSet FOLLOW_set_in_scmParentProp1650 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmParentProp1658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmLabelProp1674 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LABEL_in_scmLabelProp1676 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_NAME_in_scmLabelProp1682 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmLabelProp1684 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmWidthProp1700 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_WIDTH_in_scmWidthProp1702 = new BitSet(new ulong[]{0x0000800020000000UL});
    public static readonly BitSet FOLLOW_set_in_scmWidthProp1707 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmWidthProp1713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHeightProp1728 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_HEIGHT_in_scmHeightProp1730 = new BitSet(new ulong[]{0x0000800020000000UL});
    public static readonly BitSet FOLLOW_set_in_scmHeightProp1736 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHeightProp1742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmXYProp1758 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmXYProp1764 = new BitSet(new ulong[]{0x0000800020000000UL});
    public static readonly BitSet FOLLOW_set_in_scmXYProp1770 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmXYProp1776 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmEnabledProp1792 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_ENABLED_in_scmEnabledProp1794 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_set_in_scmEnabledProp1800 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmEnabledProp1806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBorderProp1822 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_BORDER_in_scmBorderProp1824 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmBorderProp1830 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBorderProp1832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmSpacingProp1847 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_SPACING_in_scmSpacingProp1849 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmSpacingProp1855 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmSpacingProp1857 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMinWidthProp1872 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_MIN_WIDTH_in_scmMinWidthProp1874 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmMinWidthProp1880 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMinWidthProp1882 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMinHeightProp1897 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_MIN_HEIGHT_in_scmMinHeightProp1899 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmMinHeightProp1905 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMinHeightProp1907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStretchWidthProp1922 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_STRETCH_WIDTH_in_scmStretchWidthProp1924 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_set_in_scmStretchWidthProp1930 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStretchWidthProp1936 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStretchHeightProp1951 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_STRETCH_HEIGHT_in_scmStretchHeightProp1953 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_set_in_scmStretchHeightProp1959 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStretchHeightProp1965 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmAlignmentProp1979 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_ALIGNMENT_in_scmAlignmentProp1981 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmAlignmentProp1983 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmAlignmentProp1985 = new BitSet(new ulong[]{0x0000000D00000000UL});
    public static readonly BitSet FOLLOW_scmHorizAlign_in_scmAlignmentProp1987 = new BitSet(new ulong[]{0x0000000380000000UL});
    public static readonly BitSet FOLLOW_scmVerticalAlign_in_scmAlignmentProp1990 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmAlignmentProp1993 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmAlignmentProp1995 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp2007 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmFrmStyleProp2009 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmFrmStyleProp2011 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp2013 = new BitSet(new ulong[]{0x000007E010000000UL});
    public static readonly BitSet FOLLOW_scmFrmStyleList_in_scmFrmStyleProp2015 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp2018 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp2020 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp2025 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmFrmStyleProp2027 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmFrmStyleProp2029 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp2031 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp2043 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmBtnStyleProp2045 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmBtnStyleProp2047 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp2049 = new BitSet(new ulong[]{0x0000100010040000UL});
    public static readonly BitSet FOLLOW_scmBtnStyleList_in_scmBtnStyleProp2051 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp2054 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp2056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp2061 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmBtnStyleProp2063 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmBtnStyleProp2065 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp2067 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStyleProp2079 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmStyleProp2081 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmStyleProp2083 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmStyleProp2085 = new BitSet(new ulong[]{0x0000100010000000UL});
    public static readonly BitSet FOLLOW_scmStyleList_in_scmStyleProp2087 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStyleProp2090 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStyleProp2092 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStyleProp2097 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmStyleProp2099 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmStyleProp2101 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStyleProp2103 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmVertMargin2116 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_VERT_MARGIN_in_scmVertMargin2118 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmVertMargin2124 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmVertMargin2126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHorizMargin2142 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_HORIZ_MARGIN_in_scmHorizMargin2144 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmHorizMargin2150 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHorizMargin2152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TOP_in_scmVerticalAlign2165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CENTER_in_scmVerticalAlign2172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOTTOM_in_scmVerticalAlign2179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFT_in_scmHorizAlign2192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CENTER_in_scmHorizAlign2199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RIGHT_in_scmHorizAlign2206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NO_RESIZE_BORDER_in_scmFrmStyleList2220 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_NO_CAPTION_in_scmFrmStyleList2227 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_NO_SYSTEM_MENU_in_scmFrmStyleList2234 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_MDI_PARENT_in_scmFrmStyleList2241 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_MDI_CHILD_in_scmFrmStyleList2248 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_scmFrmStyleList2255 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_BORDER_in_scmBtnStyleList2270 = new BitSet(new ulong[]{0x0000100000040002UL});
    public static readonly BitSet FOLLOW_DELETED_in_scmBtnStyleList2278 = new BitSet(new ulong[]{0x0000100000040002UL});
    public static readonly BitSet FOLLOW_DELETED_in_scmStyleList2294 = new BitSet(new ulong[]{0x0000100000000002UL});
    public static readonly BitSet FOLLOW_LP_in_parExpr2315 = new BitSet(new ulong[]{0x00FFA00068000000UL});
    public static readonly BitSet FOLLOW_parExpr_in_parExpr2322 = new BitSet(new ulong[]{0x00FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_parExpr2328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operand_in_parExpr2340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_opartors_in_parExpr2351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_operand2372 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_operand2383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_operand2394 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_operand2405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_opartors2424 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_opartors2435 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STAR_in_opartors2446 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SLASH_in_opartors2457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_opartors2468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GT_in_opartors2479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQ_in_opartors2490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOTE_in_opartors2501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMENT_in_comment2520 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}