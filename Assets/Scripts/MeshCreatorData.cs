using UnityEngine;
using System.Collections;

public class MeshCreatorData : MonoBehaviour {
	// use this texture for creating the outine
	public Texture2D outlineTexture;
	
	// settings for what the script will create
	public bool uvWrapMesh = true;
	public bool createEdges = true;
	public bool createBacksidePlane = false;
	
	// stores an automatically created material
	public Material frontMaterial;
	
	// total height, width, and depth of the resulting mesh
	public float meshHeight = 1.0f; 
	public float meshWidth = 1.0f; 
	public float meshDepth = 0.1f;
	
	// offset the placement of the mesh from 
	//public float heightOffset = 0.5f; 
	//public float widthOffset = 0.0f; 
	//public float depthOffset = 0.0f;
	
	// set center pivot offset
	public float pivotHeightOffset = 0.0f;
	public float pivotWidthOffset = 0.0f;
	public float pivotDepthOffset = 0.0f;
	
	// store the last pivot offset used so it can be subtracted from next
	public Vector3 lastPivotOffset = Vector3.zero;
	
	// collider settings
	public bool generateCollider = true;
	public bool usePrimitiveCollider = true;
	public float smallestBoxArea = 100.0f;
	public bool useAutoGeneratedMaterial = false;
	public bool usePhysicMaterial = false;
	public PhysicMaterial physicMaterial;
	
	//public string saveName = "";
}
