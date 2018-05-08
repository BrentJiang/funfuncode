
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace EntityModelCreator.models
{
    public class FfsEnumItem
    {
        public string Name { get; set; }
        public char Value { get; set; }
    };
    
    
    public enum FfsProductClassEnum 
    {
		  PCFutures,
      PCOptions,
      PCStock,
      PCBond,
      PCFund,
      PCIndex,
      PCWarrant,
      PCRepo,
      PCOther,
      
    };
       
    public enum FfsInvestorRangeEnum 
    {
		  IRAll,
      IRGroup,
      IRSingle,
      IRAllInvestUnit,
      IRSingleInvestUnit,
      
    };
       
    public enum FfsProviderTypeEnum 
    {
		  PTCtpFutureTd,
      PTCtpFutureMd,
      PTCtpFutureQry,
      PTSTPOptionTd,
      PTSTPOptionQry,
      PTSTPStockTd,
      PTSTPStockQry,
      PTFemasFutureTd,
      PTFemasFutureMd,
      PTFemasFutureQry,
      
    };
       
    public enum FfsDirectionEnum 
    {
		  DBuy,
      DSell,
      DETFPur,
      DETFRed,
      DCashIn,
      DPledgeBondIn,
      DPledgeBondOut,
      DDoublened,
      DDepositoryTransfer,
      DCreditDoublened,
      DBuyCollateral,
      DSellCollateral,
      DCollateralTransferIn,
      DCollateralTransferOut,
      DMarginTrade,
      DShortSell,
      DRepayMargin,
      DRepayStock,
      DDirectRepayMargin,
      DDirectRepayStock,
      DExcessStockTransfer,
      DOFPur,
      DOFRed,
      DSFSplit,
      DSFMerge,
      DCovered,
      DFreeze,
      DExecute,
      DCBRed,
      DCBConv,
      DOFSub,
      
    };
       
    public enum FfsQryAccountTypeEnum 
    {
		  QATOperate,
      QATQuery,
      
    };
       
    public enum FfsHedgeFlagEnum 
    {
		  HFSpeculation,
      HFArbitrage,
      HFHedge,
      HFMarketMaker,
      
    };
       
    public enum FfsUserTypeEnum 
    {
		  UTInvestor,
      UTOperator,
      UTSuperUser,
      
    };
       
    public enum FfsCoveredFlagEnum 
    {
		  CFUncovered,
      CFCovered,
      
    };
       
    public enum FfsOwnerTypeEnum 
    {
		  OT0,
      OT1,
      OT2,
      OT3,
      OT4,
      OT5,
      
    };
       
    public enum FfsInvestorLevelEnum 
    {
		  IL1,
      IL2,
      IL3,
      IL9,
      
    };
       
    public enum FfsOffsetFlagEnum 
    {
		  OFOpen,
      OFClose,
      OFForceClose,
      OFCloseToday,
      OFCloseYesterday,
      OFForceOff,
      OFLocalForceClose,
      OFAuto,
      OFCall,
      OFPut,
      
    };
       
    public enum FfsOrderPriceTypeEnum 
    {
		  OPTAnyPrice,
      OPTLimitPrice,
      OPTBestPrice,
      OPTLastPrice,
      OPTLocalBestPrice,
      OPTFiveLevelPrice,
      OPTPurchasesETF,
      OPTRedeemETF,
      
    };
       
    public enum FfsTimeConditionEnum 
    {
		  TCIOC,
      TCGFS,
      TCGFD,
      TCGTD,
      TCGTC,
      TCGFA,
      
    };
       
    public enum FfsVolumeConditionEnum 
    {
		  VCAV,
      VCMV,
      VCCV,
      
    };
       
    public enum FfsContingentConditionEnum 
    {
		  CCImmediately,
      CCTouch,
      CCTouchProfit,
      CCParkedOrder,
      
    };
       
    public enum FfsOrderStatusEnum 
    {
		  OSTUnknown,
      OSTPendingNew,
      OSTNew,
      OSTPartilyFilled,
      OSTFilled,
      OSTPartilyCanceled,
      OSTCanceled,
      OSTRejected,
      
    };
       
    public enum FfsOrderTypeEnum 
    {
		  ORDTNormal,
      ORDTDeriveFromQuote,
      ORDTDeriveFromCombination,
      ORDTCombination,
      ORDTConditionalOrder,
      ORDTSwap,
      
    };
       
    public enum FfsPosiDirectionEnum 
    {
		  PDShort,
      PDLong,
      
    };
       
    public enum FfsChangeTypeEnum 
    {
		  CGTcheck,
      CGTfronzen,
      CGTcurrent,
      CGTcost,
      
    };
       
    public enum FfsCapitalDirectionEnum 
    {
		  CPDNochange,
      CPDIncrease,
      CPDDecrease,
      
    };
       
    public enum FfsPositionDirectionEnum 
    {
		  PSDNochange,
      PSDIncrease,
      PSDDecrease,
      
    };
       
    public enum FfsPositionDateEnum 
    {
		  PSDToday,
      PSDHistory,
      
    };
       
    public enum FfsTradingPhaseEnum 
    {
		  TPNonTrade,
      TPBidding,
      TPContinuous,
      TPSuspension,
      TPFuse,
      
    };
       
    public enum FfsOpenRestrictionEnum 
    {
		  ORNone,
      ORNoCoverOpen,
      ORNoSellOpen,
      ORNoSellAndCoverOpen,
      ORNoBuyOpen,
      ORNoBuyAndCoverOpen,
      ORNoBuyAndSellOpen,
      ORNoBuySellAndCoverOpen,
      
    };
       
    public enum FfsPositionTypeEnum 
    {
		  PTNet,
      PTGross,
      
    };
       
    public enum FfsPositionDateTypeEnum 
    {
		  UseHistory,
      NoUseHistory,
      
    };
       
    public enum FfsInvestorTypeEnum 
    {
		  ITPerson,
      ITCompany,
      ITFund,
      ITSpecialOrgan,
      ITAsset,
      ITAdmin,
      
    };
       
    public enum FfsIDCardTypeEnum 
    {
		  DCTEID,
      DCTIDCard,
      DCTOfficerIDCard,
      DCTPoliceIDCard,
      DCTSoldierIDCard,
      DCTHouseholdRegister,
      DCTPassport,
      DCTTaiwanCompatriotIDCard,
      DCTHomeComingCard,
      DCTLicenseNo,
      DCTTaxNo,
      DCTHMMainlandTravelPermit,
      DCTTwMainlandTravelPermit,
      DCTDrivingLicense,
      DCTSocialID,
      DCTLocalID,
      DCTBusinessRegistration,
      DCTHKMCIDCard,
      DCTAccountsPermits,
      DCTPermanantResidence,
      DCTAssetProductRecord,
      DCTOtherCard,
      
    };
       
    public enum FfsTradingCodeTypeEnum 
    {
		  TCSpeculation,
      TCArbitrage,
      TCHedge,
      TCMarketMaker,
      
    };
       
    public enum FfsOptCommissionTypeEnum 
    {
		  OPT_CTStrikeFee,
      OPT_CTBeStrikeDFee,
      OPT_CTTransferFee,
      OPT_CTBrokerage,
      OPT_CTTradeFee,
      OPT_CTSettleFee,
      
    };
       
    public enum FfsCommDirectionEnum 
    {
		  CDBuyOpen,
      CDBuyClose,
      CDSellOpen,
      CDSellClose,
      CDCallStrike,
      CDPutStrike,
      
    };
       
    public enum FfsRateTypeEnum 
    {
		  RTByVolume,
      RTByMoney,
      RTByFace,
      
    };
       
    public enum FfsOperationTypeEnum 
    {
		  OPNTSync,
      OPNTAdmin,
      OPNTSettle,
      OPNTOther,
      
    };
       
    public enum FfsOptionTypeEnum 
    {
		  OPT_TYCall,
      OPT_TYPut,
      
    };
       
    public enum FfsSystemStatusEnum 
    {
		  STSSyncDone,
      STSTrading,
      STSClosed,
      STSSettled,
      
    };
       
    public enum FfsInstrumentRangeEnum 
    {
		  INSTRALL,
      INSTRPRODUCT_CLASS,
      INSTRSINGLE,
      
    };
       
    public enum FfsSeatTypeEnum 
    {
		  STSHOPT,
      STSHSTK,
      STSZOPT,
      STSZSTK,
      STFEMAS,
      
    };
       
    public enum FfsResumeTypeEnum 
    {
		  RTRestart,
      RTResume,
      RTQuick,
      
    };
       
    public enum FfsCompanyTypeEnum 
    {
		  CTINSIDE,
      CTORGAN,
      CTUSER,
      
    };
       
    public enum FfsEnbFlagEnum 
    {
		  EFNORMAL,
      EFOFF,
      EFLOCK,
      EFUNSYNC,
      
    };
       
    public enum FfsActionTypeEnum 
    {
		  ACTCLIENT,
      ACTWEB,
      ACTMARKET,
      
    };
       
    public enum FfsAuthTypeEnum 
    {
		  AUTGENERAL,
      AUTINSIDE,
      AUTOUTSIDE,
      
    };
       
    public enum FfsFileFlagEnum 
    {
		  InProgress,
      Success,
      Fail,
      
    };
       
    public enum FfsMarketDataTypeEnum 
    {
		  MDTREAL,
      MDTHIS,
      
    };
       
    public enum FfsPaySubjectEnum 
    {
		  PSJGENERAL,
      
    };
       
    public enum FfsAccountTypeEnum 
    {
		  ATSTOCK,
      ATCREDIT,
      ATDERIVATIVE,
      ATFUTURES,
      
    };
       
    public enum FfsChannelTypeEnum 
    {
		  CHTUFT,
      CHTCTP,
      CHTFEMAS,
      CHTO32,
      CHTSIMULATE,
      
    };
       
    public enum FfsFeeTypeEnum 
    {
		  FTTRADEFEE,
      FTSTAMPTAX,
      FTTRANSFERFEE,
      FTBROKERFEE,
      FTHANDLINGFEE,
      FTADMINFEE,
      FTOTHERFEE,
      FTCLEARINGFEE,
      FTSETTLEFEE,
      FTPERORDER,
      FTPERCANCEL,
      
    };
       
    public enum FfsCalculateTypeEnum 
    {
		  CTTOTAL,
      CTPER,
      
    };
       
    public enum FfsCancelFlagEnum 
    {
		  CFORDER,
      CFCANCEL,
      
    };
       
    public enum FfsStockRealBackEnum 
    {
		  SRBFALSE,
      SRBTRUE,
      
    };
       
    public enum FfsFundRealBackEnum 
    {
		  FRBFALSE,
      FRBTRUE,
      
    };
       
    public enum FfsInstrumentControlLevelEnum 
    {
		  INSTC_LEVELPRODUCT_CLASS,
      INSTC_LEVELSINGLE,
      
    };
       
    public enum FfsInstrumentRangeTypeEnum 
    {
		  INSTC_RANGEALL,
      INSTC_RANGESET,
      
    };
       
    public enum FfsAccountControlLevelEnum 
    {
		  AR_LEVELCOMPANY,
      AR_LEVELACCOUNT,
      AR_LEVELCOMBO,
      
    };
       
    public enum FfsAccountRangeTypeEnum 
    {
		  AR_RANGEALL,
      AR_RANGESET,
      
    };
       

    public static partial class CommonDef
    {
    
        public const char STP_PC_Futures = '1'; 
        public const string STP_PC_Futures_Label = "�ڻ�"; 
        public const char STP_PC_Options = '2'; 
        public const string STP_PC_Options_Label = "��Ȩ"; 
        public const char STP_PC_Stock = '3'; 
        public const string STP_PC_Stock_Label = "��Ʊ"; 
        public const char STP_PC_Bond = '4'; 
        public const string STP_PC_Bond_Label = "ծȯ"; 
        public const char STP_PC_Fund = '5'; 
        public const string STP_PC_Fund_Label = "����"; 
        public const char STP_PC_Index = '6'; 
        public const string STP_PC_Index_Label = "ָ��"; 
        public const char STP_PC_Warrant = '7'; 
        public const string STP_PC_Warrant_Label = "Ȩ֤"; 
        public const char STP_PC_Repo = '8'; 
        public const string STP_PC_Repo_Label = "�ع�"; 
        public const char STP_PC_Other = '9'; 
        public const string STP_PC_Other_Label = "����";  
        public const char STP_IR_All = '1'; 
        public const string STP_IR_All_Label = "����"; 
        public const char STP_IR_Group = '2'; 
        public const string STP_IR_Group_Label = "Ͷ������"; 
        public const char STP_IR_Single = '3'; 
        public const string STP_IR_Single_Label = "��һͶ����"; 
        public const char STP_IR_AllInvestUnit = '4'; 
        public const string STP_IR_AllInvestUnit_Label = "����Ͷ�ʵ�Ԫ"; 
        public const char STP_IR_SingleInvestUnit = '5'; 
        public const string STP_IR_SingleInvestUnit_Label = "��һͶ�ʵ�Ԫ";  
        public const char STP_PT_CtpFutureTd = '0'; 
        public const string STP_PT_CtpFutureTd_Label = "ctp�ڻ�����"; 
        public const char STP_PT_CtpFutureMd = '1'; 
        public const string STP_PT_CtpFutureMd_Label = "ctp�ڻ�����"; 
        public const char STP_PT_CtpFutureQry = '2'; 
        public const string STP_PT_CtpFutureQry_Label = "ctp�ڻ���ѯ"; 
        public const char STP_PT_STPOptionTd = '3'; 
        public const string STP_PT_STPOptionTd_Label = "Stp����Ȩ����"; 
        public const char STP_PT_STPOptionQry = '4'; 
        public const string STP_PT_STPOptionQry_Label = "Stp����Ȩ��ѯ"; 
        public const char STP_PT_STPStockTd = '5'; 
        public const string STP_PT_STPStockTd_Label = "Stp�Ĺ�Ʊ����"; 
        public const char STP_PT_STPStockQry = '6'; 
        public const string STP_PT_STPStockQry_Label = "Stp�Ĺ�Ʊ��ѯ"; 
        public const char STP_PT_FemasFutureTd = '7'; 
        public const string STP_PT_FemasFutureTd_Label = "Femas�ڻ�����"; 
        public const char STP_PT_FemasFutureMd = '8'; 
        public const string STP_PT_FemasFutureMd_Label = "Femas�ڻ�����"; 
        public const char STP_PT_FemasFutureQry = '9'; 
        public const string STP_PT_FemasFutureQry_Label = "Femas�ڻ���ѯ";  
        public const char STP_D_Buy = '0'; 
        public const string STP_D_Buy_Label = "��"; 
        public const char STP_D_Sell = '1'; 
        public const string STP_D_Sell_Label = "��"; 
        public const char STP_D_ETFPur = '2'; 
        public const string STP_D_ETFPur_Label = "ETF�깺"; 
        public const char STP_D_ETFRed = '3'; 
        public const string STP_D_ETFRed_Label = "ETF���"; 
        public const char STP_D_CashIn = '4'; 
        public const string STP_D_CashIn_Label = "�ֽ������ֻ�����ر�"; 
        public const char STP_D_PledgeBondIn = '5'; 
        public const string STP_D_PledgeBondIn_Label = "ծȯ���"; 
        public const char STP_D_PledgeBondOut = '6'; 
        public const string STP_D_PledgeBondOut_Label = "ծȯ����"; 
        public const char STP_D_Doublened = '7'; 
        public const string STP_D_Doublened_Label = "���"; 
        public const char STP_D_DepositoryTransfer = '8'; 
        public const string STP_D_DepositoryTransfer_Label = "ת�й�"; 
        public const char STP_D_CreditDoublened = '9'; 
        public const string STP_D_CreditDoublened_Label = "�����˻����"; 
        public const char STP_D_BuyCollateral = 'A'; 
        public const string STP_D_BuyCollateral_Label = "����Ʒ����"; 
        public const char STP_D_SellCollateral = 'B'; 
        public const string STP_D_SellCollateral_Label = "����Ʒ����"; 
        public const char STP_D_CollateralTransferIn = 'C'; 
        public const string STP_D_CollateralTransferIn_Label = "����Ʒת��"; 
        public const char STP_D_CollateralTransferOut = 'D'; 
        public const string STP_D_CollateralTransferOut_Label = "����Ʒת��"; 
        public const char STP_D_MarginTrade = 'E'; 
        public const string STP_D_MarginTrade_Label = "��������"; 
        public const char STP_D_ShortSell = 'F'; 
        public const string STP_D_ShortSell_Label = "��ȯ����"; 
        public const char STP_D_RepayMargin = 'G'; 
        public const string STP_D_RepayMargin_Label = "��ȯ����"; 
        public const char STP_D_RepayStock = 'H'; 
        public const string STP_D_RepayStock_Label = "��ȯ��ȯ"; 
        public const char STP_D_DirectRepayMargin = 'I'; 
        public const string STP_D_DirectRepayMargin_Label = "ֱ�ӻ���"; 
        public const char STP_D_DirectRepayStock = 'J'; 
        public const string STP_D_DirectRepayStock_Label = "ֱ�ӻ�ȯ"; 
        public const char STP_D_ExcessStockTransfer = 'K'; 
        public const string STP_D_ExcessStockTransfer_Label = "��ȯ��ת"; 
        public const char STP_D_OFPur = 'L'; 
        public const string STP_D_OFPur_Label = "OF�깺"; 
        public const char STP_D_OFRed = 'M'; 
        public const string STP_D_OFRed_Label = "OF���"; 
        public const char STP_D_SFSplit = 'N'; 
        public const string STP_D_SFSplit_Label = "SF���"; 
        public const char STP_D_SFMerge = 'O'; 
        public const string STP_D_SFMerge_Label = "SF�ϲ�"; 
        public const char STP_D_Covered = 'P'; 
        public const string STP_D_Covered_Label = "����"; 
        public const char STP_D_Freeze = 'Q'; 
        public const string STP_D_Freeze_Label = "֤ȯ����(��)/�ⶳ(ƽ)"; 
        public const char STP_D_Execute = 'R'; 
        public const string STP_D_Execute_Label = "��Ȩ"; 
        public const char STP_D_CBRed = 'S'; 
        public const string STP_D_CBRed_Label = "CB����"; 
        public const char STP_D_CBConv = 'T'; 
        public const string STP_D_CBConv_Label = "CBת��"; 
        public const char STP_D_OFSub = 'U'; 
        public const string STP_D_OFSub_Label = "OF�Ϲ�";  
        public const char STP_QAT_Operate = '0'; 
        public const string STP_QAT_Operate_Label = "����"; 
        public const char STP_QAT_Query = '1'; 
        public const string STP_QAT_Query_Label = "��ѯ";  
        public const char STP_HF_Speculation = '1'; 
        public const string STP_HF_Speculation_Label = "Ͷ��"; 
        public const char STP_HF_Arbitrage = '2'; 
        public const string STP_HF_Arbitrage_Label = "����"; 
        public const char STP_HF_Hedge = '3'; 
        public const string STP_HF_Hedge_Label = "�ױ�"; 
        public const char STP_HF_MarketMaker = '4'; 
        public const string STP_HF_MarketMaker_Label = "������";  
        public const char STP_UT_Investor = '0'; 
        public const string STP_UT_Investor_Label = "Ͷ����"; 
        public const char STP_UT_Operator = '1'; 
        public const string STP_UT_Operator_Label = "����Ա"; 
        public const char STP_UT_SuperUser = '2'; 
        public const string STP_UT_SuperUser_Label = "����Ա";  
        public const char STP_CF_Uncovered = '0'; 
        public const string STP_CF_Uncovered_Label = "�Ǳ���"; 
        public const char STP_CF_Covered = '1'; 
        public const string STP_CF_Covered_Label = "����";  
        public const char STP_OT_0 = '0'; 
        public const string STP_OT_0_Label = "����Ͷ����"; 
        public const char STP_OT_1 = '1'; 
        public const string STP_OT_1_Label = "����������"; 
        public const char STP_OT_2 = '2'; 
        public const string STP_OT_2_Label = "��Ȩ��Ӫ����"; 
        public const char STP_OT_3 = '3'; 
        public const string STP_OT_3_Label = "����Ͷ���߷���"; 
        public const char STP_OT_4 = '4'; 
        public const string STP_OT_4_Label = "��Ӫ���׷���"; 
        public const char STP_OT_5 = '5'; 
        public const string STP_OT_5_Label = "�����Է����ṩ�̷���";  
        public const char STP_IL_1 = '0'; 
        public const string STP_IL_1_Label = "һ��"; 
        public const char STP_IL_2 = '1'; 
        public const string STP_IL_2_Label = "����"; 
        public const char STP_IL_3 = '2'; 
        public const string STP_IL_3_Label = "����"; 
        public const char STP_IL_9 = '9'; 
        public const string STP_IL_9_Label = "�ǽ��׼��𣬴˼���investor���ɽ���";  
        public const char STP_OF_Open = '0'; 
        public const string STP_OF_Open_Label = "����"; 
        public const char STP_OF_Close = '1'; 
        public const string STP_OF_Close_Label = "ƽ��"; 
        public const char STP_OF_ForceClose = '2'; 
        public const string STP_OF_ForceClose_Label = "ǿƽ"; 
        public const char STP_OF_CloseToday = '3'; 
        public const string STP_OF_CloseToday_Label = "ƽ��"; 
        public const char STP_OF_CloseYesterday = '4'; 
        public const string STP_OF_CloseYesterday_Label = "ƽ��"; 
        public const char STP_OF_ForceOff = '5'; 
        public const string STP_OF_ForceOff_Label = "ǿ��"; 
        public const char STP_OF_LocalForceClose = '6'; 
        public const string STP_OF_LocalForceClose_Label = "����ǿƽ"; 
        public const char STP_OF_Auto = '7'; 
        public const string STP_OF_Auto_Label = "�Զ�����ƽ��ƽ���ж�(�ݲ�֧�֣�"; 
        public const char STP_OF_Call = '8'; 
        public const string STP_OF_Call_Label = "�Ϲ�"; 
        public const char STP_OF_Put = '9'; 
        public const string STP_OF_Put_Label = "�Ϲ�";  
        public const char STP_OPT_AnyPrice = '1'; 
        public const string STP_OPT_AnyPrice_Label = "�����"; 
        public const char STP_OPT_LimitPrice = '2'; 
        public const string STP_OPT_LimitPrice_Label = "�޼�"; 
        public const char STP_OPT_BestPrice = '3'; 
        public const string STP_OPT_BestPrice_Label = "���ż�"; 
        public const char STP_OPT_LastPrice = '4'; 
        public const string STP_OPT_LastPrice_Label = "���¼�"; 
        public const char STP_OPT_LocalBestPrice = '5'; 
        public const string STP_OPT_LocalBestPrice_Label = "�������¼�"; 
        public const char STP_OPT_FiveLevelPrice = '6'; 
        public const string STP_OPT_FiveLevelPrice_Label = "�嵵���ż�"; 
        public const char STP_OPT_PurchasesETF = 'd'; 
        public const string STP_OPT_PurchasesETF_Label = "ETF�깺"; 
        public const char STP_OPT_RedeemETF = 'e'; 
        public const string STP_OPT_RedeemETF_Label = "ETF���";  
        public const char STP_TC_IOC = '1'; 
        public const string STP_TC_IOC_Label = "������ɣ�������"; 
        public const char STP_TC_GFS = '2'; 
        public const string STP_TC_GFS_Label = "������Ч"; 
        public const char STP_TC_GFD = '3'; 
        public const string STP_TC_GFD_Label = "������Ч"; 
        public const char STP_TC_GTD = '4'; 
        public const string STP_TC_GTD_Label = "ָ������ǰ��Ч"; 
        public const char STP_TC_GTC = '5'; 
        public const string STP_TC_GTC_Label = "����ǰ��Ч"; 
        public const char STP_TC_GFA = '6'; 
        public const string STP_TC_GFA_Label = "���Ͼ�����Ч";  
        public const char STP_VC_AV = '1'; 
        public const string STP_VC_AV_Label = "�κ�����"; 
        public const char STP_VC_MV = '2'; 
        public const string STP_VC_MV_Label = "��С����"; 
        public const char STP_VC_CV = '3'; 
        public const string STP_VC_CV_Label = "ȫ������";  
        public const char STP_CC_Immediately = '1'; 
        public const string STP_CC_Immediately_Label = "����"; 
        public const char STP_CC_Touch = '2'; 
        public const string STP_CC_Touch_Label = "ֹ��"; 
        public const char STP_CC_TouchProfit = '3'; 
        public const string STP_CC_TouchProfit_Label = "ֹӮ"; 
        public const char STP_CC_ParkedOrder = '4'; 
        public const string STP_CC_ParkedOrder_Label = "Ԥ��";  
        public const char STP_OST_Unknown = '0'; 
        public const string STP_OST_Unknown_Label = "����"; 
        public const char STP_OST_PendingNew = '1'; 
        public const string STP_OST_PendingNew_Label = "����"; 
        public const char STP_OST_New = '2'; 
        public const string STP_OST_New_Label = "�ѱ�"; 
        public const char STP_OST_PartilyFilled = '3'; 
        public const string STP_OST_PartilyFilled_Label = "����"; 
        public const char STP_OST_Filled = '4'; 
        public const string STP_OST_Filled_Label = "�ѳ�"; 
        public const char STP_OST_PartilyCanceled = '5'; 
        public const string STP_OST_PartilyCanceled_Label = "����"; 
        public const char STP_OST_Canceled = '6'; 
        public const string STP_OST_Canceled_Label = "�ѳ�"; 
        public const char STP_OST_Rejected = '7'; 
        public const string STP_OST_Rejected_Label = "�ϵ�";  
        public const char STP_ORDT_Normal = '0'; 
        public const string STP_ORDT_Normal_Label = "����"; 
        public const char STP_ORDT_DeriveFromQuote = '1'; 
        public const string STP_ORDT_DeriveFromQuote_Label = "��������"; 
        public const char STP_ORDT_DeriveFromCombination = '2'; 
        public const string STP_ORDT_DeriveFromCombination_Label = "�������"; 
        public const char STP_ORDT_Combination = '3'; 
        public const string STP_ORDT_Combination_Label = "��ϱ���"; 
        public const char STP_ORDT_ConditionalOrder = '4'; 
        public const string STP_ORDT_ConditionalOrder_Label = "������"; 
        public const char STP_ORDT_Swap = '5'; 
        public const string STP_ORDT_Swap_Label = "������";  
        public const char STP_PD_Short = '1'; 
        public const string STP_PD_Short_Label = "��ͷ"; 
        public const char STP_PD_Long = '0'; 
        public const string STP_PD_Long_Label = "��ͷ";  
        public const char STP_CGT_check = '1'; 
        public const string STP_CGT_check_Label = "�˶�ֵ"; 
        public const char STP_CGT_fronzen = '2'; 
        public const string STP_CGT_fronzen_Label = "���Ṧ��"; 
        public const char STP_CGT_current = '3'; 
        public const string STP_CGT_current_Label = "��ǰֵ"; 
        public const char STP_CGT_cost = '4'; 
        public const string STP_CGT_cost_Label = "�ֲֳɱ�";  
        public const char STP_CPD_Nochange = '0'; 
        public const string STP_CPD_Nochange_Label = "����"; 
        public const char STP_CPD_Increase = '1'; 
        public const string STP_CPD_Increase_Label = "����"; 
        public const char STP_CPD_Decrease = '2'; 
        public const string STP_CPD_Decrease_Label = "����";  
        public const char STP_PSD_Nochange = '0'; 
        public const string STP_PSD_Nochange_Label = "����"; 
        public const char STP_PSD_Increase = '1'; 
        public const string STP_PSD_Increase_Label = "����"; 
        public const char STP_PSD_Decrease = '2'; 
        public const string STP_PSD_Decrease_Label = "����";  
        public const char STP_PSD_Today = '1'; 
        public const string STP_PSD_Today_Label = "���ճֲ�"; 
        public const char STP_PSD_History = '2'; 
        public const string STP_PSD_History_Label = "��ʷ�ֲ�";  
        public const char STP_TP_NonTrade = '0'; 
        public const string STP_TP_NonTrade_Label = "�ǽ���ʱ��"; 
        public const char STP_TP_Bidding = '1'; 
        public const string STP_TP_Bidding_Label = "���Ͼ���ʱ��"; 
        public const char STP_TP_Continuous = '2'; 
        public const string STP_TP_Continuous_Label = "��������ʱ��"; 
        public const char STP_TP_Suspension = '3'; 
        public const string STP_TP_Suspension_Label = "ͣ��ʱ��"; 
        public const char STP_TP_Fuse = '4'; 
        public const string STP_TP_Fuse_Label = "�۶�ʱ��";  
        public const char STP_OR_None = '0'; 
        public const string STP_OR_None_Label = "�޿�������"; 
        public const char STP_OR_NoCoverOpen = '1'; 
        public const string STP_OR_NoCoverOpen_Label = "���Ʊ��ҿ���"; 
        public const char STP_OR_NoSellOpen = '2'; 
        public const string STP_OR_NoSellOpen_Label = "������������"; 
        public const char STP_OR_NoSellAndCoverOpen = '3'; 
        public const string STP_OR_NoSellAndCoverOpen_Label = "�����������֡����ҿ���"; 
        public const char STP_OR_NoBuyOpen = '4'; 
        public const string STP_OR_NoBuyOpen_Label = "�������뿪��"; 
        public const char STP_OR_NoBuyAndCoverOpen = '5'; 
        public const string STP_OR_NoBuyAndCoverOpen_Label = "�������뿪�֡����ҿ���"; 
        public const char STP_OR_NoBuyAndSellOpen = '6'; 
        public const string STP_OR_NoBuyAndSellOpen_Label = "�������뿪�֡���������"; 
        public const char STP_OR_NoBuySellAndCoverOpen = '7'; 
        public const string STP_OR_NoBuySellAndCoverOpen_Label = "�������뿪�֡��������֡����ҿ���";  
        public const char STP_PT_Net = '1'; 
        public const string STP_PT_Net_Label = "���ֲ�"; 
        public const char STP_PT_Gross = '2'; 
        public const string STP_PT_Gross_Label = "�ۺϳֲ�";  
        public const char STP__UseHistory = '1'; 
        public const string STP__UseHistory_Label = "ʹ����ʷ�ֲ�"; 
        public const char STP__NoUseHistory = '2'; 
        public const string STP__NoUseHistory_Label = "��ʹ����ʷ�ֲ�";  
        public const char STP_IT_Person = '1'; 
        public const string STP_IT_Person_Label = "��Ȼ��"; 
        public const char STP_IT_Company = '2'; 
        public const string STP_IT_Company_Label = "����"; 
        public const char STP_IT_Fund = '3'; 
        public const string STP_IT_Fund_Label = "Ͷ�ʻ���"; 
        public const char STP_IT_SpecialOrgan = '4'; 
        public const string STP_IT_SpecialOrgan_Label = "���ⷨ��"; 
        public const char STP_IT_Asset = '5'; 
        public const string STP_IT_Asset_Label = "�ʹܻ�"; 
        public const char STP_IT_Admin = 'a'; 
        public const string STP_IT_Admin_Label = "ϵͳ����Ա";  
        public const char STP_DCT_EID = '0'; 
        public const string STP_DCT_EID_Label = "��֯��������"; 
        public const char STP_DCT_IDCard = '1'; 
        public const string STP_DCT_IDCard_Label = "�й��������֤"; 
        public const char STP_DCT_OfficerIDCard = '2'; 
        public const string STP_DCT_OfficerIDCard_Label = "����֤"; 
        public const char STP_DCT_PoliceIDCard = '3'; 
        public const string STP_DCT_PoliceIDCard_Label = "����֤"; 
        public const char STP_DCT_SoldierIDCard = '4'; 
        public const string STP_DCT_SoldierIDCard_Label = "ʿ��֤"; 
        public const char STP_DCT_HouseholdRegister = '5'; 
        public const string STP_DCT_HouseholdRegister_Label = "���ڲ�"; 
        public const char STP_DCT_Passport = '6'; 
        public const string STP_DCT_Passport_Label = "����"; 
        public const char STP_DCT_TaiwanCompatriotIDCard = '7'; 
        public const string STP_DCT_TaiwanCompatriotIDCard_Label = "̨��֤"; 
        public const char STP_DCT_HomeComingCard = '8'; 
        public const string STP_DCT_HomeComingCard_Label = "����֤"; 
        public const char STP_DCT_LicenseNo = '9'; 
        public const string STP_DCT_LicenseNo_Label = "Ӫҵִ�պ�"; 
        public const char STP_DCT_TaxNo = 'A'; 
        public const string STP_DCT_TaxNo_Label = "˰��ǼǺ�/������˰ID"; 
        public const char STP_DCT_HMMainlandTravelPermit = 'B'; 
        public const string STP_DCT_HMMainlandTravelPermit_Label = "�۰ľ��������ڵ�ͨ��֤"; 
        public const char STP_DCT_TwMainlandTravelPermit = 'C'; 
        public const string STP_DCT_TwMainlandTravelPermit_Label = "̨�����������½ͨ��֤"; 
        public const char STP_DCT_DrivingLicense = 'D'; 
        public const string STP_DCT_DrivingLicense_Label = "����"; 
        public const char STP_DCT_SocialID = 'F'; 
        public const string STP_DCT_SocialID_Label = "�����籣ID"; 
        public const char STP_DCT_LocalID = 'G'; 
        public const string STP_DCT_LocalID_Label = "�������֤"; 
        public const char STP_DCT_BusinessRegistration = 'H'; 
        public const string STP_DCT_BusinessRegistration_Label = "��ҵ�Ǽ�֤"; 
        public const char STP_DCT_HKMCIDCard = 'I'; 
        public const string STP_DCT_HKMCIDCard_Label = "�۰������Ծ������֤"; 
        public const char STP_DCT_AccountsPermits = 'J'; 
        public const string STP_DCT_AccountsPermits_Label = "���п������֤"; 
        public const char STP_DCT_PermanantResidence = 'K'; 
        public const string STP_DCT_PermanantResidence_Label = "��������þ���֤"; 
        public const char STP_DCT_AssetProductRecord = 'L'; 
        public const string STP_DCT_AssetProductRecord_Label = "�ʹܲ�Ʒ������"; 
        public const char STP_DCT_OtherCard = 'x'; 
        public const string STP_DCT_OtherCard_Label = "����֤��";  
        public const char STP_TC_Speculation = '1'; 
        public const string STP_TC_Speculation_Label = "Ͷ��"; 
        public const char STP_TC_Arbitrage = '2'; 
        public const string STP_TC_Arbitrage_Label = "����"; 
        public const char STP_TC_Hedge = '3'; 
        public const string STP_TC_Hedge_Label = "�ױ�"; 
        public const char STP_TC_MarketMaker = '4'; 
        public const string STP_TC_MarketMaker_Label = "������";  
        public const char STP_OPT_CT_StrikeFee = '1'; 
        public const string STP_OPT_CT_StrikeFee_Label = "��Ȩ��"; 
        public const char STP_OPT_CT_BeStrikeDFee = '2'; 
        public const string STP_OPT_CT_BeStrikeDFee_Label = "����Ȩ��"; 
        public const char STP_OPT_CT_TransferFee = '3'; 
        public const string STP_OPT_CT_TransferFee_Label = "��Ȩ������"; 
        public const char STP_OPT_CT_Brokerage = '4'; 
        public const string STP_OPT_CT_Brokerage_Label = "���ַ�"; 
        public const char STP_OPT_CT_TradeFee = '5'; 
        public const string STP_OPT_CT_TradeFee_Label = "���׷�"; 
        public const char STP_OPT_CT_SettleFee = '6'; 
        public const string STP_OPT_CT_SettleFee_Label = "�����";  
        public const char STP_CD_BuyOpen = '1'; 
        public const string STP_CD_BuyOpen_Label = "��"; 
        public const char STP_CD_BuyClose = '2'; 
        public const string STP_CD_BuyClose_Label = "��ƽ"; 
        public const char STP_CD_SellOpen = '3'; 
        public const string STP_CD_SellOpen_Label = "����"; 
        public const char STP_CD_SellClose = '4'; 
        public const string STP_CD_SellClose_Label = "��ƽ"; 
        public const char STP_CD_CallStrike = '5'; 
        public const string STP_CD_CallStrike_Label = "��Ȩ�Ϲ�"; 
        public const char STP_CD_PutStrike = '6'; 
        public const string STP_CD_PutStrike_Label = "��Ȩ�Ϲ�";  
        public const char STP_RT_ByVolume = '1'; 
        public const string STP_RT_ByVolume_Label = "������"; 
        public const char STP_RT_ByMoney = '2'; 
        public const string STP_RT_ByMoney_Label = "�����"; 
        public const char STP_RT_ByFace = '3'; 
        public const string STP_RT_ByFace_Label = "����ֵ";  
        public const char STP_OPNT_Sync = '1'; 
        public const string STP_OPNT_Sync_Label = "�ճ�ͬ������"; 
        public const char STP_OPNT_Admin = '2'; 
        public const string STP_OPNT_Admin_Label = "����ָ�����"; 
        public const char STP_OPNT_Settle = '3'; 
        public const string STP_OPNT_Settle_Label = "�����ֲֵ�������"; 
        public const char STP_OPNT_Other = '0'; 
        public const string STP_OPNT_Other_Label = "��������";  
        public const char STP_OPT_TY_Call = 'C'; 
        public const string STP_OPT_TY_Call_Label = "�Ϲ�"; 
        public const char STP_OPT_TY_Put = 'P'; 
        public const string STP_OPT_TY_Put_Label = "�Ϲ�";  
        public const char STP_STS_SyncDone = '1'; 
        public const string STP_STS_SyncDone_Label = "�����������"; 
        public const char STP_STS_Trading = '2'; 
        public const string STP_STS_Trading_Label = "���н���״̬"; 
        public const char STP_STS_Closed = '3'; 
        public const string STP_STS_Closed_Label = "�������"; 
        public const char STP_STS_Settled = '4'; 
        public const string STP_STS_Settled_Label = "�������";  
        public const char STP_INSTR_ALL = '1'; 
        public const string STP_INSTR_ALL_Label = "����"; 
        public const char STP_INSTR_PRODUCT_CLASS = '2'; 
        public const string STP_INSTR_PRODUCT_CLASS_Label = "֤ȯ���"; 
        public const char STP_INSTR_SINGLE = '3'; 
        public const string STP_INSTR_SINGLE_Label = "��һ��Լ";  
        public const char STP_ST_SHOPT = '1'; 
        public const string STP_ST_SHOPT_Label = "�Ͻ�����Ȩ"; 
        public const char STP_ST_SHSTK = '2'; 
        public const string STP_ST_SHSTK_Label = "�Ͻ�����Ʊ"; 
        public const char STP_ST_SZOPT = '3'; 
        public const string STP_ST_SZOPT_Label = "�����Ȩ"; 
        public const char STP_ST_SZSTK = '4'; 
        public const string STP_ST_SZSTK_Label = "�����Ʊ"; 
        public const char STP_ST_FEMAS = '5'; 
        public const string STP_ST_FEMAS_Label = "����";  
        public const char STP_RT_Restart = '0'; 
        public const string STP_RT_Restart_Label = "�ش�"; 
        public const char STP_RT_Resume = '1'; 
        public const string STP_RT_Resume_Label = "����"; 
        public const char STP_RT_Quick = '2'; 
        public const string STP_RT_Quick_Label = "��ǰ��ʼ";  
        public const char STP_CT_INSIDE = '1'; 
        public const string STP_CT_INSIDE_Label = "�ڲ�����"; 
        public const char STP_CT_ORGAN = '2'; 
        public const string STP_CT_ORGAN_Label = "�����ͻ�"; 
        public const char STP_CT_USER = '3'; 
        public const string STP_CT_USER_Label = "���˿ͻ�";  
        public const char STP_EF_NORMAL = 'N'; 
        public const string STP_EF_NORMAL_Label = "����"; 
        public const char STP_EF_OFF = 'C'; 
        public const string STP_EF_OFF_Label = "���ر�"; 
        public const char STP_EF_LOCK = 'L'; 
        public const string STP_EF_LOCK_Label = "����"; 
        public const char STP_EF_UNSYNC = '1'; 
        public const string STP_EF_UNSYNC_Label = "����δͬ��";  
        public const char STP_ACT_CLIENT = '1'; 
        public const string STP_ACT_CLIENT_Label = "�ͻ���"; 
        public const char STP_ACT_WEB = '2'; 
        public const string STP_ACT_WEB_Label = "web��"; 
        public const char STP_ACT_MARKET = '3'; 
        public const string STP_ACT_MARKET_Label = "����ƽ̨";  
        public const char STP_AUT_GENERAL = '0'; 
        public const string STP_AUT_GENERAL_Label = "ͨ��"; 
        public const char STP_AUT_INSIDE = '1'; 
        public const string STP_AUT_INSIDE_Label = "ȯ���ڲ�"; 
        public const char STP_AUT_OUTSIDE = '2'; 
        public const string STP_AUT_OUTSIDE_Label = "�ⲿ�ͻ�";  
        public const char STP__InProgress = 'I'; 
        public const string STP__InProgress_Label = "������"; 
        public const char STP__Success = 'S'; 
        public const string STP__Success_Label = "���ɳɹ�"; 
        public const char STP__Fail = 'F'; 
        public const string STP__Fail_Label = "����ʧ��";  
        public const char STP_MDT_REAL = '0'; 
        public const string STP_MDT_REAL_Label = "ʵʱ����"; 
        public const char STP_MDT_HIS = '1'; 
        public const string STP_MDT_HIS_Label = "��ʷ����";  
        public const char STP_PSJ_GENERAL = '1'; 
        public const string STP_PSJ_GENERAL_Label = "ͨ�÷���";  
        public const char STP_AT_STOCK = '1'; 
        public const string STP_AT_STOCK_Label = "��֤ͨȯ�˻�"; 
        public const char STP_AT_CREDIT = '2'; 
        public const string STP_AT_CREDIT_Label = "�����˻�"; 
        public const char STP_AT_DERIVATIVE = '3'; 
        public const string STP_AT_DERIVATIVE_Label = "����Ʒ�˻�"; 
        public const char STP_AT_FUTURES = '4'; 
        public const string STP_AT_FUTURES_Label = "�ڻ��˻�";  
        public const char STP_CHT_UFT = '1'; 
        public const string STP_CHT_UFT_Label = "UFT�ֲ�"; 
        public const char STP_CHT_CTP = '2'; 
        public const string STP_CHT_CTP_Label = "CTP�ֲ�"; 
        public const char STP_CHT_FEMAS = '3'; 
        public const string STP_CHT_FEMAS_Label = "����ֲ�"; 
        public const char STP_CHT_O32 = '4'; 
        public const string STP_CHT_O32_Label = "O32�ֲ�"; 
        public const char STP_CHT_SIMULATE = '5'; 
        public const string STP_CHT_SIMULATE_Label = "ģ�⽻����";  
        public const char STP_FT_TRADEFEE = '1'; 
        public const string STP_FT_TRADEFEE_Label = "���׷�"; 
        public const char STP_FT_STAMPTAX = '2'; 
        public const string STP_FT_STAMPTAX_Label = "ӡ��˰"; 
        public const char STP_FT_TRANSFERFEE = '3'; 
        public const string STP_FT_TRANSFERFEE_Label = "������"; 
        public const char STP_FT_BROKERFEE = '4'; 
        public const string STP_FT_BROKERFEE_Label = "Ӷ��"; 
        public const char STP_FT_HANDLINGFEE = '5'; 
        public const string STP_FT_HANDLINGFEE_Label = "���ַ�"; 
        public const char STP_FT_ADMINFEE = '6'; 
        public const string STP_FT_ADMINFEE_Label = "֤�ܷ�"; 
        public const char STP_FT_OTHERFEE = '7'; 
        public const string STP_FT_OTHERFEE_Label = "������"; 
        public const char STP_FT_CLEARINGFEE = 'a'; 
        public const string STP_FT_CLEARINGFEE_Label = "�����"; 
        public const char STP_FT_SETTLEFEE = 'b'; 
        public const string STP_FT_SETTLEFEE_Label = "�����"; 
        public const char STP_FT_PERORDER = 'c'; 
        public const string STP_FT_PERORDER_Label = "ί���걨��"; 
        public const char STP_FT_PERCANCEL = 'd'; 
        public const string STP_FT_PERCANCEL_Label = "�����걨��";  
        public const char STP_CT_TOTAL = '1'; 
        public const string STP_CT_TOTAL_Label = "�ֱ�"; 
        public const char STP_CT_PER = '2'; 
        public const string STP_CT_PER_Label = "�ϱ�";  
        public const char STP_CF_ORDER = '1'; 
        public const string STP_CF_ORDER_Label = "��ͨί��"; 
        public const char STP_CF_CANCEL = '2'; 
        public const string STP_CF_CANCEL_Label = "����ί��";  
        public const char STP_SRB_FALSE = '0'; 
        public const string STP_SRB_FALSE_Label = "����֤ȯ���첻����"; 
        public const char STP_SRB_TRUE = '1'; 
        public const string STP_SRB_TRUE_Label = "����֤�������";  
        public const char STP_FRB_FALSE = '0'; 
        public const string STP_FRB_FALSE_Label = "�����ʽ𲻿���"; 
        public const char STP_FRB_TRUE = '1'; 
        public const string STP_FRB_TRUE_Label = "�����ʽ������";  
        public const char STP_INSTC_LEVEL_PRODUCT_CLASS = '1'; 
        public const string STP_INSTC_LEVEL_PRODUCT_CLASS_Label = "֤ȯ���"; 
        public const char STP_INSTC_LEVEL_SINGLE = '3'; 
        public const string STP_INSTC_LEVEL_SINGLE_Label = "��һ֤ȯ";  
        public const char STP_INSTC_RANGE_ALL = '1'; 
        public const string STP_INSTC_RANGE_ALL_Label = "����"; 
        public const char STP_INSTC_RANGE_SET = '3'; 
        public const string STP_INSTC_RANGE_SET_Label = "����";  
        public const char STP_AR_LEVEL_COMPANY = '1'; 
        public const string STP_AR_LEVEL_COMPANY_Label = "��˾"; 
        public const char STP_AR_LEVEL_ACCOUNT = '2'; 
        public const string STP_AR_LEVEL_ACCOUNT_Label = "�˻�"; 
        public const char STP_AR_LEVEL_COMBO = '3'; 
        public const string STP_AR_LEVEL_COMBO_Label = "���";  
        public const char STP_AR_RANGE_ALL = '1'; 
        public const string STP_AR_RANGE_ALL_Label = "����"; 
        public const char STP_AR_RANGE_SET = '3'; 
        public const string STP_AR_RANGE_SET_Label = "����";  

        /////////////////////////////////////////////////////////////////////////
        ///��������
        /////////////////////////////////////////////////////////////////////////
        ///ʱ�䳤�ȶ���
        public const int STP_TIME_LEN = (9+1) ;
        ///���ڳ��ȶ���
        public const int STP_DATE_LEN = (8+1) ;

	  
        ///֤ȯ���볤�ȵĶ���
  	    public const int STP_INSTRUMENTID_LEN = (30 + 1); 
        ///���������볤�ȵĶ���
  	    public const int STP_EXCHANGEID_LEN = (8 + 1); 
        ///��Լ���Ƴ��ȵĶ���
  	    public const int STP_INSTRUMENTNAME_LEN = (20 + 1); 
        ///��Ʒ���볤�ȵĶ���
  	    public const int STP_PRODUCTID_LEN = (30 + 1); 
        ///���͹�˾���볤�ȵĶ���
  	    public const int STP_BROKERID_LEN = (10 + 1); 
        ///��̨���볤�ȵĶ���
  	    public const int STP_PROVIDERID_LEN = (10 + 1); 
        ///ĸ�˻����볤�ȵĶ���
  	    public const int STP_BROKERINVESTORID_LEN = (32 + 1); 
        ///ĸ�˻����Ƴ��ȵĶ���
  	    public const int STP_BROKERINVESTORNAME_LEN = (80 + 1); 
        ///���볤�ȵĶ���
  	    public const int STP_PASSWORD_LEN = (40 + 1); 
        ///��Ȩ���˻����볤�ȵĶ���
  	    public const int STP_OPTSUBINVESTORID_LEN = (8 + 1); 
        ///ϯλ�ų��ȵĶ���
  	    public const int STP_BUSINESSUNIT_LEN = (5 + 1); 
        ///Ӫҵ�����볤�ȵĶ���
  	    public const int STP_BRANCHID_LEN = (5 + 1); 
        ///Ͷ�������Ƴ��ȵĶ���
  	    public const int STP_INVESTORNAME_LEN = (80 + 1); 
        ///�û����볤�ȵĶ���
  	    public const int STP_USERID_LEN = (14 + 1); 
        ///���ص�¼�û����볤�ȵĶ���
  	    public const int STP_GATEWAYUSERID_LEN = (14 + 1); 
        ///�û����Ƴ��ȵĶ���
  	    public const int STP_USERNAME_LEN = (80 + 1); 
        ///������Ƴ��ȵĶ���
  	    public const int STP_COMBONAME_LEN = (80 + 1); 
        ///�ʲ���Ԫ��ţ�UFX Only�����ȵĶ���
  	    public const int STP_ASSETNO_LEN = (16 + 1); 
        ///��ע���ȵĶ���
  	    public const int STP_MEMO_LEN = (80 + 1); 
        ///�ɽ���ų��ȵĶ���
  	    public const int STP_TRADEID_LEN = (20 + 1); 
        ///������ų��ȵĶ���
  	    public const int STP_ORDERSYSID_LEN = (16 + 1); 
        ///���ر�����ų��ȵĶ���
  	    public const int STP_ORDERLOCALID_LEN = (12 + 1); 
        ///�������ó��ȵĶ���
  	    public const int STP_ORDERREF_LEN = (50 + 1); 
        ///ȡ���������ó��ȵĶ���
  	    public const int STP_ORDERCANCELREF_LEN = (10 + 1); 
        ///����������Ա���볤�ȵĶ���
  	    public const int STP_BRANCHPBU_LEN = (20 + 1); 
        ///�ʽ��˻����볤�ȵĶ���
  	    public const int STP_ACCOUNTCODE_LEN = (30 + 1); 
        ///��ƽ��־���ȵĶ���
  	    public const int STP_COMBOSTPETFLAG_LEN = (4 + 1); 
        ///Ͷ���ױ���־���ȵĶ���
  	    public const int STP_COMBHEDGEFLAG_LEN = (4 + 1); 
        ///���������ó��ȵĶ���
  	    public const int STP_ORDERACTIONREF_LEN = (10 + 1); 
        ///״̬��Ϣ���ȵĶ���
  	    public const int STP_STATUSMSG_LEN = (80 + 1); 
        ///������Ϣ���ȵĶ���
  	    public const int STP_ERRORMSG_LEN = (80 + 1); 
        ///��������б���|�ָ���ȵĶ���
  	    public const int STP_COMBOIDLIST_LEN = (512 + 1); 
        ///֤ȯ���״��볤�ȵĶ���
  	    public const int STP_INSTRUMENTCODE_LEN = (20 + 1); 
        ///���������Ƴ��ȵĶ���
  	    public const int STP_EXCHANGENAME_LEN = (50 + 1); 
        ///ϯλ���Ƴ��ȵĶ���
  	    public const int STP_SEATNAME_LEN = (50 + 1); 
        ///֤���ų��ȵĶ���
  	    public const int STP_IDCARDNO_LEN = (100 + 1); 
        ///Ͷ�����˻��ӱ��볤�ȵĶ���
  	    public const int STP_OPTCLIENTID_LEN = (10 + 1); 
        ///�����ų��ȵĶ���
  	    public const int STP_GROUPID_LEN = (14 + 1); 
        ///�������Ƴ��ȵĶ���
  	    public const int STP_GROUPNAME_LEN = (50 + 1); 
        ///��֯�ܹ����볤�ȵĶ���
  	    public const int STP_DEPARTMENTID_LEN = (14 + 1); 
        ///��֯�ܹ����Ƴ��ȵĶ���
  	    public const int STP_DEPTNAME_LEN = (50 + 1); 
        ///����Ա���Ƴ��ȵĶ���
  	    public const int STP_OPERATORNAME_LEN = (20 + 1); 
        ///��Ʒ���Ƴ��ȵĶ���
  	    public const int STP_PRODUCTNAME_LEN = (50 + 1); 
        ///Ͷ�ʵ�Ԫ���볤�ȵĶ���
  	    public const int STP_INVESTUNITID_LEN = (14 + 1); 
        ///ϯλ�ų��ȵĶ���
  	    public const int STP_SEATID_LEN = (10 + 1); 
        ///�ʽ��˻����Ƴ��ȵĶ���
  	    public const int STP_ACCOUNTNAME_LEN = (50 + 1); 
        ///���ִ��볤�ȵĶ���
  	    public const int STP_CURRENCYID_LEN = (3 + 1); 
        ///Ͷ�ʵ�Ԫ���Ƴ��ȵĶ���
  	    public const int STP_INVESTUNITNAME_LEN = (50 + 1); 
        ///Ͷ����ϴ��볤�ȵĶ���
  	    public const int STP_PORTFOLIOID_LEN = (14 + 1); 
        ///���ױ��볤�ȵĶ���
  	    public const int STP_TRADECODE_LEN = (18 + 1); 
        ///������볤�ȵĶ���
  	    public const int STP_RULECODE_LEN = (128 + 1); 
        ///�������Ƴ��ȵĶ���
  	    public const int STP_RULENAME_LEN = (50 + 1); 
        ///�޸�������ϸ��json�ַ��������ȵĶ���
  	    public const int STP_VALUE_LEN = (768 + 1); 
        ///Ԥ���ֶ�1���ȵĶ���
  	    public const int STP_THIRDREFF1_LEN = (20 + 1); 
        ///Ԥ���ֶ�2���ȵĶ���
  	    public const int STP_THIRDREFF2_LEN = (50 + 1); 
        ///ǰ�õ�ַ���ȵĶ���
  	    public const int STP_FRONTADDRESS_LEN = (31 + 1); 
        ///���ļ�·�����ȵĶ���
  	    public const int STP_FLOWPATH_LEN = (127 + 1); 
        ///ָ����볤�ȵĶ���
  	    public const int STP_ADMINCODE_LEN = (32 + 1); 
        ///������Ʒ���볤�ȵĶ���
  	    public const int STP_UNDERLYINGINSTRUMENTID_LEN = (30 + 1); 
        ///Ͷ����϶�Ӧ�ĺ�Լ���볤�ȵĶ���
  	    public const int STP_KEYINSTRUMENTID_LEN = (30 + 1); 
        ///��˾���Ƴ��ȵĶ���
  	    public const int STP_COMPANYNAME_LEN = (50 + 1); 
        ///����Ա��ɫ���ȵĶ���
  	    public const int STP_OPROLES_LEN = (100 + 1); 
        ///(�ѷϳ�)����Ա���Բ�ѯ���˻����ϳ��ȵĶ���
  	    public const int STP_QRYACCOUNTIDS_LEN = (500 + 1); 
        ///(�ѷϳ�)����Ա���Բ������˻����ϳ��ȵĶ���
  	    public const int STP_OPACCOUNTIDS_LEN = (500 + 1); 
        ///����Ա���Բ�ѯ����ϼ��ϳ��ȵĶ���
  	    public const int STP_QRYCOMBOIDS_LEN = (500 + 1); 
        ///����Ա���Բ�������ϼ��ϳ��ȵĶ���
  	    public const int STP_OPCOMBOIDS_LEN = (500 + 1); 
        ///��ϵ�˳��ȵĶ���
  	    public const int STP_LINKMAN_LEN = (40 + 1); 
        ///��ϵ��ַ���ȵĶ���
  	    public const int STP_ADDRESS_LEN = (50 + 1); 
        ///��ϵ�绰���ȵĶ���
  	    public const int STP_TEL_LEN = (40 + 1); 
        ///�������䳤�ȵĶ���
  	    public const int STP_EMAIL_LEN = (40 + 1); 
        ///����Ա�绰���ȵĶ���
  	    public const int STP_OPTEL_LEN = (40 + 1); 
        ///����Ա���䳤�ȵĶ���
  	    public const int STP_OPEMAIL_LEN = (40 + 1); 
        ///ע��ʱ�䳤�ȵĶ���
  	    public const int STP_REGIDATE_LEN = (14 + 1); 
        ///�޸�ʱ�䳤�ȵĶ���
  	    public const int STP_UPTTIME_LEN = (14 + 1); 
        ///��¼ʱ�䳤�ȵĶ���
  	    public const int STP_LOGTIME_LEN = (14 + 1); 
        ///�����޸�ʱ�䳤�ȵĶ���
  	    public const int STP_PWDUPTTIME_LEN = (14 + 1); 
        ///��¼����ʱ�䳤�ȵĶ���
  	    public const int STP_LOGERRTIME_LEN = (14 + 1); 
        ///Ȩ��ID���ȵĶ���
  	    public const int STP_AUTHID_LEN = (8 + 1); 
        ///Ȩ���������ȵĶ���
  	    public const int STP_AUTHDESC_LEN = (30 + 1); 
        ///��Ȩ�޳��ȵĶ���
  	    public const int STP_PARENTID_LEN = (8 + 1); 
        ///�������ȵĶ���
  	    public const int STP_ACTION_LEN = (60 + 1); 
        ///�����������ȵĶ���
  	    public const int STP_ACTIONDESC_LEN = (3000 + 1); 
        ///�������ȵĶ���
  	    public const int STP_RESV_LEN = (300 + 1); 
        ///����ʱ�䳤�ȵĶ���
  	    public const int STP_CRTTIME_LEN = (14 + 1); 
        ///���һ�θ���ʱ�䳤�ȵĶ���
  	    public const int STP_LASTUPTTIME_LEN = (14 + 1); 
        ///���һ��ʹ��ʱ�䳤�ȵĶ���
  	    public const int STP_LASTUSRTIME_LEN = (14 + 1); 
        ///�ӿڱ�ʶ���ȵĶ���
  	    public const int STP_CMDID_LEN = (100 + 1); 
        ///ϵͳ��ˮ���ȵĶ���
  	    public const int STP_SYSSEQID_LEN = (10 + 1); 
        ///��׺�ļ����ͳ��ȵĶ���
  	    public const int STP_FILEPOSTFIX_LEN = (10 + 1); 
        ///��ɫ�ų��ȵĶ���
  	    public const int STP_ROLEID_LEN = (3 + 1); 
        ///��ɫ���Ƴ��ȵĶ���
  	    public const int STP_ROLENAME_LEN = (20 + 1); 
        ///�ļ����Ƴ��ȵĶ���
  	    public const int STP_FILENAME_LEN = (120 + 1); 
        ///�ļ��洢·�����ȵĶ���
  	    public const int STP_FILEURL_LEN = (120 + 1); 
        ///�ļ���ѯ�������ȵĶ���
  	    public const int STP_FILEINFO_LEN = (120 + 1); 
        ///�������Ƴ��ȵĶ���
  	    public const int STP_SEQNAME_LEN = (50 + 1); 
        ///����IP��ַ���������ȵĶ���
  	    public const int STP_IPADDRESS_LEN = (500 + 1); 
        ///����ɷ�ʱ�䳤�ȵĶ���
  	    public const int STP_LASTPAYTIME_LEN = (14 + 1); 
        ///�ɷ�ʱ�䳤�ȵĶ���
  	    public const int STP_PAYTIME_LEN = (14 + 1); 
        ///�ͻ��ų��ȵĶ���
  	    public const int STP_CLIENTID_LEN = (50 + 1); 
        ///ͨ�����Ƴ��ȵĶ���
  	    public const int STP_CHANNELNAME_LEN = (50 + 1); 
        ///�ֲֽӿ�IP���ȵĶ���
  	    public const int STP_SYSIP_LEN = (20 + 1); 
        ///�ֲֽӿڶ˿ڳ��ȵĶ���
  	    public const int STP_SYSPORT_LEN = (10 + 1); 
        ///�ֲ��������ó��ȵĶ���
  	    public const int STP_CHANNELCONFIG_LEN = (256 + 1); 
        ///��ע���ȵĶ���
  	    public const int STP_REMARK_LEN = (200 + 1); 
        ///����IP���ȵĶ���
  	    public const int STP_ORDERIP_LEN = (20 + 1); 
        ///����MAC���ȵĶ���
  	    public const int STP_ORDERMAC_LEN = (20 + 1); 
        ///����Ӳ�����кų��ȵĶ���
  	    public const int STP_ORDERHDNUM_LEN = (50 + 1); 
        ///���������볤�ȵĶ���
  	    public const int STP_ORDERMACCODE_LEN = (50 + 1); 
        ///��������ϵͳ���ȵĶ���
  	    public const int STP_ORDEROS_LEN = (50 + 1); 
        ///���������볤�ȵĶ���
  	    public const int STP_EXCHANGEIDS_LEN = (256 + 1); 
        ///�˻����ϳ��ȵĶ���
  	    public const int STP_ACCOUNTIDS_LEN = (512 + 1); 
        ///֤ȯ���뼯�ϳ��ȵĶ���
  	    public const int STP_INSTRUMENTIDS_LEN = (512 + 1); 
        ///O32����Ա���볤�ȵĶ���
  	    public const int STP_O32OPERATORNO_LEN = (15 + 1); 
        ///O32����Ա���볤�ȵĶ���
  	    public const int STP_O32OPERATORPWD_LEN = (15 + 1); 
        ///O32������볤�ȵĶ���
  	    public const int STP_O32ACCOUNTCODE_LEN = (31 + 1); 
        ///O32��ϱ�ų��ȵĶ���
  	    public const int STP_O32COMBINO_LEN = (15 + 1); 
        ///O32�ʲ���Ԫ��ų��ȵĶ���
  	    public const int STP_O32ASSETNO_LEN = (15 + 1); 
        ///������Ϣ���ȵĶ���
  	    public const int STP_OPERATEMSG_LEN = (240 + 1); 
    };
}

  