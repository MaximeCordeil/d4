using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		List<DataObject> data = initData();		
		Func<DataObject,int,System.Object> myfun = (d, i) => d.age;
		
		// Create rectangles

		Selection s1 = d4.selectAll ()
			.data (data)
			.append ("sphere")
				.attr ("x", (d, i) => d.age / 10f)
				.attr ("y", (d, i) => d.weight / 10f)
				.attr ("r", (d, i) => d.weight / 10f)
				.style("fill", new float[]{1f,0f,0f})
				.style("opacity", .1f);

		// Selection s1 = d4.selectAll ()
		// 	.data (data)
		// 	.append ("3dline")
		// 		.attr ("x", (d, i) => d.age / 10f)
		// 		.attr ("y", (d, i) => d.weight / 10f)
		// 		.style("fill", new float[]{1f,0f,0f})
		// 		.style("opacity", .8f);
	
	}

	// Update is called once per frame
	void Update () {
	}


	List<DataObject> initData(){
		List<DataObject> data = new List<DataObject>();
		DataObject dObj = new DataObject();
		dObj.name = "A";
		dObj.gender = "m"; 
		dObj.age = 20;
		dObj.weight = 100; 
		data.Add(dObj);				

		dObj = new DataObject();
		dObj.name = "B";
		dObj.gender = "f"; 
		dObj.age = 30;
		dObj.weight = 120; 
		data.Add(dObj);				

		return data;
	}

}