# Bind the data to comboboxadv
This session describes how to bind the data to comboboxadv.
# Adding items by DataBinding
The items in ComboBoxAdv can be added by data binding by following below procedure.

**Creating Model and ViewModel data for DataBinding**
1. Create data object class named PopulationInfo and declare properties as shown below,

**[C#]**
```
public class PopulationInfo
{
        private string continent;
        private double population;
        private string country;
        private double growth;
   
        public string Continent
        {
            get { return continent; }
            set { continent = value; }
        }
   
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
   
        public double Growth
        {
            get { return growth; }
            set { growth = value; }
        }
   
        public double Population
        {
            get { return population; }
            set { population = value; }
        }
}
```
2. Create a ViewModel class with several data objects in constructor.

**[C#]**

```
public class PopulationViewModel
{
     public PopulationViewModel()
     {
         this.PopulationDetails = new ObservableCollection<PopulationInfo>();
         PopulationDetails.Add(new PopulationInfo() { Continent = "Asia", Country = "Indonesia", Growth = 3, Population = 237641326 });
         PopulationDetails.Add(new PopulationInfo() { Continent = "Asia", Country = "Russia", Growth = 2, Population = 152518015 });
         PopulationDetails.Add(new PopulationInfo() { Continent = "Asia", Country = "Malaysia", Growth = 1, Population = 29672000 });
         PopulationDetails.Add(new PopulationInfo() { Continent = "North America", Country = "United States", Growth = 4, Population = 315645000 });
         PopulationDetails.Add(new PopulationInfo() { Continent = "North America", Country = "Mexico", Growth = 2, Population = 112336538 });
         
     }
   
     public ObservableCollection<PopulationInfo> PopulationDetails
     {
         get;
         set;
     }
}
```

# Binding to Data
To bind the ComboBoxAdv to data, bind the collection created in previous step to ItemsSource property in XAML by setting PopulationViewModel as DataContext.

**[XAML]**

```
<Grid>
    <Grid.DataContext>
        <local:PopulationViewModel/>
    </Grid.DataContext>
    <syncfusion:ComboBoxAdv x:Name="comboBoxAdv" Height="30" Width="200" ItemsSource="{Binding PopulationDetails}"/>
</Grid>
```

# Binding display member
DisplayMemberPath denotes the path to a value on the data object for visual presentation of item to be displayed in combobox drop down list and displays the selected item in ComboBoxAdv.

**[XAML]**
```
<Grid>
    <Grid.DataContext>
        <local:PopulationViewModel/>
    </Grid.DataContext>
    <syncfusion:ComboBoxAdv x:Name="comboBoxAdv" Height="30" Width="200" ItemsSource="{Binding PopulationDetails}" DisplayMemberPath="Country"/>
</Grid>
```
## How to run this application?

To run this application, you need to first clone the bind-the-data-to-comboboxadv repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.