using UnityEngine;

[CreateAssetMenu]

public class MultiplyValue : ScriptableObject
{

	public FloatData Data;
    
	public void OnMultiplyValue (FloatData outsideData)
	{
		outsideData.Value *= Data.Value;
	}

}
