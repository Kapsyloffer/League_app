using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace League_2
{
    class SaveLoad
    {
        public void saveFile(DataManager d)
        {
            try
            {
                using (Stream stream = File.Open(d.getPath(), FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, d);
                    System.Windows.Forms.MessageBox.Show("Save Successful");
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        public void openLatest(DataManager d)
        {
            try
            {
                using (Stream stream = File.Open(d.getPath(), FileMode.Open, FileAccess.Read))
                {
                var binaryFormatter = new BinaryFormatter();
                d.setDM((DataManager)binaryFormatter.Deserialize(stream));
                    System.Windows.Forms.MessageBox.Show("Load Successful");
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public void openFile(DataManager d)
        {
            //File popup
            OpenFileDialog ofd = new OpenFileDialog();
            //Result of the popup
            DialogResult result = ofd.ShowDialog();
            //Filter file type.
            ofd.Filter = "Save File|*.save";
            if (result == DialogResult.OK)
            {
                if (ofd.FileName == null)
                {
                    ofd.FileName = "saveFile.save";
                }
                else
                {
                    //TODO: Set filename in dialog
                }
                d.setPath(ofd.InitialDirectory + ofd.FileName);
            }
            //TODO: Fixa namnen sen.
            openLatest(d);
        }

        public void saveAs(DataManager d)
        {
            //File popup
            SaveFileDialog sfd = new SaveFileDialog();
            //Result of the popup
            DialogResult result = sfd.ShowDialog();
            //Filter file type.
            sfd.Filter = "Save File|*.save";
            if (result == DialogResult.OK)
            {
                if(sfd.FileName == null)
                {
                    sfd.FileName = "saveFile.save";
                }
                else
                {
                    //TODO: Set filename in dialog
                }
                d.setPath(sfd.InitialDirectory + sfd.FileName);
            }
            MessageBox.Show(d.getPath());
            saveFile(d);
        }
    }
}
