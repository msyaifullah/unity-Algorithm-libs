using UnityEngine;
using UnityEditor;
using NUnit.Framework;

using rm.Trie;
using UnityEditor.VersionControl;

public class TrieWord
{
   
    [Test]
    public void AsciiWords ()
    {
        // load data from array
        string[] strings = {
            "123",
            "1",
            "23",
            "1",
            "this",
            "test",
            "the",
            "TEMP",
            "TOKEN",
            "TAKE",
            "THUMP"
        };

        ITrie trie = TrieFactory.CreateTrie ();

        foreach (string s in strings)
            trie.AddWord (s);

        bool word = trie.HasWord ("123");
        int dictCount = trie.GetWords ().Count;

        Assert.AreEqual (word, true);
        Assert.AreEqual (dictCount, 10);
    }
}
