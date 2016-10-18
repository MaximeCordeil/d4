using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class test : MonoBehaviour {

	public class DataElement{
		string name;
		string gender;
		int age;
		int weight;

		public DataElement(string name, string gender, int age, int weight){
			this.name = name; 
			this.gender = gender;
			this.age = age;
			this.weight = weight;
		}
	}

	// Use this for initialization
	void Start () {

		List<DataElement> data = initData();		

		// Create rectangles
		Selection s = d4.selectAll()
			.data(data)
			.append("sphere")
				.attr("x", (d,i)=>{ return d.age; })
				.attr("y", (d,i)=>{ return d.weight; })
				.style("fill", "#ff0000")

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	List<DataElement> initData(){
		List<DataElement> data = new List<DataElement>();
		data.Add(new DataElement("Arno", "m", 25, 73));
		data.Add(new DataElement("Bea", "f", 23, 53));
		data.Add(new DataElement("Christophe", "m", 37, 71));
		data.Add(new DataElement("Denver", "m", 53, 97));
		data.Add(new DataElement("Eva", "f", 53, 98));		
		return data;
	}
}
