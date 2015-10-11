<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  xmlns:students="hogwarts.students">
    <xsl:template match="/">
        <html>
            <link rel="stylesheet" type="text/css" href="styles/foundation.min.css"/>
            <body>
                <h1>Hogwarts Students</h1>
                <ul class="medium-block-grid-3 no-bullet">
                    <xsl:for-each select="students/students:student">
                    <li>
                        <ul class="no-bullet vcard nav-bar">
                            <li><h3 class="subheader">Name</h3><h4><xsl:value-of select="students:name"/></h4></li>
                            <li><h3 class="subheader">Sex</h3><h4><xsl:value-of select="students:sex"/></h4></li>
                            <li><h3 class="subheader">Birth</h3><h4><xsl:value-of select="students:birth"/></h4></li>
                            <li><h3 class="subheader">Phone</h3><h4><xsl:value-of select="students:phone"/></h4></li>
                            <li><h3 class="subheader">Email</h3><h4><xsl:value-of select="students:email"/></h4></li>
                            <li><h3 class="subheader">Course</h3><h4><xsl:value-of select="students:course"/></h4></li>
                            <li><h3 class="subheader">Specialty</h3><h4><xsl:value-of select="students:specialty"/></h4></li>
                            <li><h3 class="subheader">Faculty Number</h3><h4><xsl:value-of select="students:facultyNumber"/></h4></li>
                            <li>
                                <h4>Exams:</h4>
                                <xsl:for-each select="students:exams/students:exam">
                                    <ul class="no-bullet side-nav large-block-grid-3">
                                        <li><h5>Exam</h5><h6><xsl:value-of select="students:examName"/></h6></li>
                                        <li><h5>Tutor</h5><h6><xsl:value-of select="students:tutor"/></h6></li>
                                        <li><h5>Score</h5><h6><xsl:value-of select="students:score"/></h6></li>
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