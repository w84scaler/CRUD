using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using PluginInterface;

namespace oop1
{
    public partial class Form1 : Form
    {

        public List<object> ObjectList = new List<object>();
        private List<Creator> CreatorList = new List<Creator> { new BaseItemCreator(), new SpeedItemCreator(), new DamageItemCreator(), new ApItemCreator(), new AdItemCreator(), new TankItemCreator() };
        private List<DataManager> DataManagerList = new List<DataManager> { new BinDataManager(), new JsonDataManager(), new TextDataManager() };
        public Form1()
        {
            InitializeComponent();
            foreach (Creator cbbElement in CreatorList)
            {
                string str = cbbElement.GetType().ToString();
                str = str.Substring(5, str.Length - 12);
                comboBox1.Items.Add(str);
            }
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + "\\Files";
            openFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory + "\\Files";
            saveFileDialog1.RestoreDirectory = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                object NewObject = null;
                var frm = CreatorList[comboBox1.SelectedIndex].Create(AddToObjectList, NewObject, ObjectList.Count);
                frm.Show();
            }
        }

        private void AddToObjectList(object Obj, int i)
        {
            ObjectList.Insert(i, Obj);
            UpdateListView(Obj, i);
        }

        private void UpdateListView(object Obj, int i)
        {
            var item = new ListViewItem();
            item.Text = (Obj as BaseItem).Name;
            item.SubItems.Add((Obj as BaseItem).Description);
            item.SubItems.Add((Obj as BaseItem).Level.ToString());
            item.SubItems.Add((Obj as BaseItem).Cost.ToString());
            item.SubItems.Add((Obj as BaseItem).Jungle.ToString());
            listView1.Items.Insert(i, item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                    ObjectList.RemoveAt(i);
                }
            }
        }

        private void UpdateObjectList(object Obj, int i)
        {
            ObjectList.Insert(i, Obj);
            UpdateListView(Obj, i);
            ObjectList.RemoveAt(i + 1);
            listView1.Items[i + 1].Remove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    MemberInfo info = ObjectList[i].GetType();
                    if (Attribute.IsDefined(info, typeof(CreatorIndexAttribute)))
                    {
                        int CreatorIndex = (Attribute.GetCustomAttribute(info, typeof(CreatorIndexAttribute)) as CreatorIndexAttribute).Index;
                        var frm = CreatorList[CreatorIndex].Create(UpdateObjectList, ObjectList[i], i);
                        frm.Show();
                    }
                }
            }
        }

        private void OpenListView(List<object> list)
        {
            listView1.Items.Clear();
            int i = 0;
            foreach (BaseItem item in list)
            {
                UpdateListView(item, i);
                i++;
            }
        }

        private string UpdateFilter(List<IPlugin> PluginList)
        {
            string str = String.Empty;
            foreach (DataManager manager in DataManagerList)
            {
                if (Attribute.IsDefined(manager.GetType(), typeof(SerializatorAttribute)))
                {
                    string SerializatorName = (Attribute.GetCustomAttribute(manager.GetType(), typeof(SerializatorAttribute)) as SerializatorAttribute).Name;
                    string SerializatorExtension = (Attribute.GetCustomAttribute(manager.GetType(), typeof(SerializatorAttribute)) as SerializatorAttribute).Extension;
                    str += $"{SerializatorName}|*.{SerializatorExtension}|";
                }
            }
            foreach (IPlugin plugin in PluginList)
            {
                if (Attribute.IsDefined(plugin.GetType(), typeof(PluginAttribute)))
                {
                    string PluginExtension = (Attribute.GetCustomAttribute(plugin.GetType(), typeof(PluginAttribute)) as PluginAttribute).Extension;
                    string PluginName = (Attribute.GetCustomAttribute(plugin.GetType(), typeof(PluginAttribute)) as PluginAttribute).Name;

                    foreach (DataManager manager in DataManagerList)
                    {
                        if (Attribute.IsDefined(manager.GetType(), typeof(SerializatorAttribute)))
                        {
                            string SerializatorName = (Attribute.GetCustomAttribute(manager.GetType(), typeof(SerializatorAttribute)) as SerializatorAttribute).Name;
                            string SerializatorExtension = (Attribute.GetCustomAttribute(manager.GetType(), typeof(SerializatorAttribute)) as SerializatorAttribute).Extension;
                            str += $"{SerializatorName} {PluginName}|*.{SerializatorExtension}{PluginExtension}|";
                        }
                    }
                }
            }
            return str.Remove(str.Length - 1);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PluginLoader loader = new PluginLoader();
            List<IPlugin> PluginList = loader.RefreshPlugins();
            saveFileDialog1.Filter = UpdateFilter(PluginList);
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string FileName = saveFileDialog1.FileName;
            byte[] Data = DataManagerList[(saveFileDialog1.FilterIndex - 1) % DataManagerList.Count].ListToByte(ObjectList);
            if ((saveFileDialog1.FilterIndex - 1) / DataManagerList.Count == 0)
            {
                using (FileStream fs = new FileStream(FileName, FileMode.Create))
                {
                    fs.Write(Data, 0, Data.Length);
                }
            }
            else
            {
                PluginList[(saveFileDialog1.FilterIndex - 1) / DataManagerList.Count - 1].Compress(Data, FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PluginLoader loader = new PluginLoader();
            List<IPlugin> PluginList = loader.RefreshPlugins();
            openFileDialog1.Filter = UpdateFilter(PluginList);
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string FileName = openFileDialog1.FileName;
            byte[] Data = null;
            if ((openFileDialog1.FilterIndex - 1) / DataManagerList.Count == 0)
            {
                using (FileStream fs = new FileStream(FileName, FileMode.Open))
                {
                    Data = new byte[(int)fs.Length];
                    fs.Read(Data, 0, Data.Length);
                }
            }
            else
            {
                Data = PluginList[(openFileDialog1.FilterIndex - 1) / DataManagerList.Count - 1].Decompress(FileName);
            }
            try
            {
                ObjectList = DataManagerList[(openFileDialog1.FilterIndex - 1) % DataManagerList.Count].ByteToList(Data);
                OpenListView(ObjectList);
            }
            catch
            {
                MessageBox.Show(
                   "Invalid file",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }
        }
    }
}
