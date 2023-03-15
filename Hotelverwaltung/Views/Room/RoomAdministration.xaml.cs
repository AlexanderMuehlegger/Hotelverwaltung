using Hotelverwaltung.ViewModel;

namespace Hotelverwaltung.Views.Room;

public partial class RoomAdministration : ContentPage
{

	private RoomAdministrationViewModel _vm;

	public RoomAdministration()
	{
		InitializeComponent();
		this._vm = new RoomAdministrationViewModel();
		this.BindingContext = _vm;
	}

	protected override void OnAppearing() {
		base.OnAppearing();

		this._vm.OnAppearing();
	}
}