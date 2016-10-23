using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using rm.Trie;
using UnityEngine.UI;
using System.Linq;

public class TestTrie : MonoBehaviour
{
	//UI
	public InputField searchInputField;
	public Button submitButton;
	public Text showText;

	//utility
	public TextAsset dictionaryTextFile;

	//var
	private ITrie trie;
	private int wordDictCount;

	public void Start ()
	{
		trie = BuildSampleTrie ();
		wordDictCount = trie.GetWords ().Count;

		//// ui listener
		submitButton.onClick.AddListener (() => Test01Search (searchInputField.text));
		searchInputField.onEndEdit.AddListener ((inputText) => Test01Search (inputText));
	}

	

	void ActionEvent_OnFoundTextEvent (string wordFound)
	{
		Debug.Log ("texxxxt found : " + wordFound);
		showText.text = ">>> get text :" + wordFound;
		string prefix = wordFound.Substring (wordFound.Length - 1);
		GetRandomWord (prefix);
	}

	public void TearDown ()
	{
		trie = null;
	}

	#region Tests
	public void Test01Search (string wordsearch)
	{
		Debug.Log ("debug get text :" + wordsearch);
		bool word = trie.HasWord (wordsearch);
		wordsearch = (word) ? wordsearch : string.Empty;
		
	}
		
	public void GetRandomWord (string prefix)
	{		
		ICollection<string> listWordBucketFromGetPrefix = trie.GetWords (prefix);
		IList listm = listWordBucketFromGetPrefix as IList;
		int index = Random.Range (0, listWordBucketFromGetPrefix.Count);
		string wordResult = listm [index] as string;

		Debug.Log (wordResult);
	}

	public string ScrambleWord (string word)
	{ 
		if (word.Length < 2)
			return word;		
		string randWord = new string (word.ToCharArray ().OrderBy (s => (new System.Random ().Next (2) % 2) == 0).ToArray ());
		if (randWord == word)
			randWord = ScrambleWord (word);
		return randWord;
	}
	#endregion

	#region Different types of Tries
	private ITrie BuildSampleTrie ()
	{		
		return LoadFile ();
//		return AsciiWords();          
	}

	private ITrie AsciiWords ()
	{
		// load data from array
		string[] strings = { "123", "1", "23", "1", "this", "test", "the", "TEMP", "TOKEN", "TAKE", "THUMP" };
		
		ITrie trie = TrieFactory.CreateTrie ();

		foreach (string s in strings) {
			trie.AddWord (s);
		}
		return trie;
	}

	private ITrie LoadFile ()
	{
		//load data from text
		string theWholeFileAsOneLongString = dictionaryTextFile.text;
		string[] strings = theWholeFileAsOneLongString.Split ("\n" [0]);

		ITrie trie = TrieFactory.CreateTrie ();

		foreach (string s in strings) {			
			trie.AddWord (s);
		}
		return trie;
	}
	///// other type of encoding

	#endregion
}