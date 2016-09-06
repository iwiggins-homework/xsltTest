<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>
    <xsl:template match="/">
        <books>
            <xsl:for-each select="books/book">
                    <book>
                        <author>
                            <xsl:value-of select="@author"/>
                        </author>
                        <title>
                            <xsl:value-of select="@title"/>
                        </title>
                    </book>
            </xsl:for-each>
        </books>
    </xsl:template>
    
</xsl:stylesheet>
