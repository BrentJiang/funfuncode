
using System;
using System.Runtime.InteropServices;

namespace TBondMMDataCS
{
    ///��������
    public struct STPTradeDateField
    {
        ///������
        public Int32 TradingDay;
        ///��һ������
        public Int32 NextTradingDay;
        ///ϵͳ״̬
        public char SystemStatus;
    };
    
    ///��Ȩ��Լ
    public struct STPInstrumentField
    {
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///��Ʒ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///֤ȯ���״���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTCODE_LEN)]
        public string InstrumentCode; 
        ///��Լ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTNAME_LEN)]
        public string InstrumentName; 
        ///֤ȯ���
        public char ProductClass;
        ///��Լ��������
        public Int32 VolumeMultiple;
        ///��С�䶯��λ
        public double PriceTick;
        ///������
        public Int32 OpenDate;
        ///������
        public Int32 ExpireDate;
        ///��ǰ�Ƿ���
        public Int32 IsTrading;
        ///��Ȩִ�м۸�
        public double ExecPrice;
        ///��Ȩ���ֱ�֤��
        public double UnitMargin;
        ///������
        public Int32 TradingDay;
        ///��Ȩ��
        public Int32 ExerciseDay;
        ///��ʼ������
        public Int32 StartDeliveryDay;
        ///����������
        public Int32 EndDeliveryDay;
        ///�м�����µ���
        public Int32 MaxMarketOrderVolume;
        ///�м���С�µ���
        public Int32 MinMarketOrderVolume;
        ///�޼�����µ���
        public Int32 MaxLimitOrderVolume;
        ///�޼���С�µ���
        public Int32 MinLimitOrderVolume;
        ///��ͣ���
        public double UpperLimitPrice;
        ///��ͣ���
        public double LowerLimitPrice;
        ///��Ȩ����
        public char OptionType;
        ///��С����䶯����
        public Int32 BuyVolumeTick;
        ///��С�����䶯����
        public Int32 SellVolumeTick;
        ///������Ʒ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_UNDERLYINGINSTRUMENTID_LEN)]
        public string UnderlyingInstrumentID; 
        ///������Ʒ����
        public Int32 UnderlyingMultiple;
        ///�ر�֤ȯ��־
        public char StockRealBack;
        ///�ر��ʽ��־
        public char FundRealBack;
    };
    
