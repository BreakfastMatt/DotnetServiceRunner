namespace DotnetServiceRunner.Pages;

public partial class Notes : ContentPage
{
  public int NoteId = 0;
  public Dictionary<int, string> NoteDict = new Dictionary<int, string>();

  public Notes()
  {
    InitializeComponent();
  }

  private void SaveButton_Clicked(object sender, EventArgs e)
  {
    var note = TextEditor.Text;
    NoteDict.UpdateOrAdd(NoteId, note);
  }

  private void DeleteButton_Clicked(object sender, EventArgs e)
  {
    TextEditor.Text = string.Empty;
    NoteId++;
  }
}

public static class ExtensionHelpers
{
  public static void UpdateOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
  {
    // Check if the dictionary contains the entry
    if (dictionary.ContainsKey(key))
    {
      // Update the existing entry
      dictionary[key] = value;
    }
    else
    {
      // Add the new entry
      dictionary.Add(key, value);
    }
  }
}