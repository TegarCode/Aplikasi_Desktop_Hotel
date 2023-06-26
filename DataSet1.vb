Partial Class DataSet1
    Partial Public Class TBLTRANSAKSIKUDataTable
        Private Sub TBLTRANSAKSIKUDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NAMAColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub TBLTRANSAKSIKUDataTable_TBLTRANSAKSIKURowChanging(sender As Object, e As TBLTRANSAKSIKURowChangeEvent) Handles Me.TBLTRANSAKSIKURowChanging

        End Sub

    End Class
End Class

Namespace DataSet1TableAdapters

    Partial Public Class TBLTRANSAKSIKUTableAdapter
    End Class
End Namespace
