
using System;
using System.Runtime.InteropServices;

namespace TBondMMDataCS
{
    ///交易日期
    public struct STPTradeDateField
    {
        ///交易日
        public Int32 TradingDay;
        ///下一交易日
        public Int32 NextTradingDay;
        ///系统状态
        public char SystemStatus;
    };
    
    ///期权合约
    public struct STPInstrumentField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///产品代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///证券交易代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTCODE_LEN)]
        public string InstrumentCode; 
        ///合约名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTNAME_LEN)]
        public string InstrumentName; 
        ///证券类别
        public char ProductClass;
        ///合约数量乘数
        public Int32 VolumeMultiple;
        ///最小变动价位
        public double PriceTick;
        ///上市日
        public Int32 OpenDate;
        ///到期日
        public Int32 ExpireDate;
        ///当前是否交易
        public Int32 IsTrading;
        ///期权执行价格
        public double ExecPrice;
        ///期权单手保证金
        public double UnitMargin;
        ///交易日
        public Int32 TradingDay;
        ///行权日
        public Int32 ExerciseDay;
        ///开始交割日
        public Int32 StartDeliveryDay;
        ///结束交割日
        public Int32 EndDeliveryDay;
        ///市价最大下单量
        public Int32 MaxMarketOrderVolume;
        ///市价最小下单量
        public Int32 MinMarketOrderVolume;
        ///限价最大下单量
        public Int32 MaxLimitOrderVolume;
        ///限价最小下单量
        public Int32 MinLimitOrderVolume;
        ///涨停板价
        public double UpperLimitPrice;
        ///跌停板价
        public double LowerLimitPrice;
        ///期权类型
        public char OptionType;
        ///最小买入变动手数
        public Int32 BuyVolumeTick;
        ///最小卖出变动手数
        public Int32 SellVolumeTick;
        ///基础商品代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_UNDERLYINGINSTRUMENTID_LEN)]
        public string UnderlyingInstrumentID; 
        ///基础商品乘数
        public Int32 UnderlyingMultiple;
        ///回报证券标志
        public char StockRealBack;
        ///回报资金标志
        public char FundRealBack;
    };
    
    ///公司信息
    public struct STPCompanyField
    {
        ///公司编号
        public Int32 CompanyID;
        ///公司名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMPANYNAME_LEN)]
        public string CompanyName; 
        ///公司类型
        public char CompanyType;
        ///联系人
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LINKMAN_LEN)]
        public string LinkMan; 
        ///联系地址
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADDRESS_LEN)]
        public string Address; 
        ///联系电话
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TEL_LEN)]
        public string Tel; 
        ///电子邮箱
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EMAIL_LEN)]
        public string Email; 
    };
    
    ///公司操作员信息
    public struct STPOperatorField
    {
        ///操作员代码
        public Int32 OperatorID;
        ///公司编号
        public Int32 CompanyID;
        ///操作员名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPERATORNAME_LEN)]
        public string OperatorName; 
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password; 
        ///操作员角色
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPROLES_LEN)]
        public string OpRoles; 
        ///(已废除)操作员可以查询的账户集合
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_QRYACCOUNTIDS_LEN)]
        public string QryAccountIDs; 
        ///(已废除)操作员可以操作的账户集合
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPACCOUNTIDS_LEN)]
        public string OpAccountIDs; 
        ///操作员可以查询的组合集合
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_QRYCOMBOIDS_LEN)]
        public string QryComboIDs; 
        ///操作员可以操作的组合集合
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPCOMBOIDS_LEN)]
        public string OpComboIDs; 
        ///操作员电话
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPTEL_LEN)]
        public string OpTel; 
        ///操作员邮箱
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPEMAIL_LEN)]
        public string OpEmail; 
        ///注册时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REGIDATE_LEN)]
        public string RegiDate; 
        ///状态标志
        public char EnbFlag;
        ///修改时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_UPTTIME_LEN)]
        public string UptTime; 
        ///登录时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LOGTIME_LEN)]
        public string LogTime; 
        ///密码修改时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PWDUPTTIME_LEN)]
        public string PwdUptTime; 
        ///登录错误时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LOGERRTIME_LEN)]
        public string LogErrTime; 
        ///密码错误次数
        public Int32 PwdErrCnt;
        ///备注
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REMARK_LEN)]
        public string Remark; 
        ///公司类型
        public char CompanyType;
    };
    
    ///系统权限信息
    public struct STPAuthInfoField
    {
        ///权限ID
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID; 
        ///权限级别
        public Int32 AuthLevel;
        ///权限描述
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHDESC_LEN)]
        public string AuthDesc; 
        ///父权限
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PARENTID_LEN)]
        public string ParentID; 
        ///是否有下级权限
        public Int32 HaveSon;
        ///顺序号
        public Int32 ID;
        ///状态标志
        public char EnbFlag;
        ///缺省状态
        public Int32 IsDefault;
        ///权限是否作为功能显示在控台
        public Int32 IsDisplay;
        ///动作
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTION_LEN)]
        public string Action; 
        ///保留
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RESV_LEN)]
        public string Resv; 
        ///创建时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CRTTIME_LEN)]
        public string CrtTime; 
        ///最近一次更新时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUPTTIME_LEN)]
        public string LastUptTime; 
        ///功能类型
        public char ActionType;
        ///权限类型
        public char AuthType;
    };
    
    ///操作员权限信息
    public struct STPOpAuthInfoField
    {
        ///操作员代码
        public Int32 OperatorID;
        ///权限ID
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID; 
        ///状态标志
        public char EnbFlag;
        ///最近一次使用时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUSRTIME_LEN)]
        public string LastUsrTime; 
        ///使用次数
        public Int32 UsrCount;
        ///保留
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RESV_LEN)]
        public string Resv; 
        ///创建时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CRTTIME_LEN)]
        public string CrtTime; 
        ///最近一次更新时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUPTTIME_LEN)]
        public string LastUptTime; 
    };
    
    ///接口权限
    public struct STPIntefAuthInfoField
    {
        ///接口标识
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CMDID_LEN)]
        public string CmdID; 
        ///权限ID
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID; 
    };
    
    ///操作员日志
    public struct STPOpLogField
    {
        ///系统日期
        public Int32 SysDate;
        ///系统时间
        public Int32 SysTime;
        ///操作员代码
        public Int32 OperatorID;
        ///动作
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTION_LEN)]
        public string Action; 
        ///动作描述
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTIONDESC_LEN)]
        public string ActionDesc; 
    };
    
    ///角色信息
    public struct STPRoleField
    {
        ///角色号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLEID_LEN)]
        public string RoleID; 
        ///角色名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLENAME_LEN)]
        public string RoleName; 
        ///公司类型
        public char CompanyType;
    };
    
    ///角色权限信息
    public struct STPRoleAuthField
    {
        ///角色号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLEID_LEN)]
        public string RoleID; 
        ///权限ID
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID; 
    };
    
    ///下载文件列表
    public struct STPFileDownloadField
    {
        ///系统日期
        public Int32 SysDate;
        ///系统流水
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSSEQID_LEN)]
        public string SysSeqID; 
        ///操作员代码
        public Int32 OperatorID;
        ///文件名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILENAME_LEN)]
        public string FileName; 
        ///文件存储路径
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEURL_LEN)]
        public string FileUrl; 
        ///文件查询条件
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEINFO_LEN)]
        public string FileInfo; 
        ///请求执行状态
        public char FileFlag;
        ///后缀文件类型
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEPOSTFIX_LEN)]
        public string FilePostFix; 
        ///文件生成日期
        public Int32 CreateDate;
        ///文件生成时间
        public Int32 CreateTime;
        ///更新日期
        public Int32 UpdateDate;
        ///最后修改时间
        public Int32 UpdateTime;
    };
    
    ///控台序列表
    public struct STPCmdSequenceField
    {
        ///序列名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEQNAME_LEN)]
        public string SeqName; 
        ///当前序列值
        public Int32 CurrentVal;
        ///当前增长值
        public Int32 IncrementVal;
    };
    
    ///操作员行情配置信息
    public struct STPOpMarketField
    {
        ///公司编号
        public Int32 CompanyID;
        ///行情配置类型
        public char MarketDataType;
        ///操作员代码
        public Int32 OperatorID;
        ///允许连接个数
        public Int32 LimitConNum;
        ///允许订阅个数
        public Int32 LimitSubNum;
        ///连接IP地址白名单
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_IPADDRESS_LEN)]
        public string IpAddress; 
    };
    
    ///公司行情缴费信息
    public struct STPMarketDataPayField
    {
        ///公司编号
        public Int32 CompanyID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///缴费科目
        public char PaySubject;
        ///最近缴费时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTPAYTIME_LEN)]
        public string LastPayTime; 
        ///缴费金额
        public double PayBalance;
        ///起始日期
        public Int32 StartDate;
        ///到期日期
        public Int32 EndDate;
    };
    
    ///公司行情缴费流水
    public struct STPMarketDataPayFlowField
    {
        ///流水序号
        public Int32 PayID;
        ///公司编号
        public Int32 CompanyID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///缴费科目
        public char PaySubject;
        ///缴费时间
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PAYTIME_LEN)]
        public string PayTime; 
        ///缴费金额
        public double PayBalance;
        ///起始日期
        public Int32 StartDate;
        ///到期日期
        public Int32 EndDate;
    };
    
    ///账户信息
    public struct STPAccountField
    {
        ///账户编号
        public Int32 AccountID;
        ///公司编号
        public Int32 CompanyID;
        ///资金账户名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName; 
        ///投资者代码
        public Int32 InvestorID;
        ///账户类型
        public char AccountType;
        ///状态标志
        public char EnbFlag;
        ///交易日
        public Int32 TradingDay;
        ///交易通道编号
        public Int32 ChannelID;
        ///默认组合
        public Int32 DefaultCombo;
    };
    
    ///投资组合
    public struct STPAccountComboField
    {
        ///组合编号
        public Int32 ComboID;
        ///账户编号
        public Int32 AccountID;
        ///组合名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBONAME_LEN)]
        public string ComboName; 
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///投资组合对应的合约代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_KEYINSTRUMENTID_LEN)]
        public string KeyInstrumentID; 
        ///是否活跃
        public Int32 IsActive;
        ///缺省状态
        public Int32 IsDefault;
        ///交易日
        public Int32 TradingDay;
        ///允许日内交易
        public byte DayTradeEnable;
    };
    
    ///投资者信息
    public struct STPInvestorField
    {
        ///投资者代码
        public Int32 InvestorID;
        ///交易日
        public Int32 TradingDay;
        ///经纪公司代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BROKERID_LEN)]
        public string BrokerID; 
        ///母账户代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BROKERINVESTORID_LEN)]
        public string BrokerInvestorID; 
        ///用户代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_USERID_LEN)]
        public string UserID; 
        ///客户号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CLIENTID_LEN)]
        public string ClientID; 
        ///资金账户代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTCODE_LEN)]
        public string AccountCode; 
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password; 
        ///投资者名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INVESTORNAME_LEN)]
        public string InvestorName; 
        ///投资者类型
        public char InvestorType;
        ///证件类型
        public char IDCardType;
        ///证件号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_IDCARDNO_LEN)]
        public string IDCardNo; 
        ///是否活跃
        public Int32 IsActive;
        ///分组编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_GROUPID_LEN)]
        public string GroupID; 
        ///O32操作员代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32OPERATORNO_LEN)]
        public string O32OperatorNo; 
        ///O32操作员密码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32OPERATORPWD_LEN)]
        public string O32OperatorPwd; 
        ///O32基金代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32ACCOUNTCODE_LEN)]
        public string O32AccountCode; 
        ///O32组合编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32COMBINO_LEN)]
        public string O32CombiNo; 
        ///O32资产单元编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32ASSETNO_LEN)]
        public string O32AssetNo; 
    };
    
    ///投资者交易编码
    public struct STPTradingCodeField
    {
        ///交易日
        public Int32 TradingDay;
        ///账户编号
        public Int32 AccountID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///交易编码类型
        public char TradingCodeType;
        ///交易编码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///营业部代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
        public string BranchID; 
        ///席位号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
        public string SeatID; 
        ///投资者账户子编码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPTCLIENTID_LEN)]
        public string OptClientID; 
        ///是否活跃
        public Int32 IsActive;
    };
    
    ///交易通道信息
    public struct STPTradeChannelField
    {
        ///交易通道编号
        public Int32 ChannelID;
        ///通道名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CHANNELNAME_LEN)]
        public string ChannelName; 
        ///通道类型
        public char ChannelType;
        ///分仓接口IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSIP_LEN)]
        public string SysIP; 
        ///分仓接口端口
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSPORT_LEN)]
        public string SysPort; 
        ///分仓其他配置
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CHANNELCONFIG_LEN)]
        public string ChannelConfig; 
        ///交易日
        public Int32 TradingDay;
    };
    
    ///账户资金信息
    public struct STPAccountAssetField
    {
        ///交易日
        public Int32 TradingDay;
        ///账户编号
        public Int32 AccountID;
        ///币种代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CURRENCYID_LEN)]
        public string CurrencyID; 
        ///上次存款额
        public double PreDeposit;
        ///上次占用的保证金
        public double PreMargin;
        ///上次结算准备金
        public double PreBalance;
        ///当前资金
        public double Balance;
        ///入金金额
        public double Deposit;
        ///冻结的保证金
        public double FrozenMargin;
        ///冻结的手续费
        public double FrozenCommission;
        ///冻结的资金
        public double FrozenCash;
        ///手工冻结的资金
        public double ManualFrozenCash;
        ///核对调整资金
        public double CheckCash;
        ///仓位占用保证金
        public double UseMargin;
        ///手续费
        public double Commission;
        ///可取资金
        public double WithdrawQuota;
        ///保证金可用余额
        public double Credit;
        ///现金
        public double Available;
        ///平仓盈亏
        public double CloseProfit;
        ///持仓盈亏
        public double PositionProfit;
        ///资金差额
        public double CashIn;
        ///出金金额
        public double CashOut;
        ///缺省状态
        public Int32 IsDefault;
    };
    
    ///查询账户资金信息
    public struct STPUserAccountAssetField
    {
        ///账户编号
        public Int32 AccountID;
        ///资金账户名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName; 
        ///当前资金
        public double Balance;
        ///可用资金
        public double EnableBalance;
        ///冻结的资金
        public double FrozenCash;
        ///手工冻结的资金
        public double ManualFrozenCash;
        ///核对调整资金
        public double CheckCash;
    };
    
    ///账户持仓信息
    public struct STPAccountPositionField
    {
        ///账户编号
        public Int32 AccountID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///备兑标志
        public char CoveredFlag;
        ///持仓多空方向
        public char PosiDirection;
        ///交易编码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///交易编码类型
        public char TradingCodeType;
        ///交易日
        public Int32 TradingDay;
        ///上日持仓
        public double YdPosition;
        ///上次占用的保证金
        public double PreMargin;
        ///今持仓
        public double TodayPosition;
        ///总持仓
        public double TotalPosition;
        ///仓位占用保证金
        public double UseMargin;
        ///开仓量
        public double OpenVolume;
        ///平仓量
        public double CloseVolume;
        ///平昨仓量
        public double CloseYdVolume;
        ///本次结算价
        public double SettlementPrice;
        ///上次结算价
        public double PreSettlementPrice;
        ///手续费
        public double Commission;
        ///冻结的手续费
        public double FrozenCommission;
        ///冻结的保证金
        public double FrozenMargin;
        ///开仓成本
        public double OpenCost;
        ///持仓成本
        public double PositionCost;
        ///平仓盈亏
        public double CloseProfit;
        ///持仓盈亏
        public double PositionProfit;
        ///开仓金额
        public double OpenAmount;
        ///平仓金额
        public double CloseAmount;
        ///平昨仓金额
        public double CloseYdAmount;
        ///多头冻结
        public double LongFrozen;
        ///开仓冻结金额
        public double LongFrozenAmount;
        ///空头冻结
        public double ShortFrozen;
        ///开仓冻结金额
        public double ShortFrozenAmount;
        ///冻结数量
        public double FrozenVolume;
        ///手工冻结数量
        public double ManualFrozenVolume;
        ///核对调整数量
        public double CheckVolume;
        ///可用数量
        public double EnableVolume;
    };
    
    ///查询组合持仓信息
    public struct STPUserComboPositionField
    {
        ///账户编号
        public Int32 AccountID;
        ///资金账户名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName; 
        ///组合编号
        public Int32 ComboID;
        ///组合名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBONAME_LEN)]
        public string ComboName; 
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///合约名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTNAME_LEN)]
        public string InstrumentName; 
        ///总持仓
        public double TotalPosition;
        ///冻结数量
        public double FrozenVolume;
        ///手工冻结数量
        public double ManualFrozenVolume;
        ///核对调整数量
        public double CheckVolume;
        ///可用数量
        public double EnableVolume;
        ///持仓成本
        public double PositionCost;
        ///成本价
        public double CostPrice;
        ///最新价
        public double LastPrice;
        ///持仓市值
        public double OpenMarketValue;
        ///浮动盈亏
        public double FloatProfi;
        ///多头冻结
        public double LongFrozen;
        ///空头冻结
        public double ShortFrozen;
        ///日内初始数量
        public Int32 DayTradeInitVolume;
        ///日内可用数量
        public Int32 DayTradeAvailVolume;
        ///浮动盈亏
        public double DayTradeFloatProfitLoss;
        ///日内持仓成本价
        public double DayTradePositionCost;
        ///日内平仓盈亏
        public double DayTradeCloseProfit;
        ///日内累买
        public double DayTradeAccumBuy;
        ///日内累卖
        public double DayTradeAccumSell;
    };
    
    ///组合持仓信息
    public struct STPComboPositionField
    {
        ///账户编号
        public Int32 AccountID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///组合编号
        public Int32 ComboID;
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///备兑标志
        public char CoveredFlag;
        ///持仓多空方向
        public char PosiDirection;
        ///交易编码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///交易编码类型
        public char TradingCodeType;
        ///交易日
        public Int32 TradingDay;
        ///上日持仓
        public double YdPosition;
        ///上次占用的保证金
        public double PreMargin;
        ///今持仓
        public double TodayPosition;
        ///总持仓
        public double TotalPosition;
        ///仓位占用保证金
        public double UseMargin;
        ///开仓量
        public double OpenVolume;
        ///平仓量
        public double CloseVolume;
        ///平昨仓量
        public double CloseYdVolume;
        ///本次结算价
        public double SettlementPrice;
        ///上次结算价
        public double PreSettlementPrice;
        ///手续费
        public double Commission;
        ///冻结的手续费
        public double FrozenCommission;
        ///冻结的保证金
        public double FrozenMargin;
        ///开仓成本
        public double OpenCost;
        ///持仓成本
        public double PositionCost;
        ///平仓盈亏
        public double CloseProfit;
        ///持仓盈亏
        public double PositionProfit;
        ///开仓金额
        public double OpenAmount;
        ///平仓金额
        public double CloseAmount;
        ///平昨仓金额
        public double CloseYdAmount;
        ///多头冻结
        public double LongFrozen;
        ///开仓冻结金额
        public double LongFrozenAmount;
        ///空头冻结
        public double ShortFrozen;
        ///开仓冻结金额
        public double ShortFrozenAmount;
        ///冻结数量
        public double FrozenVolume;
        ///手工冻结数量
        public double ManualFrozenVolume;
        ///核对调整数量
        public double CheckVolume;
        ///可用数量
        public double EnableVolume;
        ///日内初始数量
        public Int32 DayTradeInitVolume;
        ///日内可用数量
        public Int32 DayTradeAvailVolume;
        ///浮动盈亏
        public double DayTradeFloatProfitLoss;
        ///日内持仓成本价
        public double DayTradePositionCost;
        ///日内平仓盈亏
        public double DayTradeCloseProfit;
        ///日内累买
        public double DayTradeAccumBuy;
        ///日内累卖
        public double DayTradeAccumSell;
    };
    
    ///日内持仓调整
    public struct STPDayTradePositionAdjReqField
    {
        ///操作员代码
        public Int32 OperatorID;
        ///账户编号
        public Int32 AccountID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///组合编号
        public Int32 ComboID;
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///日内调仓数量
        public Int32 DayTradePositionAdjAmount;
        ///日内调仓价格
        public double DayTradePositionAdjCost;
        ///操作信息
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPERATEMSG_LEN)]
        public string OperateMsg; 
    };
    
    ///账户持仓明细
    public struct STPAccountPositionDtlField
    {
        ///账户编号
        public Int32 AccountID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///组合编号
        public Int32 ComboID;
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///备兑标志
        public char CoveredFlag;
        ///持仓多空方向
        public char PosiDirection;
        ///上市日
        public Int32 OpenDate;
        ///成交编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
        public string TradeID; 
        ///交易编码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///交易编码类型
        public char TradingCodeType;
        ///交易日
        public Int32 TradingDay;
        ///成交量
        public Int32 Volume;
        ///本次结算价
        public double SettlementPrice;
        ///上次结算价
        public double PreSettlementPrice;
        ///今开盘
        public double OpenPrice;
        ///投资者保证金
        public double Margin;
        ///投资者保证金率
        public double MarginRate;
        ///平仓量
        public double CloseVolume;
        ///平仓金额
        public double CloseAmount;
    };
    
    ///费用设置信息
    public struct STPFeeSetField
    {
        ///公司编号
        public Int32 CompanyID;
        ///账户编号
        public Int32 AccountID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///证券类别
        public char ProductClass;
        ///产品代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID; 
        ///买卖方向
        public char Direction;
        ///开平标志
        public char OffsetFlag;
        ///备兑标志
        public char CoveredFlag;
        ///投机套保标志
        public char HedgeFlag;
        ///费用类别
        public char FeeType;
        ///费用按成交金额比例
        public double BalanceRatio;
        ///费用按成交面值比例
        public double FaceValueRatio;
        ///费用按成交数量比例
        public double AmountRatio;
        ///最高收费
        public double MaxFee;
        ///最低收费
        public double MinFee;
        ///费用计算模式
        public char CalculateType;
        ///交易日
        public Int32 TradingDay;
    };
    
    ///保证金率
    public struct STPMarginRateField
    {
        ///交易日
        public Int32 TradingDay;
        ///账户编号
        public Int32 AccountID;
        ///投资者范围
        public char InvestorRange;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///备兑标志
        public char CoveredFlag;
        ///投机套保标志
        public char HedgeFlag;
        ///期权类型
        public char OptionType;
        ///证券类别
        public char ProductClass;
        ///产品代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID; 
        ///多头保证金率
        public double LongMarginRatioByMoney;
        ///多头保证金费
        public double LongMarginRatioByVolume;
        ///空头保证金率
        public double ShortMarginRatioByMoney;
        ///空头保证金费
        public double ShortMarginRatioByVolume;
        ///是否按比例上浮
        public Int32 IsFloat;
    };
    
    ///报单
    public struct STPOrderField
    {
        ///交易日
        public Int32 TradingDay;
        ///账户编号
        public Int32 AccountID;
        ///组合编号
        public Int32 ComboID;
        ///会话编号
        public Int32 SessionID;
        ///前置编号
        public Int32 FrontID;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef; 
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///席位号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
        public string SeatID; 
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID; 
        ///买卖方向
        public char Direction;
        ///操作员代码
        public Int32 OperatorID;
        ///交易编码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///营业部代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
        public string BranchID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///报单价格条件
        public char OrderPriceType;
        ///开平标志
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBOSTPETFLAG_LEN)]
        public string CombOffsetFlag; 
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBHEDGEFLAG_LEN)]
        public string CombHedgeFlag; 
        ///备兑标志
        public char CoveredFlag;
        ///价格
        public double LimitPrice;
        ///原始数量
        public Int32 VolumeTotalOriginal;
        ///有效期类型
        public char TimeCondition;
        ///成交量类型
        public char VolumeCondition;
        ///最小成交量
        public Int32 MinVolume;
        ///触发条件
        public char ContingentCondition;
        ///止损价
        public double StopPrice;
        ///请求编号
        public Int32 ORRequestID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERSYSID_LEN)]
        public string OrderSysID; 
        ///报单状态
        public char OrderStatus;
        ///报单类型
        public char OrderType;
        ///今成交数量
        public Int32 VolumeTraded;
        ///今成交金额
        public double AmountTraded;
        ///剩余数量
        public Int32 VolumeRemain;
        ///报单日期
        public Int32 InsertDate;
        ///委托时间
        public Int32 InsertTime;
        ///最后修改时间
        public Int32 UpdateTime;
        ///撤销时间
        public Int32 CancelTime;
        ///被撤单引用
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERACTIONREF_LEN)]
        public string OrderActionRef; 
        ///状态信息
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_STATUSMSG_LEN)]
        public string StatusMsg; 
        ///发起标志
        public char OwnerType;
        ///预留字段1
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF1_LEN)]
        public string ThirdReff1; 
        ///预留字段2
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF2_LEN)]
        public string ThirdReff2; 
        ///撤成\废单数量
        public Int32 VolumeCanceled;
        ///备注
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REMARK_LEN)]
        public string Remark; 
        ///撤单标志
        public char CancelFlag;
        ///订单IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP; 
        ///订单MAC
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC; 
        ///订单硬盘序列号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum; 
        ///订单机器码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode; 
        ///订单操作系统
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS; 
        ///当前资金
        public double Balance;
        ///手续费
        public double Commission;
    };
    
    ///成交
    public struct STPTradeField
    {
        ///交易日
        public Int32 TradingDay;
        ///账户编号
        public Int32 AccountID;
        ///组合编号
        public Int32 ComboID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///成交编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
        public string TradeID; 
        ///买卖方向
        public char Direction;
        ///交易编码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///席位号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
        public string SeatID; 
        ///营业部代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
        public string BranchID; 
        ///证券交易代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTCODE_LEN)]
        public string InstrumentCode; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///操作员代码
        public Int32 OperatorID;
        ///请求编号
        public Int32 ORRequestID;
        ///报单编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERSYSID_LEN)]
        public string OrderSysID; 
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID; 
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef; 
        ///开平标志
        public char OffsetFlag;
        ///备兑标志
        public char CoveredFlag;
        ///投机套保标志
        public char HedgeFlag;
        ///价格
        public double Price;
        ///成交量
        public Int32 Volume;
        ///成交金额
        public double TradeAmount;
        ///成交时期
        public Int32 TradeDate;
        ///成交时间
        public Int32 TradeTime;
        ///手续费
        public double Commission;
        ///序号
        public Int32 SequenceNo;
        ///发起标志
        public char OwnerType;
    };
    
    ///风控规则
    public struct STPRiskRuleField
    {
        ///交易日
        public Int32 TradingDay;
        ///规则ID
        public Int32 RiskId;
        ///规则代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
        public string RuleCode; 
        ///公司编号
        public Int32 CompanyID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码集合
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTIDS_LEN)]
        public string InstrumentIDs; 
        ///证券控制层级
        public char InstrumentControlLevel;
        ///证券范围
        public char InstrumentRangeType;
        ///证券联合风控
        public byte InstrumentUnionFlag;
        ///账户集合
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTIDS_LEN)]
        public string AccountIDs; 
        ///账户集合控制层级
        public char AccountControlLevel;
        ///账户集合范围
        public char AccountRangeType;
        ///投资账户联合风控
        public byte AccountUnionFlag;
        ///规则名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULENAME_LEN)]
        public string RuleName; 
        ///是否活跃
        public Int32 IsActive;
        ///修改内容明细（json字符串）
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
        public string Value; 
    };
    
    ///触发风控规则日志
    public struct STPRiskRuleLogField
    {
        ///交易日
        public Int32 TradingDay;
        ///序号
        public Int32 SequenceNo;
        ///公司编号
        public Int32 CompanyID;
        ///登录成功时间
        public Int32 ExecuteTime;
        ///规则ID
        public Int32 RiskId;
        ///规则代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
        public string RuleCode; 
        ///规则名称
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULENAME_LEN)]
        public string RuleName; 
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码集合
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTIDS_LEN)]
        public string InstrumentIDs; 
        ///账户编号
        public Int32 AccountID;
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef; 
        ///规则阀值
        public double Threshold;
        ///计算指标值
        public double CalcValue;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg; 
    };
    
    ///管理员指令
    public struct STPAdminCommandField
    {
        ///交易日
        public Int32 TradingDay;
        ///序号
        public Int32 SequenceNo;
        ///操作员代码
        public Int32 OperatorID;
        ///指令代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADMINCODE_LEN)]
        public string AdminCode; 
        ///修改内容明细（json字符串）
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
        public string Value; 
        ///错误代码
        public Int32 ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg; 
    };
    
    ///指令日志
    public struct STPOperationLogField
    {
        ///交易日
        public Int32 TradingDay;
        ///操作员代码
        public Int32 OperatorID;
        ///投资者代码
        public Int32 InvestorID;
        ///登录成功时间
        public Int32 ExecuteTime;
        ///指令代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADMINCODE_LEN)]
        public string AdminCode; 
        ///修改内容明细（json字符串）
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
        public string Value; 
        ///错误代码
        public Int32 ErrorID;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg; 
    };
    
    ///持仓变动日志
    public struct STPPosChangeLogField
    {
        ///交易日
        public Int32 TradingDay;
        ///操作员代码
        public Int32 OperatorID;
        ///操作类型
        public char OperationType;
        ///变动类型
        public char ChangeType;
        ///账户编号
        public Int32 AccountID;
        ///组合编号
        public Int32 ComboID;
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///备兑标志
        public char CoveredFlag;
        ///持仓多空方向
        public char PosiDirection;
        ///登录成功时间
        public Int32 ExecuteTime;
        ///原始值
        public double OriginValue;
        ///更新值
        public double NewValue;
        ///备注
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_MEMO_LEN)]
        public string Memo; 
    };
    
    ///资金变动日志
    public struct STPActChangeLogField
    {
        ///交易日
        public Int32 TradingDay;
        ///操作员代码
        public Int32 OperatorID;
        ///操作类型
        public char OperationType;
        ///变动类型
        public char ChangeType;
        ///账户编号
        public Int32 AccountID;
        ///登录成功时间
        public Int32 ExecuteTime;
        ///原始值
        public double OriginValue;
        ///更新值
        public double NewValue;
        ///备注
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_MEMO_LEN)]
        public string Memo; 
    };
    
    ///返回信息
    public struct STPRspInfoField
    {
        ///错误代码
        public Int32 ErrorID;
        ///结束标志
        public Int32 IsLast;
        ///错误信息
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg; 
    };
    
    ///登录请求
    public struct STPUserLoginReqField
    {
        ///操作员代码
        public Int32 OperatorID;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password; 
    };
    
    ///登录请求
    public struct STPLoginReqField
    {
        ///操作员代码
        public Int32 OperatorID;
        ///密码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password; 
        ///订单IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP; 
        ///订单MAC
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC; 
        ///订单硬盘序列号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum; 
        ///订单机器码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode; 
        ///订单操作系统
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS; 
    };
    
    ///注销请求
    public struct STPLogoutReqField
    {
        ///操作员代码
        public Int32 OperatorID;
    };
    
    ///登入请求响应
    public struct STPRspLoginField
    {
        ///交易日
        public Int32 TradingDay;
        ///登录成功时间
        public Int32 LoginTime;
        ///操作员代码
        public Int32 OperatorID;
        ///前置编号
        public Int32 FrontID;
        ///会话编号
        public Int32 SessionID;
        ///最大报单引用
        public Int32 MaxOrderRef;
    };
    
    ///报单录入请求
    public struct STPOrderReqField
    {
        ///账户编号
        public Int32 AccountID;
        ///操作员代码
        public Int32 OperatorID;
        ///组合编号
        public Int32 ComboID;
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///报单引用
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef; 
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///报单价格条件
        public char OrderPriceType;
        ///买卖方向
        public char Direction;
        ///开平标志
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBOSTPETFLAG_LEN)]
        public string CombOffsetFlag; 
        ///投机套保标志
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBHEDGEFLAG_LEN)]
        public string CombHedgeFlag; 
        ///备兑标志
        public char CoveredFlag;
        ///价格
        public double LimitPrice;
        ///原始数量
        public Int32 VolumeTotalOriginal;
        ///有效期类型
        public char TimeCondition;
        ///成交量类型
        public char VolumeCondition;
        ///预留字段1
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF1_LEN)]
        public string ThirdReff1; 
        ///预留字段2
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF2_LEN)]
        public string ThirdReff2; 
        ///订单IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP; 
        ///订单MAC
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC; 
        ///订单硬盘序列号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum; 
        ///订单机器码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode; 
        ///订单操作系统
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS; 
    };
    
    ///取消报单请求
    public struct STPOrderCancelReqField
    {
        ///账户编号
        public Int32 AccountID;
        ///操作员代码
        public Int32 OperatorID;
        ///被撤单引用
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERACTIONREF_LEN)]
        public string OrderActionRef; 
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID; 
        ///订单IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP; 
        ///订单MAC
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC; 
        ///订单硬盘序列号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum; 
        ///订单机器码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode; 
        ///订单操作系统
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS; 
    };
    
    ///查询风控请求
    public struct STPQryRiskRuleField
    {
        ///规则ID
        public Int32 RiskId;
        ///规则代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
        public string RuleCode; 
    };
    
    ///查询产品信息
    public struct STPQryInstrumentField
    {
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
    };
    
    ///查询产品手续费信息
    public struct STPQryCommissionRateField
    {
        ///账户编号
        public Int32 AccountID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///买卖方向
        public char Direction;
        ///开平标志
        public char OffsetFlag;
        ///备兑标志
        public char CoveredFlag;
        ///投机套保标志
        public char HedgeFlag;
    };
    
    ///查询产品保证金率信息
    public struct STPQryMarginRateField
    {
        ///账户编号
        public Int32 AccountID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///买卖方向
        public char Direction;
        ///开平标志
        public char OffsetFlag;
        ///备兑标志
        public char CoveredFlag;
        ///投机套保标志
        public char HedgeFlag;
    };
    
    ///查询报单
    public struct STPQryOrderField
    {
        ///账户编号
        public Int32 AccountID;
        ///组合编号
        public Int32 ComboID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID; 
    };
    
    ///查询成交
    public struct STPQryTradeField
    {
        ///账户编号
        public Int32 AccountID;
        ///组合编号
        public Int32 ComboID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///成交编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
        public string TradeID; 
        ///本地报单编号
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID; 
    };
    
    ///查询账户资金
    public struct STPQryAccountAssetField
    {
        ///账户编号
        public Int32 AccountID;
    };
    
    ///查询账户基础信息
    public struct STPQryAccountField
    {
        ///账户编号
        public Int32 AccountID;
        ///查询账户类型
        public char QryAccountType;
    };
    
    ///查询投资者持仓
    public struct STPQryPositionField
    {
        ///账户编号
        public Int32 AccountID;
        ///组合编号
        public Int32 ComboID;
        ///交易所代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///证券代码
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
    };
    
    ///查询投资组合
    public struct STPQryComboField
    {
        ///账户编号
        public Int32 AccountID;
        ///组合编号
        public Int32 ComboID;
    };
    
}
  