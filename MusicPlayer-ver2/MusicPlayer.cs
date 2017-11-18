using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using AxWMPLib;

namespace MusicPlayer_ver2
{
    /**
     * - list
     *  - step 1: if list == null, allow opening a folder dialog, add all files from this folder to the list
     *          - each row has two columns, 1st display file name, 2nd displays time (00:00:00)
     *          - when double click on a file, highlight this item while the file is being loaded by the media player
     *  - step 2: list has some files. Now if user closes the app, save the list to a text file
     *  - step 3: open the app again, load the text file and load to the list
     *  - step 4: user can open the browse menu item again to select another folder
     *  - step 5: append all the files from the new folder to the current list
     *  - step 6: right click -> open context menu -> select Properties -> display file details 
     *          - read the Mp3 TAG1 & TAG2
     *  
     */
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            PopulateListView();
            stopBtn.Enabled = false;
            previousBtn.Enabled = false;
            nextBtn.Enabled = false;
            playBtn.Enabled = true;
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm();
            this.Cursor = new Cursor(Cursor.Current.Handle);
            popup.Show();
        }

        private void PopulateListView()
        {
            //declare and construct listView
            songListView.View = View.Details;
            songListView.GridLines = false;
            songListView.FullRowSelect = true;

            // add columns
            songListView.Columns.Add("", 0);
            songListView.Columns.Add("Title", 205, HorizontalAlignment.Left);
            songListView.Columns.Add("Length", 50, HorizontalAlignment.Left);            
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopBtn.Enabled = true;
            previousBtn.Enabled = true;
            nextBtn.Enabled = true;
            string[] files = Utils.openFileDialog(openFileDialog);
            string fileName;
            foreach (var file in files)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = file;
                fileName = Path.GetFileNameWithoutExtension(file);
                //add song's title
                item.SubItems.Add(fileName);
                //item.SubItems.Add()  ============ the length of the song
                songListView.Items.Add(item);
            }            
        }

        private void playBtn_Click(object sender, EventArgs e)
        {          
            Utils.PlaySong(songListView, player);
        }

        private void songListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Utils.PlaySong(songListView, player);
            /*
            var senderList = (ListView)sender;
            var clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null)
            {
                player.URL = clickedItem.Tag.ToString();
                player.Ctlcontrols.play();
            } */
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {            
            int newIndex;
            if (songListView.SelectedItems.Count > 0 && !songListView.Items[0].Selected)
            {                
                int currentSongIndex = songListView.Items.IndexOf(songListView.SelectedItems[0]);
                newIndex = currentSongIndex - 1;
                ListViewItem previousSong = songListView.Items[newIndex];
                string preSongPath = previousSong.Tag.ToString();
                player.URL = preSongPath;
                player.Ctlcontrols.play();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (songListView.SelectedItems.Count > 0)
            {
                int newIndex;
                int currentSongIndex = songListView.Items.IndexOf(songListView.SelectedItems[0]);
                if (currentSongIndex != songListView.Items.Count + 1)
                {
                    newIndex = currentSongIndex + 1;
                    ListViewItem nextSong = songListView.Items[newIndex];
                    string nextSongPath = nextSong.Tag.ToString();
                    player.URL = nextSongPath;
                    player.Ctlcontrols.play();
                }
            }            
        }

            /*          
            private void songListBox_MouseUp(object sender, MouseEventArgs e)
            {
                int location = songListBox.IndexFromPoint(e.Location);
                if (e.Button == MouseButtons.Right)
                {
                    songListBox.SelectedIndex = location;                //Index selected
                    contextMenuStrip1.Show(PointToScreen(e.Location));   //Show Menu
                }
            } 
            */
        }
    }

