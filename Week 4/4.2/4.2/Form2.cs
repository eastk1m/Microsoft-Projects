// namespace _4._2


using _4._2;

internal class Form2 : Form
{
    bool logonStatus = false;

    public Form2()

    {
        InitializeComponent();

    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void LogonBtn_Click(object sender, EventArgs e)
    {
        logonStatus = true;
        new Form1().ShowDialog();
        this.Close
    }

    internal void Show()
    {
        throw new NotImplementedException();
    }
}