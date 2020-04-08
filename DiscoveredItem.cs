using System.Collections.Generic;

namespace PickerDemo
{
    public class DiscoveredItem : ViewModelBase
    {
        public int id { get; set; }

       public List<string> PickerList { get; set; }

       private string selectedPickerItem;
       public string SelectedPickerItem
       {
           get => selectedPickerItem;
           set
           {
               int x = id;
               SetValue(ref selectedPickerItem, value);
            } 
       }
    }
}
