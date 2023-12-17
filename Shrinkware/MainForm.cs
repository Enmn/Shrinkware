using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Shrinkware
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            target.ShowDialog();
            txtTarget.Text = target.FileName.ToString();
        }

        private void btnLinkFolder_Click(object sender, EventArgs e)
        {
            // Configure the OpenFileDialog for ".link" files
            target.Filter = "Link Files (*.lnk)|*.lnk|All Files (*.*)|*.*";

            // Get the selected file name without extension from OpenFileDialog
            string selectedFileNameWithoutExtension = Path.GetFileNameWithoutExtension(target.FileName);

            // Configure the SaveFileDialog for ".link" files
            link.Filter = "Link Files (*.lnk)|*.lnk|All Files (*.*)|*.*";
            link.DefaultExt = "lnk";

            // Set the initial file name in the SaveFileDialog
            link.FileName = selectedFileNameWithoutExtension;

            // Show the SaveFileDialog
            link.ShowDialog();

            // Set the selected file path to the text box
            txtLinkFolder.Text = link.FileName.ToString();
        }

        private void btnCreateShortcut_Click(object sender, EventArgs e)
        {
            // Specify the target file or application path
            string targetPath = target.FileName;

            // Specify the shortcut path
            string shortcutPath = link.FileName;

            // Create a shortcut
            ShellLink.Shortcut.CreateShortcut(targetPath).WriteToFile(shortcutPath);

            MessageBox.Show("Shortcut created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}