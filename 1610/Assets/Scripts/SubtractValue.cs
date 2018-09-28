using UnityEngine;

[CreateAssetMenu]

public class SubtractValue : ScriptableObject
{

	public FloatData Data;
    
	public void OnSubtractValue (FloatData outsideData)
	{
		outsideData.Value -= Data.Value;
	}

}
