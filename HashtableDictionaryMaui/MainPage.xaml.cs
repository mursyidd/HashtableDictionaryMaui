using System.Collections;


namespace HashtableDictionaryMaui;

public partial class MainPage : ContentPage
{
	public Hashtable phoneBook = new Hashtable();
	public Dictionary<string, string> products = new Dictionary<string, string>();


    public MainPage()
	{
		InitializeComponent();

		//Hashtable phoneBook = new Hashtable()
		//{
		//	{ "Marcin Jamro", "000-000-000" },
		//	{ "John Smith", "111-111-111" }
		//};

		//Dictionary<string, string> products = new Dictionary<string, string>
		//{
		//	{ "5900000000000", "A1" },
		//	{ "5901111111111", "B5" },
		//	{ "5902222222222", "C9" }
		//};
	}

    private void Hashbtn_Clicked(object sender, EventArgs e)
    {
		string inputText1 = entHash1.Text;
        string inputText2 = entHash2.Text;
        int? inputInt1 = 0;
        int? inputInt2 = 0;
		bool check1 = false;
		bool check2 = false;

        try
        {
            inputInt1 = Convert.ToInt32(inputText1);
			if (inputInt1.HasValue && inputInt1 != 0)
				check1 = true;
        }
		catch (Exception)
		{
		}

		try
		{
            inputInt2 = Convert.ToInt32(inputText2);
            if (inputInt2.HasValue && inputInt2 != 0)
                check2 = true;
        }
		catch (Exception)
		{
		}

		if (check1)
		{
			if (check2)
			{
                phoneBook.Add(inputInt1, inputInt2);
            }
            else
			{
                phoneBook.Add(inputInt1, inputText2);
            }
        }
		else if (check2)
		{
            phoneBook.Add(inputText1, inputInt2);
        }
        else
		{
            phoneBook.Add(inputText1, inputText2);
        }

		
    }

    private void Dictbtn_Clicked(object sender, EventArgs e)
    {

    }
}

