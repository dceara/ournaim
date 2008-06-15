// $ANTLR 3.0.1 D:\\Projects\\AntlrTestApps\\ScmGrammar.g 2008-06-15 16:55:10
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

    public const int MDI_CHILD = 38;
    public const int LT = 50;
    public const int STAR = 48;
    public const int HORIZ_MARGIN = 23;
    public const int SPACING = 16;
    public const int STRETCH_WIDTH = 20;
    public const int RP = 25;
    public const int LEAD_DIGIT = 58;
    public const int STRETCH_HEIGHT = 21;
    public const int LP = 24;
    public const int NEW = 6;
    public const int BUTTON = 8;
    public const int FLOAT = 39;
    public const int ID = 42;
    public const int CAR = 55;
    public const int EOF = -1;
    public const int DEFINE = 5;
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
    public const int VERT_MARGIN = 22;
    public const int SEMI = 4;
    public const int TRUE = 27;
    public const int DELETED = 41;
    public const int NO_RESIZE_BORDER = 34;
    public const int WS = 54;
    public const int NEWLINE = 60;
    public const int LABEL = 11;
    public const int WIDTH = 12;
    public const int BOTTOM = 30;
    public const int STYLE = 40;
    public const int MIN_WIDTH = 18;
    public const int GT = 51;
    public const int FRAME = 7;
    public const int FALSE = 26;
    public const int TOP = 28;
    
    
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:74:1: main : ( scmBlock )+ EOF ;
    public void main() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:74:5: ( ( scmBlock )+ EOF )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:74:7: ( scmBlock )+ EOF
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:74:7: ( scmBlock )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:74:7: scmBlock
            			    {
            			    	PushFollow(FOLLOW_scmBlock_in_main358);
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

            	Match(input,EOF,FOLLOW_EOF_in_main361); 
            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:76:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | com= comment | pe= parExpr );
    public void scmBlock() // throws RecognitionException [1]
    {   
        ScmFrameProperties frm = null;

        ScmButtonProperties btn = null;

        ScmMessageProperties msg = null;

        string com = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:77:2: (frm= scmFrm | btn= scmBtn | msg= scmMsg | com= comment | pe= parExpr )
            int alt2 = 5;
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
                                case MESSAGE:
                                	{
                                    alt2 = 3;
                                    }
                                    break;
                                case FRAME:
                                	{
                                    alt2 = 1;
                                    }
                                    break;
                                	default:
                                	    NoViableAltException nvae_d2s7 =
                                	        new NoViableAltException("76:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | com= comment | pe= parExpr );", 2, 7, input);
                                
                                	    throw nvae_d2s7;
                                }
                            
                            }
                            else 
                            {
                                NoViableAltException nvae_d2s6 =
                                    new NoViableAltException("76:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | com= comment | pe= parExpr );", 2, 6, input);
                            
                                throw nvae_d2s6;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d2s5 =
                                new NoViableAltException("76:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | com= comment | pe= parExpr );", 2, 5, input);
                        
                            throw nvae_d2s5;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d2s4 =
                            new NoViableAltException("76:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | com= comment | pe= parExpr );", 2, 4, input);
                    
                        throw nvae_d2s4;
                    }
                }
                else if ( (LA2_1 == LP || (LA2_1 >= FALSE && LA2_1 <= TRUE) || LA2_1 == ID || (LA2_1 >= NUMBER && LA2_1 <= EQ)) )
                {
                    alt2 = 5;
                }
                else 
                {
                    NoViableAltException nvae_d2s1 =
                        new NoViableAltException("76:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | com= comment | pe= parExpr );", 2, 1, input);
                
                    throw nvae_d2s1;
                }
                }
                break;
            case COMMENT:
            	{
                alt2 = 4;
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
                alt2 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("76:1: scmBlock : (frm= scmFrm | btn= scmBtn | msg= scmMsg | com= comment | pe= parExpr );", 2, 0, input);
            
            	    throw nvae_d2s0;
            }
            
            switch (alt2) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:77:4: frm= scmFrm
                    {
                    	PushFollow(FOLLOW_scmFrm_in_scmBlock374);
                    	frm = scmFrm();
                    	followingStackPointer_--;

                    	_parsedData.Add(frm);
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:78:4: btn= scmBtn
                    {
                    	PushFollow(FOLLOW_scmBtn_in_scmBlock385);
                    	btn = scmBtn();
                    	followingStackPointer_--;

                    	_parsedData.Add(btn);
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:79:4: msg= scmMsg
                    {
                    	PushFollow(FOLLOW_scmMsg_in_scmBlock396);
                    	msg = scmMsg();
                    	followingStackPointer_--;

                    	_parsedData.Add(msg);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:80:4: com= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmBlock407);
                    	com = comment();
                    	followingStackPointer_--;

                    	_parsedData.Add(new ScmComment(com));
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:81:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmBlock418);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:83:1: scmFrm returns [ScmFrameProperties frmProp] : LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP ;
    public ScmFrameProperties scmFrm() // throws RecognitionException [1]
    {   

        ScmFrameProperties frmProp = null;
    
        IToken id = null;
    
        
        	ScmFrame frame = new ScmFrame();
        	frmProp =  frame.ScmPropertyObject as ScmFrameProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:89:2: ( LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:89:4: LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmFrm438); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmFrm440); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmFrm446); 
            	Match(input,LP,FOLLOW_LP_in_scmFrm448); 
            	Match(input,NEW,FOLLOW_NEW_in_scmFrm450); 
            	Match(input,FRAME,FOLLOW_FRAME_in_scmFrm452); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:89:35: ( scmFrmProp[$frmProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:89:35: scmFrmProp[$frmProp]
            			    {
            			    	PushFollow(FOLLOW_scmFrmProp_in_scmFrm454);
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

            	Match(input,RP,FOLLOW_RP_in_scmFrm458); 
            	Match(input,RP,FOLLOW_RP_in_scmFrm460); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:91:1: scmBtn returns [ScmButtonProperties btnProp] : LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP ;
    public ScmButtonProperties scmBtn() // throws RecognitionException [1]
    {   

        ScmButtonProperties btnProp = null;
    
        IToken id = null;
    
        
        	ScmButton btn = new ScmButton();
        	btnProp =  btn.ScmPropertyObject as ScmButtonProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:97:2: ( LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:97:4: LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBtn482); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmBtn484); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmBtn490); 
            	Match(input,LP,FOLLOW_LP_in_scmBtn492); 
            	Match(input,NEW,FOLLOW_NEW_in_scmBtn494); 
            	Match(input,BUTTON,FOLLOW_BUTTON_in_scmBtn496); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:97:36: ( scmBtnProp[$btnProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:97:36: scmBtnProp[$btnProp]
            			    {
            			    	PushFollow(FOLLOW_scmBtnProp_in_scmBtn498);
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

            	Match(input,RP,FOLLOW_RP_in_scmBtn502); 
            	Match(input,RP,FOLLOW_RP_in_scmBtn504); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:99:1: scmMsg returns [ScmMessageProperties msgProp] : LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP ;
    public ScmMessageProperties scmMsg() // throws RecognitionException [1]
    {   

        ScmMessageProperties msgProp = null;
    
        IToken id = null;
    
        
        	ScmMessage msg = new ScmMessage();
        	msgProp =  msg.ScmPropertyObject as ScmMessageProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:105:2: ( LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:105:4: LP DEFINE id= ID LP NEW MESSAGE ( scmMsgProp[$msgProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMsg526); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmMsg528); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmMsg534); 
            	Match(input,LP,FOLLOW_LP_in_scmMsg536); 
            	Match(input,NEW,FOLLOW_NEW_in_scmMsg538); 
            	Match(input,MESSAGE,FOLLOW_MESSAGE_in_scmMsg540); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:105:37: ( scmMsgProp[$msgProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:105:37: scmMsgProp[$msgProp]
            			    {
            			    	PushFollow(FOLLOW_scmMsgProp_in_scmMsg542);
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

            	Match(input,RP,FOLLOW_RP_in_scmMsg546); 
            	Match(input,RP,FOLLOW_RP_in_scmMsg548); 
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

    
    // $ANTLR start scmFrmProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:107:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:108:2: (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr )
            int alt6 = 16;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case SPACING:
                	{
                    alt6 = 7;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt6 = 8;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt6 = 9;
                    }
                    break;
                case STYLE:
                	{
                    alt6 = 13;
                    }
                    break;
                case ENABLED:
                	{
                    alt6 = 5;
                    }
                    break;
                case BORDER:
                	{
                    alt6 = 6;
                    }
                    break;
                case ID:
                	{
                    switch ( input.LA(3) ) 
                    {
                    case NUMBER:
                    	{
                        int LA6_18 = input.LA(4);
                        
                        if ( (LA6_18 == RP) )
                        {
                            alt6 = 14;
                        }
                        else if ( (LA6_18 == LP || (LA6_18 >= FALSE && LA6_18 <= TRUE) || LA6_18 == ID || (LA6_18 >= NUMBER && LA6_18 <= EQ)) )
                        {
                            alt6 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d6s18 =
                                new NoViableAltException("107:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 6, 18, input);
                        
                            throw nvae_d6s18;
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
                        alt6 = 16;
                        }
                        break;
                    case FALSE:
                    	{
                        int LA6_19 = input.LA(4);
                        
                        if ( (LA6_19 == RP) )
                        {
                            alt6 = 14;
                        }
                        else if ( (LA6_19 == LP || (LA6_19 >= FALSE && LA6_19 <= TRUE) || LA6_19 == ID || (LA6_19 >= NUMBER && LA6_19 <= EQ)) )
                        {
                            alt6 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d6s19 =
                                new NoViableAltException("107:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 6, 19, input);
                        
                            throw nvae_d6s19;
                        }
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d6s10 =
                    	        new NoViableAltException("107:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 6, 10, input);
                    
                    	    throw nvae_d6s10;
                    }
                
                    }
                    break;
                case LABEL:
                	{
                    alt6 = 2;
                    }
                    break;
                case PARENT:
                	{
                    alt6 = 1;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt6 = 10;
                    }
                    break;
                case HEIGHT:
                	{
                    alt6 = 4;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt6 = 11;
                    }
                    break;
                case WIDTH:
                	{
                    alt6 = 3;
                    }
                    break;
                case ALIGNMENT:
                	{
                    alt6 = 12;
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
                    alt6 = 16;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d6s1 =
                	        new NoViableAltException("107:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 6, 1, input);
                
                	    throw nvae_d6s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt6 = 15;
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
                alt6 = 16;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("107:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | scmFrmStyleProp[frmProp.Style] | xyProp= scmXYProp | comm= comment | pe= parExpr );", 6, 0, input);
            
            	    throw nvae_d6s0;
            }
            
            switch (alt6) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:108:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmFrmProp566);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	frmProp.Parent = parent; frmProp.AddParesedProperty(FramePropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:109:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmFrmProp577);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	frmProp.Label = label; frmProp.AddParesedProperty(FramePropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:110:4: width= scmWidthProp
                    {
                    	PushFollow(FOLLOW_scmWidthProp_in_scmFrmProp588);
                    	width = scmWidthProp();
                    	followingStackPointer_--;

                    	if (width != "#f") { frmProp.AutosizeWidth = false; frmProp.Width = width; frmProp.AddParesedProperty(FramePropNames.Width);}
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:111:4: height= scmHeightProp
                    {
                    	PushFollow(FOLLOW_scmHeightProp_in_scmFrmProp599);
                    	height = scmHeightProp();
                    	followingStackPointer_--;

                    	if (height != "#f") {frmProp.AutosizeHeight = false; frmProp.Height = height; frmProp.AddParesedProperty(FramePropNames.Height);}
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:112:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmFrmProp610);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	frmProp.Enabled = enabled; frmProp.AddParesedProperty(FramePropNames.Enabled);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:113:4: border= scmBorderProp
                    {
                    	PushFollow(FOLLOW_scmBorderProp_in_scmFrmProp621);
                    	border = scmBorderProp();
                    	followingStackPointer_--;

                    	frmProp.Border = border; frmProp.AddParesedProperty(FramePropNames.Border);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:114:4: spacing= scmSpacingProp
                    {
                    	PushFollow(FOLLOW_scmSpacingProp_in_scmFrmProp632);
                    	spacing = scmSpacingProp();
                    	followingStackPointer_--;

                    	frmProp.Spacing = spacing; frmProp.AddParesedProperty(FramePropNames.Spacing);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:115:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmFrmProp643);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	frmProp.MinWidth = minWidth; frmProp.AddParesedProperty(FramePropNames.MinWidth);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:116:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmFrmProp654);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	frmProp.MinHeight = minHeight; frmProp.AddParesedProperty(FramePropNames.MinHeight);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:117:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmFrmProp665);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	frmProp.StretchableWidth = strechWidth; frmProp.AddParesedProperty(FramePropNames.StrechWidth);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:118:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmFrmProp676);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	frmProp.StretchableHeight = strechHeight; frmProp.AddParesedProperty(FramePropNames.StrechHeight);
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:119:4: scmAlignmentProp[frmProp.Alignment]
                    {
                    	PushFollow(FOLLOW_scmAlignmentProp_in_scmFrmProp683);
                    	scmAlignmentProp(frmProp.Alignment);
                    	followingStackPointer_--;

                    	frmProp.AddParesedProperty(FramePropNames.Alignment);
                    
                    }
                    break;
                case 13 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:120:4: scmFrmStyleProp[frmProp.Style]
                    {
                    	PushFollow(FOLLOW_scmFrmStyleProp_in_scmFrmProp691);
                    	scmFrmStyleProp(frmProp.Style);
                    	followingStackPointer_--;

                    	frmProp.AddParesedProperty(FramePropNames.Style);
                    
                    }
                    break;
                case 14 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:121:4: xyProp= scmXYProp
                    {
                    	PushFollow(FOLLOW_scmXYProp_in_scmFrmProp703);
                    	xyProp = scmXYProp();
                    	followingStackPointer_--;

                    	frmProp.SetXYProp(xyProp.name, xyProp.value);
                    
                    }
                    break;
                case 15 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:122:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmFrmProp714);
                    	comm = comment();
                    	followingStackPointer_--;

                    	frmProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 16 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:123:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmFrmProp725);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:125:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:126:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr )
            int alt7 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case STYLE:
                	{
                    alt7 = 10;
                    }
                    break;
                case ENABLED:
                	{
                    alt7 = 3;
                    }
                    break;
                case PARENT:
                	{
                    alt7 = 1;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt7 = 7;
                    }
                    break;
                case LABEL:
                	{
                    alt7 = 2;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt7 = 8;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt7 = 5;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt7 = 6;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt7 = 9;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt7 = 4;
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
                    alt7 = 12;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d7s1 =
                	        new NoViableAltException("125:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );", 7, 1, input);
                
                	    throw nvae_d7s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt7 = 11;
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
                alt7 = 12;
                }
                break;
            	default:
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("125:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp[btnProp.Style] | comm= comment | pe= parExpr );", 7, 0, input);
            
            	    throw nvae_d7s0;
            }
            
            switch (alt7) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:126:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmBtnProp743);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	btnProp.Parent = parent; btnProp.AddParesedProperty(ButtonPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:127:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmBtnProp754);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	btnProp.Label = label; btnProp.AddParesedProperty(ButtonPropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:128:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmBtnProp765);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	btnProp.Enabled = enabled; btnProp.AddParesedProperty(ButtonPropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:129:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmBtnProp776);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	btnProp.MinWidth = minWidth;if (minWidth == 0) btnProp.AutosizeWidth = true; btnProp.AddParesedProperty(ButtonPropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:130:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmBtnProp787);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	btnProp.MinHeight = minHeight; if (minHeight == 0) btnProp.AutosizeHeight = true; btnProp.AddParesedProperty( ButtonPropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:131:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmBtnProp798);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	btnProp.StretchableWidth = strechWidth; btnProp.AddParesedProperty(ButtonPropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:132:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmBtnProp809);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	btnProp.StretchableHeight = strechHeight; btnProp.AddParesedProperty(ButtonPropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:133:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmBtnProp820);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	btnProp.VerticalMargin = vertMarg; btnProp.AddParesedProperty(ButtonPropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:134:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmBtnProp831);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	btnProp.HorizontalMargin = vertMarg; btnProp.AddParesedProperty(ButtonPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:135:4: scmBtnStyleProp[btnProp.Style]
                    {
                    	PushFollow(FOLLOW_scmBtnStyleProp_in_scmBtnProp838);
                    	scmBtnStyleProp(btnProp.Style);
                    	followingStackPointer_--;

                    	btnProp.AddParesedProperty(ButtonPropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:136:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmBtnProp850);
                    	comm = comment();
                    	followingStackPointer_--;

                    	btnProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:137:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmBtnProp861);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:139:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmMsgStyleProp[msgProp.Style] | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:140:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmMsgStyleProp[msgProp.Style] | comm= comment | pe= parExpr )
            int alt8 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case STRETCH_HEIGHT:
                	{
                    alt8 = 7;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt8 = 6;
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
                case VERT_MARGIN:
                	{
                    alt8 = 8;
                    }
                    break;
                case STYLE:
                	{
                    alt8 = 10;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt8 = 4;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt8 = 5;
                    }
                    break;
                case ENABLED:
                	{
                    alt8 = 3;
                    }
                    break;
                case LABEL:
                	{
                    alt8 = 2;
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
                	        new NoViableAltException("139:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmMsgStyleProp[msgProp.Style] | comm= comment | pe= parExpr );", 8, 1, input);
                
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
            	        new NoViableAltException("139:1: scmMsgProp[ScmMessageProperties msgProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmMsgStyleProp[msgProp.Style] | comm= comment | pe= parExpr );", 8, 0, input);
            
            	    throw nvae_d8s0;
            }
            
            switch (alt8) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:140:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmMsgProp878);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	msgProp.Parent = parent; msgProp.AddParesedProperty(MessagePropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:141:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmMsgProp889);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	msgProp.Label = label; msgProp.AddParesedProperty(MessagePropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:142:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmMsgProp900);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	msgProp.Enabled = enabled; msgProp.AddParesedProperty(MessagePropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:143:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmMsgProp911);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	msgProp.MinWidth = minWidth;if (minWidth == 0) msgProp.AutosizeWidth = true; msgProp.AddParesedProperty(MessagePropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:144:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmMsgProp922);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	msgProp.MinHeight = minHeight; if (minHeight == 0) msgProp.AutosizeHeight = true; msgProp.AddParesedProperty( MessagePropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:145:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmMsgProp933);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	msgProp.StretchableWidth = strechWidth; msgProp.AddParesedProperty(MessagePropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:146:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmMsgProp944);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	msgProp.StretchableHeight = strechHeight; msgProp.AddParesedProperty(MessagePropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:147:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmMsgProp955);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	msgProp.VerticalMargin = vertMarg; msgProp.AddParesedProperty(MessagePropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:148:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmMsgProp966);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	msgProp.HorizontalMargin = vertMarg; msgProp.AddParesedProperty(MessagePropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:149:4: scmMsgStyleProp[msgProp.Style]
                    {
                    	PushFollow(FOLLOW_scmMsgStyleProp_in_scmMsgProp973);
                    	scmMsgStyleProp(msgProp.Style);
                    	followingStackPointer_--;

                    	msgProp.AddParesedProperty(MessagePropNames.Style);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:150:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmMsgProp985);
                    	comm = comment();
                    	followingStackPointer_--;

                    	msgProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:151:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmMsgProp996);
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

    
    // $ANTLR start scmParentProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:153:1: scmParentProp returns [string parent] : LP PARENT par= ( ID | FALSE ) RP ;
    public string scmParentProp() // throws RecognitionException [1]
    {   

        string parent = null;
    
        IToken par = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:154:2: ( LP PARENT par= ( ID | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:154:4: LP PARENT par= ( ID | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmParentProp1012); 
            	Match(input,PARENT,FOLLOW_PARENT_in_scmParentProp1014); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmParentProp1019);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmParentProp1027); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:156:1: scmLabelProp returns [string label] : LP LABEL name= NAME RP ;
    public string scmLabelProp() // throws RecognitionException [1]
    {   

        string label = null;
    
        IToken name = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:157:2: ( LP LABEL name= NAME RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:157:4: LP LABEL name= NAME RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmLabelProp1043); 
            	Match(input,LABEL,FOLLOW_LABEL_in_scmLabelProp1045); 
            	name = (IToken)input.LT(1);
            	Match(input,NAME,FOLLOW_NAME_in_scmLabelProp1051); 
            	Match(input,RP,FOLLOW_RP_in_scmLabelProp1053); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:159:1: scmWidthProp returns [string width] : LP WIDTH v= ( NUMBER | FALSE ) RP ;
    public string scmWidthProp() // throws RecognitionException [1]
    {   

        string width = null;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:160:2: ( LP WIDTH v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:160:4: LP WIDTH v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmWidthProp1069); 
            	Match(input,WIDTH,FOLLOW_WIDTH_in_scmWidthProp1071); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmWidthProp1076);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmWidthProp1082); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:162:1: scmHeightProp returns [string height] : LP HEIGHT v= ( NUMBER | FALSE ) RP ;
    public string scmHeightProp() // throws RecognitionException [1]
    {   

        string height = null;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:163:2: ( LP HEIGHT v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:163:4: LP HEIGHT v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHeightProp1097); 
            	Match(input,HEIGHT,FOLLOW_HEIGHT_in_scmHeightProp1099); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmHeightProp1105);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmHeightProp1111); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:165:1: scmXYProp returns [string name, string value] : LP n= ID v= ( NUMBER | FALSE ) RP ;
    public scmXYProp_return scmXYProp() // throws RecognitionException [1]
    {   
        scmXYProp_return retval = new scmXYProp_return();
        retval.start = input.LT(1);
    
        IToken n = null;
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:166:2: ( LP n= ID v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:166:4: LP n= ID v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmXYProp1127); 
            	n = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmXYProp1133); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmXYProp1139);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmXYProp1145); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:168:1: scmEnabledProp returns [bool enabled] : LP ENABLED v= ( TRUE | FALSE ) RP ;
    public bool scmEnabledProp() // throws RecognitionException [1]
    {   

        bool enabled = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:169:2: ( LP ENABLED v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:169:4: LP ENABLED v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmEnabledProp1161); 
            	Match(input,ENABLED,FOLLOW_ENABLED_in_scmEnabledProp1163); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmEnabledProp1169);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmEnabledProp1175); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:172:1: scmBorderProp returns [int border] : LP BORDER nr= NUMBER RP ;
    public int scmBorderProp() // throws RecognitionException [1]
    {   

        int border = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:173:2: ( LP BORDER nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:173:4: LP BORDER nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBorderProp1191); 
            	Match(input,BORDER,FOLLOW_BORDER_in_scmBorderProp1193); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmBorderProp1199); 
            	Match(input,RP,FOLLOW_RP_in_scmBorderProp1201); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:175:1: scmSpacingProp returns [int spacing] : LP SPACING nr= NUMBER RP ;
    public int scmSpacingProp() // throws RecognitionException [1]
    {   

        int spacing = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:176:2: ( LP SPACING nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:176:4: LP SPACING nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmSpacingProp1216); 
            	Match(input,SPACING,FOLLOW_SPACING_in_scmSpacingProp1218); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmSpacingProp1224); 
            	Match(input,RP,FOLLOW_RP_in_scmSpacingProp1226); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:178:1: scmMinWidthProp returns [int minWidth] : LP MIN_WIDTH nr= NUMBER RP ;
    public int scmMinWidthProp() // throws RecognitionException [1]
    {   

        int minWidth = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:179:2: ( LP MIN_WIDTH nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:179:4: LP MIN_WIDTH nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMinWidthProp1241); 
            	Match(input,MIN_WIDTH,FOLLOW_MIN_WIDTH_in_scmMinWidthProp1243); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmMinWidthProp1249); 
            	Match(input,RP,FOLLOW_RP_in_scmMinWidthProp1251); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:181:1: scmMinHeightProp returns [int minHeight] : LP MIN_HEIGHT nr= NUMBER RP ;
    public int scmMinHeightProp() // throws RecognitionException [1]
    {   

        int minHeight = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:182:2: ( LP MIN_HEIGHT nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:182:4: LP MIN_HEIGHT nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMinHeightProp1266); 
            	Match(input,MIN_HEIGHT,FOLLOW_MIN_HEIGHT_in_scmMinHeightProp1268); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmMinHeightProp1274); 
            	Match(input,RP,FOLLOW_RP_in_scmMinHeightProp1276); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:184:1: scmStretchWidthProp returns [bool strechWidth] : LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP ;
    public bool scmStretchWidthProp() // throws RecognitionException [1]
    {   

        bool strechWidth = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:185:2: ( LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:185:4: LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmStretchWidthProp1291); 
            	Match(input,STRETCH_WIDTH,FOLLOW_STRETCH_WIDTH_in_scmStretchWidthProp1293); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmStretchWidthProp1299);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmStretchWidthProp1305); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:188:1: scmStretchHeightProp returns [bool strechHeigth] : LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP ;
    public bool scmStretchHeightProp() // throws RecognitionException [1]
    {   

        bool strechHeigth = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:189:2: ( LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:189:4: LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmStretchHeightProp1320); 
            	Match(input,STRETCH_HEIGHT,FOLLOW_STRETCH_HEIGHT_in_scmStretchHeightProp1322); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmStretchHeightProp1328);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmStretchHeightProp1334); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:192:1: scmAlignmentProp[ContainerAlignment alignment] : LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP ;
    public void scmAlignmentProp(ContainerAlignment alignment) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:193:2: ( LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:193:4: LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmAlignmentProp1348); 
            	Match(input,ALIGNMENT,FOLLOW_ALIGNMENT_in_scmAlignmentProp1350); 
            	Match(input,QUOTE,FOLLOW_QUOTE_in_scmAlignmentProp1352); 
            	Match(input,LP,FOLLOW_LP_in_scmAlignmentProp1354); 
            	PushFollow(FOLLOW_scmHorizAlign_in_scmAlignmentProp1356);
            	scmHorizAlign(alignment);
            	followingStackPointer_--;

            	PushFollow(FOLLOW_scmVerticalAlign_in_scmAlignmentProp1359);
            	scmVerticalAlign(alignment);
            	followingStackPointer_--;

            	Match(input,RP,FOLLOW_RP_in_scmAlignmentProp1362); 
            	Match(input,RP,FOLLOW_RP_in_scmAlignmentProp1364); 
            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:195:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmFrmStyleProp(ScmFrameStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:196:2: ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt9 = 2;
            int LA9_0 = input.LA(1);
            
            if ( (LA9_0 == LP) )
            {
                int LA9_1 = input.LA(2);
                
                if ( (LA9_1 == STYLE) )
                {
                    int LA9_2 = input.LA(3);
                    
                    if ( (LA9_2 == NULL) )
                    {
                        alt9 = 2;
                    }
                    else if ( (LA9_2 == QUOTE) )
                    {
                        alt9 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d9s2 =
                            new NoViableAltException("195:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 9, 2, input);
                    
                        throw nvae_d9s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d9s1 =
                        new NoViableAltException("195:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 9, 1, input);
                
                    throw nvae_d9s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("195:1: scmFrmStyleProp[ScmFrameStyle style] : ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP | LP STYLE NULL RP );", 9, 0, input);
            
                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:196:4: LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1376); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmFrmStyleProp1378); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmFrmStyleProp1380); 
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1382); 
                    	PushFollow(FOLLOW_scmFrmStyleList_in_scmFrmStyleProp1384);
                    	scmFrmStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1387); 
                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1389); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:197:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1394); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmFrmStyleProp1396); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmFrmStyleProp1398); 
                    	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1400); 
                    
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:199:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmBtnStyleProp(ScmButtonStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:200:2: ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt10 = 2;
            int LA10_0 = input.LA(1);
            
            if ( (LA10_0 == LP) )
            {
                int LA10_1 = input.LA(2);
                
                if ( (LA10_1 == STYLE) )
                {
                    int LA10_2 = input.LA(3);
                    
                    if ( (LA10_2 == NULL) )
                    {
                        alt10 = 2;
                    }
                    else if ( (LA10_2 == QUOTE) )
                    {
                        alt10 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d10s2 =
                            new NoViableAltException("199:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 10, 2, input);
                    
                        throw nvae_d10s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d10s1 =
                        new NoViableAltException("199:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 10, 1, input);
                
                    throw nvae_d10s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("199:1: scmBtnStyleProp[ScmButtonStyle style] : ( LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP | LP STYLE NULL RP );", 10, 0, input);
            
                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:200:4: LP STYLE QUOTE LP scmBtnStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1412); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmBtnStyleProp1414); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmBtnStyleProp1416); 
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1418); 
                    	PushFollow(FOLLOW_scmBtnStyleList_in_scmBtnStyleProp1420);
                    	scmBtnStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1423); 
                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1425); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:201:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1430); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmBtnStyleProp1432); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmBtnStyleProp1434); 
                    	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1436); 
                    
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

    
    // $ANTLR start scmMsgStyleProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:203:1: scmMsgStyleProp[ScmMessageStyle style] : ( LP STYLE QUOTE LP scmMsgStyleList[$style] RP RP | LP STYLE NULL RP );
    public void scmMsgStyleProp(ScmMessageStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:204:2: ( LP STYLE QUOTE LP scmMsgStyleList[$style] RP RP | LP STYLE NULL RP )
            int alt11 = 2;
            int LA11_0 = input.LA(1);
            
            if ( (LA11_0 == LP) )
            {
                int LA11_1 = input.LA(2);
                
                if ( (LA11_1 == STYLE) )
                {
                    int LA11_2 = input.LA(3);
                    
                    if ( (LA11_2 == NULL) )
                    {
                        alt11 = 2;
                    }
                    else if ( (LA11_2 == QUOTE) )
                    {
                        alt11 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d11s2 =
                            new NoViableAltException("203:1: scmMsgStyleProp[ScmMessageStyle style] : ( LP STYLE QUOTE LP scmMsgStyleList[$style] RP RP | LP STYLE NULL RP );", 11, 2, input);
                    
                        throw nvae_d11s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d11s1 =
                        new NoViableAltException("203:1: scmMsgStyleProp[ScmMessageStyle style] : ( LP STYLE QUOTE LP scmMsgStyleList[$style] RP RP | LP STYLE NULL RP );", 11, 1, input);
                
                    throw nvae_d11s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("203:1: scmMsgStyleProp[ScmMessageStyle style] : ( LP STYLE QUOTE LP scmMsgStyleList[$style] RP RP | LP STYLE NULL RP );", 11, 0, input);
            
                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:204:4: LP STYLE QUOTE LP scmMsgStyleList[$style] RP RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmMsgStyleProp1448); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmMsgStyleProp1450); 
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_scmMsgStyleProp1452); 
                    	Match(input,LP,FOLLOW_LP_in_scmMsgStyleProp1454); 
                    	PushFollow(FOLLOW_scmMsgStyleList_in_scmMsgStyleProp1456);
                    	scmMsgStyleList(style);
                    	followingStackPointer_--;

                    	Match(input,RP,FOLLOW_RP_in_scmMsgStyleProp1459); 
                    	Match(input,RP,FOLLOW_RP_in_scmMsgStyleProp1461); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:205:4: LP STYLE NULL RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_scmMsgStyleProp1466); 
                    	Match(input,STYLE,FOLLOW_STYLE_in_scmMsgStyleProp1468); 
                    	Match(input,NULL,FOLLOW_NULL_in_scmMsgStyleProp1470); 
                    	Match(input,RP,FOLLOW_RP_in_scmMsgStyleProp1472); 
                    
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
    // $ANTLR end scmMsgStyleProp

    
    // $ANTLR start scmVertMargin
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:207:1: scmVertMargin returns [int val] : LP VERT_MARGIN v= NUMBER RP ;
    public int scmVertMargin() // throws RecognitionException [1]
    {   

        int val = 0;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:208:2: ( LP VERT_MARGIN v= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:208:4: LP VERT_MARGIN v= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmVertMargin1485); 
            	Match(input,VERT_MARGIN,FOLLOW_VERT_MARGIN_in_scmVertMargin1487); 
            	v = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmVertMargin1493); 
            	Match(input,RP,FOLLOW_RP_in_scmVertMargin1495); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:210:1: scmHorizMargin returns [int val] : LP HORIZ_MARGIN v= NUMBER RP ;
    public int scmHorizMargin() // throws RecognitionException [1]
    {   

        int val = 0;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:211:2: ( LP HORIZ_MARGIN v= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:211:4: LP HORIZ_MARGIN v= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHorizMargin1511); 
            	Match(input,HORIZ_MARGIN,FOLLOW_HORIZ_MARGIN_in_scmHorizMargin1513); 
            	v = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmHorizMargin1519); 
            	Match(input,RP,FOLLOW_RP_in_scmHorizMargin1521); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:213:1: scmVerticalAlign[ContainerAlignment align] : ( TOP | CENTER | BOTTOM );
    public void scmVerticalAlign(ContainerAlignment align) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:214:2: ( TOP | CENTER | BOTTOM )
            int alt12 = 3;
            switch ( input.LA(1) ) 
            {
            case TOP:
            	{
                alt12 = 1;
                }
                break;
            case CENTER:
            	{
                alt12 = 2;
                }
                break;
            case BOTTOM:
            	{
                alt12 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d12s0 =
            	        new NoViableAltException("213:1: scmVerticalAlign[ContainerAlignment align] : ( TOP | CENTER | BOTTOM );", 12, 0, input);
            
            	    throw nvae_d12s0;
            }
            
            switch (alt12) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:214:4: TOP
                    {
                    	Match(input,TOP,FOLLOW_TOP_in_scmVerticalAlign1534); 
                    	align.VerticalAlignment = VerticalAlign.Top; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:215:4: CENTER
                    {
                    	Match(input,CENTER,FOLLOW_CENTER_in_scmVerticalAlign1541); 
                    	align.VerticalAlignment = VerticalAlign.Center; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:216:4: BOTTOM
                    {
                    	Match(input,BOTTOM,FOLLOW_BOTTOM_in_scmVerticalAlign1548); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:218:1: scmHorizAlign[ContainerAlignment align] : ( LEFT | CENTER | RIGHT );
    public void scmHorizAlign(ContainerAlignment align) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:219:2: ( LEFT | CENTER | RIGHT )
            int alt13 = 3;
            switch ( input.LA(1) ) 
            {
            case LEFT:
            	{
                alt13 = 1;
                }
                break;
            case CENTER:
            	{
                alt13 = 2;
                }
                break;
            case RIGHT:
            	{
                alt13 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d13s0 =
            	        new NoViableAltException("218:1: scmHorizAlign[ContainerAlignment align] : ( LEFT | CENTER | RIGHT );", 13, 0, input);
            
            	    throw nvae_d13s0;
            }
            
            switch (alt13) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:219:4: LEFT
                    {
                    	Match(input,LEFT,FOLLOW_LEFT_in_scmHorizAlign1561); 
                    	align.HorizontalAlignment = HorizontalAlign.Left; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:220:4: CENTER
                    {
                    	Match(input,CENTER,FOLLOW_CENTER_in_scmHorizAlign1568); 
                    	align.HorizontalAlignment = HorizontalAlign.Center; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:221:4: RIGHT
                    {
                    	Match(input,RIGHT,FOLLOW_RIGHT_in_scmHorizAlign1575); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:223:1: scmFrmStyleList[ScmFrameStyle style] : ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )* ;
    public void scmFrmStyleList(ScmFrameStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:224:2: ( ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:224:4: ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:224:4: ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )*
            	do 
            	{
            	    int alt14 = 7;
            	    switch ( input.LA(1) ) 
            	    {
            	    case NO_RESIZE_BORDER:
            	    	{
            	        alt14 = 1;
            	        }
            	        break;
            	    case NO_CAPTION:
            	    	{
            	        alt14 = 2;
            	        }
            	        break;
            	    case NO_SYSTEM_MENU:
            	    	{
            	        alt14 = 3;
            	        }
            	        break;
            	    case MDI_PARENT:
            	    	{
            	        alt14 = 4;
            	        }
            	        break;
            	    case MDI_CHILD:
            	    	{
            	        alt14 = 5;
            	        }
            	        break;
            	    case FLOAT:
            	    	{
            	        alt14 = 6;
            	        }
            	        break;
            	    
            	    }
            	
            	    switch (alt14) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:224:5: NO_RESIZE_BORDER
            			    {
            			    	Match(input,NO_RESIZE_BORDER,FOLLOW_NO_RESIZE_BORDER_in_scmFrmStyleList1589); 
            			    	style.NoResizeBorder = true; 
            			    
            			    }
            			    break;
            			case 2 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:225:4: NO_CAPTION
            			    {
            			    	Match(input,NO_CAPTION,FOLLOW_NO_CAPTION_in_scmFrmStyleList1596); 
            			    	style.NoCaption = true; 
            			    
            			    }
            			    break;
            			case 3 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:226:4: NO_SYSTEM_MENU
            			    {
            			    	Match(input,NO_SYSTEM_MENU,FOLLOW_NO_SYSTEM_MENU_in_scmFrmStyleList1603); 
            			    	style.NoSystemMenu = true; 
            			    
            			    }
            			    break;
            			case 4 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:227:4: MDI_PARENT
            			    {
            			    	Match(input,MDI_PARENT,FOLLOW_MDI_PARENT_in_scmFrmStyleList1610); 
            			    	style.MdiParent = true; 
            			    
            			    }
            			    break;
            			case 5 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:228:4: MDI_CHILD
            			    {
            			    	Match(input,MDI_CHILD,FOLLOW_MDI_CHILD_in_scmFrmStyleList1617); 
            			    	style.MdiChild = true; 
            			    
            			    }
            			    break;
            			case 6 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:229:4: FLOAT
            			    {
            			    	Match(input,FLOAT,FOLLOW_FLOAT_in_scmFrmStyleList1624); 
            			    	style.Floating = true; 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop14;
            	    }
            	} while (true);
            	
            	loop14:
            		;	// Stops C# compiler whinging that label 'loop14' has no statements

            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:231:1: scmBtnStyleList[ScmButtonStyle style] : ( BORDER | DELETED )* ;
    public void scmBtnStyleList(ScmButtonStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:232:2: ( ( BORDER | DELETED )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:232:4: ( BORDER | DELETED )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:232:4: ( BORDER | DELETED )*
            	do 
            	{
            	    int alt15 = 3;
            	    int LA15_0 = input.LA(1);
            	    
            	    if ( (LA15_0 == BORDER) )
            	    {
            	        alt15 = 1;
            	    }
            	    else if ( (LA15_0 == DELETED) )
            	    {
            	        alt15 = 2;
            	    }
            	    
            	
            	    switch (alt15) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:232:5: BORDER
            			    {
            			    	Match(input,BORDER,FOLLOW_BORDER_in_scmBtnStyleList1639); 
            			    	style.Border = true; 
            			    
            			    }
            			    break;
            			case 2 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:233:5: DELETED
            			    {
            			    	Match(input,DELETED,FOLLOW_DELETED_in_scmBtnStyleList1647); 
            			    	style.Deleted = true; 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop15;
            	    }
            	} while (true);
            	
            	loop15:
            		;	// Stops C# compiler whinging that label 'loop15' has no statements

            
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

    
    // $ANTLR start scmMsgStyleList
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:235:1: scmMsgStyleList[ScmMessageStyle style] : ( DELETED )* ;
    public void scmMsgStyleList(ScmMessageStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:236:2: ( ( DELETED )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:236:4: ( DELETED )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:236:4: ( DELETED )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);
            	    
            	    if ( (LA16_0 == DELETED) )
            	    {
            	        alt16 = 1;
            	    }
            	    
            	
            	    switch (alt16) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:236:5: DELETED
            			    {
            			    	Match(input,DELETED,FOLLOW_DELETED_in_scmMsgStyleList1663); 
            			    	style.Deleted = true; 
            			    
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
    // $ANTLR end scmMsgStyleList

    
    // $ANTLR start parExpr
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:238:1: parExpr returns [string expr] : ( LP (pe= parExpr )+ RP | op= operand | oa= opartors );
    public string parExpr() // throws RecognitionException [1]
    {   

        string expr = null;
    
        string pe = null;

        string op = null;

        string oa = null;
        
    
        
        expr =  string.Empty;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:242:2: ( LP (pe= parExpr )+ RP | op= operand | oa= opartors )
            int alt18 = 3;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                alt18 = 1;
                }
                break;
            case FALSE:
            case TRUE:
            case ID:
            case NUMBER:
            	{
                alt18 = 2;
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
                alt18 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d18s0 =
            	        new NoViableAltException("238:1: parExpr returns [string expr] : ( LP (pe= parExpr )+ RP | op= operand | oa= opartors );", 18, 0, input);
            
            	    throw nvae_d18s0;
            }
            
            switch (alt18) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:242:4: LP (pe= parExpr )+ RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_parExpr1684); 
                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:242:7: (pe= parExpr )+
                    	int cnt17 = 0;
                    	do 
                    	{
                    	    int alt17 = 2;
                    	    int LA17_0 = input.LA(1);
                    	    
                    	    if ( (LA17_0 == LP || (LA17_0 >= FALSE && LA17_0 <= TRUE) || LA17_0 == ID || (LA17_0 >= NUMBER && LA17_0 <= EQ)) )
                    	    {
                    	        alt17 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt17) 
                    		{
                    			case 1 :
                    			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:242:8: pe= parExpr
                    			    {
                    			    	PushFollow(FOLLOW_parExpr_in_parExpr1691);
                    			    	pe = parExpr();
                    			    	followingStackPointer_--;

                    			    	expr +=pe; 
                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    if ( cnt17 >= 1 ) goto loop17;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(17, input);
                    		            throw eee;
                    	    }
                    	    cnt17++;
                    	} while (true);
                    	
                    	loop17:
                    		;	// Stops C# compiler whinging that label 'loop17' has no statements

                    	Match(input,RP,FOLLOW_RP_in_parExpr1697); 
                    	expr =  "(" + expr + ")";
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:243:4: op= operand
                    {
                    	PushFollow(FOLLOW_operand_in_parExpr1709);
                    	op = operand();
                    	followingStackPointer_--;

                    	expr += op + " "; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:244:4: oa= opartors
                    {
                    	PushFollow(FOLLOW_opartors_in_parExpr1720);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:247:1: operand returns [string str] : (i= ID | i= NUMBER | i= TRUE | i= FALSE );
    public string operand() // throws RecognitionException [1]
    {   

        string str = null;
    
        IToken i = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:248:2: (i= ID | i= NUMBER | i= TRUE | i= FALSE )
            int alt19 = 4;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt19 = 1;
                }
                break;
            case NUMBER:
            	{
                alt19 = 2;
                }
                break;
            case TRUE:
            	{
                alt19 = 3;
                }
                break;
            case FALSE:
            	{
                alt19 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("247:1: operand returns [string str] : (i= ID | i= NUMBER | i= TRUE | i= FALSE );", 19, 0, input);
            
            	    throw nvae_d19s0;
            }
            
            switch (alt19) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:248:4: i= ID
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,ID,FOLLOW_ID_in_operand1741); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:249:4: i= NUMBER
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,NUMBER,FOLLOW_NUMBER_in_operand1752); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:250:4: i= TRUE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,TRUE,FOLLOW_TRUE_in_operand1763); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:251:4: i= FALSE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,FALSE,FOLLOW_FALSE_in_operand1774); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:253:1: opartors returns [string str] : (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE );
    public string opartors() // throws RecognitionException [1]
    {   

        string str = null;
    
        IToken i = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:254:2: (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE )
            int alt20 = 8;
            switch ( input.LA(1) ) 
            {
            case PLUS:
            	{
                alt20 = 1;
                }
                break;
            case MINUS:
            	{
                alt20 = 2;
                }
                break;
            case STAR:
            	{
                alt20 = 3;
                }
                break;
            case SLASH:
            	{
                alt20 = 4;
                }
                break;
            case LT:
            	{
                alt20 = 5;
                }
                break;
            case GT:
            	{
                alt20 = 6;
                }
                break;
            case EQ:
            	{
                alt20 = 7;
                }
                break;
            case QUOTE:
            	{
                alt20 = 8;
                }
                break;
            	default:
            	    NoViableAltException nvae_d20s0 =
            	        new NoViableAltException("253:1: opartors returns [string str] : (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE );", 20, 0, input);
            
            	    throw nvae_d20s0;
            }
            
            switch (alt20) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:254:4: i= PLUS
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,PLUS,FOLLOW_PLUS_in_opartors1793); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:255:4: i= MINUS
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,MINUS,FOLLOW_MINUS_in_opartors1804); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:256:4: i= STAR
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,STAR,FOLLOW_STAR_in_opartors1815); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:257:4: i= SLASH
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,SLASH,FOLLOW_SLASH_in_opartors1826); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:258:4: i= LT
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,LT,FOLLOW_LT_in_opartors1837); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:259:4: i= GT
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,GT,FOLLOW_GT_in_opartors1848); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:260:4: i= EQ
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,EQ,FOLLOW_EQ_in_opartors1859); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:261:4: i= QUOTE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_opartors1870); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:263:1: comment returns [string comm] : c= COMMENT ;
    public string comment() // throws RecognitionException [1]
    {   

        string comm = null;
    
        IToken c = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:264:2: (c= COMMENT )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:264:4: c= COMMENT
            {
            	c = (IToken)input.LT(1);
            	Match(input,COMMENT,FOLLOW_COMMENT_in_comment1889); 
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

 

    public static readonly BitSet FOLLOW_scmBlock_in_main358 = new BitSet(new ulong[]{0x003FF4000D000000UL});
    public static readonly BitSet FOLLOW_EOF_in_main361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmFrm_in_scmBlock374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtn_in_scmBlock385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMsg_in_scmBlock396 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmBlock407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmBlock418 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrm438 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmFrm440 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmFrm446 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrm448 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmFrm450 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_FRAME_in_scmFrm452 = new BitSet(new ulong[]{0x003FF4000D000000UL});
    public static readonly BitSet FOLLOW_scmFrmProp_in_scmFrm454 = new BitSet(new ulong[]{0x003FF4000F000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrm458 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrm460 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtn482 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmBtn484 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmBtn490 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtn492 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmBtn494 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_BUTTON_in_scmBtn496 = new BitSet(new ulong[]{0x003FF4000D000000UL});
    public static readonly BitSet FOLLOW_scmBtnProp_in_scmBtn498 = new BitSet(new ulong[]{0x003FF4000F000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtn502 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtn504 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsg526 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmMsg528 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmMsg534 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsg536 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmMsg538 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_MESSAGE_in_scmMsg540 = new BitSet(new ulong[]{0x003FF4000D000000UL});
    public static readonly BitSet FOLLOW_scmMsgProp_in_scmMsg542 = new BitSet(new ulong[]{0x003FF4000F000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsg546 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsg548 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmFrmProp566 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmFrmProp577 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmWidthProp_in_scmFrmProp588 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHeightProp_in_scmFrmProp599 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmFrmProp610 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBorderProp_in_scmFrmProp621 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmSpacingProp_in_scmFrmProp632 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmFrmProp643 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmFrmProp654 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmFrmProp665 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmFrmProp676 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmAlignmentProp_in_scmFrmProp683 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmFrmStyleProp_in_scmFrmProp691 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmXYProp_in_scmFrmProp703 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmFrmProp714 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmFrmProp725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmBtnProp743 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmBtnProp754 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmBtnProp765 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmBtnProp776 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmBtnProp787 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmBtnProp798 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmBtnProp809 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmBtnProp820 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmBtnProp831 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtnStyleProp_in_scmBtnProp838 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmBtnProp850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmBtnProp861 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmMsgProp878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmMsgProp889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmMsgProp900 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmMsgProp911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmMsgProp922 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmMsgProp933 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmMsgProp944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmMsgProp955 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmMsgProp966 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMsgStyleProp_in_scmMsgProp973 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmMsgProp985 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmMsgProp996 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmParentProp1012 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_PARENT_in_scmParentProp1014 = new BitSet(new ulong[]{0x0000040004000000UL});
    public static readonly BitSet FOLLOW_set_in_scmParentProp1019 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmParentProp1027 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmLabelProp1043 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LABEL_in_scmLabelProp1045 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NAME_in_scmLabelProp1051 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmLabelProp1053 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmWidthProp1069 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_WIDTH_in_scmWidthProp1071 = new BitSet(new ulong[]{0x0000100004000000UL});
    public static readonly BitSet FOLLOW_set_in_scmWidthProp1076 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmWidthProp1082 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHeightProp1097 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_HEIGHT_in_scmHeightProp1099 = new BitSet(new ulong[]{0x0000100004000000UL});
    public static readonly BitSet FOLLOW_set_in_scmHeightProp1105 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHeightProp1111 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmXYProp1127 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmXYProp1133 = new BitSet(new ulong[]{0x0000100004000000UL});
    public static readonly BitSet FOLLOW_set_in_scmXYProp1139 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmXYProp1145 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmEnabledProp1161 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ENABLED_in_scmEnabledProp1163 = new BitSet(new ulong[]{0x000000000C000000UL});
    public static readonly BitSet FOLLOW_set_in_scmEnabledProp1169 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmEnabledProp1175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBorderProp1191 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_BORDER_in_scmBorderProp1193 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmBorderProp1199 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBorderProp1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmSpacingProp1216 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_SPACING_in_scmSpacingProp1218 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmSpacingProp1224 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmSpacingProp1226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMinWidthProp1241 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_MIN_WIDTH_in_scmMinWidthProp1243 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmMinWidthProp1249 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMinWidthProp1251 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMinHeightProp1266 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_MIN_HEIGHT_in_scmMinHeightProp1268 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmMinHeightProp1274 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMinHeightProp1276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStretchWidthProp1291 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_STRETCH_WIDTH_in_scmStretchWidthProp1293 = new BitSet(new ulong[]{0x000000000C000000UL});
    public static readonly BitSet FOLLOW_set_in_scmStretchWidthProp1299 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStretchWidthProp1305 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStretchHeightProp1320 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_STRETCH_HEIGHT_in_scmStretchHeightProp1322 = new BitSet(new ulong[]{0x000000000C000000UL});
    public static readonly BitSet FOLLOW_set_in_scmStretchHeightProp1328 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStretchHeightProp1334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmAlignmentProp1348 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_ALIGNMENT_in_scmAlignmentProp1350 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmAlignmentProp1352 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmAlignmentProp1354 = new BitSet(new ulong[]{0x00000001A0000000UL});
    public static readonly BitSet FOLLOW_scmHorizAlign_in_scmAlignmentProp1356 = new BitSet(new ulong[]{0x0000000070000000UL});
    public static readonly BitSet FOLLOW_scmVerticalAlign_in_scmAlignmentProp1359 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmAlignmentProp1362 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmAlignmentProp1364 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1376 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmFrmStyleProp1378 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmFrmStyleProp1380 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1382 = new BitSet(new ulong[]{0x000000FC02000000UL});
    public static readonly BitSet FOLLOW_scmFrmStyleList_in_scmFrmStyleProp1384 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1387 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1394 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmFrmStyleProp1396 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmFrmStyleProp1398 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1412 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmBtnStyleProp1414 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmBtnStyleProp1416 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1418 = new BitSet(new ulong[]{0x0000020002008000UL});
    public static readonly BitSet FOLLOW_scmBtnStyleList_in_scmBtnStyleProp1420 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1423 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1425 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1430 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmBtnStyleProp1432 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmBtnStyleProp1434 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1436 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsgStyleProp1448 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmMsgStyleProp1450 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmMsgStyleProp1452 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsgStyleProp1454 = new BitSet(new ulong[]{0x0000020002000000UL});
    public static readonly BitSet FOLLOW_scmMsgStyleList_in_scmMsgStyleProp1456 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsgStyleProp1459 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsgStyleProp1461 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMsgStyleProp1466 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmMsgStyleProp1468 = new BitSet(new ulong[]{0x0000000200000000UL});
    public static readonly BitSet FOLLOW_NULL_in_scmMsgStyleProp1470 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMsgStyleProp1472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmVertMargin1485 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_VERT_MARGIN_in_scmVertMargin1487 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmVertMargin1493 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmVertMargin1495 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHorizMargin1511 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_HORIZ_MARGIN_in_scmHorizMargin1513 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmHorizMargin1519 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHorizMargin1521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TOP_in_scmVerticalAlign1534 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CENTER_in_scmVerticalAlign1541 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOTTOM_in_scmVerticalAlign1548 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFT_in_scmHorizAlign1561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CENTER_in_scmHorizAlign1568 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RIGHT_in_scmHorizAlign1575 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NO_RESIZE_BORDER_in_scmFrmStyleList1589 = new BitSet(new ulong[]{0x000000FC00000002UL});
    public static readonly BitSet FOLLOW_NO_CAPTION_in_scmFrmStyleList1596 = new BitSet(new ulong[]{0x000000FC00000002UL});
    public static readonly BitSet FOLLOW_NO_SYSTEM_MENU_in_scmFrmStyleList1603 = new BitSet(new ulong[]{0x000000FC00000002UL});
    public static readonly BitSet FOLLOW_MDI_PARENT_in_scmFrmStyleList1610 = new BitSet(new ulong[]{0x000000FC00000002UL});
    public static readonly BitSet FOLLOW_MDI_CHILD_in_scmFrmStyleList1617 = new BitSet(new ulong[]{0x000000FC00000002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_scmFrmStyleList1624 = new BitSet(new ulong[]{0x000000FC00000002UL});
    public static readonly BitSet FOLLOW_BORDER_in_scmBtnStyleList1639 = new BitSet(new ulong[]{0x0000020000008002UL});
    public static readonly BitSet FOLLOW_DELETED_in_scmBtnStyleList1647 = new BitSet(new ulong[]{0x0000020000008002UL});
    public static readonly BitSet FOLLOW_DELETED_in_scmMsgStyleList1663 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_LP_in_parExpr1684 = new BitSet(new ulong[]{0x001FF4000D000000UL});
    public static readonly BitSet FOLLOW_parExpr_in_parExpr1691 = new BitSet(new ulong[]{0x001FF4000F000000UL});
    public static readonly BitSet FOLLOW_RP_in_parExpr1697 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operand_in_parExpr1709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_opartors_in_parExpr1720 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_operand1741 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_operand1752 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_operand1763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_operand1774 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_opartors1793 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_opartors1804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STAR_in_opartors1815 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SLASH_in_opartors1826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_opartors1837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GT_in_opartors1848 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQ_in_opartors1859 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOTE_in_opartors1870 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMENT_in_comment1889 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}