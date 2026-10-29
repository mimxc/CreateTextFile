namespace CreateTxtFile
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        public void btnCreate_Click(object sender, EventArgs e)
        {
            var frmFileName = new FrmFileName();

            frmFileName.ShowDialog();

            string getInput = txtInput.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputfile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputfile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

        }

        public void FrmLab1_Load(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

    }
}
