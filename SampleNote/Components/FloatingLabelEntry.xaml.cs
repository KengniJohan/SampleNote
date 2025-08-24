namespace SampleNote.Components;

public partial class FloatingLabelEntry : ContentView
{
	public FloatingLabelEntry()
	{
		InitializeComponent();
	}

    // Propriété pour le texte saisi
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(FloatingLabelEntry), default(string));

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    // Propriété pour le label
    public static readonly BindableProperty LabelTextProperty =
        BindableProperty.Create(nameof(LabelText), typeof(string), typeof(FloatingLabelEntry), default(string));

    public string LabelText
    {
        get => (string)GetValue(LabelTextProperty);
        set => SetValue(LabelTextProperty, value);
    }

    // Propriété pour le placeholder (optionnel)
    public static readonly BindableProperty PlaceholderProperty =
        BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(FloatingLabelEntry), default(string));

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    // --- Gestion du focus ---
    private void OnEntryFocused(object sender, FocusEventArgs e)
    {
        MainBorder.Stroke = Colors.Blue; // Bordure bleue quand focus
    }

    private void OnEntryUnfocused(object sender, FocusEventArgs e)
    {
        MainBorder.Stroke = Colors.Gray; // Retour à la couleur normale
    }
}