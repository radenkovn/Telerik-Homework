<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <body>
                <ul>
                    <xsl:for-each select="albums/album">
                        <li>
                            <ul>
                                <li><h3>Name</h3><h4><xsl:value-of select="name"/></h4></li>
                                <li><h3>Artist</h3><h4><xsl:value-of select="artist"/></h4></li>
                                <li><h3>Year</h3><h4><xsl:value-of select="year"/></h4></li>
                                <li><h3>Producer</h3><h4><xsl:value-of select="producer"/></h4></li>
                                <li><h3>Price</h3><h4><xsl:value-of select="price"/></h4></li>
                                <li>
                                    <h3>Songs: </h3>
                                    <xsl:for-each select="songs/song">
                                        <ul>
                                            <li><h5>Title</h5><h6><xsl:value-of select="title"/></h6></li>
                                            <li><h5>Duration</h5><h6><xsl:value-of select="duration"/></h6></li>
                                        </ul>
                                    </xsl:for-each>
                                </li>
                            </ul>
                        </li>
                    </xsl:for-each>
                </ul>
            </body>
        </html>
    </xsl:template>

</xsl:stylesheet>