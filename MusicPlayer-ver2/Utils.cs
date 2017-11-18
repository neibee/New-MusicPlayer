using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using AxWMPLib; 


namespace MusicPlayer_ver2
{
    class Utils
    {
        public static string[] openFileDialog(OpenFileDialog openFileDialog)
        {
            openFileDialog.InitialDirectory = @"D:\workspace\music";
            openFileDialog.Filter = "mp3 Files | *.mp3";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // (check) ? statement_1 : statement_2;
                // <=> if () statement_1 else statement_2
                return openFileDialog.FileNames != null ? openFileDialog.FileNames : new string[0];
            }
            return new string[0];        
        }

        /*public static string[] openFolderDialog(FolderBrowserDialog folderBrowserDialog)
       {
           FolderBrowserDialog folderBrowse = new FolderBrowserDialog();
            if (folderPicker.ShowDialog() == DialogResult.OK)
            {     
                string[] files = Directory.GetFiles(folderPicker.SelectedPath);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    ListViewItem item = new ListViewItem(fileName);
                    item.Tag = file;
                    ListView1.Items.Add(item);

                }          
        } */             
        
        public static void PlaySong(ListView songListView, AxWindowsMediaPlayer player)
        {
            if (songListView.SelectedItems.Count > 0)
            {
                ListViewItem selected = songListView.SelectedItems[0];
                string selectedFilePath = selected.Tag.ToString();
                player.URL = selectedFilePath;
                player.Ctlcontrols.play();                
            }
            else
            {
                MessageBox.Show("Please select a song!");
            }
        }

           
}
}
