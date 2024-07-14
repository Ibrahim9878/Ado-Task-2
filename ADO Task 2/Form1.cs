namespace ADO_Task_2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        DatabaseCar.connectionString = DatabaseCar.configurationWindow();
        DatabaseCar.ReadUsersToDatabase();

    }

    private void button1_Click(object sender, EventArgs e)
    {
        string text = SearchBox.Text;
        if (MarkaRadioButton.Checked)
        {
            carBox.DataSource = DatabaseCar.FindCarWithMarka(text);
        }
        else
        {
            carBox.DataSource = DatabaseCar.FindCarWithModel(text);
        }
        carBox.Refresh();
    }

}
