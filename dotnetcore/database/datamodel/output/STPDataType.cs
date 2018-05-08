
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
        public const string STP_PC_Futures_Label = "期货"; 
        public const char STP_PC_Options = '2'; 
        public const string STP_PC_Options_Label = "期权"; 
        public const char STP_PC_Stock = '3'; 
        public const string STP_PC_Stock_Label = "股票"; 
        public const char STP_PC_Bond = '4'; 
        public const string STP_PC_Bond_Label = "债券"; 
        public const char STP_PC_Fund = '5'; 
        public const string STP_PC_Fund_Label = "基金"; 
        public const char STP_PC_Index = '6'; 
        public const string STP_PC_Index_Label = "指数"; 
        public const char STP_PC_Warrant = '7'; 
        public const string STP_PC_Warrant_Label = "权证"; 
        public const char STP_PC_Repo = '8'; 
        public const string STP_PC_Repo_Label = "回购"; 
        public const char STP_PC_Other = '9'; 
        public const string STP_PC_Other_Label = "其他";  
        public const char STP_IR_All = '1'; 
        public const string STP_IR_All_Label = "所有"; 
        public const char STP_IR_Group = '2'; 
        public const string STP_IR_Group_Label = "投资者组"; 
        public const char STP_IR_Single = '3'; 
        public const string STP_IR_Single_Label = "单一投资者"; 
        public const char STP_IR_AllInvestUnit = '4'; 
        public const string STP_IR_AllInvestUnit_Label = "所有投资单元"; 
        public const char STP_IR_SingleInvestUnit = '5'; 
        public const string STP_IR_SingleInvestUnit_Label = "单一投资单元";  
        public const char STP_PT_CtpFutureTd = '0'; 
        public const string STP_PT_CtpFutureTd_Label = "ctp期货交易"; 
        public const char STP_PT_CtpFutureMd = '1'; 
        public const string STP_PT_CtpFutureMd_Label = "ctp期货行情"; 
        public const char STP_PT_CtpFutureQry = '2'; 
        public const string STP_PT_CtpFutureQry_Label = "ctp期货查询"; 
        public const char STP_PT_STPOptionTd = '3'; 
        public const string STP_PT_STPOptionTd_Label = "Stp的期权交易"; 
        public const char STP_PT_STPOptionQry = '4'; 
        public const string STP_PT_STPOptionQry_Label = "Stp的期权查询"; 
        public const char STP_PT_STPStockTd = '5'; 
        public const string STP_PT_STPStockTd_Label = "Stp的股票交易"; 
        public const char STP_PT_STPStockQry = '6'; 
        public const string STP_PT_STPStockQry_Label = "Stp的股票查询"; 
        public const char STP_PT_FemasFutureTd = '7'; 
        public const string STP_PT_FemasFutureTd_Label = "Femas期货交易"; 
        public const char STP_PT_FemasFutureMd = '8'; 
        public const string STP_PT_FemasFutureMd_Label = "Femas期货行情"; 
        public const char STP_PT_FemasFutureQry = '9'; 
        public const string STP_PT_FemasFutureQry_Label = "Femas期货查询";  
        public const char STP_D_Buy = '0'; 
        public const string STP_D_Buy_Label = "买"; 
        public const char STP_D_Sell = '1'; 
        public const string STP_D_Sell_Label = "卖"; 
        public const char STP_D_ETFPur = '2'; 
        public const string STP_D_ETFPur_Label = "ETF申购"; 
        public const char STP_D_ETFRed = '3'; 
        public const string STP_D_ETFRed_Label = "ETF赎回"; 
        public const char STP_D_CashIn = '4'; 
        public const string STP_D_CashIn_Label = "现金替代，只用作回报"; 
        public const char STP_D_PledgeBondIn = '5'; 
        public const string STP_D_PledgeBondIn_Label = "债券入库"; 
        public const char STP_D_PledgeBondOut = '6'; 
        public const string STP_D_PledgeBondOut_Label = "债券出库"; 
        public const char STP_D_Doublened = '7'; 
        public const string STP_D_Doublened_Label = "配股"; 
        public const char STP_D_DepositoryTransfer = '8'; 
        public const string STP_D_DepositoryTransfer_Label = "转托管"; 
        public const char STP_D_CreditDoublened = '9'; 
        public const string STP_D_CreditDoublened_Label = "信用账户配股"; 
        public const char STP_D_BuyCollateral = 'A'; 
        public const string STP_D_BuyCollateral_Label = "担保品买入"; 
        public const char STP_D_SellCollateral = 'B'; 
        public const string STP_D_SellCollateral_Label = "担保品卖出"; 
        public const char STP_D_CollateralTransferIn = 'C'; 
        public const string STP_D_CollateralTransferIn_Label = "担保品转入"; 
        public const char STP_D_CollateralTransferOut = 'D'; 
        public const string STP_D_CollateralTransferOut_Label = "担保品转出"; 
        public const char STP_D_MarginTrade = 'E'; 
        public const string STP_D_MarginTrade_Label = "融资买入"; 
        public const char STP_D_ShortSell = 'F'; 
        public const string STP_D_ShortSell_Label = "融券卖出"; 
        public const char STP_D_RepayMargin = 'G'; 
        public const string STP_D_RepayMargin_Label = "卖券还款"; 
        public const char STP_D_RepayStock = 'H'; 
        public const string STP_D_RepayStock_Label = "买券还券"; 
        public const char STP_D_DirectRepayMargin = 'I'; 
        public const string STP_D_DirectRepayMargin_Label = "直接还款"; 
        public const char STP_D_DirectRepayStock = 'J'; 
        public const string STP_D_DirectRepayStock_Label = "直接还券"; 
        public const char STP_D_ExcessStockTransfer = 'K'; 
        public const string STP_D_ExcessStockTransfer_Label = "余券划转"; 
        public const char STP_D_OFPur = 'L'; 
        public const string STP_D_OFPur_Label = "OF申购"; 
        public const char STP_D_OFRed = 'M'; 
        public const string STP_D_OFRed_Label = "OF赎回"; 
        public const char STP_D_SFSplit = 'N'; 
        public const string STP_D_SFSplit_Label = "SF拆分"; 
        public const char STP_D_SFMerge = 'O'; 
        public const string STP_D_SFMerge_Label = "SF合并"; 
        public const char STP_D_Covered = 'P'; 
        public const string STP_D_Covered_Label = "备兑"; 
        public const char STP_D_Freeze = 'Q'; 
        public const string STP_D_Freeze_Label = "证券冻结(开)/解冻(平)"; 
        public const char STP_D_Execute = 'R'; 
        public const string STP_D_Execute_Label = "行权"; 
        public const char STP_D_CBRed = 'S'; 
        public const string STP_D_CBRed_Label = "CB回售"; 
        public const char STP_D_CBConv = 'T'; 
        public const string STP_D_CBConv_Label = "CB转股"; 
        public const char STP_D_OFSub = 'U'; 
        public const string STP_D_OFSub_Label = "OF认购";  
        public const char STP_QAT_Operate = '0'; 
        public const string STP_QAT_Operate_Label = "操作"; 
        public const char STP_QAT_Query = '1'; 
        public const string STP_QAT_Query_Label = "查询";  
        public const char STP_HF_Speculation = '1'; 
        public const string STP_HF_Speculation_Label = "投机"; 
        public const char STP_HF_Arbitrage = '2'; 
        public const string STP_HF_Arbitrage_Label = "套利"; 
        public const char STP_HF_Hedge = '3'; 
        public const string STP_HF_Hedge_Label = "套保"; 
        public const char STP_HF_MarketMaker = '4'; 
        public const string STP_HF_MarketMaker_Label = "做市商";  
        public const char STP_UT_Investor = '0'; 
        public const string STP_UT_Investor_Label = "投资者"; 
        public const char STP_UT_Operator = '1'; 
        public const string STP_UT_Operator_Label = "操作员"; 
        public const char STP_UT_SuperUser = '2'; 
        public const string STP_UT_SuperUser_Label = "管理员";  
        public const char STP_CF_Uncovered = '0'; 
        public const string STP_CF_Uncovered_Label = "非备兑"; 
        public const char STP_CF_Covered = '1'; 
        public const string STP_CF_Covered_Label = "备兑";  
        public const char STP_OT_0 = '0'; 
        public const string STP_OT_0_Label = "个人投资者"; 
        public const char STP_OT_1 = '1'; 
        public const string STP_OT_1_Label = "交易所发起"; 
        public const char STP_OT_2 = '2'; 
        public const string STP_OT_2_Label = "期权经营机构"; 
        public const char STP_OT_3 = '3'; 
        public const string STP_OT_3_Label = "机构投资者发起"; 
        public const char STP_OT_4 = '4'; 
        public const string STP_OT_4_Label = "自营交易发起"; 
        public const char STP_OT_5 = '5'; 
        public const string STP_OT_5_Label = "流动性服务提供商发起";  
        public const char STP_IL_1 = '0'; 
        public const string STP_IL_1_Label = "一级"; 
        public const char STP_IL_2 = '1'; 
        public const string STP_IL_2_Label = "二级"; 
        public const char STP_IL_3 = '2'; 
        public const string STP_IL_3_Label = "三级"; 
        public const char STP_IL_9 = '9'; 
        public const string STP_IL_9_Label = "非交易级别，此级别investor不可交易";  
        public const char STP_OF_Open = '0'; 
        public const string STP_OF_Open_Label = "开仓"; 
        public const char STP_OF_Close = '1'; 
        public const string STP_OF_Close_Label = "平仓"; 
        public const char STP_OF_ForceClose = '2'; 
        public const string STP_OF_ForceClose_Label = "强平"; 
        public const char STP_OF_CloseToday = '3'; 
        public const string STP_OF_CloseToday_Label = "平今"; 
        public const char STP_OF_CloseYesterday = '4'; 
        public const string STP_OF_CloseYesterday_Label = "平昨"; 
        public const char STP_OF_ForceOff = '5'; 
        public const string STP_OF_ForceOff_Label = "强减"; 
        public const char STP_OF_LocalForceClose = '6'; 
        public const string STP_OF_LocalForceClose_Label = "本地强平"; 
        public const char STP_OF_Auto = '7'; 
        public const string STP_OF_Auto_Label = "自动进行平昨平今判断(暂不支持）"; 
        public const char STP_OF_Call = '8'; 
        public const string STP_OF_Call_Label = "认购"; 
        public const char STP_OF_Put = '9'; 
        public const string STP_OF_Put_Label = "认沽";  
        public const char STP_OPT_AnyPrice = '1'; 
        public const string STP_OPT_AnyPrice_Label = "任意价"; 
        public const char STP_OPT_LimitPrice = '2'; 
        public const string STP_OPT_LimitPrice_Label = "限价"; 
        public const char STP_OPT_BestPrice = '3'; 
        public const string STP_OPT_BestPrice_Label = "最优价"; 
        public const char STP_OPT_LastPrice = '4'; 
        public const string STP_OPT_LastPrice_Label = "最新价"; 
        public const char STP_OPT_LocalBestPrice = '5'; 
        public const string STP_OPT_LocalBestPrice_Label = "本方最新价"; 
        public const char STP_OPT_FiveLevelPrice = '6'; 
        public const string STP_OPT_FiveLevelPrice_Label = "五档最优价"; 
        public const char STP_OPT_PurchasesETF = 'd'; 
        public const string STP_OPT_PurchasesETF_Label = "ETF申购"; 
        public const char STP_OPT_RedeemETF = 'e'; 
        public const string STP_OPT_RedeemETF_Label = "ETF赎回";  
        public const char STP_TC_IOC = '1'; 
        public const string STP_TC_IOC_Label = "立即完成，否则撤销"; 
        public const char STP_TC_GFS = '2'; 
        public const string STP_TC_GFS_Label = "本节有效"; 
        public const char STP_TC_GFD = '3'; 
        public const string STP_TC_GFD_Label = "当日有效"; 
        public const char STP_TC_GTD = '4'; 
        public const string STP_TC_GTD_Label = "指定日期前有效"; 
        public const char STP_TC_GTC = '5'; 
        public const string STP_TC_GTC_Label = "撤销前有效"; 
        public const char STP_TC_GFA = '6'; 
        public const string STP_TC_GFA_Label = "集合竞价有效";  
        public const char STP_VC_AV = '1'; 
        public const string STP_VC_AV_Label = "任何数量"; 
        public const char STP_VC_MV = '2'; 
        public const string STP_VC_MV_Label = "最小数量"; 
        public const char STP_VC_CV = '3'; 
        public const string STP_VC_CV_Label = "全部数量";  
        public const char STP_CC_Immediately = '1'; 
        public const string STP_CC_Immediately_Label = "立即"; 
        public const char STP_CC_Touch = '2'; 
        public const string STP_CC_Touch_Label = "止损"; 
        public const char STP_CC_TouchProfit = '3'; 
        public const string STP_CC_TouchProfit_Label = "止赢"; 
        public const char STP_CC_ParkedOrder = '4'; 
        public const string STP_CC_ParkedOrder_Label = "预埋单";  
        public const char STP_OST_Unknown = '0'; 
        public const string STP_OST_Unknown_Label = "待报"; 
        public const char STP_OST_PendingNew = '1'; 
        public const string STP_OST_PendingNew_Label = "正报"; 
        public const char STP_OST_New = '2'; 
        public const string STP_OST_New_Label = "已报"; 
        public const char STP_OST_PartilyFilled = '3'; 
        public const string STP_OST_PartilyFilled_Label = "部成"; 
        public const char STP_OST_Filled = '4'; 
        public const string STP_OST_Filled_Label = "已成"; 
        public const char STP_OST_PartilyCanceled = '5'; 
        public const string STP_OST_PartilyCanceled_Label = "部撤"; 
        public const char STP_OST_Canceled = '6'; 
        public const string STP_OST_Canceled_Label = "已撤"; 
        public const char STP_OST_Rejected = '7'; 
        public const string STP_OST_Rejected_Label = "废单";  
        public const char STP_ORDT_Normal = '0'; 
        public const string STP_ORDT_Normal_Label = "正常"; 
        public const char STP_ORDT_DeriveFromQuote = '1'; 
        public const string STP_ORDT_DeriveFromQuote_Label = "报价衍生"; 
        public const char STP_ORDT_DeriveFromCombination = '2'; 
        public const string STP_ORDT_DeriveFromCombination_Label = "组合衍生"; 
        public const char STP_ORDT_Combination = '3'; 
        public const string STP_ORDT_Combination_Label = "组合报单"; 
        public const char STP_ORDT_ConditionalOrder = '4'; 
        public const string STP_ORDT_ConditionalOrder_Label = "条件单"; 
        public const char STP_ORDT_Swap = '5'; 
        public const string STP_ORDT_Swap_Label = "互换单";  
        public const char STP_PD_Short = '1'; 
        public const string STP_PD_Short_Label = "空头"; 
        public const char STP_PD_Long = '0'; 
        public const string STP_PD_Long_Label = "多头";  
        public const char STP_CGT_check = '1'; 
        public const string STP_CGT_check_Label = "核对值"; 
        public const char STP_CGT_fronzen = '2'; 
        public const string STP_CGT_fronzen_Label = "冻结功能"; 
        public const char STP_CGT_current = '3'; 
        public const string STP_CGT_current_Label = "当前值"; 
        public const char STP_CGT_cost = '4'; 
        public const string STP_CGT_cost_Label = "持仓成本";  
        public const char STP_CPD_Nochange = '0'; 
        public const string STP_CPD_Nochange_Label = "不变"; 
        public const char STP_CPD_Increase = '1'; 
        public const string STP_CPD_Increase_Label = "增加"; 
        public const char STP_CPD_Decrease = '2'; 
        public const string STP_CPD_Decrease_Label = "减少";  
        public const char STP_PSD_Nochange = '0'; 
        public const string STP_PSD_Nochange_Label = "不变"; 
        public const char STP_PSD_Increase = '1'; 
        public const string STP_PSD_Increase_Label = "增加"; 
        public const char STP_PSD_Decrease = '2'; 
        public const string STP_PSD_Decrease_Label = "减少";  
        public const char STP_PSD_Today = '1'; 
        public const string STP_PSD_Today_Label = "今日持仓"; 
        public const char STP_PSD_History = '2'; 
        public const string STP_PSD_History_Label = "历史持仓";  
        public const char STP_TP_NonTrade = '0'; 
        public const string STP_TP_NonTrade_Label = "非交易时段"; 
        public const char STP_TP_Bidding = '1'; 
        public const string STP_TP_Bidding_Label = "集合竞价时段"; 
        public const char STP_TP_Continuous = '2'; 
        public const string STP_TP_Continuous_Label = "连续交易时段"; 
        public const char STP_TP_Suspension = '3'; 
        public const string STP_TP_Suspension_Label = "停牌时段"; 
        public const char STP_TP_Fuse = '4'; 
        public const string STP_TP_Fuse_Label = "熔断时段";  
        public const char STP_OR_None = '0'; 
        public const string STP_OR_None_Label = "无开仓限制"; 
        public const char STP_OR_NoCoverOpen = '1'; 
        public const string STP_OR_NoCoverOpen_Label = "限制备兑开仓"; 
        public const char STP_OR_NoSellOpen = '2'; 
        public const string STP_OR_NoSellOpen_Label = "限制卖出开仓"; 
        public const char STP_OR_NoSellAndCoverOpen = '3'; 
        public const string STP_OR_NoSellAndCoverOpen_Label = "限制卖出开仓、备兑开仓"; 
        public const char STP_OR_NoBuyOpen = '4'; 
        public const string STP_OR_NoBuyOpen_Label = "限制买入开仓"; 
        public const char STP_OR_NoBuyAndCoverOpen = '5'; 
        public const string STP_OR_NoBuyAndCoverOpen_Label = "限制买入开仓、备兑开仓"; 
        public const char STP_OR_NoBuyAndSellOpen = '6'; 
        public const string STP_OR_NoBuyAndSellOpen_Label = "限制买入开仓、卖出开仓"; 
        public const char STP_OR_NoBuySellAndCoverOpen = '7'; 
        public const string STP_OR_NoBuySellAndCoverOpen_Label = "限制买入开仓、卖出开仓、备兑开仓";  
        public const char STP_PT_Net = '1'; 
        public const string STP_PT_Net_Label = "净持仓"; 
        public const char STP_PT_Gross = '2'; 
        public const string STP_PT_Gross_Label = "综合持仓";  
        public const char STP__UseHistory = '1'; 
        public const string STP__UseHistory_Label = "使用历史持仓"; 
        public const char STP__NoUseHistory = '2'; 
        public const string STP__NoUseHistory_Label = "不使用历史持仓";  
        public const char STP_IT_Person = '1'; 
        public const string STP_IT_Person_Label = "自然人"; 
        public const char STP_IT_Company = '2'; 
        public const string STP_IT_Company_Label = "法人"; 
        public const char STP_IT_Fund = '3'; 
        public const string STP_IT_Fund_Label = "投资基金"; 
        public const char STP_IT_SpecialOrgan = '4'; 
        public const string STP_IT_SpecialOrgan_Label = "特殊法人"; 
        public const char STP_IT_Asset = '5'; 
        public const string STP_IT_Asset_Label = "资管户"; 
        public const char STP_IT_Admin = 'a'; 
        public const string STP_IT_Admin_Label = "系统管理员";  
        public const char STP_DCT_EID = '0'; 
        public const string STP_DCT_EID_Label = "组织机构代码"; 
        public const char STP_DCT_IDCard = '1'; 
        public const string STP_DCT_IDCard_Label = "中国公民身份证"; 
        public const char STP_DCT_OfficerIDCard = '2'; 
        public const string STP_DCT_OfficerIDCard_Label = "军官证"; 
        public const char STP_DCT_PoliceIDCard = '3'; 
        public const string STP_DCT_PoliceIDCard_Label = "警官证"; 
        public const char STP_DCT_SoldierIDCard = '4'; 
        public const string STP_DCT_SoldierIDCard_Label = "士兵证"; 
        public const char STP_DCT_HouseholdRegister = '5'; 
        public const string STP_DCT_HouseholdRegister_Label = "户口簿"; 
        public const char STP_DCT_Passport = '6'; 
        public const string STP_DCT_Passport_Label = "护照"; 
        public const char STP_DCT_TaiwanCompatriotIDCard = '7'; 
        public const string STP_DCT_TaiwanCompatriotIDCard_Label = "台胞证"; 
        public const char STP_DCT_HomeComingCard = '8'; 
        public const string STP_DCT_HomeComingCard_Label = "回乡证"; 
        public const char STP_DCT_LicenseNo = '9'; 
        public const string STP_DCT_LicenseNo_Label = "营业执照号"; 
        public const char STP_DCT_TaxNo = 'A'; 
        public const string STP_DCT_TaxNo_Label = "税务登记号/当地纳税ID"; 
        public const char STP_DCT_HMMainlandTravelPermit = 'B'; 
        public const string STP_DCT_HMMainlandTravelPermit_Label = "港澳居民来往内地通行证"; 
        public const char STP_DCT_TwMainlandTravelPermit = 'C'; 
        public const string STP_DCT_TwMainlandTravelPermit_Label = "台湾居民来往大陆通行证"; 
        public const char STP_DCT_DrivingLicense = 'D'; 
        public const string STP_DCT_DrivingLicense_Label = "驾照"; 
        public const char STP_DCT_SocialID = 'F'; 
        public const string STP_DCT_SocialID_Label = "当地社保ID"; 
        public const char STP_DCT_LocalID = 'G'; 
        public const string STP_DCT_LocalID_Label = "当地身份证"; 
        public const char STP_DCT_BusinessRegistration = 'H'; 
        public const string STP_DCT_BusinessRegistration_Label = "商业登记证"; 
        public const char STP_DCT_HKMCIDCard = 'I'; 
        public const string STP_DCT_HKMCIDCard_Label = "港澳永久性居民身份证"; 
        public const char STP_DCT_AccountsPermits = 'J'; 
        public const string STP_DCT_AccountsPermits_Label = "人行开户许可证"; 
        public const char STP_DCT_PermanantResidence = 'K'; 
        public const string STP_DCT_PermanantResidence_Label = "外国人永久居留证"; 
        public const char STP_DCT_AssetProductRecord = 'L'; 
        public const string STP_DCT_AssetProductRecord_Label = "资管产品备案函"; 
        public const char STP_DCT_OtherCard = 'x'; 
        public const string STP_DCT_OtherCard_Label = "其他证件";  
        public const char STP_TC_Speculation = '1'; 
        public const string STP_TC_Speculation_Label = "投机"; 
        public const char STP_TC_Arbitrage = '2'; 
        public const string STP_TC_Arbitrage_Label = "套利"; 
        public const char STP_TC_Hedge = '3'; 
        public const string STP_TC_Hedge_Label = "套保"; 
        public const char STP_TC_MarketMaker = '4'; 
        public const string STP_TC_MarketMaker_Label = "做市商";  
        public const char STP_OPT_CT_StrikeFee = '1'; 
        public const string STP_OPT_CT_StrikeFee_Label = "行权费"; 
        public const char STP_OPT_CT_BeStrikeDFee = '2'; 
        public const string STP_OPT_CT_BeStrikeDFee_Label = "被行权费"; 
        public const char STP_OPT_CT_TransferFee = '3'; 
        public const string STP_OPT_CT_TransferFee_Label = "行权过户费"; 
        public const char STP_OPT_CT_Brokerage = '4'; 
        public const string STP_OPT_CT_Brokerage_Label = "经手费"; 
        public const char STP_OPT_CT_TradeFee = '5'; 
        public const string STP_OPT_CT_TradeFee_Label = "交易费"; 
        public const char STP_OPT_CT_SettleFee = '6'; 
        public const string STP_OPT_CT_SettleFee_Label = "结算费";  
        public const char STP_CD_BuyOpen = '1'; 
        public const string STP_CD_BuyOpen_Label = "买开"; 
        public const char STP_CD_BuyClose = '2'; 
        public const string STP_CD_BuyClose_Label = "买平"; 
        public const char STP_CD_SellOpen = '3'; 
        public const string STP_CD_SellOpen_Label = "卖开"; 
        public const char STP_CD_SellClose = '4'; 
        public const string STP_CD_SellClose_Label = "卖平"; 
        public const char STP_CD_CallStrike = '5'; 
        public const string STP_CD_CallStrike_Label = "行权认购"; 
        public const char STP_CD_PutStrike = '6'; 
        public const string STP_CD_PutStrike_Label = "行权认沽";  
        public const char STP_RT_ByVolume = '1'; 
        public const string STP_RT_ByVolume_Label = "按手数"; 
        public const char STP_RT_ByMoney = '2'; 
        public const string STP_RT_ByMoney_Label = "按金额"; 
        public const char STP_RT_ByFace = '3'; 
        public const string STP_RT_ByFace_Label = "按面值";  
        public const char STP_OPNT_Sync = '1'; 
        public const string STP_OPNT_Sync_Label = "日初同步操作"; 
        public const char STP_OPNT_Admin = '2'; 
        public const string STP_OPNT_Admin_Label = "管理指令操作"; 
        public const char STP_OPNT_Settle = '3'; 
        public const string STP_OPNT_Settle_Label = "结算后持仓调整操作"; 
        public const char STP_OPNT_Other = '0'; 
        public const string STP_OPNT_Other_Label = "其他操作";  
        public const char STP_OPT_TY_Call = 'C'; 
        public const string STP_OPT_TY_Call_Label = "认购"; 
        public const char STP_OPT_TY_Put = 'P'; 
        public const string STP_OPT_TY_Put_Label = "认沽";  
        public const char STP_STS_SyncDone = '1'; 
        public const string STP_STS_SyncDone_Label = "导入数据完成"; 
        public const char STP_STS_Trading = '2'; 
        public const string STP_STS_Trading_Label = "盘中交易状态"; 
        public const char STP_STS_Closed = '3'; 
        public const string STP_STS_Closed_Label = "收市完成"; 
        public const char STP_STS_Settled = '4'; 
        public const string STP_STS_Settled_Label = "结算完成";  
        public const char STP_INSTR_ALL = '1'; 
        public const string STP_INSTR_ALL_Label = "所有"; 
        public const char STP_INSTR_PRODUCT_CLASS = '2'; 
        public const string STP_INSTR_PRODUCT_CLASS_Label = "证券类别"; 
        public const char STP_INSTR_SINGLE = '3'; 
        public const string STP_INSTR_SINGLE_Label = "单一合约";  
        public const char STP_ST_SHOPT = '1'; 
        public const string STP_ST_SHOPT_Label = "上交所期权"; 
        public const char STP_ST_SHSTK = '2'; 
        public const string STP_ST_SHSTK_Label = "上交所股票"; 
        public const char STP_ST_SZOPT = '3'; 
        public const string STP_ST_SZOPT_Label = "深交所期权"; 
        public const char STP_ST_SZSTK = '4'; 
        public const string STP_ST_SZSTK_Label = "深交所股票"; 
        public const char STP_ST_FEMAS = '5'; 
        public const string STP_ST_FEMAS_Label = "飞马";  
        public const char STP_RT_Restart = '0'; 
        public const string STP_RT_Restart_Label = "重传"; 
        public const char STP_RT_Resume = '1'; 
        public const string STP_RT_Resume_Label = "续传"; 
        public const char STP_RT_Quick = '2'; 
        public const string STP_RT_Quick_Label = "当前开始";  
        public const char STP_CT_INSIDE = '1'; 
        public const string STP_CT_INSIDE_Label = "内部机构"; 
        public const char STP_CT_ORGAN = '2'; 
        public const string STP_CT_ORGAN_Label = "机构客户"; 
        public const char STP_CT_USER = '3'; 
        public const string STP_CT_USER_Label = "个人客户";  
        public const char STP_EF_NORMAL = 'N'; 
        public const string STP_EF_NORMAL_Label = "正常"; 
        public const char STP_EF_OFF = 'C'; 
        public const string STP_EF_OFF_Label = "被关闭"; 
        public const char STP_EF_LOCK = 'L'; 
        public const string STP_EF_LOCK_Label = "锁定"; 
        public const char STP_EF_UNSYNC = '1'; 
        public const string STP_EF_UNSYNC_Label = "新增未同步";  
        public const char STP_ACT_CLIENT = '1'; 
        public const string STP_ACT_CLIENT_Label = "客户端"; 
        public const char STP_ACT_WEB = '2'; 
        public const string STP_ACT_WEB_Label = "web端"; 
        public const char STP_ACT_MARKET = '3'; 
        public const string STP_ACT_MARKET_Label = "行情平台";  
        public const char STP_AUT_GENERAL = '0'; 
        public const string STP_AUT_GENERAL_Label = "通用"; 
        public const char STP_AUT_INSIDE = '1'; 
        public const string STP_AUT_INSIDE_Label = "券商内部"; 
        public const char STP_AUT_OUTSIDE = '2'; 
        public const string STP_AUT_OUTSIDE_Label = "外部客户";  
        public const char STP__InProgress = 'I'; 
        public const string STP__InProgress_Label = "处理中"; 
        public const char STP__Success = 'S'; 
        public const string STP__Success_Label = "生成成功"; 
        public const char STP__Fail = 'F'; 
        public const string STP__Fail_Label = "生成失败";  
        public const char STP_MDT_REAL = '0'; 
        public const string STP_MDT_REAL_Label = "实时行情"; 
        public const char STP_MDT_HIS = '1'; 
        public const string STP_MDT_HIS_Label = "历史行情";  
        public const char STP_PSJ_GENERAL = '1'; 
        public const string STP_PSJ_GENERAL_Label = "通用费用";  
        public const char STP_AT_STOCK = '1'; 
        public const string STP_AT_STOCK_Label = "普通证券账户"; 
        public const char STP_AT_CREDIT = '2'; 
        public const string STP_AT_CREDIT_Label = "信用账户"; 
        public const char STP_AT_DERIVATIVE = '3'; 
        public const string STP_AT_DERIVATIVE_Label = "衍生品账户"; 
        public const char STP_AT_FUTURES = '4'; 
        public const string STP_AT_FUTURES_Label = "期货账户";  
        public const char STP_CHT_UFT = '1'; 
        public const string STP_CHT_UFT_Label = "UFT分仓"; 
        public const char STP_CHT_CTP = '2'; 
        public const string STP_CHT_CTP_Label = "CTP分仓"; 
        public const char STP_CHT_FEMAS = '3'; 
        public const string STP_CHT_FEMAS_Label = "飞马分仓"; 
        public const char STP_CHT_O32 = '4'; 
        public const string STP_CHT_O32_Label = "O32分仓"; 
        public const char STP_CHT_SIMULATE = '5'; 
        public const string STP_CHT_SIMULATE_Label = "模拟交易所";  
        public const char STP_FT_TRADEFEE = '1'; 
        public const string STP_FT_TRADEFEE_Label = "交易费"; 
        public const char STP_FT_STAMPTAX = '2'; 
        public const string STP_FT_STAMPTAX_Label = "印花税"; 
        public const char STP_FT_TRANSFERFEE = '3'; 
        public const string STP_FT_TRANSFERFEE_Label = "过户费"; 
        public const char STP_FT_BROKERFEE = '4'; 
        public const string STP_FT_BROKERFEE_Label = "佣金"; 
        public const char STP_FT_HANDLINGFEE = '5'; 
        public const string STP_FT_HANDLINGFEE_Label = "经手费"; 
        public const char STP_FT_ADMINFEE = '6'; 
        public const string STP_FT_ADMINFEE_Label = "证管费"; 
        public const char STP_FT_OTHERFEE = '7'; 
        public const string STP_FT_OTHERFEE_Label = "其它费"; 
        public const char STP_FT_CLEARINGFEE = 'a'; 
        public const string STP_FT_CLEARINGFEE_Label = "结算费"; 
        public const char STP_FT_SETTLEFEE = 'b'; 
        public const string STP_FT_SETTLEFEE_Label = "交割费"; 
        public const char STP_FT_PERORDER = 'c'; 
        public const string STP_FT_PERORDER_Label = "委托申报费"; 
        public const char STP_FT_PERCANCEL = 'd'; 
        public const string STP_FT_PERCANCEL_Label = "撤单申报费";  
        public const char STP_CT_TOTAL = '1'; 
        public const string STP_CT_TOTAL_Label = "分笔"; 
        public const char STP_CT_PER = '2'; 
        public const string STP_CT_PER_Label = "合笔";  
        public const char STP_CF_ORDER = '1'; 
        public const string STP_CF_ORDER_Label = "普通委托"; 
        public const char STP_CF_CANCEL = '2'; 
        public const string STP_CF_CANCEL_Label = "撤单委托";  
        public const char STP_SRB_FALSE = '0'; 
        public const string STP_SRB_FALSE_Label = "买入证券当天不可用"; 
        public const char STP_SRB_TRUE = '1'; 
        public const string STP_SRB_TRUE_Label = "买入证当天可用";  
        public const char STP_FRB_FALSE = '0'; 
        public const string STP_FRB_FALSE_Label = "卖出资金不可用"; 
        public const char STP_FRB_TRUE = '1'; 
        public const string STP_FRB_TRUE_Label = "卖出资金当天可用";  
        public const char STP_INSTC_LEVEL_PRODUCT_CLASS = '1'; 
        public const string STP_INSTC_LEVEL_PRODUCT_CLASS_Label = "证券类别"; 
        public const char STP_INSTC_LEVEL_SINGLE = '3'; 
        public const string STP_INSTC_LEVEL_SINGLE_Label = "单一证券";  
        public const char STP_INSTC_RANGE_ALL = '1'; 
        public const string STP_INSTC_RANGE_ALL_Label = "所有"; 
        public const char STP_INSTC_RANGE_SET = '3'; 
        public const string STP_INSTC_RANGE_SET_Label = "集合";  
        public const char STP_AR_LEVEL_COMPANY = '1'; 
        public const string STP_AR_LEVEL_COMPANY_Label = "公司"; 
        public const char STP_AR_LEVEL_ACCOUNT = '2'; 
        public const string STP_AR_LEVEL_ACCOUNT_Label = "账户"; 
        public const char STP_AR_LEVEL_COMBO = '3'; 
        public const string STP_AR_LEVEL_COMBO_Label = "组合";  
        public const char STP_AR_RANGE_ALL = '1'; 
        public const string STP_AR_RANGE_ALL_Label = "所有"; 
        public const char STP_AR_RANGE_SET = '3'; 
        public const string STP_AR_RANGE_SET_Label = "集合";  

        /////////////////////////////////////////////////////////////////////////
        ///常量定义
        /////////////////////////////////////////////////////////////////////////
        ///时间长度定义
        public const int STP_TIME_LEN = (9+1) ;
        ///日期长度定义
        public const int STP_DATE_LEN = (8+1) ;

	  
        ///证券代码长度的定义
  	    public const int STP_INSTRUMENTID_LEN = (30 + 1); 
        ///交易所代码长度的定义
  	    public const int STP_EXCHANGEID_LEN = (8 + 1); 
        ///合约名称长度的定义
  	    public const int STP_INSTRUMENTNAME_LEN = (20 + 1); 
        ///产品代码长度的定义
  	    public const int STP_PRODUCTID_LEN = (30 + 1); 
        ///经纪公司代码长度的定义
  	    public const int STP_BROKERID_LEN = (10 + 1); 
        ///柜台代码长度的定义
  	    public const int STP_PROVIDERID_LEN = (10 + 1); 
        ///母账户代码长度的定义
  	    public const int STP_BROKERINVESTORID_LEN = (32 + 1); 
        ///母账户名称长度的定义
  	    public const int STP_BROKERINVESTORNAME_LEN = (80 + 1); 
        ///密码长度的定义
  	    public const int STP_PASSWORD_LEN = (40 + 1); 
        ///期权子账户编码长度的定义
  	    public const int STP_OPTSUBINVESTORID_LEN = (8 + 1); 
        ///席位号长度的定义
  	    public const int STP_BUSINESSUNIT_LEN = (5 + 1); 
        ///营业部代码长度的定义
  	    public const int STP_BRANCHID_LEN = (5 + 1); 
        ///投资者名称长度的定义
  	    public const int STP_INVESTORNAME_LEN = (80 + 1); 
        ///用户代码长度的定义
  	    public const int STP_USERID_LEN = (14 + 1); 
        ///网关登录用户代码长度的定义
  	    public const int STP_GATEWAYUSERID_LEN = (14 + 1); 
        ///用户名称长度的定义
  	    public const int STP_USERNAME_LEN = (80 + 1); 
        ///组合名称长度的定义
  	    public const int STP_COMBONAME_LEN = (80 + 1); 
        ///资产单元编号（UFX Only）长度的定义
  	    public const int STP_ASSETNO_LEN = (16 + 1); 
        ///备注长度的定义
  	    public const int STP_MEMO_LEN = (80 + 1); 
        ///成交编号长度的定义
  	    public const int STP_TRADEID_LEN = (20 + 1); 
        ///报单编号长度的定义
  	    public const int STP_ORDERSYSID_LEN = (16 + 1); 
        ///本地报单编号长度的定义
  	    public const int STP_ORDERLOCALID_LEN = (12 + 1); 
        ///报单引用长度的定义
  	    public const int STP_ORDERREF_LEN = (50 + 1); 
        ///取消报单引用长度的定义
  	    public const int STP_ORDERCANCELREF_LEN = (10 + 1); 
        ///交易所交易员代码长度的定义
  	    public const int STP_BRANCHPBU_LEN = (20 + 1); 
        ///资金账户代码长度的定义
  	    public const int STP_ACCOUNTCODE_LEN = (30 + 1); 
        ///开平标志长度的定义
  	    public const int STP_COMBOSTPETFLAG_LEN = (4 + 1); 
        ///投机套保标志长度的定义
  	    public const int STP_COMBHEDGEFLAG_LEN = (4 + 1); 
        ///被撤单引用长度的定义
  	    public const int STP_ORDERACTIONREF_LEN = (10 + 1); 
        ///状态信息长度的定义
  	    public const int STP_STATUSMSG_LEN = (80 + 1); 
        ///错误信息长度的定义
  	    public const int STP_ERRORMSG_LEN = (80 + 1); 
        ///可用组合列表（以|分割）长度的定义
  	    public const int STP_COMBOIDLIST_LEN = (512 + 1); 
        ///证券交易代码长度的定义
  	    public const int STP_INSTRUMENTCODE_LEN = (20 + 1); 
        ///交易所名称长度的定义
  	    public const int STP_EXCHANGENAME_LEN = (50 + 1); 
        ///席位名称长度的定义
  	    public const int STP_SEATNAME_LEN = (50 + 1); 
        ///证件号长度的定义
  	    public const int STP_IDCARDNO_LEN = (100 + 1); 
        ///投资者账户子编码长度的定义
  	    public const int STP_OPTCLIENTID_LEN = (10 + 1); 
        ///分组编号长度的定义
  	    public const int STP_GROUPID_LEN = (14 + 1); 
        ///分组名称长度的定义
  	    public const int STP_GROUPNAME_LEN = (50 + 1); 
        ///组织架构代码长度的定义
  	    public const int STP_DEPARTMENTID_LEN = (14 + 1); 
        ///组织架构名称长度的定义
  	    public const int STP_DEPTNAME_LEN = (50 + 1); 
        ///操作员名称长度的定义
  	    public const int STP_OPERATORNAME_LEN = (20 + 1); 
        ///产品名称长度的定义
  	    public const int STP_PRODUCTNAME_LEN = (50 + 1); 
        ///投资单元代码长度的定义
  	    public const int STP_INVESTUNITID_LEN = (14 + 1); 
        ///席位号长度的定义
  	    public const int STP_SEATID_LEN = (10 + 1); 
        ///资金账户名称长度的定义
  	    public const int STP_ACCOUNTNAME_LEN = (50 + 1); 
        ///币种代码长度的定义
  	    public const int STP_CURRENCYID_LEN = (3 + 1); 
        ///投资单元名称长度的定义
  	    public const int STP_INVESTUNITNAME_LEN = (50 + 1); 
        ///投资组合代码长度的定义
  	    public const int STP_PORTFOLIOID_LEN = (14 + 1); 
        ///交易编码长度的定义
  	    public const int STP_TRADECODE_LEN = (18 + 1); 
        ///规则代码长度的定义
  	    public const int STP_RULECODE_LEN = (128 + 1); 
        ///规则名称长度的定义
  	    public const int STP_RULENAME_LEN = (50 + 1); 
        ///修改内容明细（json字符串）长度的定义
  	    public const int STP_VALUE_LEN = (768 + 1); 
        ///预留字段1长度的定义
  	    public const int STP_THIRDREFF1_LEN = (20 + 1); 
        ///预留字段2长度的定义
  	    public const int STP_THIRDREFF2_LEN = (50 + 1); 
        ///前置地址长度的定义
  	    public const int STP_FRONTADDRESS_LEN = (31 + 1); 
        ///流文件路径长度的定义
  	    public const int STP_FLOWPATH_LEN = (127 + 1); 
        ///指令代码长度的定义
  	    public const int STP_ADMINCODE_LEN = (32 + 1); 
        ///基础商品代码长度的定义
  	    public const int STP_UNDERLYINGINSTRUMENTID_LEN = (30 + 1); 
        ///投资组合对应的合约代码长度的定义
  	    public const int STP_KEYINSTRUMENTID_LEN = (30 + 1); 
        ///公司名称长度的定义
  	    public const int STP_COMPANYNAME_LEN = (50 + 1); 
        ///操作员角色长度的定义
  	    public const int STP_OPROLES_LEN = (100 + 1); 
        ///(已废除)操作员可以查询的账户集合长度的定义
  	    public const int STP_QRYACCOUNTIDS_LEN = (500 + 1); 
        ///(已废除)操作员可以操作的账户集合长度的定义
  	    public const int STP_OPACCOUNTIDS_LEN = (500 + 1); 
        ///操作员可以查询的组合集合长度的定义
  	    public const int STP_QRYCOMBOIDS_LEN = (500 + 1); 
        ///操作员可以操作的组合集合长度的定义
  	    public const int STP_OPCOMBOIDS_LEN = (500 + 1); 
        ///联系人长度的定义
  	    public const int STP_LINKMAN_LEN = (40 + 1); 
        ///联系地址长度的定义
  	    public const int STP_ADDRESS_LEN = (50 + 1); 
        ///联系电话长度的定义
  	    public const int STP_TEL_LEN = (40 + 1); 
        ///电子邮箱长度的定义
  	    public const int STP_EMAIL_LEN = (40 + 1); 
        ///操作员电话长度的定义
  	    public const int STP_OPTEL_LEN = (40 + 1); 
        ///操作员邮箱长度的定义
  	    public const int STP_OPEMAIL_LEN = (40 + 1); 
        ///注册时间长度的定义
  	    public const int STP_REGIDATE_LEN = (14 + 1); 
        ///修改时间长度的定义
  	    public const int STP_UPTTIME_LEN = (14 + 1); 
        ///登录时间长度的定义
  	    public const int STP_LOGTIME_LEN = (14 + 1); 
        ///密码修改时间长度的定义
  	    public const int STP_PWDUPTTIME_LEN = (14 + 1); 
        ///登录错误时间长度的定义
  	    public const int STP_LOGERRTIME_LEN = (14 + 1); 
        ///权限ID长度的定义
  	    public const int STP_AUTHID_LEN = (8 + 1); 
        ///权限描述长度的定义
  	    public const int STP_AUTHDESC_LEN = (30 + 1); 
        ///父权限长度的定义
  	    public const int STP_PARENTID_LEN = (8 + 1); 
        ///动作长度的定义
  	    public const int STP_ACTION_LEN = (60 + 1); 
        ///动作描述长度的定义
  	    public const int STP_ACTIONDESC_LEN = (3000 + 1); 
        ///保留长度的定义
  	    public const int STP_RESV_LEN = (300 + 1); 
        ///创建时间长度的定义
  	    public const int STP_CRTTIME_LEN = (14 + 1); 
        ///最近一次更新时间长度的定义
  	    public const int STP_LASTUPTTIME_LEN = (14 + 1); 
        ///最近一次使用时间长度的定义
  	    public const int STP_LASTUSRTIME_LEN = (14 + 1); 
        ///接口标识长度的定义
  	    public const int STP_CMDID_LEN = (100 + 1); 
        ///系统流水长度的定义
  	    public const int STP_SYSSEQID_LEN = (10 + 1); 
        ///后缀文件类型长度的定义
  	    public const int STP_FILEPOSTFIX_LEN = (10 + 1); 
        ///角色号长度的定义
  	    public const int STP_ROLEID_LEN = (3 + 1); 
        ///角色名称长度的定义
  	    public const int STP_ROLENAME_LEN = (20 + 1); 
        ///文件名称长度的定义
  	    public const int STP_FILENAME_LEN = (120 + 1); 
        ///文件存储路径长度的定义
  	    public const int STP_FILEURL_LEN = (120 + 1); 
        ///文件查询条件长度的定义
  	    public const int STP_FILEINFO_LEN = (120 + 1); 
        ///序列名称长度的定义
  	    public const int STP_SEQNAME_LEN = (50 + 1); 
        ///连接IP地址白名单长度的定义
  	    public const int STP_IPADDRESS_LEN = (500 + 1); 
        ///最近缴费时间长度的定义
  	    public const int STP_LASTPAYTIME_LEN = (14 + 1); 
        ///缴费时间长度的定义
  	    public const int STP_PAYTIME_LEN = (14 + 1); 
        ///客户号长度的定义
  	    public const int STP_CLIENTID_LEN = (50 + 1); 
        ///通道名称长度的定义
  	    public const int STP_CHANNELNAME_LEN = (50 + 1); 
        ///分仓接口IP长度的定义
  	    public const int STP_SYSIP_LEN = (20 + 1); 
        ///分仓接口端口长度的定义
  	    public const int STP_SYSPORT_LEN = (10 + 1); 
        ///分仓其他配置长度的定义
  	    public const int STP_CHANNELCONFIG_LEN = (256 + 1); 
        ///备注长度的定义
  	    public const int STP_REMARK_LEN = (200 + 1); 
        ///订单IP长度的定义
  	    public const int STP_ORDERIP_LEN = (20 + 1); 
        ///订单MAC长度的定义
  	    public const int STP_ORDERMAC_LEN = (20 + 1); 
        ///订单硬盘序列号长度的定义
  	    public const int STP_ORDERHDNUM_LEN = (50 + 1); 
        ///订单机器码长度的定义
  	    public const int STP_ORDERMACCODE_LEN = (50 + 1); 
        ///订单操作系统长度的定义
  	    public const int STP_ORDEROS_LEN = (50 + 1); 
        ///交易所代码长度的定义
  	    public const int STP_EXCHANGEIDS_LEN = (256 + 1); 
        ///账户集合长度的定义
  	    public const int STP_ACCOUNTIDS_LEN = (512 + 1); 
        ///证券代码集合长度的定义
  	    public const int STP_INSTRUMENTIDS_LEN = (512 + 1); 
        ///O32操作员代码长度的定义
  	    public const int STP_O32OPERATORNO_LEN = (15 + 1); 
        ///O32操作员密码长度的定义
  	    public const int STP_O32OPERATORPWD_LEN = (15 + 1); 
        ///O32基金代码长度的定义
  	    public const int STP_O32ACCOUNTCODE_LEN = (31 + 1); 
        ///O32组合编号长度的定义
  	    public const int STP_O32COMBINO_LEN = (15 + 1); 
        ///O32资产单元编号长度的定义
  	    public const int STP_O32ASSETNO_LEN = (15 + 1); 
        ///操作信息长度的定义
  	    public const int STP_OPERATEMSG_LEN = (240 + 1); 
    };
}

  