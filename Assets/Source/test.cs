using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Test{
public class test : MonoBehaviour {

	public class DataObject{
		public static string name;
		public static string gender;
		public static int age;
		public static int weight;

		public DataObject(string name, string gender, int age, int weight){
			this.name = name; 
			this.gender = gender;
			this.age = age;
			this.weight = weight;
		}
	}

	// Use this for initialization
	void Start () {

		List<DataObject> data = initData();		

		// Create rectangles
		Selection s = d4.selectAll ()
			.data (data)
			.append ("sphere")
				.attr ("x", (d, i) => { return (DataObject)d.age; })
				.attr ("y", (d, i) => { return (DataObject)d.weight; });
				// .style("fill", "#
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	List<DataObject> initData(){
		List<DataObject> data = new List<DataObject>();
		data.Add(new DataObject("Arno", "m", 25, 73));
		data.Add(new DataObject("Bea", "f", 23, 53));
		data.Add(new DataObject("Christophe", "m", 37, 71));
		data.Add(new DataObject("Denver", "m", 53, 97));
		data.Add(new DataObject("Eva", "f", 53, 98));		
		return data;
	}
}
}