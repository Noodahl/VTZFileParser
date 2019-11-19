using Crestron.SimplSharpPro.DeviceSupport;
using Crestron.SimplSharpPro;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace InterfaceBuilder
{
    public partial class InterfaceBuilder : Form
    {
        #region Navigation
        OpenFileDialog fileBrowser = new OpenFileDialog();
        FolderBrowserDialog saveLocation = new FolderBrowserDialog(); //For where the outut files will be located
        string saveLocation_String = "";
        //MenuItem openMenuItem= new MenuItem();
        DialogResult saveLocation_DialogResult;
        AppDomain thisDomain = AppDomain.CurrentDomain;
        #endregion

        #region Edit Joins
        EditJoins localEditJoins = new EditJoins();

        #endregion

        AssemblyName touchPanelAssembly = new AssemblyName("TouchPanel");
        AssemblyBuilder touchPanelAssemblyBuilder;

        #region Touch Panel Enumeration
        ModuleBuilder touchPanelModuleBuilder;

        EnumBuilder touchPanelBoolEnums;
        EnumBuilder touchPanelAnalogEnums;
        EnumBuilder touchPanelSerialEnums;
        EnumBuilder touchPanelSmartObjectEnums;

        List<join> enumBoolList = new List<join>();
        List<join> enumAnalogList = new List<join>();
        List<join> enumSerialList = new List<join>();
        List<join> enumSOList = new List<join>();
        join tempJoin = new join();
        #endregion

        #region Touch Panel Class
        MethodBuilder touchPanelInitializer;    //For initializing the Touch Panel

        #region Constructor
        Type tpConstructor; //No Idea why we do this
        ConstructorBuilder touchPanelConstructor; //For Defining the Constructor of the Touch Panel
        ConstructorInfo touchPanelConstructorInfo;  //Information about Touch Panel
        Type[] constructorParameters = new Type[] { typeof(int), typeof(CrestronControlSystem), typeof(string) };   //Signature of TouchPanel Constructor
        TypeBuilder constructorTypeBuilder; 
        FieldBuilder firstField;
        FieldBuilder secondField;
        FieldBuilder thirdField;
        ILGenerator constructorGenerator;
        #endregion

        #endregion

        public InterfaceBuilder()
        {
            InitializeComponent();
            Directory_TextBox.TextChanged += Directory_TextBox_TextChanged;
            localEditJoins.Visible = false;
            
        }


        private void SetupAssembly()
        {
            touchPanelAssemblyBuilder = thisDomain.DefineDynamicAssembly(touchPanelAssembly, AssemblyBuilderAccess.RunAndSave, saveLocation_String);
            
        }

        private void SetupEnum()
        {
            touchPanelModuleBuilder = touchPanelAssemblyBuilder.DefineDynamicModule("TouchPanel.Enums", touchPanelAssembly.Name + ".dll");
            touchPanelBoolEnums = touchPanelModuleBuilder.DefineEnum("TouchPanel.BooleanEnums", TypeAttributes.Public, typeof(int));
            touchPanelAnalogEnums = touchPanelModuleBuilder.DefineEnum("TouchPanel.AnalogEnums", TypeAttributes.Public, typeof(int));
            touchPanelSerialEnums = touchPanelModuleBuilder.DefineEnum("TouchPanel.SerialEnums", TypeAttributes.Public, typeof(int));
            touchPanelSmartObjectEnums = touchPanelModuleBuilder.DefineEnum("TouchPanel.SmartObjectEnums", TypeAttributes.Public, typeof(int));
        }
        
        private void SetupTouchPanelClass()
        {
            #region Constructor Builder
            //Define Constructor Tyoe Builder
            touchPanelModuleBuilder = touchPanelAssemblyBuilder.DefineDynamicModule("TouchPanel", touchPanelAssembly.Name + ".dll"); //Define Module
            constructorTypeBuilder = touchPanelModuleBuilder.DefineType(touchPanelAssembly.Name + ".dll", TypeAttributes.Public);
            firstField = constructorTypeBuilder.DefineField("IP ID", typeof(int), FieldAttributes.Public);
            secondField = constructorTypeBuilder.DefineField("Control System", typeof(CrestronControlSystem), FieldAttributes.Public);
            thirdField = constructorTypeBuilder.DefineField("Description", typeof(string), FieldAttributes.Public);


            Type objType = Type.GetType("System.Object");//
            touchPanelConstructorInfo = objType.GetConstructor(new Type[0]);

            touchPanelConstructor = constructorTypeBuilder.DefineConstructor(MethodAttributes.Public, 
                                                                             CallingConventions.Standard, 
                                                                             constructorParameters);
            ILGenerator constructorIL = touchPanelConstructor.GetILGenerator();

            constructorIL.Emit(OpCodes.Ldarg_0);

            constructorIL.Emit(OpCodes.Call, touchPanelConstructorInfo);

            constructorIL.Emit(OpCodes.Ldarg_0);
            constructorIL.Emit(OpCodes.Ldarg_1);
            constructorIL.Emit(OpCodes.Stfld, firstField);

            constructorIL.Emit(OpCodes.Ldarg_0);
            constructorIL.Emit(OpCodes.Ldarg_2);
            constructorIL.Emit(OpCodes.Stfld, secondField);

            constructorIL.Emit(OpCodes.Ldarg_0);
            constructorIL.Emit(OpCodes.Ldarg_3);
            constructorIL.Emit(OpCodes.Stfld, thirdField);

            constructorIL.Emit(OpCodes.Ret);

            MethodBuilder mthd1 = constructorTypeBuilder.DefineMethod("IP ID", MethodAttributes.Public, typeof(int), null);
            ILGenerator mthd1IL = mthd1.GetILGenerator();
            mthd1IL.Emit(OpCodes.Ldarg_0);
            mthd1IL.Emit(OpCodes.Ldfld, firstField);
            mthd1IL.Emit(OpCodes.Ret);

            MethodBuilder mthd2 = constructorTypeBuilder.DefineMethod("Control System", MethodAttributes.Public, typeof(CrestronControlSystem), null); ;
            ILGenerator mthd2IL = mthd2.GetILGenerator();
            mthd2IL.Emit(OpCodes.Ldarg_0);
            mthd2IL.Emit(OpCodes.Ldfld, firstField);
            mthd2IL.Emit(OpCodes.Ret);

            MethodBuilder mthd3 = constructorTypeBuilder.DefineMethod("Description", MethodAttributes.Public, typeof(string), null); ;
            ILGenerator mthd3IL = mthd3.GetILGenerator();
            mthd3IL.Emit(OpCodes.Ldarg_0);
            mthd3IL.Emit(OpCodes.Ldfld, firstField);
            mthd3IL.Emit(OpCodes.Ret);

            tpConstructor = constructorTypeBuilder.CreateType();

            touchPanelAssemblyBuilder.Save("TouchPanel.dll");


            #endregion
        }

        private void Directory_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Browse_Btn_Click(object sender, EventArgs e)
        {
            fileBrowser.FileOk += FileBrowser_FileOk;
            fileBrowser.Filter = "Compiled VTZ | *.vtz";
            fileBrowser.ShowDialog();
        }

        private void FileBrowser_FileOk(object sender, CancelEventArgs e)
        {
            Directory_TextBox.Text = fileBrowser.FileName;
            if(Directory_TextBox.Text.Contains(".vtz"))
            {
                saveLocation_btn.Enabled = true;
            }
        }

        private void ConvertFile(string FileToOpen)
        {
            ZipArchiveEntry environmentFile;
            StreamReader readFile;
            string fileContents;
            //Find the Environment.xml file

            SetupAssembly();
            SetupEnum();

            using (FileStream fileToOpen = new FileStream(FileToOpen, FileMode.Open))
            {
                using (ZipArchive tempZipArchive = new ZipArchive(fileToOpen, ZipArchiveMode.Read))
                {
                    environmentFile = tempZipArchive.GetEntry(@"swf/Environment.xml");
                    if (environmentFile != null)
                    {
                        readFile = new StreamReader(environmentFile.Open());
                        fileContents = readFile.ReadToEnd();
                        using (StreamWriter writeToFile = new StreamWriter(string.Format(@"{0}/Debug.txt", Directory.GetCurrentDirectory())))
                        {
                            writeToFile.Write(fileContents);
                        }
                        ParseFile(readFile);

                    }
                    else
                    {
                        Directory_TextBox.Text = "File Not Found";
                    }
                }
            }
            Directory_TextBox.Text = "Conversion Complete";
            OpenDirectory_Btn.BackColor = Color.MediumSeaGreen;
            OpenDirectory_Btn.Enabled = true;
        }

        private void ParseFile(StreamReader XMLContent)
        {
            //Split into Pages
            StreamWriter tempStreamWriter = new StreamWriter(string.Format(@"{0}/XMLParsed.csv", saveLocation_String));

            //Need to specify where to save the file to


            /*Within each page look for the Join
             Under Children, each Child is an object of some sort
             Break down the Child based on:
             > Page (Element)
             > Children (Element)
             > Child (Element)
             > UID (Attribute)  - Contains Join # 
             > Target Control (Element)
             > Control Name (Element)
             > Write To File
             */
            using (XmlReader reader = XmlReader.Create(XMLContent))
            {
                XmlDocument doc = new XmlDocument();
                XmlDocument doc2 = new XmlDocument();
                doc.Load((string.Format(@"{0}/Debug.txt", Directory.GetCurrentDirectory())));

                //Grab the "Children" Section per Page. This contains the information in regards to the objects on the page
                XmlNodeList nodes = doc.GetElementsByTagName("Children");

                //For debugging
                tempStreamWriter.WriteLine("Object,Object Name,Join Type,Join Number");
                //tempStreamWriter.WriteLine("Number of Nodes with Tage Page = " + nodes.Count);


                //A "Children" is built of "Child", we have data within each "Child" that we want                
                foreach (XmlNode n in nodes)
                {
                    // Breakdown the node, and grab the following information:
                    XmlAttributeCollection xmlChildAttribute = n.Attributes;

                    XmlNodeList xmlChildNodeList = n.ChildNodes;

                    //tempStreamWriter.WriteLine("Number of Child Nodes Page = " + xmlChildNodeList.Count);

                    //So we iterate through each "Child" and first grab the "Child uid", equivalent to a VT Pro Join Number
                    foreach (XmlNode child in xmlChildNodeList)
                    {
                        //Next we look inside the child and grab
                        // Control Name, Equivalent to the Object added in VT Pro
                        // Object Name, Equivalent to the Object Name in VT Pro
                        string entryToAdd = "";
                        string objectDetail = "";
                        string forEnumDetails = "";
                        string forEnum = "";
                        foreach (XmlNode chldNode in child.ChildNodes)
                        {
                            if (chldNode.Name.ToUpper() == "TARGETCONTROL")
                            {
                                objectDetail += chldNode.InnerText + ",";
                            }
                            else if (chldNode.Name.ToUpper() == "OBJECTNAME")
                            {
                                objectDetail += chldNode.InnerText + ",";
                                forEnum += chldNode.InnerText.Replace(' ', '_') + "_";
                            }
                            else if (chldNode.Name.ToUpper() == "PROPERTIES")
                            {
                                foreach (XmlNode chld2 in chldNode.ChildNodes)
                                {
                                    if (chld2.Name.ToUpper() == "CONTROLJOIN")
                                    {
                                        objectDetail += "SmartObject,";
                                        objectDetail += chld2.InnerText;
                                        forEnum += "SmartObject";
                                        tempStreamWriter.WriteLine(objectDetail);
                                        BuildEnum(forEnum, Convert.ToInt32(chld2.InnerText), eJoinType.smartObject);
                                        break;          //When the object name is grabbed, break out of the foreach loop
                                    }
                                    else if (chld2.Name.Contains("Digital") || chld2.Name.Contains("Serial") || chld2.Name.Contains("Analog"))
                                    {
                                        if (chld2.InnerText != "0")
                                        {
                                            eJoinType joinType = eJoinType.error;
                                            entryToAdd += chld2.Name + ",";
                                            entryToAdd += chld2.InnerText;

                                            forEnumDetails += chld2.Name;

                                            if (chld2.Name.Contains("Digital"))
                                            {
                                                joinType = eJoinType.digital;
                                            }
                                            else if (chld2.Name.Contains("Serial"))
                                            {
                                                joinType = eJoinType.serial;
                                            }
                                            else if (chld2.Name.Contains("Analog"))
                                            {
                                                joinType = eJoinType.analog;
                                            }

                                            if (joinType != eJoinType.error && chld2.InnerText.Length != 0)
                                            {
                                                BuildEnum(string.Format(forEnum + forEnumDetails), Convert.ToInt32(chld2.InnerText), joinType);
                                            }

                                            tempStreamWriter.WriteLine(objectDetail + entryToAdd);
                                            forEnumDetails = "";
                                            entryToAdd = "";
                                        }
                                        else
                                        {
                                            entryToAdd = "";
                                        }
                                    }
                                }
                            }
                        }

                        //tempStreamWriter.WriteLine("Target Control is: " + child.ChildNodes[);
                        //tempStreamWriter.WriteLine("Control Name is: " + child.Attributes[2].InnerText);
                    }

                }
            }
            tempStreamWriter.Close();
            CompleteEnum();
            //XmlReader.Create()
        }

        #region Enumeration Implementation
        private void BuildEnum(string Description, int Join, eJoinType JoinType)
        {
            tempJoin.description = Description;
            tempJoin.joinNumber = Join;

            switch (JoinType)
            {
                case eJoinType.analog:
                    enumAnalogList.Add(tempJoin);
                    break;
                case eJoinType.digital:
                    enumBoolList.Add(tempJoin);
                    break;
                case eJoinType.serial:
                    enumSerialList.Add(tempJoin);
                    break;
                case eJoinType.smartObject:
                    enumSOList.Add(tempJoin);
                    break;
                default:
                    break;
            }
        }

        private void CompleteEnum()
        {
            foreach (join jn in enumBoolList)
            {
                touchPanelBoolEnums.DefineLiteral(jn.description, jn.joinNumber);
            }

            foreach (join jn in enumAnalogList)
            {
                touchPanelAnalogEnums.DefineLiteral(jn.description, jn.joinNumber);
            }

            foreach (join jn in enumSerialList)
            {
                touchPanelSerialEnums.DefineLiteral(jn.description, jn.joinNumber);
            }

            foreach (join jn in enumSOList)
            {
                touchPanelSmartObjectEnums.DefineLiteral(jn.description, jn.joinNumber);
            }


            touchPanelAnalogEnums.CreateType();
            touchPanelBoolEnums.CreateType();
            touchPanelSerialEnums.CreateType();
            touchPanelSmartObjectEnums.CreateType();
            touchPanelAssemblyBuilder.Save(touchPanelAssembly.Name + ".dll");
        }
        #endregion

        private void BuildTouchPanelClass()
        {

        }

        private void Convert_Btn_Click(object sender, EventArgs e)
        {
            ConvertFile(Directory_TextBox.Text);
        }

        private struct join
        {
            public string description { get; set; }
            public int joinNumber { get; set; }
        }

        private enum eJoinType
        {
            analog,
            digital,
            serial,
            smartObject,
            error
        }

        private void SaveLocation_btn_Click(object sender, EventArgs e)
        {
            saveLocation.ShowNewFolderButton = true;
            saveLocation.Description = "Select Folder to Save Output Files to";
            saveLocation_String = saveLocation.SelectedPath;
            saveLocation_DialogResult = saveLocation.ShowDialog();

            if (saveLocation_DialogResult == DialogResult.OK)
            {
                if (saveLocation.SelectedPath != "")
                {
                    saveLocation_TxtBox.Text = saveLocation.SelectedPath;                    
                }
                else
                {
                    saveLocation_TxtBox.Text = Directory.GetCurrentDirectory();
                }
                saveLocation_String = saveLocation.SelectedPath;
                //If the length of the file name is greater than 0, enable the Convert Button
                if (Directory_TextBox.Text.Length > 0)
                {
                    Convert_Btn.BackColor = Color.LawnGreen;
                    Convert_Btn.Enabled = true;
                }
                else if (Directory_TextBox.Text == "" || Directory_TextBox.Text == "File Not Found" || Directory_TextBox.Text == "Conversion Complete")
                {
                    Convert_Btn.Enabled = false;
                }
            }
           
        }

        private void OpenDirectory_Btn_Click(object sender, EventArgs e)
        {
            Process.Start(saveLocation_String);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if the exit button is pressed, close the application
            this.Close();
        }

        private void EditJoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ModifyJoins().Show();       
        }
    }

    /*
    public class Rootobject
    {
        public Glossary glossary { get; set; }
    }

    public class Glossary
    {
        public string title { get; set; }
        public Glossdiv GlossDiv { get; set; }
    }

    public class Glossdiv
    {
        public string title { get; set; }
        public Glosslist GlossList { get; set; }
    }

    public class Glosslist
    {
        public Glossentry GlossEntry { get; set; }
    }
    */
    
}
