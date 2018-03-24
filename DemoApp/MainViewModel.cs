using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeSnoop;
using YoutubeSnoop.Fluent;

namespace DemoApp
{
    class MainViewModel
    {
        public ObservableCollection<IYoutubeItem> Videos { get; }

        public MainViewModel()
        {
            Videos = new ObservableCollection<IYoutubeItem>(Youtube.Search("playlist").Take(10).Select(s => s.Details()));
        }
    }
}
