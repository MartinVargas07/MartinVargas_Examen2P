namespace MartinVargas_Examen2P;

public partial class MainPage : ContentPage
{
	int xRecarga = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		MV_CounterBtn.Text = $" Se estaran recargando {xRecarga} $ en su cuenta";

		SemanticScreenReader.Announce(MV_CounterBtn.Text);
	}

	void Opcion1(object sender, CheckedChangedEventArgs e)
	{
        MV_lblBtn.Text = "Ha seleccionado una recarga de 3$";
		xRecarga = 3;
	}
    void Opcion2(object sender, CheckedChangedEventArgs e)
    {
        MV_lblBtn.Text = "Ha seleccionado una recarga de 5$";
        xRecarga = 5;
    }
    void Opcion3(object sender, CheckedChangedEventArgs e)
    {
        MV_lblBtn.Text = "Ha seleccionado una recarga de 10$";
        xRecarga = 10;
    }


}

