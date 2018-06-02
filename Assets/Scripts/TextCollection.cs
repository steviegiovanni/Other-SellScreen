using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="TextCollection", menuName = "Text Collection", order=1)]
public class TextCollection : ScriptableObject {
	public string title;
	public string description;
	public string banner;
	public string subType1;
	public string subFee1;
	public string subBilling1;
	public string subType2;
	public string subFee2;
	public string subBilling2;
	public string special;
	public string cont;
	public string noCommitment;
	public string restore;
	public string noThanks;
}
