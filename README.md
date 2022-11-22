# bind-the-data-to-comboboxadv
## Bind to data
To bind the ComboBoxAdv to data, bind the collection created ItemsSource property.

# C#
    <syncfusion:ComboBoxAdv x:Name="comboBoxAdv" Height="30" Width="200" ItemsSource="{Binding PopulationDetails}"/>

## Binding display member
DisplayMemberPath denotes the path to a value on the data object for visual presentation of item to be displayed in combobox drop down list and displays the selected item in ComboBoxAdv.

# C#
      <syncfusion:ComboBoxAdv x:Name="comboBoxAdv" Height="30" Width="200" ItemsSource="{Binding PopulationDetails}" DisplayMemberPath="Country"/>

For more details please refer [Bind Data to ComboBox](https://help.syncfusion.com/wpf/combobox/getting-started#binding-to-data)

![Bind data to combobox](ComboBox/Image/Bind%20data%20ComboBox.png)

