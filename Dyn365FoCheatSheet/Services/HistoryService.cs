using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyn365FoCheatSheet.Services
{
    public class HistoryService : IDisposable
    {
        private readonly NavigationManager _nav;
        public string CurrentUri { get; private set; } = "";
        public string PreviousUri { get; private set; } = "";

        public HistoryService(NavigationManager nav)
        {
            _nav = nav;
            CurrentUri = _nav.Uri;
            _nav.LocationChanged += OnLocationChanged;
        }

        private void OnLocationChanged(object? sender, LocationChangedEventArgs e)
        {
            PreviousUri = CurrentUri;
            CurrentUri = e.Location;
        }

        public void Dispose()
        {
            _nav.LocationChanged -= OnLocationChanged;
        }
    }
}
