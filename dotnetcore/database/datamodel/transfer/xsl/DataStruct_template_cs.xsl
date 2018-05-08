<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>


  <xsl:template match="/">
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace database.entitymodel
{<no_new_line />
    <xsl:for-each select="/EntityModel/Entities/Entity"><no_new_line />
    ///<xsl:value-of select="@title"/>
    public class Stp<xsl:value-of select="translate(@name, ' ', '')"/> // struct
    {<no_new_line />
	  <xsl:variable name="keynum" select="Field[@iskey='yes']" />
	  <xsl:if test="count($keynum)=0">
        [Key]
        public Int64 SmallSysId { get; set; }
	  </xsl:if>
      <xsl:for-each select="Field">
        <xsl:variable name="name" select="@name"/>
        <xsl:variable name="position" select="position()"/>
        <xsl:for-each select="/EntityModel/Fields/Field[@name=$name]">
          <xsl:if test="position()=last()">
        ///<xsl:value-of select="@label"/>
		//[Column("I<xsl:value-of select="$position"/>")]<no_new_line />
            <xsl:choose>
              <xsl:when test="@type='String'">
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_<xsl:value-of select="translate(@name, $lowercase, $uppercase)"/>_LEN)]
		[StringLength(CommonDef.STP_<xsl:value-of select="translate(@name, $lowercase, $uppercase)"/>_LEN)]
        public string <xsl:value-of select="translate(@name, ' ', '')"/> { get; set; } <no_new_line />
              </xsl:when>
              <xsl:when test="@type='Int'">
        public Int32 <xsl:value-of select="translate(@name, ' ', '')"/> { get; set; }<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Int64'">
        public Int64 <xsl:value-of select="translate(@name, ' ', '')"/> { get; set; }<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Double'">
        public double <xsl:value-of select="translate(@name, ' ', '')"/> { get; set; }<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Date'">
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_DATE_LEN)]
        public string <xsl:value-of select="translate(@name, ' ', '')"/> { get; set; }<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Time'">
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CommonDef.STP_TIME_LEN)]
        public string <xsl:value-of select="translate(@name, ' ', '')"/> { get; set; }<no_new_line />
              </xsl:when>
              <xsl:when test="@type='Bool'">
        public byte <xsl:value-of select="translate(@name, ' ', '')"/> { get; set; }<no_new_line />
              </xsl:when>
              <xsl:when test="@type='EnumChar'">
        public char <xsl:value-of select="translate(@name, ' ', '')"/> { get; set; }<no_new_line />
              </xsl:when>
              <xsl:otherwise>
                <xsl:message>
                  TYPE DOES NOT EXIST![<xsl:value-of select="@type"/>]
                </xsl:message>
              </xsl:otherwise>
            </xsl:choose>
          </xsl:if>
        </xsl:for-each>
      </xsl:for-each>
    };
	</xsl:for-each>
}
  </xsl:template>
</xsl:stylesheet>