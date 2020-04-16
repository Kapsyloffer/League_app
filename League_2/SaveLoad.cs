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
                    MessageBox.Show("Save Successful");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
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
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void openFile(DataManager d)
        {
            //File popup
            OpenFileDialog ofd = new OpenFileDialog();
            //Result of the popup
            DialogResult result = ofd.ShowDialog();
            //Filter file type.
            ofd.DefaultExt = "save";
            ofd.Filter = "Save files (*.save)|*.save|All files (*.*)|*.*";

            if (result == DialogResult.OK)
            {
                String name = ofd.FileName;
                d.setPath(Path.GetFullPath(ofd.FileName), name);
                openLatest(d);
            }
            //TODO: Fixa namnen sen.
        }

        public void saveAs(DataManager d)
        {
            //File popup
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.DefaultExt = "save";
            sfd.Filter = "Save files (*.save)|*.save|All files (*.*)|*.*";
            //Result of the popup
            DialogResult result = sfd.ShowDialog();

            if (result == DialogResult.OK)
            {
                d.setPath(Path.GetFullPath(sfd.FileName), sfd.FileName);
                MessageBox.Show(d.getPath());
                saveFile(d);
            }
        }
    }
}
