using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PickerDemo
{

    public class MainPageViewModel : ViewModelBase
    {

        public List<DiscoveredItem> DiscoveredItemList { get; set; }

        private List<string> pickerItems;
        private string firstPickerItem;

        public MainPageViewModel()
        {
            pickerItems = PopulateCollection();
            firstPickerItem = pickerItems.FirstOrDefault();

            PopulateDiscoveredItemList();
        }

        public List<string> PopulateCollection()
        {
            var myCollection = new List<string>
            {
                "hello",
                "goodbye",
                "please",
                "thank you"
            };

            return myCollection;
        }

        public void PopulateDiscoveredItemList()
        {
            DiscoveredItemList = new List<DiscoveredItem> ()
            {
                new DiscoveredItem {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=1 },
                new DiscoveredItem {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id = 2 },                
                new DiscoveredItem {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=3},                
                new DiscoveredItem {PickerList = pickerItems, SelectedPickerItem = firstPickerItem, id=4 },                
            };
        }


    }
}
