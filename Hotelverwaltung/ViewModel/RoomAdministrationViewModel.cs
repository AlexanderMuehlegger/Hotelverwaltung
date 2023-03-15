using Hotel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using System.Threading.Tasks;

namespace Hotelverwaltung.ViewModel
{
    class RoomAdministrationViewModel :  INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Room> _rooms;
        public List<Room> Rooms { get { return _rooms; }
            set {
                if(value != _rooms) {
                    _rooms = value;
                    OnPropertyChanged();
                }
            } 
        }
        private string hello = "hello";
        public string Hello { get { return this.hello; }
            set { 
                if(value != hello) {
                    this.hello = value;
                }
            }
        }

        public RoomAdministrationViewModel() {
            //zukünftige COmmands
            Hello = "hello";
        }

        public async void OnAppearing() {
            using var client = new HttpClient();

            var response = await client.GetAsync("https://localhost:7190/api/rooms/all");

            if (response != null) {
                string result = await response.Content.ReadAsStringAsync();
                Rooms = JsonConvert.DeserializeObject<List<Room>>(result);
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
