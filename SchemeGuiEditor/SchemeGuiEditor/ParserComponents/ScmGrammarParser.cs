// $ANTLR 3.0.1 D:\\Projects\\AntlrTestApps\\ScmGrammar.g 2008-06-12 17:00:34
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

    public const int MDI_CHILD = 37;
    public const int LT = 49;
    public const int STAR = 47;
    public const int HORIZ_MARGIN = 22;
    public const int STRETCH_WIDTH = 19;
    public const int SPACING = 15;
    public const int RP = 24;
    public const int LEAD_DIGIT = 57;
    public const int STRETCH_HEIGHT = 20;
    public const int LP = 23;
    public const int NEW = 6;
    public const int BUTTON = 8;
    public const int FLOAT = 38;
    public const int ID = 41;
    public const int CAR = 54;
    public const int EOF = -1;
    public const int DEFINE = 5;
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
    public const int VERT_MARGIN = 21;
    public const int SEMI = 4;
    public const int TRUE = 26;
    public const int DELETED = 40;
    public const int NO_RESIZE_BORDER = 33;
    public const int WS = 53;
    public const int NEWLINE = 59;
    public const int LABEL = 10;
    public const int WIDTH = 11;
    public const int BOTTOM = 29;
    public const int STYLE = 39;
    public const int MIN_WIDTH = 17;
    public const int GT = 50;
    public const int FRAME = 7;
    public const int FALSE = 25;
    public const int TOP = 27;
    
    
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:73:1: main : ( scmBlock )+ EOF ;
    public void main() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:73:5: ( ( scmBlock )+ EOF )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:73:7: ( scmBlock )+ EOF
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:73:7: ( scmBlock )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:73:7: scmBlock
            			    {
            			    	PushFollow(FOLLOW_scmBlock_in_main350);
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

            	Match(input,EOF,FOLLOW_EOF_in_main353); 
            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:75:1: scmBlock : (frm= scmFrm | btn= scmBtn | com= comment | pe= parExpr );
    public void scmBlock() // throws RecognitionException [1]
    {   
        ScmFrameProperties frm = null;

        ScmButtonProperties btn = null;

        string com = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:76:2: (frm= scmFrm | btn= scmBtn | com= comment | pe= parExpr )
            int alt2 = 4;
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
                                int LA2_7 = input.LA(6);
                                
                                if ( (LA2_7 == BUTTON) )
                                {
                                    alt2 = 2;
                                }
                                else if ( (LA2_7 == FRAME) )
                                {
                                    alt2 = 1;
                                }
                                else 
                                {
                                    NoViableAltException nvae_d2s7 =
                                        new NoViableAltException("75:1: scmBlock : (frm= scmFrm | btn= scmBtn | com= comment | pe= parExpr );", 2, 7, input);
                                
                                    throw nvae_d2s7;
                                }
                            }
                            else 
                            {
                                NoViableAltException nvae_d2s6 =
                                    new NoViableAltException("75:1: scmBlock : (frm= scmFrm | btn= scmBtn | com= comment | pe= parExpr );", 2, 6, input);
                            
                                throw nvae_d2s6;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d2s5 =
                                new NoViableAltException("75:1: scmBlock : (frm= scmFrm | btn= scmBtn | com= comment | pe= parExpr );", 2, 5, input);
                        
                            throw nvae_d2s5;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d2s4 =
                            new NoViableAltException("75:1: scmBlock : (frm= scmFrm | btn= scmBtn | com= comment | pe= parExpr );", 2, 4, input);
                    
                        throw nvae_d2s4;
                    }
                }
                else if ( (LA2_1 == LP || (LA2_1 >= FALSE && LA2_1 <= TRUE) || LA2_1 == ID || (LA2_1 >= NUMBER && LA2_1 <= EQ)) )
                {
                    alt2 = 4;
                }
                else 
                {
                    NoViableAltException nvae_d2s1 =
                        new NoViableAltException("75:1: scmBlock : (frm= scmFrm | btn= scmBtn | com= comment | pe= parExpr );", 2, 1, input);
                
                    throw nvae_d2s1;
                }
                }
                break;
            case COMMENT:
            	{
                alt2 = 3;
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
                alt2 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("75:1: scmBlock : (frm= scmFrm | btn= scmBtn | com= comment | pe= parExpr );", 2, 0, input);
            
            	    throw nvae_d2s0;
            }
            
            switch (alt2) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:76:4: frm= scmFrm
                    {
                    	PushFollow(FOLLOW_scmFrm_in_scmBlock366);
                    	frm = scmFrm();
                    	followingStackPointer_--;

                    	_parsedData.Add(frm);
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:77:4: btn= scmBtn
                    {
                    	PushFollow(FOLLOW_scmBtn_in_scmBlock377);
                    	btn = scmBtn();
                    	followingStackPointer_--;

                    	_parsedData.Add(btn);
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:78:4: com= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmBlock388);
                    	com = comment();
                    	followingStackPointer_--;

                    	_parsedData.Add(new ScmComment(com));
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:79:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmBlock399);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:81:1: scmFrm returns [ScmFrameProperties frmProp] : LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP ;
    public ScmFrameProperties scmFrm() // throws RecognitionException [1]
    {   

        ScmFrameProperties frmProp = null;
    
        IToken id = null;
    
        
        	ScmFrame frame = new ScmFrame();
        	frmProp =  frame.ScmPropertyObject as ScmFrameProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:87:2: ( LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:87:4: LP DEFINE id= ID LP NEW FRAME ( scmFrmProp[$frmProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmFrm419); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmFrm421); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmFrm427); 
            	Match(input,LP,FOLLOW_LP_in_scmFrm429); 
            	Match(input,NEW,FOLLOW_NEW_in_scmFrm431); 
            	Match(input,FRAME,FOLLOW_FRAME_in_scmFrm433); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:87:35: ( scmFrmProp[$frmProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:87:35: scmFrmProp[$frmProp]
            			    {
            			    	PushFollow(FOLLOW_scmFrmProp_in_scmFrm435);
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

            	Match(input,RP,FOLLOW_RP_in_scmFrm439); 
            	Match(input,RP,FOLLOW_RP_in_scmFrm441); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:89:1: scmBtn returns [ScmButtonProperties btnProp] : LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP ;
    public ScmButtonProperties scmBtn() // throws RecognitionException [1]
    {   

        ScmButtonProperties btnProp = null;
    
        IToken id = null;
    
        
        	ScmButton btn = new ScmButton();
        	btnProp =  btn.ScmPropertyObject as ScmButtonProperties;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:95:2: ( LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:95:4: LP DEFINE id= ID LP NEW BUTTON ( scmBtnProp[$btnProp] )+ RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBtn463); 
            	Match(input,DEFINE,FOLLOW_DEFINE_in_scmBtn465); 
            	id = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmBtn471); 
            	Match(input,LP,FOLLOW_LP_in_scmBtn473); 
            	Match(input,NEW,FOLLOW_NEW_in_scmBtn475); 
            	Match(input,BUTTON,FOLLOW_BUTTON_in_scmBtn477); 
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:95:36: ( scmBtnProp[$btnProp] )+
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
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:95:36: scmBtnProp[$btnProp]
            			    {
            			    	PushFollow(FOLLOW_scmBtnProp_in_scmBtn479);
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

            	Match(input,RP,FOLLOW_RP_in_scmBtn483); 
            	Match(input,RP,FOLLOW_RP_in_scmBtn485); 
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

    
    // $ANTLR start scmFrmProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:97:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | style= scmFrmStyleProp | xyProp= scmXYProp | comm= comment | pe= parExpr );
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

        ScmFrameStyle style = null;

        scmXYProp_return xyProp = null;

        string comm = null;

        string pe = null;
        
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:98:2: (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | style= scmFrmStyleProp | xyProp= scmXYProp | comm= comment | pe= parExpr )
            int alt5 = 16;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case ENABLED:
                	{
                    alt5 = 5;
                    }
                    break;
                case HEIGHT:
                	{
                    alt5 = 4;
                    }
                    break;
                case STYLE:
                	{
                    alt5 = 13;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt5 = 8;
                    }
                    break;
                case SPACING:
                	{
                    alt5 = 7;
                    }
                    break;
                case ID:
                	{
                    switch ( input.LA(3) ) 
                    {
                    case NUMBER:
                    	{
                        int LA5_18 = input.LA(4);
                        
                        if ( (LA5_18 == RP) )
                        {
                            alt5 = 14;
                        }
                        else if ( (LA5_18 == LP || (LA5_18 >= FALSE && LA5_18 <= TRUE) || LA5_18 == ID || (LA5_18 >= NUMBER && LA5_18 <= EQ)) )
                        {
                            alt5 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d5s18 =
                                new NoViableAltException("97:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | style= scmFrmStyleProp | xyProp= scmXYProp | comm= comment | pe= parExpr );", 5, 18, input);
                        
                            throw nvae_d5s18;
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
                        alt5 = 16;
                        }
                        break;
                    case FALSE:
                    	{
                        int LA5_19 = input.LA(4);
                        
                        if ( (LA5_19 == RP) )
                        {
                            alt5 = 14;
                        }
                        else if ( (LA5_19 == LP || (LA5_19 >= FALSE && LA5_19 <= TRUE) || LA5_19 == ID || (LA5_19 >= NUMBER && LA5_19 <= EQ)) )
                        {
                            alt5 = 16;
                        }
                        else 
                        {
                            NoViableAltException nvae_d5s19 =
                                new NoViableAltException("97:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | style= scmFrmStyleProp | xyProp= scmXYProp | comm= comment | pe= parExpr );", 5, 19, input);
                        
                            throw nvae_d5s19;
                        }
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d5s9 =
                    	        new NoViableAltException("97:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | style= scmFrmStyleProp | xyProp= scmXYProp | comm= comment | pe= parExpr );", 5, 9, input);
                    
                    	    throw nvae_d5s9;
                    }
                
                    }
                    break;
                case BORDER:
                	{
                    alt5 = 6;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt5 = 10;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt5 = 9;
                    }
                    break;
                case WIDTH:
                	{
                    alt5 = 3;
                    }
                    break;
                case ALIGNMENT:
                	{
                    alt5 = 12;
                    }
                    break;
                case PARENT:
                	{
                    alt5 = 1;
                    }
                    break;
                case LABEL:
                	{
                    alt5 = 2;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt5 = 11;
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
                    alt5 = 16;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d5s1 =
                	        new NoViableAltException("97:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | style= scmFrmStyleProp | xyProp= scmXYProp | comm= comment | pe= parExpr );", 5, 1, input);
                
                	    throw nvae_d5s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt5 = 15;
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
                alt5 = 16;
                }
                break;
            	default:
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("97:1: scmFrmProp[ScmFrameProperties frmProp] : (parent= scmParentProp | label= scmLabelProp | width= scmWidthProp | height= scmHeightProp | enabled= scmEnabledProp | border= scmBorderProp | spacing= scmSpacingProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | scmAlignmentProp[frmProp.Alignment] | style= scmFrmStyleProp | xyProp= scmXYProp | comm= comment | pe= parExpr );", 5, 0, input);
            
            	    throw nvae_d5s0;
            }
            
            switch (alt5) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:98:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmFrmProp503);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	frmProp.Parent = parent; frmProp.AddParesedProperty(FramePropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:99:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmFrmProp514);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	frmProp.Label = label; frmProp.AddParesedProperty(FramePropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:100:4: width= scmWidthProp
                    {
                    	PushFollow(FOLLOW_scmWidthProp_in_scmFrmProp525);
                    	width = scmWidthProp();
                    	followingStackPointer_--;

                    	if (width != "#f") { frmProp.AutosizeWidth = false; frmProp.Width = width; frmProp.AddParesedProperty(FramePropNames.Width);}
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:101:4: height= scmHeightProp
                    {
                    	PushFollow(FOLLOW_scmHeightProp_in_scmFrmProp536);
                    	height = scmHeightProp();
                    	followingStackPointer_--;

                    	if (height != "#f") {frmProp.AutosizeHeight = false; frmProp.Height = height; frmProp.AddParesedProperty(FramePropNames.Height);}
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:102:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmFrmProp547);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	frmProp.Enabled = enabled; frmProp.AddParesedProperty(FramePropNames.Enabled);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:103:4: border= scmBorderProp
                    {
                    	PushFollow(FOLLOW_scmBorderProp_in_scmFrmProp558);
                    	border = scmBorderProp();
                    	followingStackPointer_--;

                    	frmProp.Border = border; frmProp.AddParesedProperty(FramePropNames.Border);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:104:4: spacing= scmSpacingProp
                    {
                    	PushFollow(FOLLOW_scmSpacingProp_in_scmFrmProp569);
                    	spacing = scmSpacingProp();
                    	followingStackPointer_--;

                    	frmProp.Spacing = spacing; frmProp.AddParesedProperty(FramePropNames.Spacing);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:105:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmFrmProp580);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	frmProp.MinWidth = minWidth; frmProp.AddParesedProperty(FramePropNames.MinWidth);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:106:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmFrmProp591);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	frmProp.MinHeight = minHeight; frmProp.AddParesedProperty(FramePropNames.MinHeight);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:107:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmFrmProp602);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	frmProp.StretchableWidth = strechWidth; frmProp.AddParesedProperty(FramePropNames.StrechWidth);
                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:108:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmFrmProp613);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	frmProp.StretchableHeight = strechHeight; frmProp.AddParesedProperty(FramePropNames.StrechHeight);
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:109:4: scmAlignmentProp[frmProp.Alignment]
                    {
                    	PushFollow(FOLLOW_scmAlignmentProp_in_scmFrmProp620);
                    	scmAlignmentProp(frmProp.Alignment);
                    	followingStackPointer_--;

                    	frmProp.AddParesedProperty(FramePropNames.Alignment);
                    
                    }
                    break;
                case 13 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:110:4: style= scmFrmStyleProp
                    {
                    	PushFollow(FOLLOW_scmFrmStyleProp_in_scmFrmProp632);
                    	style = scmFrmStyleProp();
                    	followingStackPointer_--;

                    	frmProp.Style = style; frmProp.AddParesedProperty(FramePropNames.Style);
                    
                    }
                    break;
                case 14 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:111:4: xyProp= scmXYProp
                    {
                    	PushFollow(FOLLOW_scmXYProp_in_scmFrmProp643);
                    	xyProp = scmXYProp();
                    	followingStackPointer_--;

                    	frmProp.SetXYProp(xyProp.name, xyProp.value);
                    
                    }
                    break;
                case 15 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:112:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmFrmProp654);
                    	comm = comment();
                    	followingStackPointer_--;

                    	frmProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 16 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:113:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmFrmProp665);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:115:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp | comm= comment | pe= parExpr );
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
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:116:2: (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp | comm= comment | pe= parExpr )
            int alt6 = 12;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                switch ( input.LA(2) ) 
                {
                case PARENT:
                	{
                    alt6 = 1;
                    }
                    break;
                case STRETCH_WIDTH:
                	{
                    alt6 = 6;
                    }
                    break;
                case STRETCH_HEIGHT:
                	{
                    alt6 = 7;
                    }
                    break;
                case LABEL:
                	{
                    alt6 = 2;
                    }
                    break;
                case ENABLED:
                	{
                    alt6 = 3;
                    }
                    break;
                case STYLE:
                	{
                    alt6 = 10;
                    }
                    break;
                case MIN_HEIGHT:
                	{
                    alt6 = 5;
                    }
                    break;
                case VERT_MARGIN:
                	{
                    alt6 = 8;
                    }
                    break;
                case HORIZ_MARGIN:
                	{
                    alt6 = 9;
                    }
                    break;
                case MIN_WIDTH:
                	{
                    alt6 = 4;
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
                    alt6 = 12;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d6s1 =
                	        new NoViableAltException("115:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp | comm= comment | pe= parExpr );", 6, 1, input);
                
                	    throw nvae_d6s1;
                }
            
                }
                break;
            case COMMENT:
            	{
                alt6 = 11;
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
                alt6 = 12;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("115:1: scmBtnProp[ScmButtonProperties btnProp] : (parent= scmParentProp | label= scmLabelProp | enabled= scmEnabledProp | minWidth= scmMinWidthProp | minHeight= scmMinHeightProp | strechWidth= scmStretchWidthProp | strechHeight= scmStretchHeightProp | vertMarg= scmVertMargin | horizMarg= scmHorizMargin | scmBtnStyleProp | comm= comment | pe= parExpr );", 6, 0, input);
            
            	    throw nvae_d6s0;
            }
            
            switch (alt6) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:116:4: parent= scmParentProp
                    {
                    	PushFollow(FOLLOW_scmParentProp_in_scmBtnProp683);
                    	parent = scmParentProp();
                    	followingStackPointer_--;

                    	btnProp.Parent = parent; btnProp.AddParesedProperty(ButtonPropNames.Parent); 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:117:4: label= scmLabelProp
                    {
                    	PushFollow(FOLLOW_scmLabelProp_in_scmBtnProp694);
                    	label = scmLabelProp();
                    	followingStackPointer_--;

                    	btnProp.Label = label; btnProp.AddParesedProperty(ButtonPropNames.Label); 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:118:4: enabled= scmEnabledProp
                    {
                    	PushFollow(FOLLOW_scmEnabledProp_in_scmBtnProp705);
                    	enabled = scmEnabledProp();
                    	followingStackPointer_--;

                    	btnProp.Enabled = enabled; btnProp.AddParesedProperty(ButtonPropNames.Enabled);
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:119:4: minWidth= scmMinWidthProp
                    {
                    	PushFollow(FOLLOW_scmMinWidthProp_in_scmBtnProp716);
                    	minWidth = scmMinWidthProp();
                    	followingStackPointer_--;

                    	btnProp.MinWidth = minWidth;if (minWidth == 0) btnProp.AutosizeWidth = true; btnProp.AddParesedProperty(ButtonPropNames.MinWidth);
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:120:4: minHeight= scmMinHeightProp
                    {
                    	PushFollow(FOLLOW_scmMinHeightProp_in_scmBtnProp727);
                    	minHeight = scmMinHeightProp();
                    	followingStackPointer_--;

                    	btnProp.MinHeight = minHeight; if (minHeight == 0) btnProp.AutosizeHeight = true; btnProp.AddParesedProperty( ButtonPropNames.MinHeight);
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:121:4: strechWidth= scmStretchWidthProp
                    {
                    	PushFollow(FOLLOW_scmStretchWidthProp_in_scmBtnProp738);
                    	strechWidth = scmStretchWidthProp();
                    	followingStackPointer_--;

                    	btnProp.StretchableWidth = strechWidth; btnProp.AddParesedProperty(ButtonPropNames.StrechWidth);
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:122:4: strechHeight= scmStretchHeightProp
                    {
                    	PushFollow(FOLLOW_scmStretchHeightProp_in_scmBtnProp749);
                    	strechHeight = scmStretchHeightProp();
                    	followingStackPointer_--;

                    	btnProp.StretchableHeight = strechHeight; btnProp.AddParesedProperty(ButtonPropNames.StrechHeight);
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:123:4: vertMarg= scmVertMargin
                    {
                    	PushFollow(FOLLOW_scmVertMargin_in_scmBtnProp760);
                    	vertMarg = scmVertMargin();
                    	followingStackPointer_--;

                    	btnProp.VerticalMargin = vertMarg; btnProp.AddParesedProperty(ButtonPropNames.VerticalMargin);
                    
                    }
                    break;
                case 9 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:124:4: horizMarg= scmHorizMargin
                    {
                    	PushFollow(FOLLOW_scmHorizMargin_in_scmBtnProp771);
                    	horizMarg = scmHorizMargin();
                    	followingStackPointer_--;

                    	btnProp.HorizontalMargin = vertMarg; btnProp.AddParesedProperty(ButtonPropNames.HorizontalMargin);
                    
                    }
                    break;
                case 10 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:125:4: scmBtnStyleProp
                    {
                    	PushFollow(FOLLOW_scmBtnStyleProp_in_scmBtnProp778);
                    	scmBtnStyleProp();
                    	followingStackPointer_--;

                    
                    }
                    break;
                case 11 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:126:4: comm= comment
                    {
                    	PushFollow(FOLLOW_comment_in_scmBtnProp788);
                    	comm = comment();
                    	followingStackPointer_--;

                    	btnProp.SetScmComment(new ScmComment(comm)); 
                    
                    }
                    break;
                case 12 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:127:4: pe= parExpr
                    {
                    	PushFollow(FOLLOW_parExpr_in_scmBtnProp799);
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

    
    // $ANTLR start scmParentProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:129:1: scmParentProp returns [string parent] : LP PARENT par= ( ID | FALSE ) RP ;
    public string scmParentProp() // throws RecognitionException [1]
    {   

        string parent = null;
    
        IToken par = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:130:2: ( LP PARENT par= ( ID | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:130:4: LP PARENT par= ( ID | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmParentProp814); 
            	Match(input,PARENT,FOLLOW_PARENT_in_scmParentProp816); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmParentProp821);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmParentProp829); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:132:1: scmLabelProp returns [string label] : LP LABEL name= NAME RP ;
    public string scmLabelProp() // throws RecognitionException [1]
    {   

        string label = null;
    
        IToken name = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:133:2: ( LP LABEL name= NAME RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:133:4: LP LABEL name= NAME RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmLabelProp845); 
            	Match(input,LABEL,FOLLOW_LABEL_in_scmLabelProp847); 
            	name = (IToken)input.LT(1);
            	Match(input,NAME,FOLLOW_NAME_in_scmLabelProp853); 
            	Match(input,RP,FOLLOW_RP_in_scmLabelProp855); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:135:1: scmWidthProp returns [string width] : LP WIDTH v= ( NUMBER | FALSE ) RP ;
    public string scmWidthProp() // throws RecognitionException [1]
    {   

        string width = null;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:136:2: ( LP WIDTH v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:136:4: LP WIDTH v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmWidthProp871); 
            	Match(input,WIDTH,FOLLOW_WIDTH_in_scmWidthProp873); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmWidthProp878);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmWidthProp884); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:138:1: scmHeightProp returns [string height] : LP HEIGHT v= ( NUMBER | FALSE ) RP ;
    public string scmHeightProp() // throws RecognitionException [1]
    {   

        string height = null;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:139:2: ( LP HEIGHT v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:139:4: LP HEIGHT v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHeightProp899); 
            	Match(input,HEIGHT,FOLLOW_HEIGHT_in_scmHeightProp901); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmHeightProp907);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmHeightProp913); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:141:1: scmXYProp returns [string name, string value] : LP n= ID v= ( NUMBER | FALSE ) RP ;
    public scmXYProp_return scmXYProp() // throws RecognitionException [1]
    {   
        scmXYProp_return retval = new scmXYProp_return();
        retval.start = input.LT(1);
    
        IToken n = null;
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:142:2: ( LP n= ID v= ( NUMBER | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:142:4: LP n= ID v= ( NUMBER | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmXYProp929); 
            	n = (IToken)input.LT(1);
            	Match(input,ID,FOLLOW_ID_in_scmXYProp935); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmXYProp941);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmXYProp947); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:144:1: scmEnabledProp returns [bool enabled] : LP ENABLED v= ( TRUE | FALSE ) RP ;
    public bool scmEnabledProp() // throws RecognitionException [1]
    {   

        bool enabled = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:145:2: ( LP ENABLED v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:145:4: LP ENABLED v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmEnabledProp963); 
            	Match(input,ENABLED,FOLLOW_ENABLED_in_scmEnabledProp965); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmEnabledProp971);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmEnabledProp977); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:148:1: scmBorderProp returns [int border] : LP BORDER nr= NUMBER RP ;
    public int scmBorderProp() // throws RecognitionException [1]
    {   

        int border = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:149:2: ( LP BORDER nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:149:4: LP BORDER nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBorderProp993); 
            	Match(input,BORDER,FOLLOW_BORDER_in_scmBorderProp995); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmBorderProp1001); 
            	Match(input,RP,FOLLOW_RP_in_scmBorderProp1003); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:151:1: scmSpacingProp returns [int spacing] : LP SPACING nr= NUMBER RP ;
    public int scmSpacingProp() // throws RecognitionException [1]
    {   

        int spacing = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:152:2: ( LP SPACING nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:152:4: LP SPACING nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmSpacingProp1018); 
            	Match(input,SPACING,FOLLOW_SPACING_in_scmSpacingProp1020); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmSpacingProp1026); 
            	Match(input,RP,FOLLOW_RP_in_scmSpacingProp1028); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:154:1: scmMinWidthProp returns [int minWidth] : LP MIN_WIDTH nr= NUMBER RP ;
    public int scmMinWidthProp() // throws RecognitionException [1]
    {   

        int minWidth = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:155:2: ( LP MIN_WIDTH nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:155:4: LP MIN_WIDTH nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMinWidthProp1043); 
            	Match(input,MIN_WIDTH,FOLLOW_MIN_WIDTH_in_scmMinWidthProp1045); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmMinWidthProp1051); 
            	Match(input,RP,FOLLOW_RP_in_scmMinWidthProp1053); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:157:1: scmMinHeightProp returns [int minHeight] : LP MIN_HEIGHT nr= NUMBER RP ;
    public int scmMinHeightProp() // throws RecognitionException [1]
    {   

        int minHeight = 0;
    
        IToken nr = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:158:2: ( LP MIN_HEIGHT nr= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:158:4: LP MIN_HEIGHT nr= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmMinHeightProp1068); 
            	Match(input,MIN_HEIGHT,FOLLOW_MIN_HEIGHT_in_scmMinHeightProp1070); 
            	nr = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmMinHeightProp1076); 
            	Match(input,RP,FOLLOW_RP_in_scmMinHeightProp1078); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:160:1: scmStretchWidthProp returns [bool strechWidth] : LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP ;
    public bool scmStretchWidthProp() // throws RecognitionException [1]
    {   

        bool strechWidth = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:161:2: ( LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:161:4: LP STRETCH_WIDTH v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmStretchWidthProp1093); 
            	Match(input,STRETCH_WIDTH,FOLLOW_STRETCH_WIDTH_in_scmStretchWidthProp1095); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmStretchWidthProp1101);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmStretchWidthProp1107); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:164:1: scmStretchHeightProp returns [bool strechHeigth] : LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP ;
    public bool scmStretchHeightProp() // throws RecognitionException [1]
    {   

        bool strechHeigth = false;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:165:2: ( LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:165:4: LP STRETCH_HEIGHT v= ( TRUE | FALSE ) RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmStretchHeightProp1122); 
            	Match(input,STRETCH_HEIGHT,FOLLOW_STRETCH_HEIGHT_in_scmStretchHeightProp1124); 
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
            	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmStretchHeightProp1130);    throw mse;
            	}

            	Match(input,RP,FOLLOW_RP_in_scmStretchHeightProp1136); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:168:1: scmAlignmentProp[ContainerAlignment alignment] : LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP ;
    public void scmAlignmentProp(ContainerAlignment alignment) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:169:2: ( LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:169:4: LP ALIGNMENT QUOTE LP scmHorizAlign[$alignment] scmVerticalAlign[$alignment] RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmAlignmentProp1150); 
            	Match(input,ALIGNMENT,FOLLOW_ALIGNMENT_in_scmAlignmentProp1152); 
            	Match(input,QUOTE,FOLLOW_QUOTE_in_scmAlignmentProp1154); 
            	Match(input,LP,FOLLOW_LP_in_scmAlignmentProp1156); 
            	PushFollow(FOLLOW_scmHorizAlign_in_scmAlignmentProp1158);
            	scmHorizAlign(alignment);
            	followingStackPointer_--;

            	PushFollow(FOLLOW_scmVerticalAlign_in_scmAlignmentProp1161);
            	scmVerticalAlign(alignment);
            	followingStackPointer_--;

            	Match(input,RP,FOLLOW_RP_in_scmAlignmentProp1164); 
            	Match(input,RP,FOLLOW_RP_in_scmAlignmentProp1166); 
            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:171:1: scmFrmStyleProp returns [ScmFrameStyle style] : LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP ;
    public ScmFrameStyle scmFrmStyleProp() // throws RecognitionException [1]
    {   

        ScmFrameStyle style = null;
    
        
        	style =  new ScmFrameStyle();
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:176:2: ( LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:176:4: LP STYLE QUOTE LP scmFrmStyleList[$style] RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1185); 
            	Match(input,STYLE,FOLLOW_STYLE_in_scmFrmStyleProp1187); 
            	Match(input,QUOTE,FOLLOW_QUOTE_in_scmFrmStyleProp1189); 
            	Match(input,LP,FOLLOW_LP_in_scmFrmStyleProp1191); 
            	PushFollow(FOLLOW_scmFrmStyleList_in_scmFrmStyleProp1193);
            	scmFrmStyleList(style);
            	followingStackPointer_--;

            	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1196); 
            	Match(input,RP,FOLLOW_RP_in_scmFrmStyleProp1198); 
            
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
        return style;
    }
    // $ANTLR end scmFrmStyleProp

    
    // $ANTLR start scmBtnStyleProp
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:178:1: scmBtnStyleProp : LP STYLE QUOTE LP scmBtnStyleList RP RP ;
    public void scmBtnStyleProp() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:179:2: ( LP STYLE QUOTE LP scmBtnStyleList RP RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:179:4: LP STYLE QUOTE LP scmBtnStyleList RP RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1208); 
            	Match(input,STYLE,FOLLOW_STYLE_in_scmBtnStyleProp1210); 
            	Match(input,QUOTE,FOLLOW_QUOTE_in_scmBtnStyleProp1212); 
            	Match(input,LP,FOLLOW_LP_in_scmBtnStyleProp1214); 
            	PushFollow(FOLLOW_scmBtnStyleList_in_scmBtnStyleProp1216);
            	scmBtnStyleList();
            	followingStackPointer_--;

            	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1218); 
            	Match(input,RP,FOLLOW_RP_in_scmBtnStyleProp1220); 
            
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

    
    // $ANTLR start scmVertMargin
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:181:1: scmVertMargin returns [int val] : LP VERT_MARGIN v= NUMBER RP ;
    public int scmVertMargin() // throws RecognitionException [1]
    {   

        int val = 0;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:182:2: ( LP VERT_MARGIN v= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:182:4: LP VERT_MARGIN v= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmVertMargin1233); 
            	Match(input,VERT_MARGIN,FOLLOW_VERT_MARGIN_in_scmVertMargin1235); 
            	v = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmVertMargin1241); 
            	Match(input,RP,FOLLOW_RP_in_scmVertMargin1243); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:184:1: scmHorizMargin returns [int val] : LP HORIZ_MARGIN v= NUMBER RP ;
    public int scmHorizMargin() // throws RecognitionException [1]
    {   

        int val = 0;
    
        IToken v = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:185:2: ( LP HORIZ_MARGIN v= NUMBER RP )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:185:4: LP HORIZ_MARGIN v= NUMBER RP
            {
            	Match(input,LP,FOLLOW_LP_in_scmHorizMargin1259); 
            	Match(input,HORIZ_MARGIN,FOLLOW_HORIZ_MARGIN_in_scmHorizMargin1261); 
            	v = (IToken)input.LT(1);
            	Match(input,NUMBER,FOLLOW_NUMBER_in_scmHorizMargin1267); 
            	Match(input,RP,FOLLOW_RP_in_scmHorizMargin1269); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:187:1: scmVerticalAlign[ContainerAlignment align] : ( TOP | CENTER | BOTTOM );
    public void scmVerticalAlign(ContainerAlignment align) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:188:2: ( TOP | CENTER | BOTTOM )
            int alt7 = 3;
            switch ( input.LA(1) ) 
            {
            case TOP:
            	{
                alt7 = 1;
                }
                break;
            case CENTER:
            	{
                alt7 = 2;
                }
                break;
            case BOTTOM:
            	{
                alt7 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("187:1: scmVerticalAlign[ContainerAlignment align] : ( TOP | CENTER | BOTTOM );", 7, 0, input);
            
            	    throw nvae_d7s0;
            }
            
            switch (alt7) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:188:4: TOP
                    {
                    	Match(input,TOP,FOLLOW_TOP_in_scmVerticalAlign1282); 
                    	align.VerticalAlignment = VerticalAlign.Top; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:189:4: CENTER
                    {
                    	Match(input,CENTER,FOLLOW_CENTER_in_scmVerticalAlign1289); 
                    	align.VerticalAlignment = VerticalAlign.Center; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:190:4: BOTTOM
                    {
                    	Match(input,BOTTOM,FOLLOW_BOTTOM_in_scmVerticalAlign1296); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:192:1: scmHorizAlign[ContainerAlignment align] : ( LEFT | CENTER | RIGHT );
    public void scmHorizAlign(ContainerAlignment align) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:193:2: ( LEFT | CENTER | RIGHT )
            int alt8 = 3;
            switch ( input.LA(1) ) 
            {
            case LEFT:
            	{
                alt8 = 1;
                }
                break;
            case CENTER:
            	{
                alt8 = 2;
                }
                break;
            case RIGHT:
            	{
                alt8 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("192:1: scmHorizAlign[ContainerAlignment align] : ( LEFT | CENTER | RIGHT );", 8, 0, input);
            
            	    throw nvae_d8s0;
            }
            
            switch (alt8) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:193:4: LEFT
                    {
                    	Match(input,LEFT,FOLLOW_LEFT_in_scmHorizAlign1309); 
                    	align.HorizontalAlignment = HorizontalAlign.Left; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:194:4: CENTER
                    {
                    	Match(input,CENTER,FOLLOW_CENTER_in_scmHorizAlign1316); 
                    	align.HorizontalAlignment = HorizontalAlign.Center; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:195:4: RIGHT
                    {
                    	Match(input,RIGHT,FOLLOW_RIGHT_in_scmHorizAlign1323); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:197:1: scmFrmStyleList[ScmFrameStyle style] : ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )* ;
    public void scmFrmStyleList(ScmFrameStyle style) // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:198:2: ( ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:198:4: ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:198:4: ( NO_RESIZE_BORDER | NO_CAPTION | NO_SYSTEM_MENU | MDI_PARENT | MDI_CHILD | FLOAT )*
            	do 
            	{
            	    int alt9 = 7;
            	    switch ( input.LA(1) ) 
            	    {
            	    case NO_RESIZE_BORDER:
            	    	{
            	        alt9 = 1;
            	        }
            	        break;
            	    case NO_CAPTION:
            	    	{
            	        alt9 = 2;
            	        }
            	        break;
            	    case NO_SYSTEM_MENU:
            	    	{
            	        alt9 = 3;
            	        }
            	        break;
            	    case MDI_PARENT:
            	    	{
            	        alt9 = 4;
            	        }
            	        break;
            	    case MDI_CHILD:
            	    	{
            	        alt9 = 5;
            	        }
            	        break;
            	    case FLOAT:
            	    	{
            	        alt9 = 6;
            	        }
            	        break;
            	    
            	    }
            	
            	    switch (alt9) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:198:5: NO_RESIZE_BORDER
            			    {
            			    	Match(input,NO_RESIZE_BORDER,FOLLOW_NO_RESIZE_BORDER_in_scmFrmStyleList1337); 
            			    	style.NoResizeBorder = true; 
            			    
            			    }
            			    break;
            			case 2 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:199:4: NO_CAPTION
            			    {
            			    	Match(input,NO_CAPTION,FOLLOW_NO_CAPTION_in_scmFrmStyleList1344); 
            			    	style.NoCaption = true; 
            			    
            			    }
            			    break;
            			case 3 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:200:4: NO_SYSTEM_MENU
            			    {
            			    	Match(input,NO_SYSTEM_MENU,FOLLOW_NO_SYSTEM_MENU_in_scmFrmStyleList1351); 
            			    	style.NoSystemMenu = true; 
            			    
            			    }
            			    break;
            			case 4 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:201:4: MDI_PARENT
            			    {
            			    	Match(input,MDI_PARENT,FOLLOW_MDI_PARENT_in_scmFrmStyleList1358); 
            			    	style.MdiParent = true; 
            			    
            			    }
            			    break;
            			case 5 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:202:4: MDI_CHILD
            			    {
            			    	Match(input,MDI_CHILD,FOLLOW_MDI_CHILD_in_scmFrmStyleList1365); 
            			    	style.MdiChild = true; 
            			    
            			    }
            			    break;
            			case 6 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:203:4: FLOAT
            			    {
            			    	Match(input,FLOAT,FOLLOW_FLOAT_in_scmFrmStyleList1372); 
            			    	style.Floating = true; 
            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop9;
            	    }
            	} while (true);
            	
            	loop9:
            		;	// Stops C# compiler whinging that label 'loop9' has no statements

            
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:205:1: scmBtnStyleList : ( BORDER | DELETED )* ;
    public void scmBtnStyleList() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:206:2: ( ( BORDER | DELETED )* )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:206:4: ( BORDER | DELETED )*
            {
            	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:206:4: ( BORDER | DELETED )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);
            	    
            	    if ( (LA10_0 == BORDER || LA10_0 == DELETED) )
            	    {
            	        alt10 = 1;
            	    }
            	    
            	
            	    switch (alt10) 
            		{
            			case 1 :
            			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:
            			    {
            			    	if ( input.LA(1) == BORDER || input.LA(1) == DELETED ) 
            			    	{
            			    	    input.Consume();
            			    	    errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse =
            			    	        new MismatchedSetException(null,input);
            			    	    RecoverFromMismatchedSet(input,mse,FOLLOW_set_in_scmBtnStyleList1385);    throw mse;
            			    	}

            			    
            			    }
            			    break;
            	
            			default:
            			    goto loop10;
            	    }
            	} while (true);
            	
            	loop10:
            		;	// Stops C# compiler whinging that label 'loop10' has no statements

            
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

    
    // $ANTLR start parExpr
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:208:1: parExpr returns [string expr] : ( LP (pe= parExpr )+ RP | op= operand | oa= opartors );
    public string parExpr() // throws RecognitionException [1]
    {   

        string expr = null;
    
        string pe = null;

        string op = null;

        string oa = null;
        
    
        
        expr =  string.Empty;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:212:2: ( LP (pe= parExpr )+ RP | op= operand | oa= opartors )
            int alt12 = 3;
            switch ( input.LA(1) ) 
            {
            case LP:
            	{
                alt12 = 1;
                }
                break;
            case FALSE:
            case TRUE:
            case ID:
            case NUMBER:
            	{
                alt12 = 2;
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
                alt12 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d12s0 =
            	        new NoViableAltException("208:1: parExpr returns [string expr] : ( LP (pe= parExpr )+ RP | op= operand | oa= opartors );", 12, 0, input);
            
            	    throw nvae_d12s0;
            }
            
            switch (alt12) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:212:4: LP (pe= parExpr )+ RP
                    {
                    	Match(input,LP,FOLLOW_LP_in_parExpr1409); 
                    	// D:\\Projects\\AntlrTestApps\\ScmGrammar.g:212:7: (pe= parExpr )+
                    	int cnt11 = 0;
                    	do 
                    	{
                    	    int alt11 = 2;
                    	    int LA11_0 = input.LA(1);
                    	    
                    	    if ( (LA11_0 == LP || (LA11_0 >= FALSE && LA11_0 <= TRUE) || LA11_0 == ID || (LA11_0 >= NUMBER && LA11_0 <= EQ)) )
                    	    {
                    	        alt11 = 1;
                    	    }
                    	    
                    	
                    	    switch (alt11) 
                    		{
                    			case 1 :
                    			    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:212:8: pe= parExpr
                    			    {
                    			    	PushFollow(FOLLOW_parExpr_in_parExpr1416);
                    			    	pe = parExpr();
                    			    	followingStackPointer_--;

                    			    	expr +=pe; 
                    			    
                    			    }
                    			    break;
                    	
                    			default:
                    			    if ( cnt11 >= 1 ) goto loop11;
                    		            EarlyExitException eee =
                    		                new EarlyExitException(11, input);
                    		            throw eee;
                    	    }
                    	    cnt11++;
                    	} while (true);
                    	
                    	loop11:
                    		;	// Stops C# compiler whinging that label 'loop11' has no statements

                    	Match(input,RP,FOLLOW_RP_in_parExpr1422); 
                    	expr =  "(" + expr + ")";
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:213:4: op= operand
                    {
                    	PushFollow(FOLLOW_operand_in_parExpr1434);
                    	op = operand();
                    	followingStackPointer_--;

                    	expr += op + " "; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:214:4: oa= opartors
                    {
                    	PushFollow(FOLLOW_opartors_in_parExpr1445);
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:217:1: operand returns [string str] : (i= ID | i= NUMBER | i= TRUE | i= FALSE );
    public string operand() // throws RecognitionException [1]
    {   

        string str = null;
    
        IToken i = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:218:2: (i= ID | i= NUMBER | i= TRUE | i= FALSE )
            int alt13 = 4;
            switch ( input.LA(1) ) 
            {
            case ID:
            	{
                alt13 = 1;
                }
                break;
            case NUMBER:
            	{
                alt13 = 2;
                }
                break;
            case TRUE:
            	{
                alt13 = 3;
                }
                break;
            case FALSE:
            	{
                alt13 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d13s0 =
            	        new NoViableAltException("217:1: operand returns [string str] : (i= ID | i= NUMBER | i= TRUE | i= FALSE );", 13, 0, input);
            
            	    throw nvae_d13s0;
            }
            
            switch (alt13) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:218:4: i= ID
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,ID,FOLLOW_ID_in_operand1466); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:219:4: i= NUMBER
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,NUMBER,FOLLOW_NUMBER_in_operand1477); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:220:4: i= TRUE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,TRUE,FOLLOW_TRUE_in_operand1488); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:221:4: i= FALSE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,FALSE,FOLLOW_FALSE_in_operand1499); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:223:1: opartors returns [string str] : (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE );
    public string opartors() // throws RecognitionException [1]
    {   

        string str = null;
    
        IToken i = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:224:2: (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE )
            int alt14 = 8;
            switch ( input.LA(1) ) 
            {
            case PLUS:
            	{
                alt14 = 1;
                }
                break;
            case MINUS:
            	{
                alt14 = 2;
                }
                break;
            case STAR:
            	{
                alt14 = 3;
                }
                break;
            case SLASH:
            	{
                alt14 = 4;
                }
                break;
            case LT:
            	{
                alt14 = 5;
                }
                break;
            case GT:
            	{
                alt14 = 6;
                }
                break;
            case EQ:
            	{
                alt14 = 7;
                }
                break;
            case QUOTE:
            	{
                alt14 = 8;
                }
                break;
            	default:
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("223:1: opartors returns [string str] : (i= PLUS | i= MINUS | i= STAR | i= SLASH | i= LT | i= GT | i= EQ | i= QUOTE );", 14, 0, input);
            
            	    throw nvae_d14s0;
            }
            
            switch (alt14) 
            {
                case 1 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:224:4: i= PLUS
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,PLUS,FOLLOW_PLUS_in_opartors1518); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 2 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:225:4: i= MINUS
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,MINUS,FOLLOW_MINUS_in_opartors1529); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 3 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:226:4: i= STAR
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,STAR,FOLLOW_STAR_in_opartors1540); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 4 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:227:4: i= SLASH
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,SLASH,FOLLOW_SLASH_in_opartors1551); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 5 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:228:4: i= LT
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,LT,FOLLOW_LT_in_opartors1562); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 6 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:229:4: i= GT
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,GT,FOLLOW_GT_in_opartors1573); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 7 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:230:4: i= EQ
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,EQ,FOLLOW_EQ_in_opartors1584); 
                    	str =  i.Text; 
                    
                    }
                    break;
                case 8 :
                    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:231:4: i= QUOTE
                    {
                    	i = (IToken)input.LT(1);
                    	Match(input,QUOTE,FOLLOW_QUOTE_in_opartors1595); 
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
    // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:233:1: comment returns [string comm] : c= COMMENT ;
    public string comment() // throws RecognitionException [1]
    {   

        string comm = null;
    
        IToken c = null;
    
        try 
    	{
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:234:2: (c= COMMENT )
            // D:\\Projects\\AntlrTestApps\\ScmGrammar.g:234:4: c= COMMENT
            {
            	c = (IToken)input.LT(1);
            	Match(input,COMMENT,FOLLOW_COMMENT_in_comment1614); 
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

 

    public static readonly BitSet FOLLOW_scmBlock_in_main350 = new BitSet(new ulong[]{0x001FFA0006800000UL});
    public static readonly BitSet FOLLOW_EOF_in_main353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmFrm_in_scmBlock366 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtn_in_scmBlock377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmBlock388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmBlock399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrm419 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmFrm421 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmFrm427 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrm429 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmFrm431 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_FRAME_in_scmFrm433 = new BitSet(new ulong[]{0x001FFA0006800000UL});
    public static readonly BitSet FOLLOW_scmFrmProp_in_scmFrm435 = new BitSet(new ulong[]{0x001FFA0007800000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrm439 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrm441 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtn463 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_DEFINE_in_scmBtn465 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmBtn471 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtn473 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_NEW_in_scmBtn475 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_BUTTON_in_scmBtn477 = new BitSet(new ulong[]{0x001FFA0006800000UL});
    public static readonly BitSet FOLLOW_scmBtnProp_in_scmBtn479 = new BitSet(new ulong[]{0x001FFA0007800000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtn483 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtn485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmFrmProp503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmFrmProp514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmWidthProp_in_scmFrmProp525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHeightProp_in_scmFrmProp536 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmFrmProp547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBorderProp_in_scmFrmProp558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmSpacingProp_in_scmFrmProp569 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmFrmProp580 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmFrmProp591 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmFrmProp602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmFrmProp613 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmAlignmentProp_in_scmFrmProp620 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmFrmStyleProp_in_scmFrmProp632 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmXYProp_in_scmFrmProp643 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmFrmProp654 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmFrmProp665 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmParentProp_in_scmBtnProp683 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmLabelProp_in_scmBtnProp694 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmEnabledProp_in_scmBtnProp705 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinWidthProp_in_scmBtnProp716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmMinHeightProp_in_scmBtnProp727 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchWidthProp_in_scmBtnProp738 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmStretchHeightProp_in_scmBtnProp749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmVertMargin_in_scmBtnProp760 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmHorizMargin_in_scmBtnProp771 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scmBtnStyleProp_in_scmBtnProp778 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_scmBtnProp788 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpr_in_scmBtnProp799 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmParentProp814 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_PARENT_in_scmParentProp816 = new BitSet(new ulong[]{0x0000020002000000UL});
    public static readonly BitSet FOLLOW_set_in_scmParentProp821 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmParentProp829 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmLabelProp845 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LABEL_in_scmLabelProp847 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_NAME_in_scmLabelProp853 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmLabelProp855 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmWidthProp871 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_WIDTH_in_scmWidthProp873 = new BitSet(new ulong[]{0x0000080002000000UL});
    public static readonly BitSet FOLLOW_set_in_scmWidthProp878 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmWidthProp884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHeightProp899 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_HEIGHT_in_scmHeightProp901 = new BitSet(new ulong[]{0x0000080002000000UL});
    public static readonly BitSet FOLLOW_set_in_scmHeightProp907 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHeightProp913 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmXYProp929 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_ID_in_scmXYProp935 = new BitSet(new ulong[]{0x0000080002000000UL});
    public static readonly BitSet FOLLOW_set_in_scmXYProp941 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmXYProp947 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmEnabledProp963 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_ENABLED_in_scmEnabledProp965 = new BitSet(new ulong[]{0x0000000006000000UL});
    public static readonly BitSet FOLLOW_set_in_scmEnabledProp971 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmEnabledProp977 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBorderProp993 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_BORDER_in_scmBorderProp995 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmBorderProp1001 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBorderProp1003 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmSpacingProp1018 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_SPACING_in_scmSpacingProp1020 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmSpacingProp1026 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmSpacingProp1028 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMinWidthProp1043 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_MIN_WIDTH_in_scmMinWidthProp1045 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmMinWidthProp1051 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMinWidthProp1053 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmMinHeightProp1068 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_MIN_HEIGHT_in_scmMinHeightProp1070 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmMinHeightProp1076 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmMinHeightProp1078 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStretchWidthProp1093 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_STRETCH_WIDTH_in_scmStretchWidthProp1095 = new BitSet(new ulong[]{0x0000000006000000UL});
    public static readonly BitSet FOLLOW_set_in_scmStretchWidthProp1101 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStretchWidthProp1107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmStretchHeightProp1122 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_STRETCH_HEIGHT_in_scmStretchHeightProp1124 = new BitSet(new ulong[]{0x0000000006000000UL});
    public static readonly BitSet FOLLOW_set_in_scmStretchHeightProp1130 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmStretchHeightProp1136 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmAlignmentProp1150 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ALIGNMENT_in_scmAlignmentProp1152 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmAlignmentProp1154 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LP_in_scmAlignmentProp1156 = new BitSet(new ulong[]{0x00000000D0000000UL});
    public static readonly BitSet FOLLOW_scmHorizAlign_in_scmAlignmentProp1158 = new BitSet(new ulong[]{0x0000000038000000UL});
    public static readonly BitSet FOLLOW_scmVerticalAlign_in_scmAlignmentProp1161 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmAlignmentProp1164 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmAlignmentProp1166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1185 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmFrmStyleProp1187 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmFrmStyleProp1189 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LP_in_scmFrmStyleProp1191 = new BitSet(new ulong[]{0x0000007E01000000UL});
    public static readonly BitSet FOLLOW_scmFrmStyleList_in_scmFrmStyleProp1193 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1196 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmFrmStyleProp1198 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1208 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_STYLE_in_scmBtnStyleProp1210 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_QUOTE_in_scmBtnStyleProp1212 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LP_in_scmBtnStyleProp1214 = new BitSet(new ulong[]{0x0000010001004000UL});
    public static readonly BitSet FOLLOW_scmBtnStyleList_in_scmBtnStyleProp1216 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1218 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmBtnStyleProp1220 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmVertMargin1233 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_VERT_MARGIN_in_scmVertMargin1235 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmVertMargin1241 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmVertMargin1243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LP_in_scmHorizMargin1259 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_HORIZ_MARGIN_in_scmHorizMargin1261 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_scmHorizMargin1267 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_RP_in_scmHorizMargin1269 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TOP_in_scmVerticalAlign1282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CENTER_in_scmVerticalAlign1289 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOTTOM_in_scmVerticalAlign1296 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFT_in_scmHorizAlign1309 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CENTER_in_scmHorizAlign1316 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RIGHT_in_scmHorizAlign1323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NO_RESIZE_BORDER_in_scmFrmStyleList1337 = new BitSet(new ulong[]{0x0000007E00000002UL});
    public static readonly BitSet FOLLOW_NO_CAPTION_in_scmFrmStyleList1344 = new BitSet(new ulong[]{0x0000007E00000002UL});
    public static readonly BitSet FOLLOW_NO_SYSTEM_MENU_in_scmFrmStyleList1351 = new BitSet(new ulong[]{0x0000007E00000002UL});
    public static readonly BitSet FOLLOW_MDI_PARENT_in_scmFrmStyleList1358 = new BitSet(new ulong[]{0x0000007E00000002UL});
    public static readonly BitSet FOLLOW_MDI_CHILD_in_scmFrmStyleList1365 = new BitSet(new ulong[]{0x0000007E00000002UL});
    public static readonly BitSet FOLLOW_FLOAT_in_scmFrmStyleList1372 = new BitSet(new ulong[]{0x0000007E00000002UL});
    public static readonly BitSet FOLLOW_set_in_scmBtnStyleList1385 = new BitSet(new ulong[]{0x0000010000004002UL});
    public static readonly BitSet FOLLOW_LP_in_parExpr1409 = new BitSet(new ulong[]{0x000FFA0006800000UL});
    public static readonly BitSet FOLLOW_parExpr_in_parExpr1416 = new BitSet(new ulong[]{0x000FFA0007800000UL});
    public static readonly BitSet FOLLOW_RP_in_parExpr1422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operand_in_parExpr1434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_opartors_in_parExpr1445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_operand1466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_operand1477 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_in_operand1488 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_in_operand1499 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_opartors1518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_opartors1529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STAR_in_opartors1540 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SLASH_in_opartors1551 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_opartors1562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GT_in_opartors1573 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EQ_in_opartors1584 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QUOTE_in_opartors1595 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMENT_in_comment1614 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}