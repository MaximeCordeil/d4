using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using UnityEngine;
using DataLoader;
public class d4: MonoBehaviour {

    public TextAsset myFile;

    public void Start()
    {
        DataLoader.DataObject do_ = new DataLoader.DataObject();
        Debug.Log(do_.loadCSV(myFile.text));
   
      //  loadCSV(myFile.text);
    }

    //void loadCSV(string data)
    //{
    //    string[] lines = data.Split('\n');

    //    //1: read types
    //    string[] identifiers = lines[0].Split(',');
    //    string[] typesToRead = lines[1].Split(',');
    //    string[] theTypes = new string[typesToRead.Length];
    //    for(int i=0; i<typesToRead.Length;i++)
    //    {
    //        if (isBool(typesToRead[i]))
    //            theTypes[i] = "bool";
    //        else if (isFloat(typesToRead[i]))
    //            theTypes[i] = "float";
    //        else theTypes[i] = "string";
    //    }

    //    string DataObject = createClass(identifiers, theTypes);
    //    //compile the class
    //    CodeDomProvider oCodeDomProvider = CodeDomProvider.CreateProvider("CSharp");
    //    // Add what referenced assemblies
    //    CompilerParameters oCompilerParameters = new CompilerParameters();
    //    oCompilerParameters.ReferencedAssemblies.Add("system.dll");
    //    // set the compiler to create a DLL
    //    oCompilerParameters.GenerateExecutable = false;
    //    // set the dll to be created in memory and not on the hard drive
    //    oCompilerParameters.GenerateInMemory = true;
    //    var oCompilerResults =
    //      oCodeDomProvider.CompileAssemblyFromSource(oCompilerParameters, DataObject);
    //    if (oCompilerResults.Errors.Count != 0)
    //        Debug.Log("There were errors while compiling the Data ");

    //    Debug.Log(DataObject);

    //}

    internal static Selection selectAll()
    {
        return new Selection();
    }

    public bool isBool(string value)
    {
        bool res = false;
        return bool.TryParse(value, out res);
    }

    public bool isFloat(string value)
    {
        float res = 0f;
        return float.TryParse(value, out res);
    }

    string createClass(string[] ids, string[] typeFields)
    {
        
        string classCompile =
            @"using System;
              
              class DataObject
              {
              "+"\n";
            
        string fields = "";
            for(int i=0; i<typeFields.Length;i++)
             {
                 fields+= "public static " + typeFields[i] + " " + ids[i]+";\n";
             }
        classCompile+= fields;
        classCompile+="}\n";

        return classCompile;
    }
              
    

    
}
