<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>
  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>


  <xsl:template match="/">
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace database.entitymodel
{
    public class StpEnumItem
    {
        public string Name { get; set; }
        public char Value { get; set; }
    };
    
    <xsl:for-each select="EntityModel/Fields/Field[@type='EnumChar']">
      <xsl:variable name="prefix" select="@prefix"/>
      <xsl:variable name="name" select="translate(@name, ' ', '')"/>
    public enum Stp<xsl:copy-of select="$name"/>Enum 
    {
		  <xsl:for-each select="enum">
        <!--use @name to set value of enum-->
        <xsl:value-of select="$prefix"/><xsl:value-of select="translate(@name, ' ', '')"/><xsl:if test="position()!=last()">, </xsl:if>
      </xsl:for-each>
    };
      <xsl:text> </xsl:text>
		</xsl:for-each>
    
    <xsl:for-each select="EntityModel/Fields/Field[@type='EnumInt']">
      <xsl:variable name="prefix" select="@prefix"/>
      <xsl:variable name="name" select="translate(@name, ' ', '')"/>
    public enum Stp<xsl:copy-of select="$name"/>Enum 
    {
		  <xsl:for-each select="enum">
        <!--use @name to set value of enum-->
        <xsl:value-of select="$prefix"/><xsl:value-of select="translate(@name, ' ', '')"/><xsl:if test="position()!=last()">, </xsl:if>
      </xsl:for-each>
    };
      <xsl:text> </xsl:text>
		</xsl:for-each>

    public static partial class CommonDef
    {
    <xsl:for-each select="EntityModel/Fields/Field[@type='EnumChar']">
      <xsl:variable name="prefix" select="translate(@prefix, ' ', '')"/>
      <xsl:variable name="name" select="translate(@name, ' ', '')"/>
		  <xsl:for-each select="enum">
        public const char STP_<xsl:value-of select="$prefix"/>_<xsl:value-of select="translate(@name, ' ', '')"/> = '<xsl:value-of select="@value"/>'; <no_new_line />
        public const string STP_<xsl:copy-of select="$prefix"/>_<xsl:value-of select="translate(@name, ' ', '')"/>_Label = "<xsl:value-of select="@label"/>"; <no_new_line />
      </xsl:for-each>
      <xsl:text> </xsl:text>
		</xsl:for-each>
    <xsl:for-each select="EntityModel/Fields/Field[@type='EnumInt']">
      <xsl:variable name="prefix" select="translate(@prefix, ' ', '')"/>
      <xsl:variable name="name" select="translate(@name, ' ', '')"/>
		  <xsl:for-each select="enum">
        public const char STP_<xsl:value-of select="$prefix"/>_<xsl:value-of select="translate(@name, ' ', '')"/> = <xsl:value-of select="@value"/>; <no_new_line />
        public const string STP_<xsl:copy-of select="$prefix"/>_<xsl:value-of select="translate(@name, ' ', '')"/>_Label = "<xsl:value-of select="@label"/>"; <no_new_line />
      </xsl:for-each>
      <xsl:text> </xsl:text>
		</xsl:for-each>

        /////////////////////////////////////////////////////////////////////////
        ///常量定义
        /////////////////////////////////////////////////////////////////////////
        ///时间长度定义
        public const int STP_TIME_LEN = (9+1) ;
        ///日期长度定义
        public const int STP_DATE_LEN = (8+1) ;

	  <xsl:for-each select="EntityModel/Fields/Field[@type='String']">
        ///<xsl:value-of select="@label"/>长度的定义
  	    public const int STP_<xsl:value-of select="translate(@name, $lowercase, $uppercase)"/>_LEN = (<xsl:value-of select="@length"/> + 1); <no_new_line />
		</xsl:for-each>
    };
}

  </xsl:template>
</xsl:stylesheet>