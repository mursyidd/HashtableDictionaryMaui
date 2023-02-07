using System.Collections;


namespace HashtableDictionaryMaui;

public partial class MainPage : ContentPage
{
	//public Hashtable UserHash = new Hashtable();
	//public Dictionary<int, Employee> UserDict = new Dictionary<int, Employee>();


    public MainPage()
	{
		InitializeComponent();


        editorHash.Text = "Hashtable testing = new Hashtable()";
        editorHash.Text += Environment.NewLine;
        editorHash.Text += Environment.NewLine;
        editorHash.Text += (
            "        testing.Add(\"1\", \"Mursyid\");", Environment.NewLine +
            "        testing.Add(\"2\", \"Syawani\");", Environment.NewLine +
            "        testing.Add(\"3\", \"Akmal\");", Environment.NewLine +
            "        testing.Add(\"4\", \"Marni\");");
        editorHash.Text += Environment.NewLine;
        editorHash.Text += Environment.NewLine;
        editorHash.Text += "Output:-";
        editorHash.Text += Environment.NewLine;

        Hashtable testing = new Hashtable();
        testing.Add("1", "Mursyid");
        testing.Add("2", "Syawani");
        testing.Add("3", "Akmal");
        testing.Add("4", "Marni");

        foreach (DictionaryEntry e in testing)
        {
            editorHash.Text += string.Format("ID:{0,5}  Staff:{1,20}{2}", e.Key, e.Value, Environment.NewLine);

        }


        editorDict.Text = "Dictionary<string, string> testing2 = new Dictionary<string, string>()";
        editorDict.Text += Environment.NewLine;
        editorDict.Text += Environment.NewLine;
        editorDict.Text += (
    "        testing2.Add(\"1\", \"Mursyid\");", Environment.NewLine +
    "        testing2.Add(\"2\", \"Syawani\");", Environment.NewLine +
    "        testing2.Add(\"3\", \"Akmal\");", Environment.NewLine +
    "        testing2.Add(\"4\", \"Marni\");");
        editorDict.Text += Environment.NewLine;
        editorDict.Text += Environment.NewLine;
        editorDict.Text += "Output:-";
        editorDict.Text += Environment.NewLine;

        Dictionary<string, string> testing2 = new Dictionary<string, string>();
        testing2.Add("1", "Mursyid");
        testing2.Add("2", "Syawani");
        testing2.Add("3", "Akmal");
        testing2.Add("4", "Marni");

        foreach (KeyValuePair<string,string> e in testing2)
        {
            //string tesss = string.Format("ID: {0} Staff: {1}", e.Key.ToString(), e.Value.ToString());

            editorDict.Text += string.Format("ID:{0,5}  Staff:{1,20}{2}", e.Key, e.Value, Environment.NewLine);

        }
    }

    private void Hashbtn_Clicked(object sender, EventArgs e)
    {
    }

    private void Dictbtn_Clicked(object sender, EventArgs e)
    {

    }
}

