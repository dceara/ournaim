// $ANTLR 3.0.1 D:\\Projects\\AntlrTestApps\\ScmGrammar.g 2008-06-17 02:48:17
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | com= comment | pe= parExpr );
    public void scmBlock() // throws RecognitionException [1]
    {   
        ScmFrameProperties frm = null;

        ScmButtonProperties btn = null;

        ScmMessageProperties msg = null;

        ScmCheckBoxProperties cbx = null;

        ScmHorizontalPanelProperties hpnl = null;

        string com = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:80:2: (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | com= comment | pe= parExpr )
            int alt2 = 7;
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
                                case MESSAGE:
                                	{
                                    alt2 = 3;
                                    }
                                    break;
                                case CHECKBOX:
                                	{
                                    alt2 = 4;
                                    }
                                    break;
                                case FRAME:
                                	{
                                    alt2 = 1;
                                    }
                                    break;
                                case BUTTON:
                                	{
                                    alt2 = 2;
                                    }
                                    break;
                                case HPANEL:
                                	{
                                    alt2 = 5;
                                    }
                                    break;
                                	default:
                                	    NoViableAltException nvae_d2s7 =
                                	        new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | com= comment | pe= parExpr );", 2, 7, input);
                                
                                	    throw nvae_d2s7;
                                }
                            
                            }
                            else 
                            {
                                NoViableAltException nvae_d2s6 =
                                    new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | com= comment | pe= parExpr );", 2, 6, input);
                            
                                throw nvae_d2s6;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d2s5 =
                                new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | com= comment | pe= parExpr );", 2, 5, input);
                        
                            throw nvae_d2s5;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d2s4 =
                            new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | com= comment | pe= parExpr );", 2, 4, input);
                    
                        throw nvae_d2s4;
                    }
                }
                else if ( (LA2_1 == LP || (LA2_1 >= FALSE && LA2_1 <= TRUE) || LA2_1 == ID || (LA2_1 >= NUMBER && LA2_1 <= EQ)) )
                {
                    alt2 = 7;
                }
                else 
                {
                    NoViableAltException nvae_d2s1 =
                        new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | com= comment | pe= parExpr );", 2, 1, input);
                
                    throw nvae_d2s1;
                }
                }
                break;
            case COMMENT:
            	{
                alt2 = 6;
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
                alt2 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("79:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | cbx= scmCbx | hpnl= scmHpnl | com= comment | pe= parExpr );", 2, 0, input);
            
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
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:85:4: com= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmBlock453);
                    	com = comment();
                    	followingStackPointer_--;

                    	_parsedData.Add(new ScmComment(com));
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:86:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmBlock464);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:88:1: scmFrm returns [ScmFrameProperties frmProp] : LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP ;
    public ScmFrameProperties scmFrm() // throws RecognitionException [1]
    {   

        ScmFrameProperties frmProp = null;
    
        IToken id = null;
    
        
        	ScmFrame frame = new ScmFrame();
        	frmProp =  frame.ScmPropertyObject as ScmFrameProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:94:2: ( LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:94:4: LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmFrm484); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmFrm486); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmFrm492); 
            	Match(input,LP,FOLLOW_LP_in_scmFrm494); 
            	Match(input,NEW,FOLLOW_NEW_in_scmFrm496); 
            	Match(input,FRAME,FOLLOW_FRAME_in_scmFrm498); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:94:35: ( scmFrmProp[$frmProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:94:35: scmFrmProp[$frmProp]
            			    {
            			    	PushFollow(FOLLOW_scmFrmProp_in_scmFrm500);
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

            	Match(input,RP,FOLLOW_RP_in_scmFrm504); 
            	Match(input,RP,FOLLOW_RP_in_scmFrm506); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:96:1: scmBtn returns [ScmButtonProperties btnProp] : LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP ;
    public ScmButtonProperties scmBtn() // throws RecognitionException [1]
    {   

        ScmButtonProperties btnProp = null;
    
        IToken id = null;
    
        
        	ScmButton btn = new ScmButton();
        	btnProp =  btn.ScmPropertyObject as ScmButtonProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:102:2: ( LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:102:4: LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBtn528); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmBtn530); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmBtn536); 
            	Match(input,LP,FOLLOW_LP_in_scmBtn538); 
            	Match(input,NEW,FOLLOW_NEW_in_scmBtn540); 
            	Match(input,BUTTON,FOLLOW_BUTTON_in_scmBtn542); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:102:36: ( scmBtnProp[$btnProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:102:36: scmBtnProp[$btnProp]
            			    {
            			    	PushFollow(FOLLOW_scmBtnProp_in_scmBtn544);
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

            	Match(input,RP,FOLLOW_RP_in_scmBtn548); 
            	Match(input,RP,FOLLOW_RP_in_scmBtn550); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:104:1: scmMsg returns [ScmMessageProperties msgProp] : LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP ;
    public ScmMessageProperties scmMsg() // throws RecognitionException [1]
    {   

        ScmMessageProperties msgProp = null;
    
        IToken id = null;
    
        
        	ScmMessage msg = new ScmMessage();
        	msgProp =  msg.ScmPropertyObject as ScmMessageProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:110:2: ( LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:110:4: LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMsg572); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmMsg574); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmMsg580); 
            	Match(input,LP,FOLLOW_LP_in_scmMsg582); 
            	Match(input,NEW,FOLLOW_NEW_in_scmMsg584); 
            	Match(input,MESSAGE,FOLLOW_MESSAGE_in_scmMsg586); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:110:37: ( scmMsgProp[$msgProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:110:37: scmMsgProp[$msgProp]
            			    {
            			    	PushFollow(FOLLOW_scmMsgProp_in_scmMsg588);
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

            	Match(input,RP,FOLLOW_RP_in_scmMsg592); 
            	Match(input,RP,FOLLOW_RP_in_scmMsg594); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:112:1: scmCbx returns [ScmCheckBoxProperties cbxProp] : LP DEFINE id= ID LP NEW CHECKBOX ( scmCbxProp[$cbxProp] )+ RP RP ;
    public ScmCheckBoxProperties scmCbx() // throws RecognitionException [1]
    {   

        ScmCheckBoxProperties cbxProp = null;
    
        IToken id = null;
    
        
        	ScmCheckBox cbx = new ScmCheckBox();
        	cbxProp =  cbx.ScmPropertyObject as ScmCheckBoxProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:118:2: ( LP DEFINE id= ID LP NEW CHECKBOX ( scmCbxProp[$cbxProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:118:4: LP DEFINE id= ID LP NEW CHECKBOX ( scmCbxProp[$cbxProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmCbx614); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmCbx616); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmCbx622); 
            	Match(input,LP,FOLLOW_LP_in_scmCbx624); 
            	Match(input,NEW,FOLLOW_NEW_in_scmCbx626); 
            	Match(input,CHECKBOX,FOLLOW_CHECKBOX_in_scmCbx628); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:118:38: ( scmCbxProp[$cbxProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:118:38: scmCbxProp[$cbxProp]
            			    {
            			    	PushFollow(FOLLOW_scmCbxProp_in_scmCbx630);
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

            	Match(input,RP,FOLLOW_RP_in_scmCbx634); 
            	Match(input,RP,FOLLOW_RP_in_scmCbx636); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:120:1: scmHpnl returns [ScmHorizontalPanelProperties hpnlProp] : LP DEFINE id= ID LP NEW HPANEL ( scmHpnlProp[$hpnlProp] )+ RP RP ;
    public ScmHorizontalPanelProperties scmHpnl() // throws RecognitionException [1]
    {   

        ScmHorizontalPanelProperties hpnlProp = null;
    
        IToken id = null;
    
        
        	ScmHorizontalPanel hpnl = new ScmHorizontalPanel();
        	hpnlProp =  hpnl.ScmPropertyObject as ScmHorizontalPanelProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:126:2: ( LP DEFINE id= ID LP NEW HPANEL ( scmHpnlProp[$hpnlProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:126:4: LP DEFINE id= ID LP NEW HPANEL ( scmHpnlProp[$hpnlProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHpnl657); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmHpnl659); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmHpnl665); 
            	Match(input,LP,FOLLOW_LP_in_scmHpnl667); 
            	Match(input,NEW,FOLLOW_NEW_in_scmHpnl669); 
            	Match(input,HPANEL,FOLLOW_HPANEL_in_scmHpnl671); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:126:36: ( scmHpnlProp[$hpnlProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:126:36: scmHpnlProp[$hpnlProp]
            			    {
            			    	PushFollow(FOLLOW_scmHpnlProp_in_scmHpnl673);
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

            	Match(input,RP,FOLLOW_RP_in_scmHpnl677); 
            	Match(input,RP,FOLLOW_RP_in_scmHpnl679); 
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

    
    // $ANTLR start scmFrmProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:136:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:137:2: (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr )
            int alt8 = 16;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case STRETCH_HEIGHT:
                	{
                    alt8 = 11;
                    }
                    break;
                case ALIGNMENT:
                	{
                    alt8 = 12;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt8 = 10;
                    }
                    break;
                case LABEL:
                	{
                    alt8 = 2;
                    }
                    break;
                case PARENT:
                	{
                    alt8 = 1;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt8 = 9;
                    }
                    break;
                case SPACING:
                	{
                    alt8 = 7;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt8 = 8;
                    }
                    break;
                case ENABLED:
                	{
                    alt8 = 5;
                    }
                    break;
                case ID:
                	{
                    switch ( input.LA(3) ) 
                    {
                    case NUMBER:
                    	{
                        int LA8_18 = input.LA(4);
                        
                        if ( (LA8_18 == RP) )
                        {
                            alt8 = 14;
                        }
                        else if ( (LA8_18 == LP || (LA8_18 >= FALSE && LA8_18 <= TRUE) || LA8_18 == ID || (LA8_18 >= NUMBER && LA8_18 <= EQ)) )
                        {
                            alt8 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d8s18 =
                                new NoViableAltException("136:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 8, 18, input);
                        
                            throw nvae_d8s18;
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
                        alt8 = 16;
                        }
                        break;
                    case FALSE:
                    	{
                        int LA8_19 = input.LA(4);
                        
                        if ( (LA8_19 == RP) )
                        {
                            alt8 = 14;
                        }
                        else if ( (LA8_19 == LP || (LA8_19 >= FALSE && LA8_19 <= TRUE) || LA8_19 == ID || (LA8_19 >= NUMBER && LA8_19 <= EQ)) )
                        {
                            alt8 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d8s19 =
                                new NoViableAltException("136:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 8, 19, input);
                        
                            throw nvae_d8s19;
                        }
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d8s13 =
                    	        new NoViableAltException("136:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 8, 13, input);
                    
                    	    throw nvae_d8s13;
                    }
                
                    }
                    break;
                case BORDER:
                	{
                    alt8 = 6;
                    }
                    break;
                case WIDTH:
                	{
                    alt8 = 3;
                    }
                    break;
                case STYLE:
                	{
                    alt8 = 13;
                    }
                    break;
                case HEIGHT:
                	{
                    alt8 = 4;
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
                    alt8 = 16;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d8s1 =
                	        new NoViableAltException("136:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 8, 1, input);
                
                	    throw nvae_d8s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt8 = 15;
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
                alt8 = 16;
                }
                break;
            	default:
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("136:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 8, 0, input);
            
            	    throw nvae_d8s0;
            }
            
            switch (alt8) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:137:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmFrmProp701);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	frmProp.Parent = parent; frmProp.AddParesedProperty(FramePropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:138:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmFrmProp712);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	frmProp.Label = label; frmProp.AddParesedProperty(FramePropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:139:4: width= scmWidthProp
                    {
                    	PushFollow(FOLLOW_scmWidthProp_in_scmFrmProp723);
                    	width = scmWidthProp();
                    	followingStackPointer_--;

                    	if (width != "#f") { frmProp.AutosizeWidth = false; frmProp.Width = width; frmProp.AddParesedProperty(FramePropNames.Width);}
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:140:4: height= scmHeightProp
                    {
                    	PushFollow(FOLLOW_scmHeightProp_in_scmFrmProp734);
                    	height = scmHeightProp();
                    	followingStackPointer_--;

                    	if (height != "#f") {frmProp.AutosizeHeight = false; frmProp.Height = height; frmProp.AddParesedProperty(FramePropNames.Height);}
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:141:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmFrmProp745);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	frmProp.Enabled = enabled; frmProp.AddParesedProperty(FramePropNames.Enabled);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:142:4: border= scmBorderProp
                    {
                    	PushFollow(FOLLOW_scmBorderProp_in_scmFrmProp756);
                    	border = scmBorderProp();
                    	followingStackPointer_--;

                    	frmProp.Border = border; frmProp.AddParesedProperty(FramePropNames.Border);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:143:4: spacing= scmSpacingProp
                    {
                    	PushFollow(FOLLOW_scmSpacingProp_in_scmFrmProp767);
                    	spacing = scmSpacingProp();
                    	followingStackPointer_--;

                    	frmProp.Spacing = spacing; frmProp.AddParesedProperty(FramePropNames.Spacing);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:144:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmFrmProp778);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	frmProp.MinWidth = minWidth; frmProp.AddParesedProperty(FramePropNames.MinWidth);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:145:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmFrmProp789);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	frmProp.MinHeight = minHeight; frmProp.AddParesedProperty(FramePropNames.MinHeight);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:146:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmFrmProp800);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	frmProp.StretchableWidth = strechWidth; frmProp.AddParesedProperty(FramePropNames.StrechWidth);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:147:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmFrmProp811);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	frmProp.StretchableHeight = strechHeight; frmProp.AddParesedProperty(FramePropNames.StrechHeight);
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:148:4: scmAlignmentProp[frmProp.Alignment]
                    {
                    	PushFollow(FOLLOW_scmAlignmentProp_in_scmFrmProp818);
                    	scmAlignmentProp(frmProp.Alignment);
                    	followingStackPointer_--;

                    	frmProp.AddParesedProperty(FramePropNames.Alignment);
                    
                    }
                    break;
                case 13 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:149:4: scmFrmStyleProp[frmProp.Style]
                    {
                    	PushFollow(FOLLOW_scmFrmStyleProp_in_scmFrmProp826);
                    	scmFrmStyleProp(frmProp.Style);
                    	followingStackPointer_--;

                    	frmProp.AddParesedProperty(FramePropNames.Style);
                    
                    }
                    break;
                case 14 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:150:4: xyProp= scmXYProp
                    {
                    	PushFollow(FOLLOW_scmXYProp_in_scmFrmProp838);
                    	xyProp = scmXYProp();
                    	followingStackPointer_--;

                    	frmProp.SetXYProp(xyProp.name, xyProp.value);
                    
                    }
                    break;
                case 15 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:151:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmFrmProp849);
                    	comm = comment();
                    	followingStackPointer_--;

                    	frmProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 16 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:152:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmFrmProp860);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:154:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:155:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr )
            int alt9 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case MIN_WIDTH:
                	{
                    alt9 = 4;
                    }
                    break;
                case STYLE:
                	{
                    alt9 = 10;
                    }
                    break;
                case ENABLED:
                	{
                    alt9 = 3;
                    }
                    break;
                case PARENT:
                	{
                    alt9 = 1;
                    }
                    break;
                case LABEL:
                	{
                    alt9 = 2;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt9 = 6;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt9 = 9;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt9 = 7;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt9 = 5;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt9 = 8;
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
                	        new NoViableAltException("154:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );", 9, 1, input);
                
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
            	        new NoViableAltException("154:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );", 9, 0, input);
            
            	    throw nvae_d9s0;
            }
            
            switch (alt9) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:155:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmBtnProp878);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	btnProp.Parent = parent; btnProp.AddParesedProperty(ButtonPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:156:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmBtnProp889);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	btnProp.Label = label; btnProp.AddParesedProperty(ButtonPropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:157:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmBtnProp900);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	btnProp.Enabled = enabled; btnProp.AddParesedProperty(ButtonPropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:158:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmBtnProp911);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	if (minWidth != 0) btnProp.AutosizeWidth = false; btnProp.MinWidth = minWidth; btnProp.AddParesedProperty(ButtonPropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:159:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmBtnProp922);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	if (minHeight != 0) btnProp.AutosizeHeight = false; btnProp.MinHeight = minHeight; btnProp.AddParesedProperty( ButtonPropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:160:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmBtnProp933);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	btnProp.StretchableWidth = strechWidth; btnProp.AddParesedProperty(ButtonPropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:161:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmBtnProp944);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	btnProp.StretchableHeight = strechHeight; btnProp.AddParesedProperty(ButtonPropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:162:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmBtnProp955);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	btnProp.VerticalMargin = vertMarg; btnProp.AddParesedProperty(ButtonPropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:163:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmBtnProp966);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	btnProp.HorizontalMargin = vertMarg; btnProp.AddParesedProperty(ButtonPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:164:4: scmBtnStyleProp[btnProp.Style]
                    {
                    	PushFollow(FOLLOW_scmBtnStyleProp_in_scmBtnProp973);
                    	scmBtnStyleProp(btnProp.Style);
                    	followingStackPointer_--;

                    	btnProp.AddParesedProperty(ButtonPropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:165:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmBtnProp985);
                    	comm = comment();
                    	followingStackPointer_--;

                    	btnProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:166:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmBtnProp996);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:168:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:169:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr )
            int alt10 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
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
                case MIN_HEIGHT:
                	{
                    alt10 = 5;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt10 = 9;
                    }
                    break;
                case STYLE:
                	{
                    alt10 = 10;
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
                	        new NoViableAltException("168:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr );", 10, 1, input);
                
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
            	        new NoViableAltException("168:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[msgProp.Style] | comm= comment | pe= parExpr );", 10, 0, input);
            
            	    throw nvae_d10s0;
            }
            
            switch (alt10) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:169:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmMsgProp1013);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	msgProp.Parent = parent; msgProp.AddParesedProperty(MessagePropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:170:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmMsgProp1024);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	msgProp.Label = label; msgProp.AddParesedProperty(MessagePropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:171:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmMsgProp1035);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	msgProp.Enabled = enabled; msgProp.AddParesedProperty(MessagePropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:172:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmMsgProp1046);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	if (minWidth != 0) msgProp.AutosizeWidth = false; msgProp.MinWidth = minWidth; msgProp.AddParesedProperty(MessagePropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:173:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmMsgProp1057);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	if (minHeight != 0) msgProp.AutosizeHeight = false; msgProp.MinHeight = minHeight; msgProp.AddParesedProperty( MessagePropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:174:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmMsgProp1068);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	msgProp.StretchableWidth = strechWidth; msgProp.AddParesedProperty(MessagePropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:175:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmMsgProp1079);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	msgProp.StretchableHeight = strechHeight; msgProp.AddParesedProperty(MessagePropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:176:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmMsgProp1090);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	msgProp.VerticalMargin = vertMarg; msgProp.AddParesedProperty(MessagePropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:177:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmMsgProp1101);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	msgProp.HorizontalMargin = vertMarg; msgProp.AddParesedProperty(MessagePropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:178:4: scmStyleProp[msgProp.Style]
                    {
                    	PushFollow(FOLLOW_scmStyleProp_in_scmMsgProp1108);
                    	scmStyleProp(msgProp.Style);
                    	followingStackPointer_--;

                    	msgProp.AddParesedProperty(MessagePropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:179:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmMsgProp1120);
                    	comm = comment();
                    	followingStackPointer_--;

                    	msgProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:180:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmMsgProp1131);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:182:1: scmCbxProp[ScmCheckBoxProperties cbxProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:183:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr )
            int alt11 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
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
                case PARENT:
                	{
                    alt11 = 1;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt11 = 9;
                    }
                    break;
                case LABEL:
                	{
                    alt11 = 2;
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
                	        new NoViableAltException("182:1: scmCbxProp[ScmCheckBoxProperties cbxProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr );", 11, 1, input);
                
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
            	        new NoViableAltException("182:1: scmCbxProp[ScmCheckBoxProperties cbxProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmStyleProp[cbxProp.Style] | comm= comment | pe= parExpr );", 11, 0, input);
            
            	    throw nvae_d11s0;
            }
            
            switch (alt11) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:183:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmCbxProp1149);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	cbxProp.Parent = parent; cbxProp.AddParesedProperty(CheckBoxPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:184:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmCbxProp1160);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	cbxProp.Label = label; cbxProp.AddParesedProperty(CheckBoxPropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:185:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmCbxProp1171);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	cbxProp.Enabled = enabled; cbxProp.AddParesedProperty(CheckBoxPropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:186:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmCbxProp1182);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	if (minWidth != 0) cbxProp.AutosizeWidth = false; cbxProp.MinWidth = minWidth; cbxProp.AddParesedProperty(CheckBoxPropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:187:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmCbxProp1193);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	if (minHeight != 0) cbxProp.AutosizeHeight = false; cbxProp.MinHeight = minHeight; cbxProp.AddParesedProperty( CheckBoxPropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:188:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmCbxProp1204);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	cbxProp.StretchableWidth = strechWidth; cbxProp.AddParesedProperty(CheckBoxPropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:189:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmCbxProp1215);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	cbxProp.StretchableHeight = strechHeight; cbxProp.AddParesedProperty(CheckBoxPropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:190:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmCbxProp1226);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	cbxProp.VerticalMargin = vertMarg; cbxProp.AddParesedProperty(CheckBoxPropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:191:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmCbxProp1237);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	cbxProp.HorizontalMargin = vertMarg; cbxProp.AddParesedProperty(CheckBoxPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:192:4: scmStyleProp[cbxProp.Style]
                    {
                    	PushFollow(FOLLOW_scmStyleProp_in_scmCbxProp1244);
                    	scmStyleProp(cbxProp.Style);
                    	followingStackPointer_--;

                    	cbxProp.AddParesedProperty(CheckBoxPropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:193:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmCbxProp1256);
                    	comm = comment();
                    	followingStackPointer_--;

                    	cbxProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:194:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmCbxProp1267);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:196:1: scmHpnlProp[ScmHorizontalPanelProperties hpnlProp] : (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[hpnlProp.Style] | scmAlignmentProp[hpnlProp.Alignment] | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:197:2: (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[hpnlProp.Style] | scmAlignmentProp[hpnlProp.Alignment] | comm= comment | pe= parExpr )
            int alt12 = 14;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case HORIZ_MARGIN:
                	{
                    alt12 = 8;
                    }
                    break;
                case ENABLED:
                	{
                    alt12 = 2;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt12 = 7;
                    }
                    break;
                case ALIGNMENT:
                	{
                    alt12 = 12;
                    }
                    break;
                case PARENT:
                	{
                    alt12 = 1;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt12 = 6;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt12 = 5;
                    }
                    break;
                case SPACING:
                	{
                    alt12 = 10;
                    }
                    break;
                case BORDER:
                	{
                    alt12 = 9;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt12 = 4;
                    }
                    break;
                case STYLE:
                	{
                    alt12 = 11;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt12 = 3;
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
                    alt12 = 14;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d12s1 =
                	        new NoViableAltException("196:1: scmHpnlProp[ScmHorizontalPanelProperties hpnlProp] : (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[hpnlProp.Style] | scmAlignmentProp[hpnlProp.Alignment] | comm= comment | pe= parExpr );", 12, 1, input);
                
                	    throw nvae_d12s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt12 = 13;
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
                alt12 = 14;
                }
                break;
            	default:
            	    NoViableAltException nvae_d12s0 =
            	        new NoViableAltException("196:1: scmHpnlProp[ScmHorizontalPanelProperties hpnlProp] : (parent= scmParentProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | border= scmBorderProp | spacing= scmSpacingProp | scmBtnStyleProp[hpnlProp.Style] | scmAlignmentProp[hpnlProp.Alignment] | comm= comment | pe= parExpr );", 12, 0, input);
            
            	    throw nvae_d12s0;
            }
            
            switch (alt12) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:197:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmHpnlProp1285);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	hpnlProp.Parent = parent; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:198:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmHpnlProp1296);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	hpnlProp.Enabled = enabled; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Enabled);
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:199:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmHpnlProp1307);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	if (minWidth != 0) hpnlProp.AutosizeWidth = false; hpnlProp.MinWidth = minWidth; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.MinWidth);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:200:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmHpnlProp1318);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	if (minHeight != 0) hpnlProp.AutosizeHeight = false; hpnlProp.MinHeight = minHeight; hpnlProp.AddParesedProperty( HorizontalPanelPropNames.MinHeight);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:201:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmHpnlProp1329);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	hpnlProp.StretchableWidth = strechWidth; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.StrechWidth);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:202:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmHpnlProp1340);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	hpnlProp.StretchableHeight = strechHeight; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.StrechHeight);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:203:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmHpnlProp1351);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	hpnlProp.VerticalMargin = vertMarg; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.VerticalMargin);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:204:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmHpnlProp1362);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	hpnlProp.HorizontalMargin = vertMarg; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:205:4: border= scmBorderProp
                    {
                    	PushFollow(FOLLOW_scmBorderProp_in_scmHpnlProp1373);
                    	border = scmBorderProp();
                    	followingStackPointer_--;

                    	hpnlProp.Border = border; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Border);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:206:4: spacing= scmSpacingProp
                    {
                    	PushFollow(FOLLOW_scmSpacingProp_in_scmHpnlProp1384);
                    	spacing = scmSpacingProp();
                    	followingStackPointer_--;

                    	hpnlProp.Spacing = spacing; hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Spacing);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:207:4: scmBtnStyleProp[hpnlProp.Style]
                    {
                    	PushFollow(FOLLOW_scmBtnStyleProp_in_scmHpnlProp1391);
                    	scmBtnStyleProp(hpnlProp.Style);
                    	followingStackPointer_--;

                    	hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Style);
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:208:4: scmAlignmentProp[hpnlProp.Alignment]
                    {
                    	PushFollow(FOLLOW_scmAlignmentProp_in_scmHpnlProp1399);
                    	scmAlignmentProp(hpnlProp.Alignment);
                    	followingStackPointer_--;

                    	hpnlProp.AddParesedProperty(HorizontalPanelPropNames.Alignment);
                    
                    }
                    break;
                case 13 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:209:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmHpnlProp1411);
                    	comm = comment();
                    	followingStackPointer_--;

                    	hpnlProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 14 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:210:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmHpnlProp1422);
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

    
    // $ANTLR start scmParentProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:212:1: scmParentProp returns [string parent] : LP PARENT par= ( ID | FALSE ) RP ;
    public string scmParentProp() // throws RecognitionException [1]
    {   

        string parent = null;
    
        IToken par = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:213:2: ( LP PARENT par= ( ID | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:213:4: LP PARENT par= ( ID | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmParentProp1438); 
            	Match(input,PARENT,FOLLOW_PARENT_in_scmParentProp1440); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmParentProp1445);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmParentProp1453); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:215:1: scmLabelProp returns [string label] : LP LABEL name= NAME RP ;
    public string scmLabelProp() // throws RecognitionException [1]
    {   

        string label = null;
    
        IToken name = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:216:2: ( LP LABEL name= NAME RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:216:4: LP LABEL name= NAME RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmLabelProp1469); 
            	Match(input,LABEL,FOLLOW_LABEL_in_scmLabelProp1471); 
            	name = (IToken)input.LT(1);
            	Match(input,NAME,FOLLOW_NAME_in_scmLabelProp1477); 
            	Match(input,RP,FOLLOW_RP_in_scmLabelProp1479); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:218:1: scmWidthProp returns [string width] : LP WIDTH v= ( NUMBER | FALSE ) RP ;
    public string scmWidthProp() // throws RecognitionException [1]
    {   

        string width = null;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:219:2: ( LP WIDTH v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:219:4: LP WIDTH v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmWidthProp1495); 
            	Match(input,WIDTH,FOLLOW_WIDTH_in_scmWidthProp1497); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmWidthProp1502);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmWidthProp1508); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:221:1: scmHeightProp returns [string height] : LP HEIGHT v= ( NUMBER | FALSE ) RP ;
    public string scmHeightProp() // throws RecognitionException [1]
    {   

        string height = null;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:222:2: ( LP HEIGHT v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:222:4: LP HEIGHT v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHeightProp1523); 
            	Match(input,HEIGHT,FOLLOW_HEIGHT_in_scmHeightProp1525); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmHeightProp1531);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmHeightProp1537); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:224:1: scmXYProp returns [string name, string value] : LP n= ID v= ( NUMBER | FALSE ) RP ;
    public scmXYProp_return scmXYProp() // throws RecognitionException [1]
    {   
        scmXYProp_return retval = new scmXYProp_return();
        retval.start = input.LT(1);
    
        IToken n = null;
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:225:2: ( LP n= ID v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:225:4: LP n= ID v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmXYProp1553); 
            	n = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmXYProp1559); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmXYProp1565);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmXYProp1571); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:227:1: scmEnabledProp returns [bool enabled] : LP ENABLED v= ( TRUE | FALSE ) RP ;
    public bool scmEnabledProp() // throws RecognitionException [1]
    {   

        bool enabled = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:228:2: ( LP ENABLED v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:228:4: LP ENABLED v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmEnabledProp1587); 
            	Match(input,ENABLED,FOLLOW_ENABLED_in_scmEnabledProp1589); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmEnabledProp1595);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmEnabledProp1601); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:231:1: scmBorderProp returns [int border] : LP BORDER nr= NUMBER RP ;
    public int scmBorderProp() // throws RecognitionException [1]
    {   

        int border = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:232:2: ( LP BORDER nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:232:4: LP BORDER nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBorderProp1617); 
            	Match(input,BORDER,FOLLOW_BORDER_in_scmBorderProp1619); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmBorderProp1625); 
            	Match(input,RP,FOLLOW_RP_in_scmBorderProp1627); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:234:1: scmSpacingProp returns [int spacing] : LP SPACING nr= NUMBER RP ;
    public int scmSpacingProp() // throws RecognitionException [1]
    {   

        int spacing = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:235:2: ( LP SPACING nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:235:4: LP SPACING nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmSpacingProp1642); 
            	Match(input,SPACING,FOLLOW_SPACING_in_scmSpacingProp1644); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmSpacingProp1650); 
            	Match(input,RP,FOLLOW_RP_in_scmSpacingProp1652); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:237:1: scmMinWidthProp returns [int minWidth] : LP MIN_WIDTH nr= NUMBER RP ;
    public int scmMinWidthProp() // throws RecognitionException [1]
    {   

        int minWidth = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:238:2: ( LP MIN_WIDTH nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:238:4: LP MIN_WIDTH nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMinWidthProp1667); 
            	Match(input,MIN_WIDTH,FOLLOW_MIN_WIDTH_in_scmMinWidthProp1669); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmMinWidthProp1675); 
            	Match(input,RP,FOLLOW_RP_in_scmMinWidthProp1677); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:240:1: scmMinHeightProp returns [int minHeight] : LP MIN_HEIGHT nr= NUMBER RP ;
    public int scmMinHeightProp() // throws RecognitionException [1]
    {   

        int minHeight = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:241:2: ( LP MIN_HEIGHT nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:241:4: LP MIN_HEIGHT nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMinHeightProp1692); 
            	Match(input,MIN_HEIGHT,FOLLOW_MIN_HEIGHT_in_scmMinHeightProp1694); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmMinHeightProp1700); 
            	Match(input,RP,FOLLOW_RP_in_scmMinHeightProp1702); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:243:1: scmStretchWidthProp returns [bool strechWidth] : LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP ;
    public bool scmStretchWidthProp() // throws RecognitionException [1]
    {   

        bool strechWidth = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:244:2: ( LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:244:4: LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmStretchWidthProp1717); 
            	Match(input,STRETCH_WIDTH,FOLLOW_STRETCH_WIDTH_in_scmStretchWidthProp1719); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmStretchWidthProp1725);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmStretchWidthProp1731); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:247:1: scmStretchHeightProp returns [bool strechHeigth] : LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP ;
    public bool scmStretchHeightProp() // throws RecognitionException [1]
    {   

        bool strechHeigth = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:248:2: ( LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:248:4: LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmStretchHeightProp1746); 
            	Match(input,STRETCH_HEIGHT,FOLLOW_STRETCH_HEIGHT_in_scmStretchHeightProp1748); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmStretchHeightProp1754);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmStretchHeightProp1760); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:251:1: scmAlignmentProp[ContainerAlignment alignment] : LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP ;
    public void scmAlignmentProp(ContainerAlignment alignment) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:252:2: ( LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:252:4: LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmAlignmentProp1774); 
            	Match(input,ALIGNMENT,FOLLOW_ALIGNMENT_in_scmAlignmentProp1776); 
            	Match(input,QUOTE,FOLLOW_QUOTE_in_scmAlignmentProp1778); 
            	Match(input,LP,FOLLOW_LP_in_scmAlignmentProp1780); 
            	PushFollow(FOLLOW_scmHorizAlign_in_scmAlignmentProp1782);
            	scmHorizAlign(alignment);
            	followingStackPointer_--;

            	PushFollow(FOLLOW_scmVerticalAlign_in_scmAlignmentProp1785);
            	scmVerticalAlign(alignment);
            	followingStackPointer_--;

            	Match(input,RP,FOLLOW_RP_in_scmAlignmentProp1788); 
            	Match(input,RP,FOLLOW_RP_in_scmAlignmentProp1790); 
            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:254:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmFrmStyleProp(ScmFrameStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:255:2: ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt13 = 2;
            int LA13_0 = input.LA(1);
            
            if ( (LA13_0 == LP) )
            {
                int LA13_1 = input.LA(2);
                
                if ( (LA13_1 == STYLE) )
                {
                    int LA13_2 = input.LA(3);
                    
                    if ( (LA13_2 == NULL) )
                    {
                        alt13 = 2;
                    }
                    else if ( (LA13_2 == QUOTE) )
                    {
                        alt13 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d13s2 =
                            new NoViableAltException("254:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 13, 2, input);
                    
                        throw nvae_d13s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d13s1 =
                        new NoViableAltException("254:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 13, 1, input);
                
                    throw nvae_d13s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("254:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 13, 0, input);
            
                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:255:4: LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1802); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmFrmStyleProp1804); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmFrmStyleProp1806); 
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1808); 
                    	PushFollow(FOLLOW_scmFrmStyleList_in_scmFrmStyleProp1810);
                    	scmFrmStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1813); 
                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1815); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:256:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1820); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmFrmStyleProp1822); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmFrmStyleProp1824); 
                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1826); 
                    
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:258:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmBtnStyleProp(ScmButtonStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:259:2: ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt14 = 2;
            int LA14_0 = input.LA(1);
            
            if ( (LA14_0 == LP) )
            {
                int LA14_1 = input.LA(2);
                
                if ( (LA14_1 == STYLE) )
                {
                    int LA14_2 = input.LA(3);
                    
                    if ( (LA14_2 == QUOTE) )
                    {
                        alt14 = 1;
                    }
                    else if ( (LA14_2 == NULL) )
                    {
                        alt14 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d14s2 =
                            new NoViableAltException("258:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 14, 2, input);
                    
                        throw nvae_d14s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d14s1 =
                        new NoViableAltException("258:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 14, 1, input);
                
                    throw nvae_d14s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d14s0 =
                    new NoViableAltException("258:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 14, 0, input);
            
                throw nvae_d14s0;
            }
            switch (alt14) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:259:4: LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1838); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmBtnStyleProp1840); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmBtnStyleProp1842); 
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1844); 
                    	PushFollow(FOLLOW_scmBtnStyleList_in_scmBtnStyleProp1846);
                    	scmBtnStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1849); 
                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1851); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:260:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1856); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmBtnStyleProp1858); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmBtnStyleProp1860); 
                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1862); 
                    
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:262:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmStyleProp(ScmStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:263:2: ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt15 = 2;
            int LA15_0 = input.LA(1);
            
            if ( (LA15_0 == LP) )
            {
                int LA15_1 = input.LA(2);
                
                if ( (LA15_1 == STYLE) )
                {
                    int LA15_2 = input.LA(3);
                    
                    if ( (LA15_2 == NULL) )
                    {
                        alt15 = 2;
                    }
                    else if ( (LA15_2 == QUOTE) )
                    {
                        alt15 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d15s2 =
                            new NoViableAltException("262:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );", 15, 2, input);
                    
                        throw nvae_d15s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d15s1 =
                        new NoViableAltException("262:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );", 15, 1, input);
                
                    throw nvae_d15s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d15s0 =
                    new NoViableAltException("262:1: scmStyleProp[ScmStyle style] : ( LP STYLE QUOTE LP scmStyleList[$style] RP RP | LP STYLE NULL RP );", 15, 0, input);
            
                throw nvae_d15s0;
            }
            switch (alt15) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:263:4: LP STYLE QUOTE LP scmStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmStyleProp1874); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmStyleProp1876); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmStyleProp1878); 
                    	Match(input,LP,FOLLOW_LP_in_scmStyleProp1880); 
                    	PushFollow(FOLLOW_scmStyleList_in_scmStyleProp1882);
                    	scmStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmStyleProp1885); 
                    	Match(input,RP,FOLLOW_RP_in_scmStyleProp1887); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:264:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmStyleProp1892); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmStyleProp1894); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmStyleProp1896); 
                    	Match(input,RP,FOLLOW_RP_in_scmStyleProp1898); 
                    
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:266:1: scmVertMargin returns [int val] : LP VERT_MARGIN v= NUMBER RP ;
    public int scmVertMargin() // throws RecognitionException [1]
    {   

        int val = 0;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:267:2: ( LP VERT_MARGIN v= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:267:4: LP VERT_MARGIN v= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmVertMargin1911); 
            	Match(input,VERT_MARGIN,FOLLOW_VERT_MARGIN_in_scmVertMargin1913); 
            	v = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmVertMargin1919); 
            	Match(input,RP,FOLLOW_RP_in_scmVertMargin1921); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:269:1: scmHorizMargin returns [int val] : LP HORIZ_MARGIN v= NUMBER RP ;
    public int scmHorizMargin() // throws RecognitionException [1]
    {   

        int val = 0;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:270:2: ( LP HORIZ_MARGIN v= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:270:4: LP HORIZ_MARGIN v= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHorizMargin1937); 
            	Match(input,HORIZ_MARGIN,FOLLOW_HORIZ_MARGIN_in_scmHorizMargin1939); 
            	v = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmHorizMargin1945); 
            	Match(input,RP,FOLLOW_RP_in_scmHorizMargin1947); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:272:1: scmVerticalAlign[ContainerAlignment align] : ( TOP | CENTER | BOTTOM );
    public void scmVerticalAlign(ContainerAlignment align) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:273:2: ( TOP | CENTER | BOTTOM )
            int alt16 = 3;
            switch ( input.LA(1) ) 
            {
            case TOP:
            	{
                alt16 = 1;
                }
                break;
            case CENTER:
            	{
                alt16 = 2;
                }
                break;
            case BOTTOM:
            	{
                alt16 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("272:1: scmVerticalAlign[ContainerAlignment align] : ( TOP | CENTER | BOTTOM );", 16, 0, input);
            
            	    throw nvae_d16s0;
            }
            
            switch (alt16) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:273:4: TOP
                    {
                    	Match(input,TOP,FOLLOW_TOP_in_scmVerticalAlign1960); 
                    	align.VerticalAlignment = VerticalAlign.Top; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:274:4: CENTER
                    {
                    	Match(input,CENTER,FOLLOW_CENTER_in_scmVerticalAlign1967); 
                    	align.VerticalAlignment = VerticalAlign.Center; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:275:4: BOTTOM
                    {
                    	Match(input,BOTTOM,FOLLOW_BOTTOM_in_scmVerticalAlign1974); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:277:1: scmHorizAlign[ContainerAlignment align] : ( LEFT | CENTER | RIGHT );
    public void scmHorizAlign(ContainerAlignment align) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:278:2: ( LEFT | CENTER | RIGHT )
            int alt17 = 3;
            switch ( input.LA(1) ) 
            {
            case LEFT:
            	{
                alt17 = 1;
                }
                break;
            case CENTER:
            	{
                alt17 = 2;
                }
                break;
            case RIGHT:
            	{
                alt17 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d17s0 =
            	        new NoViableAltException("277:1: scmHorizAlign[ContainerAlignment align] : ( LEFT | CENTER | RIGHT );", 17, 0, input);
            
            	    throw nvae_d17s0;
            }
            
            switch (alt17) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:278:4: LEFT
                    {
                    	Match(input,LEFT,FOLLOW_LEFT_in_scmHorizAlign1987); 
                    	align.HorizontalAlignment = HorizontalAlign.Left; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:279:4: CENTER
                    {
                    	Match(input,CENTER,FOLLOW_CENTER_in_scmHorizAlign1994); 
                    	align.HorizontalAlignment = HorizontalAlign.Center; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:280:4: RIGHT
                    {
                    	Match(input,RIGHT,FOLLOW_RIGHT_in_scmHorizAlign2001); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:282:1: scmFrmStyleList[ScmFrameStyle style] : ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )* ;
    public void scmFrmStyleList(ScmFrameStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:2: ( ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:4: ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:4: ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )*
            	do 
            	{
            	    int alt18 = 7;
            	    switch ( input.LA(1) ) 
            	    {
            	    case NO_RESIZE_BORDER:
            	    	{
            	        alt18 = 1;
            	        }
            	        break;
            	    case NO_CAPTION:
            	    	{
            	        alt18 = 2;
            	        }
            	        break;
            	    case NO_SYSTEM_MENU:
            	    	{
            	        alt18 = 3;
            	        }
            	        break;
            	    case MDI_PARENT:
            	    	{
            	        alt18 = 4;
            	        }
            	        break;
            	    case MDI_CHILD:
            	    	{
            	        alt18 = 5;
            	        }
            	        break;
            	    case FLOAT:
            	    	{
            	        alt18 = 6;
            	        }
            	        break;
            	    
            	    }
            	
            	    switch (alt18) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:283:5: NO_RESIZE_BORDER
            			    {
            			    	Match(input,NO_RESIZE_BORDER,FOLLOW_NO_RESIZE_BORDER_in_scmFrmStyleList2015); 
            			    	style.NoResizeBorder = true; 
            			    
            			    }
            			    break;
            			case 2 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:284:4: NO_CAPTION
            			    {
            			    	Match(input,NO_CAPTION,FOLLOW_NO_CAPTION_in_scmFrmStyleList2022); 
            			    	style.NoCaption = true; 
            			    
            			    }
            			    break;
            			case 3 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:285:4: NO_SYSTEM_MENU
            			    {
            			    	Match(input,NO_SYSTEM_MENU,FOLLOW_NO_SYSTEM_MENU_in_scmFrmStyleList2029); 
            			    	style.NoSystemMenu = true; 
            			    
            			    }
            			    break;
            			case 4 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:286:4: MDI_PARENT
            			    {
            			    	Match(input,MDI_PARENT,FOLLOW_MDI_PARENT_in_scmFrmStyleList2036); 
            			    	style.MdiParent = true; 
            			    
            			    }
            			    break;
            			case 5 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:287:4: MDI_CHILD
            			    {
            			    	Match(input,MDI_CHILD,FOLLOW_MDI_CHILD_in_scmFrmStyleList2043); 
            			    	style.MdiChild = true; 
            			    
            			    }
            			    break;
            			case 6 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:288:4: FLOAT
            			    {
            			    	Match(input,FLOAT,FOLLOW_FLOAT_in_scmFrmStyleList2050); 
            			    	style.Floating = true; 
            			    
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
    // $ANTLR end scmFrmStyleList

    
    // $ANTLR start scmBtnStyleList
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:290:1: scmBtnStyleList[ScmButtonStyle style] : ( BORDER | DELETED )* ;
    public void scmBtnStyleList(ScmButtonStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:291:2: ( ( BORDER | DELETED )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:291:4: ( BORDER | DELETED )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:291:4: ( BORDER | DELETED )*
            	do 
            	{
            	    int alt19 = 3;
            	    int LA19_0 = input.LA(1);
            	    
            	    if ( (LA19_0 == BORDER) )
            	    {
            	        alt19 = 1;
            	    }
            	    else if ( (LA19_0 == DELETED) )
            	    {
            	        alt19 = 2;
            	    }
            	    
            	
            	    switch (alt19) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:291:5: BORDER
            			    {
            			    	Match(input,BORDER,FOLLOW_BORDER_in_scmBtnStyleList2065); 
            			    	style.Border = true; 
            			    
            			    }
            			    break;
            			case 2 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:292:5: DELETED
            			    {
            			    	Match(input,DELETED,FOLLOW_DELETED_in_scmBtnStyleList2073); 
            			    	style.Deleted = true; 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop19;
            	    }
            	} while (true);
            	
            	loop19:
            		;	// Stops C# compiler whinging that label 'loop19' has no statements

            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:294:1: scmStyleList[ScmStyle style] : ( DELETED )* ;
    public void scmStyleList(ScmStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:295:2: ( ( DELETED )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:295:4: ( DELETED )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:295:4: ( DELETED )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);
            	    
            	    if ( (LA20_0 == DELETED) )
            	    {
            	        alt20 = 1;
            	    }
            	    
            	
            	    switch (alt20) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:295:5: DELETED
            			    {
            			    	Match(input,DELETED,FOLLOW_DELETED_in_scmStyleList2089); 
            			    	style.Deleted = true; 
            			    
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
    // $ANTLR end scmStyleList

    
    // $ANTLR start parExpr
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:297:1: parExpr returns [string expr] : ( LP (pe= parExpr )+ RP | op= operand | oa= opartors );
    public string parExpr() // throws RecognitionException [1]
    {   

        string expr = null;
    
        string pe = null;

        string op = null;

        string oa = null;
        
    
        
        expr =  string.Empty;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:301:2: ( LP (pe= parExpr )+ RP | op= operand | oa= opartors )
            int alt22 = 3;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                alt22 = 1;
                }
                break;
            case FALSE:
            case TRUE:
            case ID:
            case NUMBER:
            	{
                alt22 = 2;
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
                alt22 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d22s0 =
            	        new NoViableAltException("297:1: parExpr returns [string expr] : ( LP (pe= parExpr )+ RP | op= operand | oa= opartors );", 22, 0, input);
            
            	    throw nvae_d22s0;
            }
            
            switch (alt22) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:301:4: LP (pe= parExpr )+ RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_parExpr2110); 
                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:301:7: (pe= parExpr )+
                    	int cnt21 = 0;
                    	do 
                    	{
                    	    int alt21 = 2;
                    	    int LA21_0 = input.LA(1);
                    	    
                    	    if ( (LA21_0 == LP || (LA21_0 >= FALSE && LA21_0 <= TRUE) || LA21_0 == ID || (LA21_0 >= NUMBER && LA21_0 <= EQ)) )
                    	    {
                    	        alt21 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt21) 
                    		{
                    			case 1 :
                    			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:301:8: pe= parExpr
                    			    {
                    			    	PushFollow(FOLLOW_parExpr_in_parExpr2117);
                    			    	pe = parExpr();
                    			    	followingStackPointer_--;

                    			    	expr +=pe; 
                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    if ( cnt21 >= 1 ) goto loop21;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(21, input);
                    		            throw eee;
                    	    }
                    	    cnt21++;
                    	} while (true);
                    	
                    	loop21:
                    		;	// Stops C# compiler whinging that label 'loop21' has no statements

                    	Match(input,RP,FOLLOW_RP_in_parExpr2123); 
                    	expr =  "(" + expr + ")";
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:302:4: op= operand
                    {
                    	PushFollow(FOLLOW_operand_in_parExpr2135);
                    	op = operand();
                    	followingStackPointer_--;

                    	expr += op + " "; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:303:4: oa= opartors
                    {
                    	PushFollow(FOLLOW_opartors_in_parExpr2146);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:306:1: operand returns [string str] : (i= ID | i= NUMBER | i= TRUE | i= FALSE );
    public string operand() // throws RecognitionException [1]
    {   

        string str = null;
    
        IToken i = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:307:2: (i= ID | i= NUMBER | i= TRUE | i= FALSE )
            int alt23 = 4;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt23 = 1;
                }
                break;
            case NUMBER:
            	{
                alt23 = 2;
                }
                break;
            case TRUE:
            	{
                alt23 = 3;
                }
                break;
            case FALSE:
            	{
                alt23 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d23s0 =
            	        new NoViableAltException("306:1: operand returns [string str] : (i= ID | i= NUMBER | i= TRUE | i= FALSE );", 23, 0, input);
            
            	    throw nvae_d23s0;
            }
            
            switch (alt23) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:307:4: i= ID
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,ID,FOLLOW_ID_in_operand2167); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:308:4: i= NUMBER
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,NUMBER,FOLLOW_NUMBER_in_operand2178); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:309:4: i= TRUE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,TRUE,FOLLOW_TRUE_in_operand2189); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:310:4: i= FALSE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,FALSE,FOLLOW_FALSE_in_operand2200); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:312:1: opartors returns [string str] : (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE );
    public string opartors() // throws RecognitionException [1]
    {   

        string str = null;
    
        IToken i = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:313:2: (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE )
            int alt24 = 8;
            switch ( input.LA(1) ) 
            {
            case PLUS:
            	{
                alt24 = 1;
                }
                break;
            case MINUS:
            	{
                alt24 = 2;
                }
                break;
            case STAR:
            	{
                alt24 = 3;
                }
                break;
            case SLASH:
            	{
                alt24 = 4;
                }
                break;
            case LT:
            	{
                alt24 = 5;
                }
                break;
            case GT:
            	{
                alt24 = 6;
                }
                break;
            case EQ:
            	{
                alt24 = 7;
                }
                break;
            case QUOTE:
            	{
                alt24 = 8;
                }
                break;
            	default:
            	    NoViableAltException nvae_d24s0 =
            	        new NoViableAltException("312:1: opartors returns [string str] : (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE );", 24, 0, input);
            
            	    throw nvae_d24s0;
            }
            
            switch (alt24) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:313:4: i= PLUS
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,PLUS,FOLLOW_PLUS_in_opartors2219); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:314:4: i= MINUS
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,MINUS,FOLLOW_MINUS_in_opartors2230); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:315:4: i= STAR
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,STAR,FOLLOW_STAR_in_opartors2241); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:316:4: i= SLASH
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,SLASH,FOLLOW_SLASH_in_opartors2252); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:317:4: i= LT
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,LT,FOLLOW_LT_in_opartors2263); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:318:4: i= GT
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,GT,FOLLOW_GT_in_opartors2274); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:319:4: i= EQ
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,EQ,FOLLOW_EQ_in_opartors2285); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:320:4: i= QUOTE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_opartors2296); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:322:1: comment returns [string comm] : c= COMMENT ;
    public string comment() // throws RecognitionException [1]
    {   

        string comm = null;
    
        IToken c = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:323:2: (c= COMMENT )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:323:4: c= COMMENT
            {
            	c = (IToken)input.LT(1);
            	Match(input,COMMENT,FOLLOW_COMMENT_in_comment2315); 
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
    public static readonly BitSet FOLLOW_comment_in_scmBlock453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmBlock464 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrm484 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmFrm486 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmFrm492 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrm494 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmFrm496 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_FRAME_in_scmFrm498 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmFrmProp_in_scmFrm500 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrm504 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrm506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtn528 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmBtn530 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmBtn536 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtn538 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmBtn540 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_BUTTON_in_scmBtn542 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmBtnProp_in_scmBtn544 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtn548 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtn550 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsg572 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmMsg574 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmMsg580 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsg582 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmMsg584 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_MESSAGE_in_scmMsg586 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmMsgProp_in_scmMsg588 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsg592 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsg594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmCbx614 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmCbx616 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmCbx622 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmCbx624 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmCbx626 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_CHECKBOX_in_scmCbx628 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmCbxProp_in_scmCbx630 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmCbx634 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmCbx636 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHpnl657 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmHpnl659 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmHpnl665 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmHpnl667 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmHpnl669 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_HPANEL_in_scmHpnl671 = new BitSet(new ulong[]{0x01FFA00068000000UL});
    public static readonly BitSet FOLLOW_scmHpnlProp_in_scmHpnl673 = new BitSet(new ulong[]{0x01FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHpnl677 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHpnl679 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmFrmProp701 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmFrmProp712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmWidthProp_in_scmFrmProp723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHeightProp_in_scmFrmProp734 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmFrmProp745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBorderProp_in_scmFrmProp756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmSpacingProp_in_scmFrmProp767 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmFrmProp778 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmFrmProp789 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmFrmProp800 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmFrmProp811 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmAlignmentProp_in_scmFrmProp818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmFrmStyleProp_in_scmFrmProp826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmXYProp_in_scmFrmProp838 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmFrmProp849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmFrmProp860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmBtnProp878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmBtnProp889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmBtnProp900 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmBtnProp911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmBtnProp922 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmBtnProp933 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmBtnProp944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmBtnProp955 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmBtnProp966 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtnStyleProp_in_scmBtnProp973 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmBtnProp985 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmBtnProp996 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmMsgProp1013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmMsgProp1024 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmMsgProp1035 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmMsgProp1046 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmMsgProp1057 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmMsgProp1068 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmMsgProp1079 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmMsgProp1090 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmMsgProp1101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStyleProp_in_scmMsgProp1108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmMsgProp1120 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmMsgProp1131 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmCbxProp1149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmCbxProp1160 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmCbxProp1171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmCbxProp1182 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmCbxProp1193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmCbxProp1204 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmCbxProp1215 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmCbxProp1226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmCbxProp1237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStyleProp_in_scmCbxProp1244 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmCbxProp1256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmCbxProp1267 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmHpnlProp1285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmHpnlProp1296 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmHpnlProp1307 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmHpnlProp1318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmHpnlProp1329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmHpnlProp1340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmHpnlProp1351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmHpnlProp1362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBorderProp_in_scmHpnlProp1373 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmSpacingProp_in_scmHpnlProp1384 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtnStyleProp_in_scmHpnlProp1391 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmAlignmentProp_in_scmHpnlProp1399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmHpnlProp1411 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmHpnlProp1422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmParentProp1438 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_PARENT_in_scmParentProp1440 = new BitSet(new ulong[]{0x0000200020000000UL});
    public static readonly BitSet FOLLOW_set_in_scmParentProp1445 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmParentProp1453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmLabelProp1469 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LABEL_in_scmLabelProp1471 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_NAME_in_scmLabelProp1477 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmLabelProp1479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmWidthProp1495 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_WIDTH_in_scmWidthProp1497 = new BitSet(new ulong[]{0x0000800020000000UL});
    public static readonly BitSet FOLLOW_set_in_scmWidthProp1502 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmWidthProp1508 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHeightProp1523 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_HEIGHT_in_scmHeightProp1525 = new BitSet(new ulong[]{0x0000800020000000UL});
    public static readonly BitSet FOLLOW_set_in_scmHeightProp1531 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHeightProp1537 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmXYProp1553 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmXYProp1559 = new BitSet(new ulong[]{0x0000800020000000UL});
    public static readonly BitSet FOLLOW_set_in_scmXYProp1565 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmXYProp1571 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmEnabledProp1587 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_ENABLED_in_scmEnabledProp1589 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_set_in_scmEnabledProp1595 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmEnabledProp1601 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBorderProp1617 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_BORDER_in_scmBorderProp1619 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmBorderProp1625 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBorderProp1627 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmSpacingProp1642 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_SPACING_in_scmSpacingProp1644 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmSpacingProp1650 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmSpacingProp1652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMinWidthProp1667 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_MIN_WIDTH_in_scmMinWidthProp1669 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmMinWidthProp1675 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMinWidthProp1677 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMinHeightProp1692 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_MIN_HEIGHT_in_scmMinHeightProp1694 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmMinHeightProp1700 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMinHeightProp1702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStretchWidthProp1717 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_STRETCH_WIDTH_in_scmStretchWidthProp1719 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_set_in_scmStretchWidthProp1725 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStretchWidthProp1731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStretchHeightProp1746 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_STRETCH_HEIGHT_in_scmStretchHeightProp1748 = new BitSet(new ulong[]{0x0000000060000000UL});
    public static readonly BitSet FOLLOW_set_in_scmStretchHeightProp1754 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStretchHeightProp1760 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmAlignmentProp1774 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_ALIGNMENT_in_scmAlignmentProp1776 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmAlignmentProp1778 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmAlignmentProp1780 = new BitSet(new ulong[]{0x0000000D00000000UL});
    public static readonly BitSet FOLLOW_scmHorizAlign_in_scmAlignmentProp1782 = new BitSet(new ulong[]{0x0000000380000000UL});
    public static readonly BitSet FOLLOW_scmVerticalAlign_in_scmAlignmentProp1785 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmAlignmentProp1788 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmAlignmentProp1790 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1802 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmFrmStyleProp1804 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmFrmStyleProp1806 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1808 = new BitSet(new ulong[]{0x000007E010000000UL});
    public static readonly BitSet FOLLOW_scmFrmStyleList_in_scmFrmStyleProp1810 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1813 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1815 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1820 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmFrmStyleProp1822 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmFrmStyleProp1824 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1838 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmBtnStyleProp1840 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmBtnStyleProp1842 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1844 = new BitSet(new ulong[]{0x0000100010040000UL});
    public static readonly BitSet FOLLOW_scmBtnStyleList_in_scmBtnStyleProp1846 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1849 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1856 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmBtnStyleProp1858 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmBtnStyleProp1860 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1862 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStyleProp1874 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmStyleProp1876 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmStyleProp1878 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmStyleProp1880 = new BitSet(new ulong[]{0x0000100010000000UL});
    public static readonly BitSet FOLLOW_scmStyleList_in_scmStyleProp1882 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStyleProp1885 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStyleProp1887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStyleProp1892 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmStyleProp1894 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmStyleProp1896 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStyleProp1898 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmVertMargin1911 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_VERT_MARGIN_in_scmVertMargin1913 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmVertMargin1919 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmVertMargin1921 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHorizMargin1937 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_HORIZ_MARGIN_in_scmHorizMargin1939 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmHorizMargin1945 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHorizMargin1947 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TOP_in_scmVerticalAlign1960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CENTER_in_scmVerticalAlign1967 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOTTOM_in_scmVerticalAlign1974 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFT_in_scmHorizAlign1987 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CENTER_in_scmHorizAlign1994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RIGHT_in_scmHorizAlign2001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NO_RESIZE_BORDER_in_scmFrmStyleList2015 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_NO_CAPTION_in_scmFrmStyleList2022 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_NO_SYSTEM_MENU_in_scmFrmStyleList2029 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_MDI_PARENT_in_scmFrmStyleList2036 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_MDI_CHILD_in_scmFrmStyleList2043 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_scmFrmStyleList2050 = new BitSet(new ulong[]{0x000007E000000002UL});
    public static readonly BitSet FOLLOW_BORDER_in_scmBtnStyleList2065 = new BitSet(new ulong[]{0x0000100000040002UL});
    public static readonly BitSet FOLLOW_DELETED_in_scmBtnStyleList2073 = new BitSet(new ulong[]{0x0000100000040002UL});
    public static readonly BitSet FOLLOW_DELETED_in_scmStyleList2089 = new BitSet(new ulong[]{0x0000100000000002UL});
    public static readonly BitSet FOLLOW_LP_in_parExpr2110 = new BitSet(new ulong[]{0x00FFA00068000000UL});
    public static readonly BitSet FOLLOW_parExpr_in_parExpr2117 = new BitSet(new ulong[]{0x00FFA00078000000UL});
    public static readonly BitSet FOLLOW_RP_in_parExpr2123 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operand_in_parExpr2135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_opartors_in_parExpr2146 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_operand2167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_operand2178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_operand2189 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_operand2200 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_opartors2219 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_opartors2230 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STAR_in_opartors2241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SLASH_in_opartors2252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_opartors2263 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GT_in_opartors2274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQ_in_opartors2285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOTE_in_opartors2296 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMENT_in_comment2315 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}