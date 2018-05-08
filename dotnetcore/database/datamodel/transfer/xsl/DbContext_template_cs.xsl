<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="text" encoding="GB2312"/>

  <xsl:variable name="lowercase" select="'abcdefghijklmnopqrstuvwxyz'"/>
  <xsl:variable name="uppercase" select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"/>


  <xsl:template match="/">
using System;
using System.IO;
using System.Net;
using Microsoft.EntityFrameworkCore;
using database.entitymodel;

namespace database.database
{<no_new_line />
    public class TradeContext : DbContext
    {
        public TradeContext(DbContextOptions&lt;TradeContext&gt; options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    <xsl:for-each select="/EntityModel/Entities/Entity"><no_new_line />
      <xsl:if test="@dbTable='yes'">
        <xsl:variable name="name" select="@name"/>
        <xsl:variable name="keynum" select="Field[@iskey='yes']" />
        <xsl:if test="count($keynum)>0">
            /// total <xsl:value-of select="count($keynum)"/> key-elements
            modelBuilder.Entity&lt;Stp<xsl:value-of select="$name"/>&gt;().HasKey(b => new  {<no_new_line /> 
        </xsl:if>
        <xsl:for-each select="Field">
          <xsl:if test="@iskey='yes'">
                b.<xsl:value-of select="@name"/>,<no_new_line />
          </xsl:if>
        </xsl:for-each>
        <xsl:if test="count($keynum)>0">
            });
        </xsl:if>
      </xsl:if>
    </xsl:for-each>
        }

    <xsl:for-each select="/EntityModel/Entities/Entity"><no_new_line />
      <xsl:if test="@dbTable='yes'">
        public DbSet&lt;Stp<xsl:value-of select="@name"/>&gt; <xsl:value-of select="@name"/> { get; set; }
      </xsl:if>
    </xsl:for-each>
    }
<![CDATA[

    /// <summary>
    /// A factory to create an instance of the StudentsContext 
    /// </summary>
    /// <remarks>
    /// for MySQL, see https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework-core.html
    ///  Install-Package MySql.Data.EntityFrameworkCore -Version 8.0.11	
    /// </remarks>
    public static class ContextFactory
    {
        public static TradeContext Create(string connectionString)
        {
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<TradeContext>();
                if (IsMySQLConnectionString(connectionString))
                {
                    optionsBuilder.UseMySQL(connectionString);
                }
                else
                {
                    optionsBuilder.UseSqlite(connectionString);
                }

                // Ensure that the SQLite database and sechema is created!
                var context = new TradeContext(optionsBuilder.Options);
                context.Database.EnsureCreated();

                return context;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static bool IsMySQLConnectionString(string connectionString)
        {
            return connectionString.Contains("server")
                && connectionString.Contains("database")
                && connectionString.Contains("user")
                && connectionString.Contains("password")
                ;
        }

        public static string MakeMySQLConnectionString(string schema, string server)
        {
            return $"server={server};database=pb_{schema};user=trade;password=zij/)Z3sO0;persistsecurityinfo=True;SslMode=none";
        }

        public static TradeContext GetContext(string schema, string dbInfo)
        {
            TradeContext context = null;
            IPAddress address = null;
            try
            {
                if (IPAddress.TryParse(dbInfo, out address)) // IsUnc
                {
                    context = ContextFactory.Create(ContextFactory.MakeMySQLConnectionString(schema, dbInfo));
                }
                else
                {
                    var fn = $"{dbInfo.Replace('\\', '/').TrimEnd('/')}";
                    Directory.CreateDirectory(fn);
                    context = ContextFactory.Create($"DataSource={fn}/pb_{dbInfo.Trim()}.db");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return context;
        }
	}
]]>
}
  </xsl:template>
</xsl:stylesheet>