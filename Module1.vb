Imports System.Data.OracleClient
Module Module1
    Public cn As New OracleConnection
    Public cmd As New OracleCommand
    Public dr As OracleDataReader
    Sub koneksi()

        cn.Close()
        cn = New OracleConnection("data source=(DESCRIPTION = " &
        "(ADDRESS = (PROTOCOL = TCP)(HOST = LAPTOP-31QAL627)(PORT = 1521)) " &
        "(CONNECT_DATA = " &
        "(SERVER = DEDICATED) " &
        "(SERVICE_NAME = XE) " &
        ")" &
        "); user id = SYSTEM; password = SYSTEM;")
        cn.Open()
    End Sub
End Module
