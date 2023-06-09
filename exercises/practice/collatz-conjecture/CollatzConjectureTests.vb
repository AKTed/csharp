Imports System
Imports Xunit

Public Class CollatzConjectureTests
    <Fact>
    Public Sub Zero_steps_for_one()
        Assert.Equal(0, Steps(1))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Divide_if_even()
        Assert.Equal(4, Steps(16))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Even_and_odd_steps()
        Assert.Equal(9, Steps(12))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Large_number_of_even_and_odd_steps()
        Assert.Equal(152, Steps(1000000))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Zero_is_an_error()
        Assert.Throws(Of ArgumentOutOfRangeException)(Function() Steps(0))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Negative_value_is_an_error()
        Assert.Throws(Of ArgumentOutOfRangeException)(Function() Steps(-15))
    End Sub
End Class
