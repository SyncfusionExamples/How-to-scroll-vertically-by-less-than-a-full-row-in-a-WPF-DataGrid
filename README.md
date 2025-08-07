# How to scroll vertically by less than a full row in a WPF DataGrid (SfDataGrid)


In [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid), vertical scrolling moves one full row at a time. You can modify this behavior to scroll by your preferred units by adjusting the vertical offset  in the [ScrollChanged](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.scrollviewer.scrollchanged?view=netframework-4.7.2) event. 

**Code snippet to scroll vertically by less than a full row:**

 
 ```csharp
sfDataGrid.Loaded += OnLoaded;

private void OnLoaded(object sender, RoutedEventArgs e)
{
    this.sfDataGrid.GetVisualContainer().ScrollOwner.ScrollChanged += OnScrollChanged;          
}

private void OnScrollChanged(object sender, ScrollChangedEventArgs e)
{
    if (e.VerticalChange == 24)
     {
        if (e.VerticalChange > 0)
         {                    
             // Here customize based on your scenario
             double newOffset = e.VerticalOffset - 12;            
             this.sfDataGrid.GetVisualContainer().SetVerticalOffset(newOffset);
         }
     }
     if (e.VerticalChange == -24)
      {
         if (e.VerticalChange < 0)
          {
              // Here customize based on your scenario
              double newOffset = e.VerticalOffset + 12;              
            this.sfDataGrid.GetVisualContainer().SetVerticalOffset(newOffset);
           }
      }
  } 
 ```

![VerticalScroll](VerticalScroll.Gif)
