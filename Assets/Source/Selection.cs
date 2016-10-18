using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Test;

public class Selection {

    float DEFAULT_PRIMITIVE_SIZE = 0.01f;
    float DEFAULT_LINE_THICKNESS = 0.001f;

	List<test.DataObject> dataElements = new List<test.DataObject>();
	List<test.DataObject> filteredDataElements = new List<test.DataObject>();
    List<UnityEngine.GameObject> visualElements = new List<UnityEngine.GameObject>();
    Delegate overHandler ;
    Delegate moveHandler;
    Delegate outHandler;
    Delegate downHandler;
    Delegate upHandler;
    Delegate clickHandler;

    // visual primitive for this selection
    string shape;

    ///TODO: handle Objects arrays
    ///
    //Selection data(Object[] objects)
    //{
    //    dataElements = objects;
    //    filteredDataElements = objects;
    //    return this;
    //}

    /// Binds data obejcts to indices
	public Selection data(List<test.DataObject> objects)
    {
		dataElements = new List<test.DataObject>(objects);
		filteredDataElements = new List<test.DataObject>(objects);
        return this;
    }

	public Selection append(string _shape)
    {

        switch(_shape){
            case "sphere" : createSpheres(); break;
            // case "g": elements = createG(); break (later)
            case "path": createPaths(); break;
            case "line": createLines(); break;
            case "cube": createCubes(); break;
            case "rectangle": createRectangles(); break;
            case "cylinder": createCylinder(); break;
            case "text": createText(); break;
            case "polygon": createMeshes(); break;
            case "mesh": createPolygons(); break;
            default: Console.WriteLine("Shape" + _shape + "does not exist.");break; 
        }

        this.shape = _shape;

        return this;
    }

  

	public Selection attr(string attributeName, System.Object val )
    {
		for(int i = 0 ; i < this.dataElements.Count; i++ )
        {
			setAttr (attributeName, val, this.visualElements [i]);
        }
		return this;
    }
	public Selection attr(string attributeName, Func<System.Object,int,System.Object> func)
    {
		for(int i=0 ; i<this.dataElements.Count ; i++){
			System.Object val = func (this.dataElements [i], i);
			setAttr(attributeName, val, this.visualElements[i]);
        }
		return this;
    }
	private void setAttr(string attributeName, System.Object val, GameObject visualObject)
    {
        switch(attributeName){
		case "x": setPosX (visualObject, (float) val); break;
		case "y": setPosY(visualObject, (float) val); break;
		case "z": setPosZ(visualObject, (float) val); break;                           
        }

    }
	private void setPosX(GameObject visualObject, float val)
    {
        var pos = visualObject.transform.position;
        pos.x = val;
        visualObject.transform.position = pos;

    }
	private void setPosY(GameObject visualObject, float val)
    {
        var pos = visualObject.transform.position;
        pos.y = val;
        visualObject.transform.position = pos;
    }
	private void setPosZ(GameObject visualObject, float val)
    {
        var pos = visualObject.transform.position;
        pos.z = val;
        visualObject.transform.position = pos;
    }
    


   

    /////////////////////////
    /// CREATOR FUNCTIONS /// 
    /////////////////////////


	private void createCylinder()
	{
		for (int i = 0; i < filteredDataElements.Count; i++)
		{
			//creates a default sphere
			UnityEngine.GameObject go = UnityEngine.GameObject.CreatePrimitive(UnityEngine.PrimitiveType.Cylinder);
			//scales it down to 1cm
			go.transform.localScale *= DEFAULT_PRIMITIVE_SIZE;
			UnityEngine.Vector3 _scale = go.transform.localScale;
			_scale.y = DEFAULT_PRIMITIVE_SIZE*2f;
			go.transform.localScale = _scale;
			//add the created GameObject to the visual elements
			visualElements.Add(go);
		}
	}


    private void createPolygons()
    {
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
//        for (int i = 0; i < filteredDataElements.Count; i++)
//        {
//            //creates a default sphere
//            UnityEngine.GameObject go = UnityEngine.GameObject.CreatePrimitive(UnityEngine.PrimitiveType.LineRenderer);
//            //scales it down to 1cm
//            go.SetWidth(DEFAULT_LINE_THICKNESS, DEFAULT_LINE_THICKNESS);
//            // go.transform.localScale *= DEFAULT_PRIMITIVE_SIZE;
//            //add the created GameObject to the visual elements
//            visualElements.Add(go);
//        }
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
