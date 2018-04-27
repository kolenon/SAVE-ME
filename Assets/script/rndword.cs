using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rndword : MonoBehaviour {
    public Text rndtxt;
    public static rndword Rword;
    public GameObject[] type_fishs;
    string[] wordlisttype;
    GameObject way;
    int score_present;
    private void Awake()
    {
        Rword = this;
    }
    private string[] wordlist1= { "act", "add", "age", "air", "all", "and", "any",
            "arm", "art", "ask", "bed", "ban", "bit", "boy", "bus", "beg", "can", "cow"
            , "cry", "dad", "day", "dry", "dig", "ear", "eat", "egg", "end", "eye", "far",
            "few", "fit", "fly", "fun", "gas", "gun", "got", "job", "jam", "jet", "joy",
            "key", "keg", "law", "leg", "let", "lie", "low", "mix", "new", "oil", "our",
            "pay", "pet", "pin", "pit", "pug", "row", "sad", "sag", "sit", "see", "shy", "sic",
            "sir", "ski", "sky", "spa", "sup", "tag", "tap", "tax", "use", "uni", "vas", "war",
            "wet", "yam", "yet", "yum", "zoo", "zip", "zag", "say", "sea", "bee", "set", "six",
            "son", "sun", "rag", "ram", "rom", "run", "rap", "rat", "gab", "gel", "gem", "god", "gut" };
    private string[] wordlist2 ={"able", "ache", "acid", "ally", "also", "area", "baby", "back", "bait",
            "blad", "ball", "bell", "cake", "call", "calm", "cell", "chain", "chef", "dare", "dark", "date",
            "dish", "dead", "down", "each", "earn", "east", "easy", "even", "ever", "edit", "edge", "else",
            "envy", "epic", "fade", "fare", "feed", "food", "fear", "fail", "fair", "fake", "find", "fish",
            "fool", "gain", "gang", "gash", "gate", "gift", "glue", "hand", "hack", "half", "hour", "huge",
            "hurt", "idea", "inch", "into", "iron", "idle", "icon", "jazz", "jeep", "join", "joke", "jump",
            "just", "jerk", "junk", "jolt", "july", "june", "kink", "kiss", "knee", "kiwi", "knot", "keep",
            "kick", "kind", "king", "know", "kite", "lack", "lamb", "land", "leek", "line", "lock", "made",
            "maid", "mail", "main", "mate", "mean", "meal", "mind", "near", "neck", "nose", "open", "only",
            "over", "pair", "path", "pick", "poor", "quiz", "safe", "sale", "salt", "same", "save", "seem",
            "seat", "semi", "send", "ship", "shoe", "side", "sign", "spot", "such", "suit", "town", "tale", "unit" };
    private string[] wordlist3 ={"abate", "abbey", "about", "actor", "badge", "baker", "banjo", "basic",
            "campus", "canal","corps", "couch", "daily", "dance", "diary", "dirty", "elbow", "empty", "enemy",
            "error", "faint", "fairy", "false", "force", "genus", "ghost", "group", "guide", "habit", "happy",
            "harsh", "hobby", "image", "imply", "input", "issue", "jelly", "jewel", "joker", "judge", "kebab",
            "knife", "knock", "koala", "label", "large", "larva", "loser", "magic", "media", "money", "movie",
            "naive", "nasty", "noble", "nurse", "onion", "opera", "order", "organ", "party", "pasta", "paste",
            "proud", "quart", "quest", "quick", "quiet", "renew", "repay", "rigid", "ruler", "salad", "scene",
            "screw", "serve", "taste", "thick", "thief", "truth", "uncle", "under", "unzip", "upset", "value",
            "valve", "video", "virus", "waist", "waste", "watch", "wound", "write", "wrong", "xerox", "yacht",
            "yeast", "yield", "yummy", "zebra"};

    private void Update()
    {
        score_present = score.scoregame;
    }

    public void wordrnd()
    {
            if (score_present<15)
            {
                int numword = Random.Range(0, wordlist1.Length);
                rndtxt.text = wordlist1[numword];
            }
            else if (score_present<30)
            {
                int numword = Random.Range(0, wordlist2.Length);
                rndtxt.text = wordlist2[numword];
            }
            else
            {
                int numword = Random.Range(0, wordlist3.Length);
                rndtxt.text = wordlist3[numword];
            }

        
    }

}
