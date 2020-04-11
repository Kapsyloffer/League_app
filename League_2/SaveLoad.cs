using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace League_2
{
    class SaveLoad
    {
        private String filePath = "C:\\Users\\User\\save.save";
        public void saveFile(DataManager d)
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
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
        public void openFile(DataManager d)
        {
            try
            {
                using (Stream stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
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
    }
}
