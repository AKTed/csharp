Imports System
Imports Xunit

Public Class PerfectNumbersTests
    <Fact>
    Public Sub Smallest_perfect_number_is_classified_correctly()
        Assert.Equal(Classification.Perfect, Classify(6))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Medium_perfect_number_is_classified_correctly()
        Assert.Equal(Classification.Perfect, Classify(28))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Large_perfect_number_is_classified_correctly()
        Assert.Equal(Classification.Perfect, Classify(33550336))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Smallest_abundant_number_is_classified_correctly()
        Assert.Equal(Classification.Abundant, Classify(12))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Medium_abundant_number_is_classified_correctly()
        Assert.Equal(Classification.Abundant, Classify(30))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Large_abundant_number_is_classified_correctly()
        Assert.Equal(Classification.Abundant, Classify(33550335))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Smallest_prime_deficient_number_is_classified_correctly()
        Assert.Equal(Classification.Deficient, Classify(2))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Smallest_non_prime_deficient_number_is_classified_correctly()
        Assert.Equal(Classification.Deficient, Classify(4))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Medium_deficient_number_is_classified_correctly()
        Assert.Equal(Classification.Deficient, Classify(32))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Large_deficient_number_is_classified_correctly()
        Assert.Equal(Classification.Deficient, Classify(33550337))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Edge_case_no_factors_other_than_itself_is_classified_correctly()
        Assert.Equal(Classification.Deficient, Classify(1))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Zero_is_rejected_as_it_is_not_a_positive_integer_()
        Assert.Throws(Of ArgumentOutOfRangeException)(Function() Classify(0))
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Negative_integer_is_rejected_as_it_is_not_a_positive_integer_()
        Assert.Throws(Of ArgumentOutOfRangeException)(Function() Classify(-1))
    End Sub
End Class
