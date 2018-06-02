using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageChanger : MonoBehaviour {
	public Text title;
	public Text description;
	public Text banner;
	public Text subType1;
	public Text subFee1;
	public Text subBilling1;
	public Text subType2;
	public Text subFee2;
	public Text subBilling2;
	public Text special;
	public Text cont;
	public Text noCommitment;
	public Text restore;
	public Text noThanks;

	// text collections for different languages
	[SerializeField]
	private List<TextCollection> _textCollections;

	// getter setter for text collections
	public List<TextCollection> TextCollection{
		get{ return _textCollections;}
		set{ _textCollections = value;}
	}

	// current language index
	private int curLangIndex = 0;

	// Use this for initialization
	void Start () {
		ChangeLanguage (curLangIndex);
	}
	
	// Update is called once per frame
	void Update () {
		// change the language when space is hit
		if (Input.GetKeyDown (KeyCode.Space)){
			curLangIndex++;
			ChangeLanguage (curLangIndex);
		}
	}

	// change the language to the specified language index
	public void ChangeLanguage(int langIndex){
		if ((TextCollection == null) || (TextCollection.Count == 0))
			return;

		TextCollection textCol = TextCollection [langIndex % TextCollection.Count];
		title.text = textCol.title;
		description.text= textCol.description;
		banner.text= textCol.banner.ToUpper();
		subType1.text= textCol.subType1.ToUpper();
		subFee1.text= textCol.subFee1;
		subBilling1.text= textCol.subBilling1;
		subType2.text= textCol.subType2.ToUpper();
		subFee2.text= textCol.subFee2;
		subBilling2.text= textCol.subBilling2;
		special.text= textCol.special.ToUpper();
		cont.text= textCol.cont;
		noCommitment.text= textCol.noCommitment;
		restore.text= textCol.restore;
		noThanks.text= textCol.noThanks;
	}
}
