using System.Collections;
using System.Collections.Generic;
using System;

public class Selection {

    List<Object> dataElements = new List<Object>();
    List<Object> filteredDataElements = new List<Object>();
    List<UnityEngine.GameObject> visualElements = new List<UnityEngine.GameObject>();
    Delegate overHandler ;
    Delegate moveHandler;
    Delegate outHandler;
    Delegate downHandler;
    Delegate upHandler;
    Delegate clickHandler;

    UnityEngine.PrimitiveType shape;

    Selection data(Object[] objects)
    {
        return this;
    }

    Selection data(List<Object> objects)
    {
        return this;
    }

    Selection append(string _shape)
    {
        switch(_shape){
        case "sphere" : createSpheres(); break;
        // case "g": elements = createG(); break (later)
        case "path": createPaths(); break;
        case "line": createLines(); break;
        case "cube": createCubes(); break;
        case "cylinder": createRectangles(); break;
        case "text": createText(); break;
        case "polygon": createMeshes(); break;
        case "mesh": createPolygons(); break;
        default: Console.WriteLine("Shape" + _shape + "does not exist.");break; 
        }
    return this;
    }
    
    

    /////////////////////////
    /// CREATOR FUNCTIONS /// 
    /////////////////////////


    private void createPolygons()
    {
        throw new NotImplementedException();
    }

    private void createMeshes()
    {
        throw new NotImplementedException();
    }

    private void createText()
    {
        throw new NotImplementedException();
    }

    private void createRectangles()
    {
        throw new NotImplementedException();
    }

    private void createCubes()
    {
        throw new NotImplementedException();
    }

    private void createLines()
    {
        throw new NotImplementedException();
    }

    private void createPaths()
    {
        throw new NotImplementedException();
    }

    private void createSpheres()
    {
        throw new NotImplementedException();
    }     

}
