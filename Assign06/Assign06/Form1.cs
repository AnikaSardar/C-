namespace Assign06
{
    /// <summary>
    /// Search Directory Form
    /// Uses Directory and Path class, LINQ to query collections.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clicks the SearchDirectory button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    //clears the previous search result
                    txtResultList.Clear(); 

                    //SOURCE: https://www.dotnetperls.com/recursive-file-list 
                    string[] files = Directory.GetFiles(txtDirectory.Text, "*.*", SearchOption.AllDirectories);

                    //SOURCE: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.groupby?view=net-8.0 
                    var query = GetFileExtensionsAndCount(files)
                                .GroupBy(ext => ext.Key, ext => ext.Value);

                    foreach (var fileExtAndCount in query)
                    {
                        txtResultList.Text += $"* Found {fileExtAndCount.First()} {fileExtAndCount.Key} files\r\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }
        }
        
        public Dictionary<string, int> GetFileExtensionsAndCount(string[] files)
        {
            //dictionary to store file ext as key and num of files as value
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string file in files)
            {
                string extension = Path.GetExtension(file);

                if (dict.ContainsKey(extension))
                {
                    dict[extension] += 1;
                }
                else
                {
                    dict[extension] = 1;
                }
            }
            return dict;
        } 

        /// <summary>
        /// Validates the directory (file path) entered
        /// </summary>
        /// <returns>True if entered file path is valid, otherwise false</returns>
        public bool IsValidData() => IsPresent(txtPathSearch);
        
        /// <summary>
        /// Verifies the entered file path
        /// </summary>
        /// <param name="textBox">Directory Search Textbox</param>
        /// <returns></returns>
        public bool IsPresent(TextBox textBox)
        {
            string filePath = txtPathSearch.Text;

            if (string.IsNullOrEmpty(filePath))
            {
                txtDirectory.Text = Directory.GetCurrentDirectory();
                return true;
            }
            else if (!Directory.Exists(filePath))
            {
                MessageBox.Show("No such directory found! Please enter a valid directory.", "Path Error");
                textBox.Focus();
                txtDirectory.Clear(); //clears the directory textbox
                txtResultList.Clear(); //clears the search result textbox
                return false;
            }
            else
            {
                txtDirectory.Text = filePath;
                textBox.Clear(); 
                return true;
            }
        }
    }
    
}
