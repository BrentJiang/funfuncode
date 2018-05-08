
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    namespace TFDataCS
    {
    /// AdminCodeType��һ������Ա��������
    public enum eTFAdminCode
    {
    [Description("���")]
    CI = 0,
    [Description("����")]
    CO = 1,
    [Description("����")]
    FZ = 2,
    [Description("�ⶳ")]
    UF = 3
    }
    
      /// <summary>
      /// ProductClassType��һ��֤ȯ�������
      /// </summary>
      public enum eTFProductClass
      {
        [Description("�ڻ�")]
        TF_PC_Futures = '1', 
        [Description("��Ȩ")]
        TF_PC_Options = '2', 
        [Description("��Ʊ")]
        TF_PC_Stock = '3', 
        [Description("ծȯ")]
        TF_PC_Bond = '4', 
        [Description("����")]
        TF_PC_Fund = '5', 
        [Description("ָ��")]
        TF_PC_Index = '6', 
        [Description("Ȩ֤")]
        TF_PC_Warrant = '7', 
        [Description("�ع�")]
        TF_PC_Repo = '8', 
        [Description("����")]
        TF_PC_Other = '9', 
      }
    
      /// <summary>
      /// InvestorRangeType��һ��Ͷ���߷�Χ����
      /// </summary>
      public enum eTFInvestorRange
      {
        [Description("����")]
        TF_IR_All = '1', 
        [Description("Ͷ������")]
        TF_IR_Group = '2', 
        [Description("��һͶ����")]
        TF_IR_Single = '3', 
        [Description("����Ͷ�ʵ�Ԫ")]
        TF_IR_AllInvestUnit = '4', 
        [Description("��һͶ�ʵ�Ԫ")]
        TF_IR_SingleInvestUnit = '5', 
      }
    
      /// <summary>
      /// ProviderTypeType��һ����̨��������
      /// </summary>
      public enum eTFProviderType
      {
        [Description("ctp�ڻ�����")]
        TF_PT_CtpFutureTd = '0', 
        [Description("ctp�ڻ�����")]
        TF_PT_CtpFutureMd = '1', 
        [Description("ctp�ڻ���ѯ")]
        TF_PT_CtpFutureQry = '2', 
        [Description("Stp����Ȩ����")]
        TF_PT_STPOptionTd = '3', 
        [Description("Stp����Ȩ��ѯ")]
        TF_PT_STPOptionQry = '4', 
        [Description("Stp�Ĺ�Ʊ����")]
        TF_PT_STPStockTd = '5', 
        [Description("Stp�Ĺ�Ʊ��ѯ")]
        TF_PT_STPStockQry = '6', 
        [Description("Femas�ڻ�����")]
        TF_PT_FemasFutureTd = '7', 
        [Description("Femas�ڻ�����")]
        TF_PT_FemasFutureMd = '8', 
        [Description("Femas�ڻ���ѯ")]
        TF_PT_FemasFutureQry = '9', 
      }
    
      /// <summary>
      /// DirectionType��һ��������������
      /// </summary>
      public enum eTFDirection
      {
        [Description("��")]
        TF_D_Buy = '0', 
        [Description("��")]
        TF_D_Sell = '1', 
        [Description("ETF�깺")]
        TF_D_ETFPur = '2', 
        [Description("ETF���")]
        TF_D_ETFRed = '3', 
        [Description("�ֽ������ֻ�����ر�")]
        TF_D_CashIn = '4', 
        [Description("ծȯ���")]
        TF_D_PledgeBondIn = '5', 
        [Description("ծȯ����")]
        TF_D_PledgeBondOut = '6', 
        [Description("���")]
        TF_D_Doublened = '7', 
        [Description("ת�й�")]
        TF_D_DepositoryTransfer = '8', 
        [Description("�����˻����")]
        TF_D_CreditDoublened = '9', 
        [Description("����Ʒ����")]
        TF_D_BuyCollateral = 'A', 
        [Description("����Ʒ����")]
        TF_D_SellCollateral = 'B', 
        [Description("����Ʒת��")]
        TF_D_CollateralTransferIn = 'C', 
        [Description("����Ʒת��")]
        TF_D_CollateralTransferOut = 'D', 
        [Description("��������")]
        TF_D_MarginTrade = 'E', 
        [Description("��ȯ����")]
        TF_D_ShortSell = 'F', 
        [Description("��ȯ����")]
        TF_D_RepayMargin = 'G', 
        [Description("��ȯ��ȯ")]
        TF_D_RepayStock = 'H', 
        [Description("ֱ�ӻ���")]
        TF_D_DirectRepayMargin = 'I', 
        [Description("ֱ�ӻ�ȯ")]
        TF_D_DirectRepayStock = 'J', 
        [Description("��ȯ��ת")]
        TF_D_ExcessStockTransfer = 'K', 
        [Description("OF�깺")]
        TF_D_OFPur = 'L', 
        [Description("OF���")]
        TF_D_OFRed = 'M', 
        [Description("SF���")]
        TF_D_SFSplit = 'N', 
        [Description("SF�ϲ�")]
        TF_D_SFMerge = 'O', 
        [Description("����")]
        TF_D_Covered = 'P', 
        [Description("֤ȯ����(��)/�ⶳ(ƽ)")]
        TF_D_Freeze = 'Q', 
        [Description("��Ȩ")]
        TF_D_Execute = 'R', 
        [Description("CB����")]
        TF_D_CBRed = 'S', 
        [Description("CBת��")]
        TF_D_CBConv = 'T', 
        [Description("OF�Ϲ�")]
        TF_D_OFSub = 'U', 
      }
    
      /// <summary>
      /// QryAccountTypeType��һ����ѯ�˻���������
      /// </summary>
      public enum eTFQryAccountType
      {
        [Description("����")]
        TF_QAT_Operate = '0', 
        [Description("��ѯ")]
        TF_QAT_Query = '1', 
      }
    
      /// <summary>
      /// HedgeFlagType��һ��Ͷ���ױ���־����
      /// </summary>
      public enum eTFHedgeFlag
      {
        [Description("Ͷ��")]
        TF_HF_Speculation = '1', 
        [Description("����")]
        TF_HF_Arbitrage = '2', 
        [Description("�ױ�")]
        TF_HF_Hedge = '3', 
        [Description("������")]
        TF_HF_MarketMaker = '4', 
      }
    
      /// <summary>
      /// UserTypeType��һ���û���������
      /// </summary>
      public enum eTFUserType
      {
        [Description("Ͷ����")]
        TF_UT_Investor = '0', 
        [Description("����Ա")]
        TF_UT_Operator = '1', 
        [Description("����Ա")]
        TF_UT_SuperUser = '2', 
      }
    
      /// <summary>
      /// CoveredFlagType��һ�����ұ�־����
      /// </summary>
      public enum eTFCoveredFlag
      {
        [Description("�Ǳ���")]
        TF_CF_Uncovered = '0', 
        [Description("����")]
        TF_CF_Covered = '1', 
      }
    
      /// <summary>
      /// OwnerTypeType��һ�������־����
      /// </summary>
      public enum eTFOwnerType
      {
        [Description("����Ͷ����")]
        TF_OT_0 = '0', 
        [Description("����������")]
        TF_OT_1 = '1', 
        [Description("��Ȩ��Ӫ����")]
        TF_OT_2 = '2', 
        [Description("����Ͷ���߷���")]
        TF_OT_3 = '3', 
        [Description("��Ӫ���׷���")]
        TF_OT_4 = '4', 
        [Description("�����Է����ṩ�̷���")]
        TF_OT_5 = '5', 
      }
    
      /// <summary>
      /// InvestorLevelType��һ��Ͷ���߽��׵ȼ�����
      /// </summary>
      public enum eTFInvestorLevel
      {
        [Description("һ��")]
        TF_IL_1 = '0', 
        [Description("����")]
        TF_IL_2 = '1', 
        [Description("����")]
        TF_IL_3 = '2', 
        [Description("�ǽ��׼��𣬴˼���investor���ɽ���")]
        TF_IL_9 = '9', 
      }
    
      /// <summary>
      /// OffsetFlagType��һ����ƽ��־����
      /// </summary>
      public enum eTFOffsetFlag
      {
        [Description("����")]
        TF_OF_Open = '0', 
        [Description("ƽ��")]
        TF_OF_Close = '1', 
        [Description("ǿƽ")]
        TF_OF_ForceClose = '2', 
        [Description("ƽ��")]
        TF_OF_CloseToday = '3', 
        [Description("ƽ��")]
        TF_OF_CloseYesterday = '4', 
        [Description("ǿ��")]
        TF_OF_ForceOff = '5', 
        [Description("����ǿƽ")]
        TF_OF_LocalForceClose = '6', 
        [Description("�Զ�����ƽ��ƽ���ж�(�ݲ�֧�֣�")]
        TF_OF_Auto = '7', 
        [Description("�Ϲ�")]
        TF_OF_Call = '8', 
        [Description("�Ϲ�")]
        TF_OF_Put = '9', 
      }
    
      /// <summary>
      /// OrderPriceTypeType��һ�������۸���������
      /// </summary>
      public enum eTFOrderPriceType
      {
        [Description("�����")]
        TF_OPT_AnyPrice = '1', 
        [Description("�޼�")]
        TF_OPT_LimitPrice = '2', 
        [Description("���ż�")]
        TF_OPT_BestPrice = '3', 
        [Description("���¼�")]
        TF_OPT_LastPrice = '4', 
        [Description("�������¼�")]
        TF_OPT_LocalBestPrice = '5', 
        [Description("�嵵���ż�")]
        TF_OPT_FiveLevelPrice = '6', 
        [Description("ETF�깺")]
        TF_OPT_PurchasesETF  = 'd', 
        [Description("ETF���")]
        TF_OPT_RedeemETF = 'e', 
      }
    
      /// <summary>
      /// TimeConditionType��һ����Ч����������
      /// </summary>
      public enum eTFTimeCondition
      {
        [Description("������ɣ�������")]
        TF_TC_IOC = '1', 
        [Description("������Ч")]
        TF_TC_GFS = '2', 
        [Description("������Ч")]
        TF_TC_GFD = '3', 
        [Description("ָ������ǰ��Ч")]
        TF_TC_GTD = '4', 
        [Description("����ǰ��Ч")]
        TF_TC_GTC = '5', 
        [Description("���Ͼ�����Ч")]
        TF_TC_GFA = '6', 
      }
    
      /// <summary>
      /// VolumeConditionType��һ���ɽ�����������
      /// </summary>
      public enum eTFVolumeCondition
      {
        [Description("�κ�����")]
        TF_VC_AV = '1', 
        [Description("��С����")]
        TF_VC_MV = '2', 
        [Description("ȫ������")]
        TF_VC_CV = '3', 
      }
    
      /// <summary>
      /// ContingentConditionType��һ��������������
      /// </summary>
      public enum eTFContingentCondition
      {
        [Description("����")]
        TF_CC_Immediately = '1', 
        [Description("ֹ��")]
        TF_CC_Touch = '2', 
        [Description("ֹӮ")]
        TF_CC_TouchProfit = '3', 
        [Description("Ԥ��")]
        TF_CC_ParkedOrder = '4', 
      }
    
      /// <summary>
      /// OrderStatusType��һ������״̬����
      /// </summary>
      public enum eTFOrderStatus
      {
        [Description("����")]
        TF_OST_Unknown = '0', 
        [Description("����")]
        TF_OST_PendingNew = '1', 
        [Description("�ѱ�")]
        TF_OST_New = '2', 
        [Description("����")]
        TF_OST_PartilyFilled = '3', 
        [Description("�ѳ�")]
        TF_OST_Filled = '4', 
        [Description("����")]
        TF_OST_PartilyCanceled = '5', 
        [Description("�ѳ�")]
        TF_OST_Canceled = '6', 
        [Description("�ϵ�")]
        TF_OST_Rejected = '7', 
      }
    
      /// <summary>
      /// OrderTypeType��һ��������������
      /// </summary>
      public enum eTFOrderType
      {
        [Description("����")]
        TF_ORDT_Normal = '0', 
        [Description("��������")]
        TF_ORDT_DeriveFromQuote = '1', 
        [Description("�������")]
        TF_ORDT_DeriveFromCombination = '2', 
        [Description("��ϱ���")]
        TF_ORDT_Combination = '3', 
        [Description("������")]
        TF_ORDT_ConditionalOrder = '4', 
        [Description("������")]
        TF_ORDT_Swap = '5', 
      }
    
      /// <summary>
      /// PosiDirectionType��һ���ֲֶ�շ�������
      /// </summary>
      public enum eTFPosiDirection
      {
        [Description("��ͷ")]
        TF_PD_Short = '1', 
        [Description("��ͷ")]
        TF_PD_Long = '0', 
      }
    
      /// <summary>
      /// ChangeTypeType��һ���䶯��������
      /// </summary>
      public enum eTFChangeType
      {
        [Description("�˶�ֵ")]
        TF_CGT_check = '1', 
        [Description("���Ṧ��")]
        TF_CGT_fronzen = '2', 
        [Description("��ǰֵ")]
        TF_CGT_current = '3', 
        [Description("�ֲֳɱ�")]
        TF_CGT_cost = '4', 
      }
    
      /// <summary>
      /// CapitalDirectionType��һ���ʽ�仯��������
      /// </summary>
      public enum eTFCapitalDirection
      {
        [Description("����")]
        TF_CPD_Nochange = '0', 
        [Description("����")]
        TF_CPD_Increase = '1', 
        [Description("����")]
        TF_CPD_Decrease = '2', 
      }
    
      /// <summary>
      /// PositionDirectionType��һ���ֱֲ仯��������
      /// </summary>
      public enum eTFPositionDirection
      {
        [Description("����")]
        TF_PSD_Nochange = '0', 
        [Description("����")]
        TF_PSD_Increase = '1', 
        [Description("����")]
        TF_PSD_Decrease = '2', 
      }
    
      /// <summary>
      /// PositionDateType��һ���ֲ����ڱ�־����
      /// </summary>
      public enum eTFPositionDate
      {
        [Description("���ճֲ�")]
        TF_PSD_Today = '1', 
        [Description("��ʷ�ֲ�")]
        TF_PSD_History = '2', 
      }
    
      /// <summary>
      /// TradingPhaseType��һ�����׽׶�����
      /// </summary>
      public enum eTFTradingPhase
      {
        [Description("�ǽ���ʱ��")]
        TF_TP_NonTrade = '0', 
        [Description("���Ͼ���ʱ��")]
        TF_TP_Bidding = '1', 
        [Description("��������ʱ��")]
        TF_TP_Continuous = '2', 
        [Description("ͣ��ʱ��")]
        TF_TP_Suspension = '3', 
        [Description("�۶�ʱ��")]
        TF_TP_Fuse = '4', 
      }
    
      /// <summary>
      /// OpenRestrictionType��һ��������������
      /// </summary>
      public enum eTFOpenRestriction
      {
        [Description("�޿�������")]
        TF_OR_None = '0', 
        [Description("���Ʊ��ҿ���")]
        TF_OR_NoCoverOpen = '1', 
        [Description("������������")]
        TF_OR_NoSellOpen = '2', 
        [Description("�����������֡����ҿ���")]
        TF_OR_NoSellAndCoverOpen = '3', 
        [Description("�������뿪��")]
        TF_OR_NoBuyOpen = '4', 
        [Description("�������뿪�֡����ҿ���")]
        TF_OR_NoBuyAndCoverOpen = '5', 
        [Description("�������뿪�֡���������")]
        TF_OR_NoBuyAndSellOpen = '6', 
        [Description("�������뿪�֡��������֡����ҿ���")]
        TF_OR_NoBuySellAndCoverOpen = '7', 
      }
    
      /// <summary>
      /// PositionTypeType��һ���ֲ���������
      /// </summary>
      public enum eTFPositionType
      {
        [Description("���ֲ�")]
        TF_PT_Net = '1', 
        [Description("�ۺϳֲ�")]
        TF_PT_Gross = '2', 
      }
    
      /// <summary>
      /// PositionDateTypeType��һ���ֲ�������������
      /// </summary>
      public enum eTFPositionDateType
      {
        [Description("ʹ����ʷ�ֲ�")]
        TF__UseHistory = '1', 
        [Description("��ʹ����ʷ�ֲ�")]
        TF__NoUseHistory = '2', 
      }
    
      /// <summary>
      /// InvestorTypeType��һ��Ͷ������������
      /// </summary>
      public enum eTFInvestorType
      {
        [Description("��Ȼ��")]
        TF_IT_Person = '1', 
        [Description("����")]
        TF_IT_Company = '2', 
        [Description("Ͷ�ʻ���")]
        TF_IT_Fund = '3', 
        [Description("���ⷨ��")]
        TF_IT_SpecialOrgan = '4', 
        [Description("�ʹܻ�")]
        TF_IT_Asset = '5', 
        [Description("ϵͳ����Ա")]
        TF_IT_Admin = 'a', 
      }
    
      /// <summary>
      /// IDCardTypeType��һ��֤����������
      /// </summary>
      public enum eTFIDCardType
      {
        [Description("��֯��������")]
        TF_DCT_EID = '0', 
        [Description("�й��������֤")]
        TF_DCT_IDCard = '1', 
        [Description("����֤")]
        TF_DCT_OfficerIDCard = '2', 
        [Description("����֤")]
        TF_DCT_PoliceIDCard = '3', 
        [Description("ʿ��֤")]
        TF_DCT_SoldierIDCard = '4', 
        [Description("���ڲ�")]
        TF_DCT_HouseholdRegister  = '5', 
        [Description("����")]
        TF_DCT_Passport = '6', 
        [Description("̨��֤")]
        TF_DCT_TaiwanCompatriotIDCard  = '7', 
        [Description("����֤")]
        TF_DCT_HomeComingCard = '8', 
        [Description("Ӫҵִ�պ�")]
        TF_DCT_LicenseNo = '9', 
        [Description("˰��ǼǺ�/������˰ID")]
        TF_DCT_TaxNo = 'A', 
        [Description("�۰ľ��������ڵ�ͨ��֤")]
        TF_DCT_HMMainlandTravelPermit  = 'B', 
        [Description("̨�����������½ͨ��֤")]
        TF_DCT_TwMainlandTravelPermit = 'C', 
        [Description("����")]
        TF_DCT_DrivingLicense = 'D', 
        [Description("�����籣ID")]
        TF_DCT_SocialID = 'F', 
        [Description("�������֤")]
        TF_DCT_LocalID = 'G', 
        [Description("��ҵ�Ǽ�֤")]
        TF_DCT_BusinessRegistration  = 'H', 
        [Description("�۰������Ծ������֤")]
        TF_DCT_HKMCIDCard  = 'I', 
        [Description("���п������֤")]
        TF_DCT_AccountsPermits = 'J', 
        [Description("��������þ���֤")]
        TF_DCT_PermanantResidence = 'K', 
        [Description("�ʹܲ�Ʒ������")]
        TF_DCT_AssetProductRecord = 'L', 
        [Description("����֤��")]
        TF_DCT_OtherCard = 'x', 
      }
    
      /// <summary>
      /// TradingCodeTypeType��һ�����ױ�����������
      /// </summary>
      public enum eTFTradingCodeType
      {
        [Description("Ͷ��")]
        TF_TC_Speculation = '1', 
        [Description("����")]
        TF_TC_Arbitrage = '2', 
        [Description("�ױ�")]
        TF_TC_Hedge = '3', 
        [Description("������")]
        TF_TC_MarketMaker = '4', 
      }
    
      /// <summary>
      /// OptCommissionTypeType��һ����Ȩ������������
      /// </summary>
      public enum eTFOptCommissionType
      {
        [Description("��Ȩ��")]
        TF_OPT_CT_StrikeFee = '1', 
        [Description("����Ȩ��")]
        TF_OPT_CT_BeStrikeDFee = '2', 
        [Description("��Ȩ������")]
        TF_OPT_CT_TransferFee = '3', 
        [Description("���ַ�")]
        TF_OPT_CT_Brokerage = '4', 
        [Description("���׷�")]
        TF_OPT_CT_TradeFee = '5', 
        [Description("�����")]
        TF_OPT_CT_SettleFee = '6', 
      }
    
      /// <summary>
      /// CommDirectionType��һ��ί�з�������
      /// </summary>
      public enum eTFCommDirection
      {
        [Description("��")]
        TF_CD_BuyOpen = '1', 
        [Description("��ƽ")]
        TF_CD_BuyClose = '2', 
        [Description("����")]
        TF_CD_SellOpen = '3', 
        [Description("��ƽ")]
        TF_CD_SellClose = '4', 
        [Description("��Ȩ�Ϲ�")]
        TF_CD_CallStrike = '5', 
        [Description("��Ȩ�Ϲ�")]
        TF_CD_PutStrike = '6', 
      }
    
      /// <summary>
      /// RateTypeType��һ�����㷽ʽ����
      /// </summary>
      public enum eTFRateType
      {
        [Description("������")]
        TF_RT_ByVolume = '1', 
        [Description("�����")]
        TF_RT_ByMoney = '2', 
        [Description("����ֵ")]
        TF_RT_ByFace = '3', 
      }
    
      /// <summary>
      /// OperationTypeType��һ��������������
      /// </summary>
      public enum eTFOperationType
      {
        [Description("�ճ�ͬ������")]
        TF_OPNT_Sync = '1', 
        [Description("����ָ�����")]
        TF_OPNT_Admin = '2', 
        [Description("�����ֲֵ�������")]
        TF_OPNT_Settle = '3', 
        [Description("��������")]
        TF_OPNT_Other = '0', 
      }
    
      /// <summary>
      /// OptionTypeType��һ����Ȩ��������
      /// </summary>
      public enum eTFOptionType
      {
        [Description("�Ϲ�")]
        TF_OPT_TY_Call = 'C', 
        [Description("�Ϲ�")]
        TF_OPT_TY_Put = 'P', 
      }
    
      /// <summary>
      /// SystemStatusType��һ��ϵͳ״̬����
      /// </summary>
      public enum eTFSystemStatus
      {
        [Description("�����������")]
        TF_STS_SyncDone = '1', 
        [Description("���н���״̬")]
        TF_STS_Trading = '2', 
        [Description("�������")]
        TF_STS_Closed = '3', 
        [Description("�������")]
        TF_STS_Settled = '4', 
      }
    
      /// <summary>
      /// InstrumentRangeType��һ����Լ��Χ����
      /// </summary>
      public enum eTFInstrumentRange
      {
        [Description("����")]
        TF_INSTR_ALL = '1', 
        [Description("֤ȯ���")]
        TF_INSTR_PRODUCT_CLASS = '2', 
        [Description("��һ��Լ")]
        TF_INSTR_SINGLE = '3', 
      }
    
      /// <summary>
      /// SeatTypeType��һ��ϯλ��������
      /// </summary>
      public enum eTFSeatType
      {
        [Description("�Ͻ�����Ȩ")]
        TF_ST_SHOPT = '1', 
        [Description("�Ͻ�����Ʊ")]
        TF_ST_SHSTK = '2', 
        [Description("�����Ȩ")]
        TF_ST_SZOPT = '3', 
        [Description("�����Ʊ")]
        TF_ST_SZSTK = '4', 
        [Description("����")]
        TF_ST_FEMAS = '5', 
      }
    
      /// <summary>
      /// ResumeTypeType��һ��˽�����ش���ʽ����
      /// </summary>
      public enum eTFResumeType
      {
        [Description("�ش�")]
        TF_RT_Restart = '0', 
        [Description("����")]
        TF_RT_Resume = '1', 
        [Description("��ǰ��ʼ")]
        TF_RT_Quick = '2', 
      }
    
      /// <summary>
      /// CompanyTypeType��һ����˾��������
      /// </summary>
      public enum eTFCompanyType
      {
        [Description("�ڲ�����")]
        TF_CT_INSIDE = '1', 
        [Description("�����ͻ�")]
        TF_CT_ORGAN = '2', 
        [Description("���˿ͻ�")]
        TF_CT_USER = '3', 
      }
    
      /// <summary>
      /// EnbFlagType��һ��״̬��־����
      /// </summary>
      public enum eTFEnbFlag
      {
        [Description("����")]
        TF_EF_NORMAL = 'N', 
        [Description("���ر�")]
        TF_EF_OFF = 'C', 
        [Description("����")]
        TF_EF_LOCK = 'L', 
        [Description("����δͬ��")]
        TF_EF_UNSYNC = '1', 
      }
    
      /// <summary>
      /// ActionTypeType��һ��������������
      /// </summary>
      public enum eTFActionType
      {
        [Description("�ͻ���")]
        TF_ACT_CLIENT = '1', 
        [Description("web��")]
        TF_ACT_WEB = '2', 
        [Description("����ƽ̨")]
        TF_ACT_MARKET = '3', 
      }
    
      /// <summary>
      /// AuthTypeType��һ��Ȩ����������
      /// </summary>
      public enum eTFAuthType
      {
        [Description("ͨ��")]
        TF_AUT_GENERAL = '0', 
        [Description("ȯ���ڲ�")]
        TF_AUT_INSIDE = '1', 
        [Description("�ⲿ�ͻ�")]
        TF_AUT_OUTSIDE = '2', 
      }
    
      /// <summary>
      /// FileFlagType��һ������ִ��״̬����
      /// </summary>
      public enum eTFFileFlag
      {
        [Description("������")]
        TF__InProgress = 'I', 
        [Description("���ɳɹ�")]
        TF__Success = 'S', 
        [Description("����ʧ��")]
        TF__Fail = 'F', 
      }
    
      /// <summary>
      /// MarketDataTypeType��һ������������������
      /// </summary>
      public enum eTFMarketDataType
      {
        [Description("ʵʱ����")]
        TF_MDT_REAL = '0', 
        [Description("��ʷ����")]
        TF_MDT_HIS = '1', 
      }
    
      /// <summary>
      /// PaySubjectType��һ���ɷѿ�Ŀ����
      /// </summary>
      public enum eTFPaySubject
      {
        [Description("ͨ�÷���")]
        TF_PSJ_GENERAL = '1', 
      }
    
      /// <summary>
      /// AccountTypeType��һ���˻���������
      /// </summary>
      public enum eTFAccountType
      {
        [Description("��֤ͨȯ�˻�")]
        TF_AT_STOCK = '1', 
        [Description("�����˻�")]
        TF_AT_CREDIT = '2', 
        [Description("����Ʒ�˻�")]
        TF_AT_DERIVATIVE = '3', 
        [Description("�ڻ��˻�")]
        TF_AT_FUTURES = '4', 
      }
    
      /// <summary>
      /// ChannelTypeType��һ��ͨ����������
      /// </summary>
      public enum eTFChannelType
      {
        [Description("UFT�ֲ�")]
        TF_CHT_UFT = '1', 
        [Description("CTP�ֲ�")]
        TF_CHT_CTP = '2', 
        [Description("����ֲ�")]
        TF_CHT_FEMAS = '3', 
        [Description("O32�ֲ�")]
        TF_CHT_O32 = '4', 
        [Description("ģ�⽻����")]
        TF_CHT_SIMULATE = '5', 
      }
    
      /// <summary>
      /// FeeTypeType��һ�������������
      /// </summary>
      public enum eTFFeeType
      {
        [Description("���׷�")]
        TF_FT_TRADEFEE = '1', 
        [Description("ӡ��˰")]
        TF_FT_STAMPTAX = '2', 
        [Description("������")]
        TF_FT_TRANSFERFEE = '3', 
        [Description("Ӷ��")]
        TF_FT_BROKERFEE = '4', 
        [Description("���ַ�")]
        TF_FT_HANDLINGFEE = '5', 
        [Description("֤�ܷ�")]
        TF_FT_ADMINFEE = '6', 
        [Description("������")]
        TF_FT_OTHERFEE = '7', 
        [Description("�����")]
        TF_FT_CLEARINGFEE = 'a', 
        [Description("�����")]
        TF_FT_SETTLEFEE = 'b', 
        [Description("ί���걨��")]
        TF_FT_PERORDER = 'c', 
        [Description("�����걨��")]
        TF_FT_PERCANCEL = 'd', 
      }
    
      /// <summary>
      /// CalculateTypeType��һ�����ü���ģʽ����
      /// </summary>
      public enum eTFCalculateType
      {
        [Description("�ֱ�")]
        TF_CT_TOTAL = '1', 
        [Description("�ϱ�")]
        TF_CT_PER = '2', 
      }
    
      /// <summary>
      /// CancelFlagType��һ��������־����
      /// </summary>
      public enum eTFCancelFlag
      {
        [Description("��ͨί��")]
        TF_CF_ORDER = '1', 
        [Description("����ί��")]
        TF_CF_CANCEL = '2', 
      }
    
      /// <summary>
      /// StockRealBackType��һ���ر�֤ȯ��־����
      /// </summary>
      public enum eTFStockRealBack
      {
        [Description("����֤ȯ���첻����")]
        TF_SRB_FALSE = '0', 
        [Description("����֤�������")]
        TF_SRB_TRUE = '1', 
      }
    
      /// <summary>
      /// FundRealBackType��һ���ر��ʽ��־����
      /// </summary>
      public enum eTFFundRealBack
      {
        [Description("�����ʽ𲻿���")]
        TF_FRB_FALSE = '0', 
        [Description("�����ʽ������")]
        TF_FRB_TRUE = '1', 
      }
    
      /// <summary>
      /// InstrumentControlLevelType��һ��֤ȯ���Ʋ㼶����
      /// </summary>
      public enum eTFInstrumentControlLevel
      {
        [Description("֤ȯ���")]
        TF_INSTC_LEVEL_PRODUCT_CLASS = '1', 
        [Description("��һ֤ȯ")]
        TF_INSTC_LEVEL_SINGLE = '3', 
      }
    
      /// <summary>
      /// InstrumentRangeTypeType��һ��֤ȯ��Χ����
      /// </summary>
      public enum eTFInstrumentRangeType
      {
        [Description("����")]
        TF_INSTC_RANGE_ALL = '1', 
        [Description("����")]
        TF_INSTC_RANGE_SET = '3', 
      }
    
      /// <summary>
      /// AccountControlLevelType��һ���˻����Ͽ��Ʋ㼶����
      /// </summary>
      public enum eTFAccountControlLevel
      {
        [Description("��˾")]
        TF_AR_LEVEL_COMPANY = '1', 
        [Description("�˻�")]
        TF_AR_LEVEL_ACCOUNT = '2', 
        [Description("���")]
        TF_AR_LEVEL_COMBO = '3', 
      }
    
      /// <summary>
      /// AccountRangeTypeType��һ���˻����Ϸ�Χ����
      /// </summary>
      public enum eTFAccountRangeType
      {
        [Description("����")]
        TF_AR_RANGE_ALL = '1', 
        [Description("����")]
        TF_AR_RANGE_SET = '3', 
      }
    
    }
  