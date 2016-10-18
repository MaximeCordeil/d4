using System.Collections;
using System.Collections.Generic;
using System;

public class Selection {

    float DEFAULT_PRIMITIVE_SIZE = 0.01f;

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
        dataElements = objects;
        filteredDataElements = objects;s
        return this;
    }

    Selection data(List<Object> objects)
    {
        dataElements = new List<Object>(objects);
        filteredDataElements = new List<Object>(objects);
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

    private void createRectangle()
    {
        for (int i = 0; i < filteredDataElements.Count; i++)
        {
            //creates a default sphere
            UnityEngine.GameObject go = UnityEngine.GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Cube);
            //scales it down to 1cm
            go.transform.localScale *= DEFAULT_PRIMITIVE_SIZE;
            UnityEngine.Vector3 _scale = go.transform.localScale;
            _scale.z = 0f;
            go.transform.localScale = _scale;
            //add the created GameObject to the visual elements
            visualElements.Add(go);
        }
    }

    private void createCubes()
    {
        for (int i = 0; i < filteredDataElements.Count; i++)
        {
            //creates a default sphere
            UnityEngine.GameObject go = UnityEngine.GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Cube);
            //scales it down to 1cm
            go.transform.localScale *= DEFAULT_PRIMITIVE_SIZE;
            //add the created GameObject to the visual elements
            visualElements.Add(go);
        }
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

        for (int i=0; i< filteredDataElements.Count; i++)
        {
            //creates a default sphere
            UnityEngine.GameObject go = UnityEngine.GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Sphere);
            //scales it down to 1cm
            go.transform.localScale *= DEFAULT_PRIMITIVE_SIZE;
            //add the created GameObject to the visual elements
            visualElements.Add(go);
        }
    }

    private void createCircle()
    {
        for (int i = 0; i < filteredDataElements.Count; i++)
        {
            //creates a default sphere
            UnityEngine.GameObject go = UnityEngine.GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Sphere);
            //scales it down to 1cm
            go.transform.localScale *= DEFAULT_PRIMITIVE_SIZE;
            //flatten z to create a disc
            UnityEngine.Vector3 _scale = go.transform.localScale;
            _scale.z = 0f;
            go.transform.localScale = _scale;
            //add the created GameObject to the visual elements
            visualElements.Add(go);
        }
    }     
}
