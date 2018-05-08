<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312" />

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'" />
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'" />

  <xsl:template match="/">
    <no_new_line />
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace database.entitymodel
{
    /// AdminCodeType是一个管理员命令类型
    public enum eStpAdminCode
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
    <no_new_line />
    <xsl:for-each select="EntityModel/Fields/Field[@type='EnumChar']">
      <xsl:variable name="prefix" select="@prefix" />
    /// <xsl:text >&lt;summary&gt;</xsl:text>
    /// <xsl:value-of select="@name" />Type是一个<xsl:value-of select="@label" />类型
    /// <xsl:text >&lt;/summary&gt;</xsl:text>
    public enum eStp<xsl:value-of select="@name" />
    {<no_new_line />
      <xsl:for-each select="enum">
        [Description("<xsl:value-of select="@label" />")]
        STP_<xsl:value-of select="$prefix" />_<xsl:value-of select="@name" /> = '<xsl:value-of select="@value" />', <no_new_line />
      </xsl:for-each>
    }
    </xsl:for-each>
}
  </xsl:template>
</xsl:stylesheet>