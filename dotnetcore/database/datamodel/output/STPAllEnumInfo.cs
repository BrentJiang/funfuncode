
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;

    namespace TFDataCS
    {
    /// AdminCodeType是一个管理员命令类型
    public enum eTFAdminCode
    {
    [Description("入金")]
    CI = 0,
    [Description("出金")]
    CO = 1,
    [Description("冻结")]
    FZ = 2,
    [Description("解冻")]
    UF = 3
    }
    
      /// <summary>
      /// ProductClassType是一个证券类别类型
      /// </summary>
      public enum eTFProductClass
      {
        [Description("期货")]
        TF_PC_Futures = '1', 
        [Description("期权")]
        TF_PC_Options = '2', 
        [Description("股票")]
        TF_PC_Stock = '3', 
        [Description("债券")]
        TF_PC_Bond = '4', 
        [Description("基金")]
        TF_PC_Fund = '5', 
        [Description("指数")]
        TF_PC_Index = '6', 
        [Description("权证")]
        TF_PC_Warrant = '7', 
        [Description("回购")]
        TF_PC_Repo = '8', 
        [Description("其他")]
        TF_PC_Other = '9', 
      }
    
      /// <summary>
      /// InvestorRangeType是一个投资者范围类型
      /// </summary>
      public enum eTFInvestorRange
      {
        [Description("所有")]
        TF_IR_All = '1', 
        [Description("投资者组")]
        TF_IR_Group = '2', 
        [Description("单一投资者")]
        TF_IR_Single = '3', 
        [Description("所有投资单元")]
        TF_IR_AllInvestUnit = '4', 
        [Description("单一投资单元")]
        TF_IR_SingleInvestUnit = '5', 
      }
    
      /// <summary>
      /// ProviderTypeType是一个柜台类型类型
      /// </summary>
      public enum eTFProviderType
      {
        [Description("ctp期货交易")]
        TF_PT_CtpFutureTd = '0', 
        [Description("ctp期货行情")]
        TF_PT_CtpFutureMd = '1', 
        [Description("ctp期货查询")]
        TF_PT_CtpFutureQry = '2', 
        [Description("Stp的期权交易")]
        TF_PT_STPOptionTd = '3', 
        [Description("Stp的期权查询")]
        TF_PT_STPOptionQry = '4', 
        [Description("Stp的股票交易")]
        TF_PT_STPStockTd = '5', 
        [Description("Stp的股票查询")]
        TF_PT_STPStockQry = '6', 
        [Description("Femas期货交易")]
        TF_PT_FemasFutureTd = '7', 
        [Description("Femas期货行情")]
        TF_PT_FemasFutureMd = '8', 
        [Description("Femas期货查询")]
        TF_PT_FemasFutureQry = '9', 
      }
    
      /// <summary>
      /// DirectionType是一个买卖方向类型
      /// </summary>
      public enum eTFDirection
      {
        [Description("买")]
        TF_D_Buy = '0', 
        [Description("卖")]
        TF_D_Sell = '1', 
        [Description("ETF申购")]
        TF_D_ETFPur = '2', 
        [Description("ETF赎回")]
        TF_D_ETFRed = '3', 
        [Description("现金替代，只用作回报")]
        TF_D_CashIn = '4', 
        [Description("债券入库")]
        TF_D_PledgeBondIn = '5', 
        [Description("债券出库")]
        TF_D_PledgeBondOut = '6', 
        [Description("配股")]
        TF_D_Doublened = '7', 
        [Description("转托管")]
        TF_D_DepositoryTransfer = '8', 
        [Description("信用账户配股")]
        TF_D_CreditDoublened = '9', 
        [Description("担保品买入")]
        TF_D_BuyCollateral = 'A', 
        [Description("担保品卖出")]
        TF_D_SellCollateral = 'B', 
        [Description("担保品转入")]
        TF_D_CollateralTransferIn = 'C', 
        [Description("担保品转出")]
        TF_D_CollateralTransferOut = 'D', 
        [Description("融资买入")]
        TF_D_MarginTrade = 'E', 
        [Description("融券卖出")]
        TF_D_ShortSell = 'F', 
        [Description("卖券还款")]
        TF_D_RepayMargin = 'G', 
        [Description("买券还券")]
        TF_D_RepayStock = 'H', 
        [Description("直接还款")]
        TF_D_DirectRepayMargin = 'I', 
        [Description("直接还券")]
        TF_D_DirectRepayStock = 'J', 
        [Description("余券划转")]
        TF_D_ExcessStockTransfer = 'K', 
        [Description("OF申购")]
        TF_D_OFPur = 'L', 
        [Description("OF赎回")]
        TF_D_OFRed = 'M', 
        [Description("SF拆分")]
        TF_D_SFSplit = 'N', 
        [Description("SF合并")]
        TF_D_SFMerge = 'O', 
        [Description("备兑")]
        TF_D_Covered = 'P', 
        [Description("证券冻结(开)/解冻(平)")]
        TF_D_Freeze = 'Q', 
        [Description("行权")]
        TF_D_Execute = 'R', 
        [Description("CB回售")]
        TF_D_CBRed = 'S', 
        [Description("CB转股")]
        TF_D_CBConv = 'T', 
        [Description("OF认购")]
        TF_D_OFSub = 'U', 
      }
    
      /// <summary>
      /// QryAccountTypeType是一个查询账户类型类型
      /// </summary>
      public enum eTFQryAccountType
      {
        [Description("操作")]
        TF_QAT_Operate = '0', 
        [Description("查询")]
        TF_QAT_Query = '1', 
      }
    
      /// <summary>
      /// HedgeFlagType是一个投机套保标志类型
      /// </summary>
      public enum eTFHedgeFlag
      {
        [Description("投机")]
        TF_HF_Speculation = '1', 
        [Description("套利")]
        TF_HF_Arbitrage = '2', 
        [Description("套保")]
        TF_HF_Hedge = '3', 
        [Description("做市商")]
        TF_HF_MarketMaker = '4', 
      }
    
      /// <summary>
      /// UserTypeType是一个用户类型类型
      /// </summary>
      public enum eTFUserType
      {
        [Description("投资者")]
        TF_UT_Investor = '0', 
        [Description("操作员")]
        TF_UT_Operator = '1', 
        [Description("管理员")]
        TF_UT_SuperUser = '2', 
      }
    
      /// <summary>
      /// CoveredFlagType是一个备兑标志类型
      /// </summary>
      public enum eTFCoveredFlag
      {
        [Description("非备兑")]
        TF_CF_Uncovered = '0', 
        [Description("备兑")]
        TF_CF_Covered = '1', 
      }
    
      /// <summary>
      /// OwnerTypeType是一个发起标志类型
      /// </summary>
      public enum eTFOwnerType
      {
        [Description("个人投资者")]
        TF_OT_0 = '0', 
        [Description("交易所发起")]
        TF_OT_1 = '1', 
        [Description("期权经营机构")]
        TF_OT_2 = '2', 
        [Description("机构投资者发起")]
        TF_OT_3 = '3', 
        [Description("自营交易发起")]
        TF_OT_4 = '4', 
        [Description("流动性服务提供商发起")]
        TF_OT_5 = '5', 
      }
    
      /// <summary>
      /// InvestorLevelType是一个投资者交易等级类型
      /// </summary>
      public enum eTFInvestorLevel
      {
        [Description("一级")]
        TF_IL_1 = '0', 
        [Description("二级")]
        TF_IL_2 = '1', 
        [Description("三级")]
        TF_IL_3 = '2', 
        [Description("非交易级别，此级别investor不可交易")]
        TF_IL_9 = '9', 
      }
    
      /// <summary>
      /// OffsetFlagType是一个开平标志类型
      /// </summary>
      public enum eTFOffsetFlag
      {
        [Description("开仓")]
        TF_OF_Open = '0', 
        [Description("平仓")]
        TF_OF_Close = '1', 
        [Description("强平")]
        TF_OF_ForceClose = '2', 
        [Description("平今")]
        TF_OF_CloseToday = '3', 
        [Description("平昨")]
        TF_OF_CloseYesterday = '4', 
        [Description("强减")]
        TF_OF_ForceOff = '5', 
        [Description("本地强平")]
        TF_OF_LocalForceClose = '6', 
        [Description("自动进行平昨平今判断(暂不支持）")]
        TF_OF_Auto = '7', 
        [Description("认购")]
        TF_OF_Call = '8', 
        [Description("认沽")]
        TF_OF_Put = '9', 
      }
    
      /// <summary>
      /// OrderPriceTypeType是一个报单价格条件类型
      /// </summary>
      public enum eTFOrderPriceType
      {
        [Description("任意价")]
        TF_OPT_AnyPrice = '1', 
        [Description("限价")]
        TF_OPT_LimitPrice = '2', 
        [Description("最优价")]
        TF_OPT_BestPrice = '3', 
        [Description("最新价")]
        TF_OPT_LastPrice = '4', 
        [Description("本方最新价")]
        TF_OPT_LocalBestPrice = '5', 
        [Description("五档最优价")]
        TF_OPT_FiveLevelPrice = '6', 
        [Description("ETF申购")]
        TF_OPT_PurchasesETF  = 'd', 
        [Description("ETF赎回")]
        TF_OPT_RedeemETF = 'e', 
      }
    
      /// <summary>
      /// TimeConditionType是一个有效期类型类型
      /// </summary>
      public enum eTFTimeCondition
      {
        [Description("立即完成，否则撤销")]
        TF_TC_IOC = '1', 
        [Description("本节有效")]
        TF_TC_GFS = '2', 
        [Description("当日有效")]
        TF_TC_GFD = '3', 
        [Description("指定日期前有效")]
        TF_TC_GTD = '4', 
        [Description("撤销前有效")]
        TF_TC_GTC = '5', 
        [Description("集合竞价有效")]
        TF_TC_GFA = '6', 
      }
    
      /// <summary>
      /// VolumeConditionType是一个成交量类型类型
      /// </summary>
      public enum eTFVolumeCondition
      {
        [Description("任何数量")]
        TF_VC_AV = '1', 
        [Description("最小数量")]
        TF_VC_MV = '2', 
        [Description("全部数量")]
        TF_VC_CV = '3', 
      }
    
      /// <summary>
      /// ContingentConditionType是一个触发条件类型
      /// </summary>
      public enum eTFContingentCondition
      {
        [Description("立即")]
        TF_CC_Immediately = '1', 
        [Description("止损")]
        TF_CC_Touch = '2', 
        [Description("止赢")]
        TF_CC_TouchProfit = '3', 
        [Description("预埋单")]
        TF_CC_ParkedOrder = '4', 
      }
    
      /// <summary>
      /// OrderStatusType是一个报单状态类型
      /// </summary>
      public enum eTFOrderStatus
      {
        [Description("待报")]
        TF_OST_Unknown = '0', 
        [Description("正报")]
        TF_OST_PendingNew = '1', 
        [Description("已报")]
        TF_OST_New = '2', 
        [Description("部成")]
        TF_OST_PartilyFilled = '3', 
        [Description("已成")]
        TF_OST_Filled = '4', 
        [Description("部撤")]
        TF_OST_PartilyCanceled = '5', 
        [Description("已撤")]
        TF_OST_Canceled = '6', 
        [Description("废单")]
        TF_OST_Rejected = '7', 
      }
    
      /// <summary>
      /// OrderTypeType是一个报单类型类型
      /// </summary>
      public enum eTFOrderType
      {
        [Description("正常")]
        TF_ORDT_Normal = '0', 
        [Description("报价衍生")]
        TF_ORDT_DeriveFromQuote = '1', 
        [Description("组合衍生")]
        TF_ORDT_DeriveFromCombination = '2', 
        [Description("组合报单")]
        TF_ORDT_Combination = '3', 
        [Description("条件单")]
        TF_ORDT_ConditionalOrder = '4', 
        [Description("互换单")]
        TF_ORDT_Swap = '5', 
      }
    
      /// <summary>
      /// PosiDirectionType是一个持仓多空方向类型
      /// </summary>
      public enum eTFPosiDirection
      {
        [Description("空头")]
        TF_PD_Short = '1', 
        [Description("多头")]
        TF_PD_Long = '0', 
      }
    
      /// <summary>
      /// ChangeTypeType是一个变动类型类型
      /// </summary>
      public enum eTFChangeType
      {
        [Description("核对值")]
        TF_CGT_check = '1', 
        [Description("冻结功能")]
        TF_CGT_fronzen = '2', 
        [Description("当前值")]
        TF_CGT_current = '3', 
        [Description("持仓成本")]
        TF_CGT_cost = '4', 
      }
    
      /// <summary>
      /// CapitalDirectionType是一个资金变化方向类型
      /// </summary>
      public enum eTFCapitalDirection
      {
        [Description("不变")]
        TF_CPD_Nochange = '0', 
        [Description("增加")]
        TF_CPD_Increase = '1', 
        [Description("减少")]
        TF_CPD_Decrease = '2', 
      }
    
      /// <summary>
      /// PositionDirectionType是一个持仓变化方向类型
      /// </summary>
      public enum eTFPositionDirection
      {
        [Description("不变")]
        TF_PSD_Nochange = '0', 
        [Description("增加")]
        TF_PSD_Increase = '1', 
        [Description("减少")]
        TF_PSD_Decrease = '2', 
      }
    
      /// <summary>
      /// PositionDateType是一个持仓日期标志类型
      /// </summary>
      public enum eTFPositionDate
      {
        [Description("今日持仓")]
        TF_PSD_Today = '1', 
        [Description("历史持仓")]
        TF_PSD_History = '2', 
      }
    
      /// <summary>
      /// TradingPhaseType是一个交易阶段类型
      /// </summary>
      public enum eTFTradingPhase
      {
        [Description("非交易时段")]
        TF_TP_NonTrade = '0', 
        [Description("集合竞价时段")]
        TF_TP_Bidding = '1', 
        [Description("连续交易时段")]
        TF_TP_Continuous = '2', 
        [Description("停牌时段")]
        TF_TP_Suspension = '3', 
        [Description("熔断时段")]
        TF_TP_Fuse = '4', 
      }
    
      /// <summary>
      /// OpenRestrictionType是一个开仓限制类型
      /// </summary>
      public enum eTFOpenRestriction
      {
        [Description("无开仓限制")]
        TF_OR_None = '0', 
        [Description("限制备兑开仓")]
        TF_OR_NoCoverOpen = '1', 
        [Description("限制卖出开仓")]
        TF_OR_NoSellOpen = '2', 
        [Description("限制卖出开仓、备兑开仓")]
        TF_OR_NoSellAndCoverOpen = '3', 
        [Description("限制买入开仓")]
        TF_OR_NoBuyOpen = '4', 
        [Description("限制买入开仓、备兑开仓")]
        TF_OR_NoBuyAndCoverOpen = '5', 
        [Description("限制买入开仓、卖出开仓")]
        TF_OR_NoBuyAndSellOpen = '6', 
        [Description("限制买入开仓、卖出开仓、备兑开仓")]
        TF_OR_NoBuySellAndCoverOpen = '7', 
      }
    
      /// <summary>
      /// PositionTypeType是一个持仓类型类型
      /// </summary>
      public enum eTFPositionType
      {
        [Description("净持仓")]
        TF_PT_Net = '1', 
        [Description("综合持仓")]
        TF_PT_Gross = '2', 
      }
    
      /// <summary>
      /// PositionDateTypeType是一个持仓日期类型类型
      /// </summary>
      public enum eTFPositionDateType
      {
        [Description("使用历史持仓")]
        TF__UseHistory = '1', 
        [Description("不使用历史持仓")]
        TF__NoUseHistory = '2', 
      }
    
      /// <summary>
      /// InvestorTypeType是一个投资者类型类型
      /// </summary>
      public enum eTFInvestorType
      {
        [Description("自然人")]
        TF_IT_Person = '1', 
        [Description("法人")]
        TF_IT_Company = '2', 
        [Description("投资基金")]
        TF_IT_Fund = '3', 
        [Description("特殊法人")]
        TF_IT_SpecialOrgan = '4', 
        [Description("资管户")]
        TF_IT_Asset = '5', 
        [Description("系统管理员")]
        TF_IT_Admin = 'a', 
      }
    
      /// <summary>
      /// IDCardTypeType是一个证件类型类型
      /// </summary>
      public enum eTFIDCardType
      {
        [Description("组织机构代码")]
        TF_DCT_EID = '0', 
        [Description("中国公民身份证")]
        TF_DCT_IDCard = '1', 
        [Description("军官证")]
        TF_DCT_OfficerIDCard = '2', 
        [Description("警官证")]
        TF_DCT_PoliceIDCard = '3', 
        [Description("士兵证")]
        TF_DCT_SoldierIDCard = '4', 
        [Description("户口簿")]
        TF_DCT_HouseholdRegister  = '5', 
        [Description("护照")]
        TF_DCT_Passport = '6', 
        [Description("台胞证")]
        TF_DCT_TaiwanCompatriotIDCard  = '7', 
        [Description("回乡证")]
        TF_DCT_HomeComingCard = '8', 
        [Description("营业执照号")]
        TF_DCT_LicenseNo = '9', 
        [Description("税务登记号/当地纳税ID")]
        TF_DCT_TaxNo = 'A', 
        [Description("港澳居民来往内地通行证")]
        TF_DCT_HMMainlandTravelPermit  = 'B', 
        [Description("台湾居民来往大陆通行证")]
        TF_DCT_TwMainlandTravelPermit = 'C', 
        [Description("驾照")]
        TF_DCT_DrivingLicense = 'D', 
        [Description("当地社保ID")]
        TF_DCT_SocialID = 'F', 
        [Description("当地身份证")]
        TF_DCT_LocalID = 'G', 
        [Description("商业登记证")]
        TF_DCT_BusinessRegistration  = 'H', 
        [Description("港澳永久性居民身份证")]
        TF_DCT_HKMCIDCard  = 'I', 
        [Description("人行开户许可证")]
        TF_DCT_AccountsPermits = 'J', 
        [Description("外国人永久居留证")]
        TF_DCT_PermanantResidence = 'K', 
        [Description("资管产品备案函")]
        TF_DCT_AssetProductRecord = 'L', 
        [Description("其他证件")]
        TF_DCT_OtherCard = 'x', 
      }
    
      /// <summary>
      /// TradingCodeTypeType是一个交易编码类型类型
      /// </summary>
      public enum eTFTradingCodeType
      {
        [Description("投机")]
        TF_TC_Speculation = '1', 
        [Description("套利")]
        TF_TC_Arbitrage = '2', 
        [Description("套保")]
        TF_TC_Hedge = '3', 
        [Description("做市商")]
        TF_TC_MarketMaker = '4', 
      }
    
      /// <summary>
      /// OptCommissionTypeType是一个期权费用类型类型
      /// </summary>
      public enum eTFOptCommissionType
      {
        [Description("行权费")]
        TF_OPT_CT_StrikeFee = '1', 
        [Description("被行权费")]
        TF_OPT_CT_BeStrikeDFee = '2', 
        [Description("行权过户费")]
        TF_OPT_CT_TransferFee = '3', 
        [Description("经手费")]
        TF_OPT_CT_Brokerage = '4', 
        [Description("交易费")]
        TF_OPT_CT_TradeFee = '5', 
        [Description("结算费")]
        TF_OPT_CT_SettleFee = '6', 
      }
    
      /// <summary>
      /// CommDirectionType是一个委托方向类型
      /// </summary>
      public enum eTFCommDirection
      {
        [Description("买开")]
        TF_CD_BuyOpen = '1', 
        [Description("买平")]
        TF_CD_BuyClose = '2', 
        [Description("卖开")]
        TF_CD_SellOpen = '3', 
        [Description("卖平")]
        TF_CD_SellClose = '4', 
        [Description("行权认购")]
        TF_CD_CallStrike = '5', 
        [Description("行权认沽")]
        TF_CD_PutStrike = '6', 
      }
    
      /// <summary>
      /// RateTypeType是一个计算方式类型
      /// </summary>
      public enum eTFRateType
      {
        [Description("按手数")]
        TF_RT_ByVolume = '1', 
        [Description("按金额")]
        TF_RT_ByMoney = '2', 
        [Description("按面值")]
        TF_RT_ByFace = '3', 
      }
    
      /// <summary>
      /// OperationTypeType是一个操作类型类型
      /// </summary>
      public enum eTFOperationType
      {
        [Description("日初同步操作")]
        TF_OPNT_Sync = '1', 
        [Description("管理指令操作")]
        TF_OPNT_Admin = '2', 
        [Description("结算后持仓调整操作")]
        TF_OPNT_Settle = '3', 
        [Description("其他操作")]
        TF_OPNT_Other = '0', 
      }
    
      /// <summary>
      /// OptionTypeType是一个期权类型类型
      /// </summary>
      public enum eTFOptionType
      {
        [Description("认购")]
        TF_OPT_TY_Call = 'C', 
        [Description("认沽")]
        TF_OPT_TY_Put = 'P', 
      }
    
      /// <summary>
      /// SystemStatusType是一个系统状态类型
      /// </summary>
      public enum eTFSystemStatus
      {
        [Description("导入数据完成")]
        TF_STS_SyncDone = '1', 
        [Description("盘中交易状态")]
        TF_STS_Trading = '2', 
        [Description("收市完成")]
        TF_STS_Closed = '3', 
        [Description("结算完成")]
        TF_STS_Settled = '4', 
      }
    
      /// <summary>
      /// InstrumentRangeType是一个合约范围类型
      /// </summary>
      public enum eTFInstrumentRange
      {
        [Description("所有")]
        TF_INSTR_ALL = '1', 
        [Description("证券类别")]
        TF_INSTR_PRODUCT_CLASS = '2', 
        [Description("单一合约")]
        TF_INSTR_SINGLE = '3', 
      }
    
      /// <summary>
      /// SeatTypeType是一个席位类型类型
      /// </summary>
      public enum eTFSeatType
      {
        [Description("上交所期权")]
        TF_ST_SHOPT = '1', 
        [Description("上交所股票")]
        TF_ST_SHSTK = '2', 
        [Description("深交所期权")]
        TF_ST_SZOPT = '3', 
        [Description("深交所股票")]
        TF_ST_SZSTK = '4', 
        [Description("飞马")]
        TF_ST_FEMAS = '5', 
      }
    
      /// <summary>
      /// ResumeTypeType是一个私有流重传方式类型
      /// </summary>
      public enum eTFResumeType
      {
        [Description("重传")]
        TF_RT_Restart = '0', 
        [Description("续传")]
        TF_RT_Resume = '1', 
        [Description("当前开始")]
        TF_RT_Quick = '2', 
      }
    
      /// <summary>
      /// CompanyTypeType是一个公司类型类型
      /// </summary>
      public enum eTFCompanyType
      {
        [Description("内部机构")]
        TF_CT_INSIDE = '1', 
        [Description("机构客户")]
        TF_CT_ORGAN = '2', 
        [Description("个人客户")]
        TF_CT_USER = '3', 
      }
    
      /// <summary>
      /// EnbFlagType是一个状态标志类型
      /// </summary>
      public enum eTFEnbFlag
      {
        [Description("正常")]
        TF_EF_NORMAL = 'N', 
        [Description("被关闭")]
        TF_EF_OFF = 'C', 
        [Description("锁定")]
        TF_EF_LOCK = 'L', 
        [Description("新增未同步")]
        TF_EF_UNSYNC = '1', 
      }
    
      /// <summary>
      /// ActionTypeType是一个功能类型类型
      /// </summary>
      public enum eTFActionType
      {
        [Description("客户端")]
        TF_ACT_CLIENT = '1', 
        [Description("web端")]
        TF_ACT_WEB = '2', 
        [Description("行情平台")]
        TF_ACT_MARKET = '3', 
      }
    
      /// <summary>
      /// AuthTypeType是一个权限类型类型
      /// </summary>
      public enum eTFAuthType
      {
        [Description("通用")]
        TF_AUT_GENERAL = '0', 
        [Description("券商内部")]
        TF_AUT_INSIDE = '1', 
        [Description("外部客户")]
        TF_AUT_OUTSIDE = '2', 
      }
    
      /// <summary>
      /// FileFlagType是一个请求执行状态类型
      /// </summary>
      public enum eTFFileFlag
      {
        [Description("处理中")]
        TF__InProgress = 'I', 
        [Description("生成成功")]
        TF__Success = 'S', 
        [Description("生成失败")]
        TF__Fail = 'F', 
      }
    
      /// <summary>
      /// MarketDataTypeType是一个行情配置类型类型
      /// </summary>
      public enum eTFMarketDataType
      {
        [Description("实时行情")]
        TF_MDT_REAL = '0', 
        [Description("历史行情")]
        TF_MDT_HIS = '1', 
      }
    
      /// <summary>
      /// PaySubjectType是一个缴费科目类型
      /// </summary>
      public enum eTFPaySubject
      {
        [Description("通用费用")]
        TF_PSJ_GENERAL = '1', 
      }
    
      /// <summary>
      /// AccountTypeType是一个账户类型类型
      /// </summary>
      public enum eTFAccountType
      {
        [Description("普通证券账户")]
        TF_AT_STOCK = '1', 
        [Description("信用账户")]
        TF_AT_CREDIT = '2', 
        [Description("衍生品账户")]
        TF_AT_DERIVATIVE = '3', 
        [Description("期货账户")]
        TF_AT_FUTURES = '4', 
      }
    
      /// <summary>
      /// ChannelTypeType是一个通道类型类型
      /// </summary>
      public enum eTFChannelType
      {
        [Description("UFT分仓")]
        TF_CHT_UFT = '1', 
        [Description("CTP分仓")]
        TF_CHT_CTP = '2', 
        [Description("飞马分仓")]
        TF_CHT_FEMAS = '3', 
        [Description("O32分仓")]
        TF_CHT_O32 = '4', 
        [Description("模拟交易所")]
        TF_CHT_SIMULATE = '5', 
      }
    
      /// <summary>
      /// FeeTypeType是一个费用类别类型
      /// </summary>
      public enum eTFFeeType
      {
        [Description("交易费")]
        TF_FT_TRADEFEE = '1', 
        [Description("印花税")]
        TF_FT_STAMPTAX = '2', 
        [Description("过户费")]
        TF_FT_TRANSFERFEE = '3', 
        [Description("佣金")]
        TF_FT_BROKERFEE = '4', 
        [Description("经手费")]
        TF_FT_HANDLINGFEE = '5', 
        [Description("证管费")]
        TF_FT_ADMINFEE = '6', 
        [Description("其它费")]
        TF_FT_OTHERFEE = '7', 
        [Description("结算费")]
        TF_FT_CLEARINGFEE = 'a', 
        [Description("交割费")]
        TF_FT_SETTLEFEE = 'b', 
        [Description("委托申报费")]
        TF_FT_PERORDER = 'c', 
        [Description("撤单申报费")]
        TF_FT_PERCANCEL = 'd', 
      }
    
      /// <summary>
      /// CalculateTypeType是一个费用计算模式类型
      /// </summary>
      public enum eTFCalculateType
      {
        [Description("分笔")]
        TF_CT_TOTAL = '1', 
        [Description("合笔")]
        TF_CT_PER = '2', 
      }
    
      /// <summary>
      /// CancelFlagType是一个撤单标志类型
      /// </summary>
      public enum eTFCancelFlag
      {
        [Description("普通委托")]
        TF_CF_ORDER = '1', 
        [Description("撤单委托")]
        TF_CF_CANCEL = '2', 
      }
    
      /// <summary>
      /// StockRealBackType是一个回报证券标志类型
      /// </summary>
      public enum eTFStockRealBack
      {
        [Description("买入证券当天不可用")]
        TF_SRB_FALSE = '0', 
        [Description("买入证当天可用")]
        TF_SRB_TRUE = '1', 
      }
    
      /// <summary>
      /// FundRealBackType是一个回报资金标志类型
      /// </summary>
      public enum eTFFundRealBack
      {
        [Description("卖出资金不可用")]
        TF_FRB_FALSE = '0', 
        [Description("卖出资金当天可用")]
        TF_FRB_TRUE = '1', 
      }
    
      /// <summary>
      /// InstrumentControlLevelType是一个证券控制层级类型
      /// </summary>
      public enum eTFInstrumentControlLevel
      {
        [Description("证券类别")]
        TF_INSTC_LEVEL_PRODUCT_CLASS = '1', 
        [Description("单一证券")]
        TF_INSTC_LEVEL_SINGLE = '3', 
      }
    
      /// <summary>
      /// InstrumentRangeTypeType是一个证券范围类型
      /// </summary>
      public enum eTFInstrumentRangeType
      {
        [Description("所有")]
        TF_INSTC_RANGE_ALL = '1', 
        [Description("集合")]
        TF_INSTC_RANGE_SET = '3', 
      }
    
      /// <summary>
      /// AccountControlLevelType是一个账户集合控制层级类型
      /// </summary>
      public enum eTFAccountControlLevel
      {
        [Description("公司")]
        TF_AR_LEVEL_COMPANY = '1', 
        [Description("账户")]
        TF_AR_LEVEL_ACCOUNT = '2', 
        [Description("组合")]
        TF_AR_LEVEL_COMBO = '3', 
      }
    
      /// <summary>
      /// AccountRangeTypeType是一个账户集合范围类型
      /// </summary>
      public enum eTFAccountRangeType
      {
        [Description("所有")]
        TF_AR_RANGE_ALL = '1', 
        [Description("集合")]
        TF_AR_RANGE_SET = '3', 
      }
    
    }
  