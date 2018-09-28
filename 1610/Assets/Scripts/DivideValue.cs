using UnityEngine;

[CreateAssetMenu]

public class DivideValue : ScriptableObject
{

	public FloatData Data;
    
	public void OnDivideValue (FloatData outsideData)
	{
		outsideData.Value /= Data.Value;
	}

}