    ///��˾��Ϣ
    public struct STPCompanyField
    {
        ///��˾���
        public Int32 CompanyID;
        ///��˾����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMPANYNAME_LEN)]
        public string CompanyName; 
        ///��˾����
        public char CompanyType;
        ///��ϵ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LINKMAN_LEN)]
        public string LinkMan; 
        ///��ϵ��ַ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADDRESS_LEN)]
        public string Address; 
        ///��ϵ�绰
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TEL_LEN)]
        public string Tel; 
        ///��������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EMAIL_LEN)]
        public string Email; 
    };
    
    ///��˾����Ա��Ϣ
    public struct STPOperatorField
    {
        ///����Ա����
        public Int32 OperatorID;
        ///��˾���
        public Int32 CompanyID;
        ///����Ա����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPERATORNAME_LEN)]
        public string OperatorName; 
        ///����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password; 
        ///����Ա��ɫ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPROLES_LEN)]
        public string OpRoles; 
        ///(�ѷϳ�)����Ա���Բ�ѯ���˻�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_QRYACCOUNTIDS_LEN)]
        public string QryAccountIDs; 
        ///(�ѷϳ�)����Ա���Բ������˻�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPACCOUNTIDS_LEN)]
        public string OpAccountIDs; 
        ///����Ա���Բ�ѯ����ϼ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_QRYCOMBOIDS_LEN)]
        public string QryComboIDs; 
        ///����Ա���Բ�������ϼ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPCOMBOIDS_LEN)]
        public string OpComboIDs; 
        ///����Ա�绰
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPTEL_LEN)]
        public string OpTel; 
        ///����Ա����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPEMAIL_LEN)]
        public string OpEmail; 
        ///ע��ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REGIDATE_LEN)]
        public string RegiDate; 
        ///״̬��־
        public char EnbFlag;
        ///�޸�ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_UPTTIME_LEN)]
        public string UptTime; 
        ///��¼ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LOGTIME_LEN)]
        public string LogTime; 
        ///�����޸�ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PWDUPTTIME_LEN)]
        public string PwdUptTime; 
        ///��¼����ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LOGERRTIME_LEN)]
        public string LogErrTime; 
        ///����������
        public Int32 PwdErrCnt;
        ///��ע
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REMARK_LEN)]
        public string Remark; 
        ///��˾����
        public char CompanyType;
    };
    
    ///ϵͳȨ����Ϣ
    public struct STPAuthInfoField
    {
        ///Ȩ��ID
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID; 
        ///Ȩ�޼���
        public Int32 AuthLevel;
        ///Ȩ������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHDESC_LEN)]
        public string AuthDesc; 
        ///��Ȩ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PARENTID_LEN)]
        public string ParentID; 
        ///�Ƿ����¼�Ȩ��
        public Int32 HaveSon;
        ///˳���
        public Int32 ID;
        ///״̬��־
        public char EnbFlag;
        ///ȱʡ״̬
        public Int32 IsDefault;
        ///Ȩ���Ƿ���Ϊ������ʾ�ڿ�̨
        public Int32 IsDisplay;
        ///����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTION_LEN)]
        public string Action; 
        ///����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RESV_LEN)]
        public string Resv; 
        ///����ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CRTTIME_LEN)]
        public string CrtTime; 
        ///���һ�θ���ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUPTTIME_LEN)]
        public string LastUptTime; 
        ///��������
        public char ActionType;
        ///Ȩ������
        public char AuthType;
    };
    
    ///����ԱȨ����Ϣ
    public struct STPOpAuthInfoField
    {
        ///����Ա����
        public Int32 OperatorID;
        ///Ȩ��ID
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID; 
        ///״̬��־
        public char EnbFlag;
        ///���һ��ʹ��ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUSRTIME_LEN)]
        public string LastUsrTime; 
        ///ʹ�ô���
        public Int32 UsrCount;
        ///����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RESV_LEN)]
        public string Resv; 
        ///����ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CRTTIME_LEN)]
        public string CrtTime; 
        ///���һ�θ���ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTUPTTIME_LEN)]
        public string LastUptTime; 
    };
    
    ///�ӿ�Ȩ��
    public struct STPIntefAuthInfoField
    {
        ///�ӿڱ�ʶ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CMDID_LEN)]
        public string CmdID; 
        ///Ȩ��ID
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID; 
    };
    
    ///����Ա��־
    public struct STPOpLogField
    {
        ///ϵͳ����
        public Int32 SysDate;
        ///ϵͳʱ��
        public Int32 SysTime;
        ///����Ա����
        public Int32 OperatorID;
        ///����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTION_LEN)]
        public string Action; 
        ///��������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACTIONDESC_LEN)]
        public string ActionDesc; 
    };
    
    ///��ɫ��Ϣ
    public struct STPRoleField
    {
        ///��ɫ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLEID_LEN)]
        public string RoleID; 
        ///��ɫ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLENAME_LEN)]
        public string RoleName; 
        ///��˾����
        public char CompanyType;
    };
    
    ///��ɫȨ����Ϣ
    public struct STPRoleAuthField
    {
        ///��ɫ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ROLEID_LEN)]
        public string RoleID; 
        ///Ȩ��ID
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_AUTHID_LEN)]
        public string AuthID; 
    };
    
    ///�����ļ��б�
    public struct STPFileDownloadField
    {
        ///ϵͳ����
        public Int32 SysDate;
        ///ϵͳ��ˮ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSSEQID_LEN)]
        public string SysSeqID; 
        ///����Ա����
        public Int32 OperatorID;
        ///�ļ�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILENAME_LEN)]
        public string FileName; 
        ///�ļ��洢·��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEURL_LEN)]
        public string FileUrl; 
        ///�ļ���ѯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEINFO_LEN)]
        public string FileInfo; 
        ///����ִ��״̬
        public char FileFlag;
        ///��׺�ļ�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_FILEPOSTFIX_LEN)]
        public string FilePostFix; 
        ///�ļ���������
        public Int32 CreateDate;
        ///�ļ�����ʱ��
        public Int32 CreateTime;
        ///��������
        public Int32 UpdateDate;
        ///����޸�ʱ��
        public Int32 UpdateTime;
    };
    
    ///��̨���б�
    public struct STPCmdSequenceField
    {
        ///��������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEQNAME_LEN)]
        public string SeqName; 
        ///��ǰ����ֵ
        public Int32 CurrentVal;
        ///��ǰ����ֵ
        public Int32 IncrementVal;
    };
    
    ///����Ա����������Ϣ
    public struct STPOpMarketField
    {
        ///��˾���
        public Int32 CompanyID;
        ///������������
        public char MarketDataType;
        ///����Ա����
        public Int32 OperatorID;
        ///�������Ӹ���
        public Int32 LimitConNum;
        ///�����ĸ���
        public Int32 LimitSubNum;
        ///����IP��ַ������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_IPADDRESS_LEN)]
        public string IpAddress; 
    };
    
    ///��˾����ɷ���Ϣ
    public struct STPMarketDataPayField
    {
        ///��˾���
        public Int32 CompanyID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///�ɷѿ�Ŀ
        public char PaySubject;
        ///����ɷ�ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_LASTPAYTIME_LEN)]
        public string LastPayTime; 
        ///�ɷѽ��
        public double PayBalance;
        ///��ʼ����
        public Int32 StartDate;
        ///��������
        public Int32 EndDate;
    };
    
    ///��˾����ɷ���ˮ
    public struct STPMarketDataPayFlowField
    {
        ///��ˮ���
        public Int32 PayID;
        ///��˾���
        public Int32 CompanyID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///�ɷѿ�Ŀ
        public char PaySubject;
        ///�ɷ�ʱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PAYTIME_LEN)]
        public string PayTime; 
        ///�ɷѽ��
        public double PayBalance;
        ///��ʼ����
        public Int32 StartDate;
        ///��������
        public Int32 EndDate;
    };
    
    ///�˻���Ϣ
    public struct STPAccountField
    {
        ///�˻����
        public Int32 AccountID;
        ///��˾���
        public Int32 CompanyID;
        ///�ʽ��˻�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName; 
        ///Ͷ���ߴ���
        public Int32 InvestorID;
        ///�˻�����
        public char AccountType;
        ///״̬��־
        public char EnbFlag;
        ///������
        public Int32 TradingDay;
        ///����ͨ�����
        public Int32 ChannelID;
        ///Ĭ�����
        public Int32 DefaultCombo;
    };
    
    ///Ͷ�����
    public struct STPAccountComboField
    {
        ///��ϱ��
        public Int32 ComboID;
        ///�˻����
        public Int32 AccountID;
        ///�������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBONAME_LEN)]
        public string ComboName; 
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///Ͷ����϶�Ӧ�ĺ�Լ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_KEYINSTRUMENTID_LEN)]
        public string KeyInstrumentID; 
        ///�Ƿ��Ծ
        public Int32 IsActive;
        ///ȱʡ״̬
        public Int32 IsDefault;
        ///������
        public Int32 TradingDay;
        ///�������ڽ���
        public byte DayTradeEnable;
    };
    
    ///Ͷ������Ϣ
    public struct STPInvestorField
    {
        ///Ͷ���ߴ���
        public Int32 InvestorID;
        ///������
        public Int32 TradingDay;
        ///���͹�˾����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BROKERID_LEN)]
        public string BrokerID; 
        ///ĸ�˻�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BROKERINVESTORID_LEN)]
        public string BrokerInvestorID; 
        ///�û�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_USERID_LEN)]
        public string UserID; 
        ///�ͻ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CLIENTID_LEN)]
        public string ClientID; 
        ///�ʽ��˻�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTCODE_LEN)]
        public string AccountCode; 
        ///����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password; 
        ///Ͷ��������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INVESTORNAME_LEN)]
        public string InvestorName; 
        ///Ͷ��������
        public char InvestorType;
        ///֤������
        public char IDCardType;
        ///֤����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_IDCARDNO_LEN)]
        public string IDCardNo; 
        ///�Ƿ��Ծ
        public Int32 IsActive;
        ///������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_GROUPID_LEN)]
        public string GroupID; 
        ///O32����Ա����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32OPERATORNO_LEN)]
        public string O32OperatorNo; 
        ///O32����Ա����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32OPERATORPWD_LEN)]
        public string O32OperatorPwd; 
        ///O32�������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32ACCOUNTCODE_LEN)]
        public string O32AccountCode; 
        ///O32��ϱ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32COMBINO_LEN)]
        public string O32CombiNo; 
        ///O32�ʲ���Ԫ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_O32ASSETNO_LEN)]
        public string O32AssetNo; 
    };
    
    ///Ͷ���߽��ױ���
    public struct STPTradingCodeField
    {
        ///������
        public Int32 TradingDay;
        ///�˻����
        public Int32 AccountID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///���ױ�������
        public char TradingCodeType;
        ///���ױ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///Ӫҵ������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
        public string BranchID; 
        ///ϯλ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
        public string SeatID; 
        ///Ͷ�����˻��ӱ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPTCLIENTID_LEN)]
        public string OptClientID; 
        ///�Ƿ��Ծ
        public Int32 IsActive;
    };
    
    ///����ͨ����Ϣ
    public struct STPTradeChannelField
    {
        ///����ͨ�����
        public Int32 ChannelID;
        ///ͨ������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CHANNELNAME_LEN)]
        public string ChannelName; 
        ///ͨ������
        public char ChannelType;
        ///�ֲֽӿ�IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSIP_LEN)]
        public string SysIP; 
        ///�ֲֽӿڶ˿�
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SYSPORT_LEN)]
        public string SysPort; 
        ///�ֲ���������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CHANNELCONFIG_LEN)]
        public string ChannelConfig; 
        ///������
        public Int32 TradingDay;
    };
    
    ///�˻��ʽ���Ϣ
    public struct STPAccountAssetField
    {
        ///������
        public Int32 TradingDay;
        ///�˻����
        public Int32 AccountID;
        ///���ִ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_CURRENCYID_LEN)]
        public string CurrencyID; 
        ///�ϴδ���
        public double PreDeposit;
        ///�ϴ�ռ�õı�֤��
        public double PreMargin;
        ///�ϴν���׼����
        public double PreBalance;
        ///��ǰ�ʽ�
        public double Balance;
        ///�����
        public double Deposit;
        ///����ı�֤��
        public double FrozenMargin;
        ///�����������
        public double FrozenCommission;
        ///������ʽ�
        public double FrozenCash;
        ///�ֹ�������ʽ�
        public double ManualFrozenCash;
        ///�˶Ե����ʽ�
        public double CheckCash;
        ///��λռ�ñ�֤��
        public double UseMargin;
        ///������
        public double Commission;
        ///��ȡ�ʽ�
        public double WithdrawQuota;
        ///��֤��������
        public double Credit;
        ///�ֽ�
        public double Available;
        ///ƽ��ӯ��
        public double CloseProfit;
        ///�ֲ�ӯ��
        public double PositionProfit;
        ///�ʽ���
        public double CashIn;
        ///������
        public double CashOut;
        ///ȱʡ״̬
        public Int32 IsDefault;
    };
    
    ///��ѯ�˻��ʽ���Ϣ
    public struct STPUserAccountAssetField
    {
        ///�˻����
        public Int32 AccountID;
        ///�ʽ��˻�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName; 
        ///��ǰ�ʽ�
        public double Balance;
        ///�����ʽ�
        public double EnableBalance;
        ///������ʽ�
        public double FrozenCash;
        ///�ֹ�������ʽ�
        public double ManualFrozenCash;
        ///�˶Ե����ʽ�
        public double CheckCash;
    };
    
    ///�˻��ֲ���Ϣ
    public struct STPAccountPositionField
    {
        ///�˻����
        public Int32 AccountID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///���ұ�־
        public char CoveredFlag;
        ///�ֲֶ�շ���
        public char PosiDirection;
        ///���ױ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///���ױ�������
        public char TradingCodeType;
        ///������
        public Int32 TradingDay;
        ///���ճֲ�
        public double YdPosition;
        ///�ϴ�ռ�õı�֤��
        public double PreMargin;
        ///��ֲ�
        public double TodayPosition;
        ///�ֲܳ�
        public double TotalPosition;
        ///��λռ�ñ�֤��
        public double UseMargin;
        ///������
        public double OpenVolume;
        ///ƽ����
        public double CloseVolume;
        ///ƽ�����
        public double CloseYdVolume;
        ///���ν����
        public double SettlementPrice;
        ///�ϴν����
        public double PreSettlementPrice;
        ///������
        public double Commission;
        ///�����������
        public double FrozenCommission;
        ///����ı�֤��
        public double FrozenMargin;
        ///���ֳɱ�
        public double OpenCost;
        ///�ֲֳɱ�
        public double PositionCost;
        ///ƽ��ӯ��
        public double CloseProfit;
        ///�ֲ�ӯ��
        public double PositionProfit;
        ///���ֽ��
        public double OpenAmount;
        ///ƽ�ֽ��
        public double CloseAmount;
        ///ƽ��ֽ��
        public double CloseYdAmount;
        ///��ͷ����
        public double LongFrozen;
        ///���ֶ�����
        public double LongFrozenAmount;
        ///��ͷ����
        public double ShortFrozen;
        ///���ֶ�����
        public double ShortFrozenAmount;
        ///��������
        public double FrozenVolume;
        ///�ֹ���������
        public double ManualFrozenVolume;
        ///�˶Ե�������
        public double CheckVolume;
        ///��������
        public double EnableVolume;
    };
    
    ///��ѯ��ϳֲ���Ϣ
    public struct STPUserComboPositionField
    {
        ///�˻����
        public Int32 AccountID;
        ///�ʽ��˻�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTNAME_LEN)]
        public string AccountName; 
        ///��ϱ��
        public Int32 ComboID;
        ///�������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBONAME_LEN)]
        public string ComboName; 
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///��Լ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTNAME_LEN)]
        public string InstrumentName; 
        ///�ֲܳ�
        public double TotalPosition;
        ///��������
        public double FrozenVolume;
        ///�ֹ���������
        public double ManualFrozenVolume;
        ///�˶Ե�������
        public double CheckVolume;
        ///��������
        public double EnableVolume;
        ///�ֲֳɱ�
        public double PositionCost;
        ///�ɱ���
        public double CostPrice;
        ///���¼�
        public double LastPrice;
        ///�ֲ���ֵ
        public double OpenMarketValue;
        ///����ӯ��
        public double FloatProfi;
        ///��ͷ����
        public double LongFrozen;
        ///��ͷ����
        public double ShortFrozen;
        ///���ڳ�ʼ����
        public Int32 DayTradeInitVolume;
        ///���ڿ�������
        public Int32 DayTradeAvailVolume;
        ///����ӯ��
        public double DayTradeFloatProfitLoss;
        ///���ڳֲֳɱ���
        public double DayTradePositionCost;
        ///����ƽ��ӯ��
        public double DayTradeCloseProfit;
        ///��������
        public double DayTradeAccumBuy;
        ///��������
        public double DayTradeAccumSell;
    };
    
    ///��ϳֲ���Ϣ
    public struct STPComboPositionField
    {
        ///�˻����
        public Int32 AccountID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///��ϱ��
        public Int32 ComboID;
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///���ұ�־
        public char CoveredFlag;
        ///�ֲֶ�շ���
        public char PosiDirection;
        ///���ױ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///���ױ�������
        public char TradingCodeType;
        ///������
        public Int32 TradingDay;
        ///���ճֲ�
        public double YdPosition;
        ///�ϴ�ռ�õı�֤��
        public double PreMargin;
        ///��ֲ�
        public double TodayPosition;
        ///�ֲܳ�
        public double TotalPosition;
        ///��λռ�ñ�֤��
        public double UseMargin;
        ///������
        public double OpenVolume;
        ///ƽ����
        public double CloseVolume;
        ///ƽ�����
        public double CloseYdVolume;
        ///���ν����
        public double SettlementPrice;
        ///�ϴν����
        public double PreSettlementPrice;
        ///������
        public double Commission;
        ///�����������
        public double FrozenCommission;
        ///����ı�֤��
        public double FrozenMargin;
        ///���ֳɱ�
        public double OpenCost;
        ///�ֲֳɱ�
        public double PositionCost;
        ///ƽ��ӯ��
        public double CloseProfit;
        ///�ֲ�ӯ��
        public double PositionProfit;
        ///���ֽ��
        public double OpenAmount;
        ///ƽ�ֽ��
        public double CloseAmount;
        ///ƽ��ֽ��
        public double CloseYdAmount;
        ///��ͷ����
        public double LongFrozen;
        ///���ֶ�����
        public double LongFrozenAmount;
        ///��ͷ����
        public double ShortFrozen;
        ///���ֶ�����
        public double ShortFrozenAmount;
        ///��������
        public double FrozenVolume;
        ///�ֹ���������
        public double ManualFrozenVolume;
        ///�˶Ե�������
        public double CheckVolume;
        ///��������
        public double EnableVolume;
        ///���ڳ�ʼ����
        public Int32 DayTradeInitVolume;
        ///���ڿ�������
        public Int32 DayTradeAvailVolume;
        ///����ӯ��
        public double DayTradeFloatProfitLoss;
        ///���ڳֲֳɱ���
        public double DayTradePositionCost;
        ///����ƽ��ӯ��
        public double DayTradeCloseProfit;
        ///��������
        public double DayTradeAccumBuy;
        ///��������
        public double DayTradeAccumSell;
    };
    
    ///���ڳֲֵ���
    public struct STPDayTradePositionAdjReqField
    {
        ///����Ա����
        public Int32 OperatorID;
        ///�˻����
        public Int32 AccountID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///��ϱ��
        public Int32 ComboID;
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///���ڵ�������
        public Int32 DayTradePositionAdjAmount;
        ///���ڵ��ּ۸�
        public double DayTradePositionAdjCost;
        ///������Ϣ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_OPERATEMSG_LEN)]
        public string OperateMsg; 
    };
    
    ///�˻��ֲ���ϸ
    public struct STPAccountPositionDtlField
    {
        ///�˻����
        public Int32 AccountID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///��ϱ��
        public Int32 ComboID;
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///���ұ�־
        public char CoveredFlag;
        ///�ֲֶ�շ���
        public char PosiDirection;
        ///������
        public Int32 OpenDate;
        ///�ɽ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
        public string TradeID; 
        ///���ױ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///���ױ�������
        public char TradingCodeType;
        ///������
        public Int32 TradingDay;
        ///�ɽ���
        public Int32 Volume;
        ///���ν����
        public double SettlementPrice;
        ///�ϴν����
        public double PreSettlementPrice;
        ///����
        public double OpenPrice;
        ///Ͷ���߱�֤��
        public double Margin;
        ///Ͷ���߱�֤����
        public double MarginRate;
        ///ƽ����
        public double CloseVolume;
        ///ƽ�ֽ��
        public double CloseAmount;
    };
    
    ///����������Ϣ
    public struct STPFeeSetField
    {
        ///��˾���
        public Int32 CompanyID;
        ///�˻����
        public Int32 AccountID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///֤ȯ���
        public char ProductClass;
        ///��Ʒ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID; 
        ///��������
        public char Direction;
        ///��ƽ��־
        public char OffsetFlag;
        ///���ұ�־
        public char CoveredFlag;
        ///Ͷ���ױ���־
        public char HedgeFlag;
        ///�������
        public char FeeType;
        ///���ð��ɽ�������
        public double BalanceRatio;
        ///���ð��ɽ���ֵ����
        public double FaceValueRatio;
        ///���ð��ɽ���������
        public double AmountRatio;
        ///����շ�
        public double MaxFee;
        ///����շ�
        public double MinFee;
        ///���ü���ģʽ
        public char CalculateType;
        ///������
        public Int32 TradingDay;
    };
    
    ///��֤����
    public struct STPMarginRateField
    {
        ///������
        public Int32 TradingDay;
        ///�˻����
        public Int32 AccountID;
        ///Ͷ���߷�Χ
        public char InvestorRange;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///���ұ�־
        public char CoveredFlag;
        ///Ͷ���ױ���־
        public char HedgeFlag;
        ///��Ȩ����
        public char OptionType;
        ///֤ȯ���
        public char ProductClass;
        ///��Ʒ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PRODUCTID_LEN)]
        public string ProductID; 
        ///��ͷ��֤����
        public double LongMarginRatioByMoney;
        ///��ͷ��֤���
        public double LongMarginRatioByVolume;
        ///��ͷ��֤����
        public double ShortMarginRatioByMoney;
        ///��ͷ��֤���
        public double ShortMarginRatioByVolume;
        ///�Ƿ񰴱����ϸ�
        public Int32 IsFloat;
    };
    
    ///����
    public struct STPOrderField
    {
        ///������
        public Int32 TradingDay;
        ///�˻����
        public Int32 AccountID;
        ///��ϱ��
        public Int32 ComboID;
        ///�Ự���
        public Int32 SessionID;
        ///ǰ�ñ��
        public Int32 FrontID;
        ///��������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef; 
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///ϯλ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
        public string SeatID; 
        ///���ر������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID; 
        ///��������
        public char Direction;
        ///����Ա����
        public Int32 OperatorID;
        ///���ױ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///Ӫҵ������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
        public string BranchID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///�����۸�����
        public char OrderPriceType;
        ///��ƽ��־
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBOSTPETFLAG_LEN)]
        public string CombOffsetFlag; 
        ///Ͷ���ױ���־
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBHEDGEFLAG_LEN)]
        public string CombHedgeFlag; 
        ///���ұ�־
        public char CoveredFlag;
        ///�۸�
        public double LimitPrice;
        ///ԭʼ����
        public Int32 VolumeTotalOriginal;
        ///��Ч������
        public char TimeCondition;
        ///�ɽ�������
        public char VolumeCondition;
        ///��С�ɽ���
        public Int32 MinVolume;
        ///��������
        public char ContingentCondition;
        ///ֹ���
        public double StopPrice;
        ///������
        public Int32 ORRequestID;
        ///�������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERSYSID_LEN)]
        public string OrderSysID; 
        ///����״̬
        public char OrderStatus;
        ///��������
        public char OrderType;
        ///��ɽ�����
        public Int32 VolumeTraded;
        ///��ɽ����
        public double AmountTraded;
        ///ʣ������
        public Int32 VolumeRemain;
        ///��������
        public Int32 InsertDate;
        ///ί��ʱ��
        public Int32 InsertTime;
        ///����޸�ʱ��
        public Int32 UpdateTime;
        ///����ʱ��
        public Int32 CancelTime;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERACTIONREF_LEN)]
        public string OrderActionRef; 
        ///״̬��Ϣ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_STATUSMSG_LEN)]
        public string StatusMsg; 
        ///�����־
        public char OwnerType;
        ///Ԥ���ֶ�1
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF1_LEN)]
        public string ThirdReff1; 
        ///Ԥ���ֶ�2
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF2_LEN)]
        public string ThirdReff2; 
        ///����\�ϵ�����
        public Int32 VolumeCanceled;
        ///��ע
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_REMARK_LEN)]
        public string Remark; 
        ///������־
        public char CancelFlag;
        ///����IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP; 
        ///����MAC
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC; 
        ///����Ӳ�����к�
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum; 
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode; 
        ///��������ϵͳ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS; 
        ///��ǰ�ʽ�
        public double Balance;
        ///������
        public double Commission;
    };
    
    ///�ɽ�
    public struct STPTradeField
    {
        ///������
        public Int32 TradingDay;
        ///�˻����
        public Int32 AccountID;
        ///��ϱ��
        public Int32 ComboID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///�ɽ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
        public string TradeID; 
        ///��������
        public char Direction;
        ///���ױ���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADECODE_LEN)]
        public string TradeCode; 
        ///ϯλ��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_SEATID_LEN)]
        public string SeatID; 
        ///Ӫҵ������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_BRANCHID_LEN)]
        public string BranchID; 
        ///֤ȯ���״���
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTCODE_LEN)]
        public string InstrumentCode; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///����Ա����
        public Int32 OperatorID;
        ///������
        public Int32 ORRequestID;
        ///�������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERSYSID_LEN)]
        public string OrderSysID; 
        ///���ر������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID; 
        ///��������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef; 
        ///��ƽ��־
        public char OffsetFlag;
        ///���ұ�־
        public char CoveredFlag;
        ///Ͷ���ױ���־
        public char HedgeFlag;
        ///�۸�
        public double Price;
        ///�ɽ���
        public Int32 Volume;
        ///�ɽ����
        public double TradeAmount;
        ///�ɽ�ʱ��
        public Int32 TradeDate;
        ///�ɽ�ʱ��
        public Int32 TradeTime;
        ///������
        public double Commission;
        ///���
        public Int32 SequenceNo;
        ///�����־
        public char OwnerType;
    };
    
    ///��ع���
    public struct STPRiskRuleField
    {
        ///������
        public Int32 TradingDay;
        ///����ID
        public Int32 RiskId;
        ///�������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
        public string RuleCode; 
        ///��˾���
        public Int32 CompanyID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ���뼯��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTIDS_LEN)]
        public string InstrumentIDs; 
        ///֤ȯ���Ʋ㼶
        public char InstrumentControlLevel;
        ///֤ȯ��Χ
        public char InstrumentRangeType;
        ///֤ȯ���Ϸ��
        public byte InstrumentUnionFlag;
        ///�˻�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ACCOUNTIDS_LEN)]
        public string AccountIDs; 
        ///�˻����Ͽ��Ʋ㼶
        public char AccountControlLevel;
        ///�˻����Ϸ�Χ
        public char AccountRangeType;
        ///Ͷ���˻����Ϸ��
        public byte AccountUnionFlag;
        ///��������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULENAME_LEN)]
        public string RuleName; 
        ///�Ƿ��Ծ
        public Int32 IsActive;
        ///�޸�������ϸ��json�ַ�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
        public string Value; 
    };
    
    ///������ع�����־
    public struct STPRiskRuleLogField
    {
        ///������
        public Int32 TradingDay;
        ///���
        public Int32 SequenceNo;
        ///��˾���
        public Int32 CompanyID;
        ///��¼�ɹ�ʱ��
        public Int32 ExecuteTime;
        ///����ID
        public Int32 RiskId;
        ///�������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
        public string RuleCode; 
        ///��������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULENAME_LEN)]
        public string RuleName; 
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ���뼯��
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTIDS_LEN)]
        public string InstrumentIDs; 
        ///�˻����
        public Int32 AccountID;
        ///��������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef; 
        ///����ֵ
        public double Threshold;
        ///����ָ��ֵ
        public double CalcValue;
        ///������Ϣ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg; 
    };
    
    ///����Աָ��
    public struct STPAdminCommandField
    {
        ///������
        public Int32 TradingDay;
        ///���
        public Int32 SequenceNo;
        ///����Ա����
        public Int32 OperatorID;
        ///ָ�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADMINCODE_LEN)]
        public string AdminCode; 
        ///�޸�������ϸ��json�ַ�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
        public string Value; 
        ///�������
        public Int32 ErrorID;
        ///������Ϣ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg; 
    };
    
    ///ָ����־
    public struct STPOperationLogField
    {
        ///������
        public Int32 TradingDay;
        ///����Ա����
        public Int32 OperatorID;
        ///Ͷ���ߴ���
        public Int32 InvestorID;
        ///��¼�ɹ�ʱ��
        public Int32 ExecuteTime;
        ///ָ�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ADMINCODE_LEN)]
        public string AdminCode; 
        ///�޸�������ϸ��json�ַ�����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_VALUE_LEN)]
        public string Value; 
        ///�������
        public Int32 ErrorID;
        ///������Ϣ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg; 
    };
    
    ///�ֱֲ䶯��־
    public struct STPPosChangeLogField
    {
        ///������
        public Int32 TradingDay;
        ///����Ա����
        public Int32 OperatorID;
        ///��������
        public char OperationType;
        ///�䶯����
        public char ChangeType;
        ///�˻����
        public Int32 AccountID;
        ///��ϱ��
        public Int32 ComboID;
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///���ұ�־
        public char CoveredFlag;
        ///�ֲֶ�շ���
        public char PosiDirection;
        ///��¼�ɹ�ʱ��
        public Int32 ExecuteTime;
        ///ԭʼֵ
        public double OriginValue;
        ///����ֵ
        public double NewValue;
        ///��ע
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_MEMO_LEN)]
        public string Memo; 
    };
    
    ///�ʽ�䶯��־
    public struct STPActChangeLogField
    {
        ///������
        public Int32 TradingDay;
        ///����Ա����
        public Int32 OperatorID;
        ///��������
        public char OperationType;
        ///�䶯����
        public char ChangeType;
        ///�˻����
        public Int32 AccountID;
        ///��¼�ɹ�ʱ��
        public Int32 ExecuteTime;
        ///ԭʼֵ
        public double OriginValue;
        ///����ֵ
        public double NewValue;
        ///��ע
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_MEMO_LEN)]
        public string Memo; 
    };
    
    ///������Ϣ
    public struct STPRspInfoField
    {
        ///�������
        public Int32 ErrorID;
        ///������־
        public Int32 IsLast;
        ///������Ϣ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ERRORMSG_LEN)]
        public string ErrorMsg; 
    };
    
    ///��¼����
    public struct STPUserLoginReqField
    {
        ///����Ա����
        public Int32 OperatorID;
        ///����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password; 
    };
    
    ///��¼����
    public struct STPLoginReqField
    {
        ///����Ա����
        public Int32 OperatorID;
        ///����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_PASSWORD_LEN)]
        public string Password; 
        ///����IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP; 
        ///����MAC
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC; 
        ///����Ӳ�����к�
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum; 
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode; 
        ///��������ϵͳ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS; 
    };
    
    ///ע������
    public struct STPLogoutReqField
    {
        ///����Ա����
        public Int32 OperatorID;
    };
    
    ///����������Ӧ
    public struct STPRspLoginField
    {
        ///������
        public Int32 TradingDay;
        ///��¼�ɹ�ʱ��
        public Int32 LoginTime;
        ///����Ա����
        public Int32 OperatorID;
        ///ǰ�ñ��
        public Int32 FrontID;
        ///�Ự���
        public Int32 SessionID;
        ///��󱨵�����
        public Int32 MaxOrderRef;
    };
    
    ///����¼������
    public struct STPOrderReqField
    {
        ///�˻����
        public Int32 AccountID;
        ///����Ա����
        public Int32 OperatorID;
        ///��ϱ��
        public Int32 ComboID;
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///��������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERREF_LEN)]
        public string OrderRef; 
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///�����۸�����
        public char OrderPriceType;
        ///��������
        public char Direction;
        ///��ƽ��־
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBOSTPETFLAG_LEN)]
        public string CombOffsetFlag; 
        ///Ͷ���ױ���־
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_COMBHEDGEFLAG_LEN)]
        public string CombHedgeFlag; 
        ///���ұ�־
        public char CoveredFlag;
        ///�۸�
        public double LimitPrice;
        ///ԭʼ����
        public Int32 VolumeTotalOriginal;
        ///��Ч������
        public char TimeCondition;
        ///�ɽ�������
        public char VolumeCondition;
        ///Ԥ���ֶ�1
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF1_LEN)]
        public string ThirdReff1; 
        ///Ԥ���ֶ�2
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_THIRDREFF2_LEN)]
        public string ThirdReff2; 
        ///����IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP; 
        ///����MAC
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC; 
        ///����Ӳ�����к�
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum; 
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode; 
        ///��������ϵͳ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS; 
    };
    
    ///ȡ����������
    public struct STPOrderCancelReqField
    {
        ///�˻����
        public Int32 AccountID;
        ///����Ա����
        public Int32 OperatorID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERACTIONREF_LEN)]
        public string OrderActionRef; 
        ///���ر������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID; 
        ///����IP
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERIP_LEN)]
        public string OrderIP; 
        ///����MAC
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMAC_LEN)]
        public string OrderMAC; 
        ///����Ӳ�����к�
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERHDNUM_LEN)]
        public string OrderHDNum; 
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERMACCODE_LEN)]
        public string OrderMacCode; 
        ///��������ϵͳ
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDEROS_LEN)]
        public string OrderOS; 
    };
    
    ///��ѯ�������
    public struct STPQryRiskRuleField
    {
        ///����ID
        public Int32 RiskId;
        ///�������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_RULECODE_LEN)]
        public string RuleCode; 
    };
    
    ///��ѯ��Ʒ��Ϣ
    public struct STPQryInstrumentField
    {
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
    };
    
    ///��ѯ��Ʒ��������Ϣ
    public struct STPQryCommissionRateField
    {
        ///�˻����
        public Int32 AccountID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///��������
        public char Direction;
        ///��ƽ��־
        public char OffsetFlag;
        ///���ұ�־
        public char CoveredFlag;
        ///Ͷ���ױ���־
        public char HedgeFlag;
    };
    
    ///��ѯ��Ʒ��֤������Ϣ
    public struct STPQryMarginRateField
    {
        ///�˻����
        public Int32 AccountID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///��������
        public char Direction;
        ///��ƽ��־
        public char OffsetFlag;
        ///���ұ�־
        public char CoveredFlag;
        ///Ͷ���ױ���־
        public char HedgeFlag;
    };
    
    ///��ѯ����
    public struct STPQryOrderField
    {
        ///�˻����
        public Int32 AccountID;
        ///��ϱ��
        public Int32 ComboID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///���ر������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID; 
    };
    
    ///��ѯ�ɽ�
    public struct STPQryTradeField
    {
        ///�˻����
        public Int32 AccountID;
        ///��ϱ��
        public Int32 ComboID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
        ///�ɽ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TRADEID_LEN)]
        public string TradeID; 
        ///���ر������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_ORDERLOCALID_LEN)]
        public string OrderLocalID; 
    };
    
    ///��ѯ�˻��ʽ�
    public struct STPQryAccountAssetField
    {
        ///�˻����
        public Int32 AccountID;
    };
    
    ///��ѯ�˻�������Ϣ
    public struct STPQryAccountField
    {
        ///�˻����
        public Int32 AccountID;
        ///��ѯ�˻�����
        public char QryAccountType;
    };
    
    ///��ѯͶ���ֲ߳�
    public struct STPQryPositionField
    {
        ///�˻����
        public Int32 AccountID;
        ///��ϱ��
        public Int32 ComboID;
        ///����������
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_EXCHANGEID_LEN)]
        public string ExchangeID; 
        ///֤ȯ����
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_INSTRUMENTID_LEN)]
        public string InstrumentID; 
    };
    
    ///��ѯͶ�����
    public struct STPQryComboField
    {
        ///�˻����
        public Int32 AccountID;
        ///��ϱ��
        public Int32 ComboID;
    };
    
}
  