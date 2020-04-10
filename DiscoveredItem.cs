using System.Collections.Generic;
using Xamarin.Forms;

namespace PickerDemo
{
    public class DiscoveredItem : ViewModelBase
    {
        public delegate void Picked();

        public event Picked PickedEvent;

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
               if (PickedEvent != null)
                {
                    PickedEvent();
                }
            } 
       }
    }
}
