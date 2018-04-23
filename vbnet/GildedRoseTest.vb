Imports Xunit

Public Class GildedRoseTest
    <Fact>
    Public Sub foo()
        Dim Items As IList(Of Item) = New List(Of Item) From {New Item With {.Name = "foo", .SellIn = 0, .Quality = 0}}
        Dim app = New GildedRose(Items)
        app.UpdateQuality()
        Assert.Equal("fixme", Items(0).Name)
    End Sub
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by Refactoring Essentials.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
