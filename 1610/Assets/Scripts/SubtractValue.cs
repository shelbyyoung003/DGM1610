using UnityEngine;

[CreateAssetMenu]

public class SubtractValue : ScriptableObject
{

	public FloatData Data;
    
	public void OnSubtractValue (FloatData Data)
	{
		Data.Value -= Data.Value;
	}

}
