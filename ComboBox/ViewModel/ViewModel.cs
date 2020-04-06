using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ComboBox
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Model> products;
        public ObservableCollection<Model> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
                RaisePropertyChanged("Products");
            }
        }
        public ViewModel()
        {
            Products = new ObservableCollection<Model>();
            Products.Add(new Model() { Text = "Item 1" });
            Products.Add(new Model() { Text = "Item 2" });
            Products.Add(new Model() { Text = "Item 3" });
            Products.Add(new Model() { Text = "Item 4" });
            Products.Add(new Model() { Text = "Item 5" });
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
